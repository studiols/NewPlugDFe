using PlugDFe.ApplicationLayer.DTO.ZipFilesIO;
using PlugDFe.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace PlugDFe.ApplicationLayer.Services
{
    public static class HandlerFiles
    {
        #region Handlers

        public static void CreateFiles(string path, DataTable dt, string blobToBase64, string base64ToString, string compressedBase64ToString)
        {
            string xmlName;
            string xmlContent;

            foreach (DataRow item in dt.Rows)
            {
                xmlName = $"{path}/{item["chave"].ToString()}.XML";
                xmlContent = item["xml"].ToString();

                if (blobToBase64 == "S")
                {
                    xmlContent = BlobToBase64((byte[])item["xml"]);
                }

                if (compressedBase64ToString == "S") //Tem que descompactar o conteudo do BASE64
                {
                    xmlContent = CompressedBase64ToString(Convert.FromBase64String(xmlContent));
                }
                else if (base64ToString == "S")
                {
                    xmlContent = Base64ToString(xmlContent);
                }

                File.WriteAllText(xmlName, xmlContent);
            }
        }

        public static ZipFilesOutput CreateTemporaryZipFiles(string address, EReadMode readAction, DateTime lastDateExecute, DateTime startDate, bool redundancy = false)
        {
            try
            {
                //Gravar Log (Coleta iniciada)
                long maxBytesOnZip = 10276045;
                List<FileInfo> validFilesAfterFilter = new List<FileInfo>();
                List<string> zipsToUploadPaths = new List<string>();

                FileInfo[] files = GetFiles(address);
                IEnumerable<FileInfo> filteredFiles = FilterFiles(readAction, files, lastDateExecute, startDate, redundancy);

                if (filteredFiles == null)
                {
                    return new ZipFilesOutput(false, "Nenhum arquivo válido encontrado!", zipsToUploadPaths, validFilesAfterFilter);
                }

                string nameArqTemp = Path.GetTempPath() + "ArqDFe" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".zip";

                ZipArchive zip = CreateZip(nameArqTemp);

                zipsToUploadPaths.Add(nameArqTemp); //Criando nome do primeiro arquivo temporário ZIP

                foreach (FileInfo arq in filteredFiles)
                {
                    if (arq.FullName.Contains(@"\Env\"))
                        continue;

                    validFilesAfterFilter.Add(arq);

                    if ((maxBytesOnZip - arq.Length) >= 0)
                    {
                        ZipArchiveEntry entry = zip.CreateEntryFromFile(arq.Directory + "/" + arq.Name, arq.Name);
                        maxBytesOnZip -= arq.Length;
                    }
                    else
                    {
                        zip.Dispose();

                        maxBytesOnZip = 10276045;

                        nameArqTemp = Path.GetTempPath() + "ArqDFe" + DateTime.Now.ToString("yyyyMMddhhmmssfff") + ".zip";
                        zip = CreateZip(nameArqTemp);
                        ZipArchiveEntry entry = zip.CreateEntryFromFile(arq.Directory + "/" + arq.Name, arq.Name);
                        maxBytesOnZip -= arq.Length;

                        zipsToUploadPaths.Add(nameArqTemp); //Criando nome do próximo arquivo temporário ZIP
                    }
                }

                zip.Dispose();

                if (maxBytesOnZip == 10276045)
                {
                    //Gravar log - Nenhum arquivo válido

                    for (int i = 0; i < zipsToUploadPaths.Count; i++)
                    {
                        File.Delete(Path.GetFullPath(zipsToUploadPaths[0]));
                    }

                    return new ZipFilesOutput(false, "Nenhum arquivo válido encontrado!", zipsToUploadPaths, validFilesAfterFilter);
                }

                return new ZipFilesOutput(true, "Arquivos formados com sucesso!", zipsToUploadPaths, validFilesAfterFilter);
            }
            catch (Exception ex)
            {
                //Log
                return new ZipFilesOutput(false, ex.Message, null, null);
            }

        }        
        
        public static void DeleteRemainingTemporaryZipFiles(List<string> zipPaths)
        {
            for (int i = 0; i < zipPaths.Count; i++)
            {
                File.Delete(zipPaths[i]);
            }
        }

        public static void DeleteFiles(List<FileInfo> validFilesAfterFilter)
        {
            for (int i = 0; i < validFilesAfterFilter.Count; i++)
            {
                File.Delete(validFilesAfterFilter[i].FullName);
            }
        }

        #endregion

        #region Helpers

        private static FileInfo[] GetFiles(string address)
        {
            DirectoryInfo Dir = new DirectoryInfo(@address);
            FileInfo[] files = Dir.GetFiles("*.xml", SearchOption.AllDirectories);
            return files;
        }

        private static IEnumerable<FileInfo> FilterFiles(EReadMode readAction, FileInfo[] files, DateTime lastDateExecute, DateTime startDate,  bool redundancy = false)
        {
            IEnumerable<FileInfo> filteredFiles;

            if (redundancy)
            {
                DateTime finalDate = DateTime.Now;
                DateTime initialDate = new DateTime(finalDate.Year, finalDate.Month, 1);

                if (finalDate.AddDays(1).Day > 4) { return null; }
                if (finalDate.AddDays(1).AddMonths(-1).Month < startDate.Month) { return null; }

                if (finalDate.Day >= 1 && finalDate.Day <= 3)
                {
                    int year = finalDate.AddMonths(-1).Year;
                    int month = finalDate.AddMonths(-1).Month;

                    initialDate = new DateTime(year, month, 1);
                }

                filteredFiles = from a in files
                where a.CreationTime >= initialDate
                select a;
            }         
            else if (readAction == EReadMode.DOCUMENTOS_CRIADOS_APOS_ULTIMA_EXECUCAO)
            {
                filteredFiles = from a in files
                                where a.CreationTime > lastDateExecute
                                select a;
            }
            else if (readAction == EReadMode.DOCUMENTOS_DO_DIA_ANTERIOR)
            {
                throw new Exception("Not Implemented YET");
            }
            else if (readAction == EReadMode.DOCUMENTOS_ATUAIS)
            {
                filteredFiles = files;
            }
            else
            {
                throw new Exception("Falha ao definir ação de Leitura");
            }

            return filteredFiles;
        }

        private static ZipArchive CreateZip(string nameArqTemp)
        {
            ZipArchive zip = ZipFile.Open(nameArqTemp, ZipArchiveMode.Create);
            return zip;
        }        

        private static string BlobToBase64(byte[] blob)
        {
            return Convert.ToBase64String(blob);
        }

        private static string Base64ToString(string encodedString)
        {
            byte[] data = Convert.FromBase64String(encodedString);
            string decodedString = Encoding.UTF8.GetString(data);

            return decodedString;
        }

        private static string CompressedBase64ToString(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    CopyTo(gs, mso);
                }

                return Encoding.UTF8.GetString(mso.ToArray());
            }
        }
        
        private static void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }

        //public static byte[] GetBlob(string filePath)
        //{
        //    FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        //    BinaryReader br = new BinaryReader(fs);

        //    byte[] blob = br.ReadBytes((int)fs.Length);

        //    br.Close();
        //    fs.Close();

        //    return blob;
        //}

        #endregion
    }
}
