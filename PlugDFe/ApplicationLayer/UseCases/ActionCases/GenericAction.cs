using PlugDFe.ApplicationLayer.DTO.ConnectViewerIO;
using PlugDFe.ApplicationLayer.DTO.IntegrationIO;
using PlugDFe.ApplicationLayer.DTO.ZipFilesIO;
using PlugDFe.ApplicationLayer.Services;
using PlugDFe.ApplicationLayer.UseCases.ConnectViewerCases;
using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Integration;
using PlugDFe.Domain.Repositories;
using PlugDFe.Domain.Services;
using System;
using System.Collections.Generic;
using System.IO;

namespace PlugDFe.ApplicationLayer.UseCases.ActionCases
{
    public abstract class GenericAction
    {
        public GenericAction(PlugUser plugUser, PlugAddress plugAddress, PlugTask plugTask, ConnectViewer connectViewer, List<TransferredDocument> transferredDocuments, ICommunicationPlatform communicationPlatform, ITransferredDocumentRepository transferredDocumentRepository)
        {
            PlugUser = plugUser;
            PlugAddress = plugAddress;
            PlugTask = plugTask;
            ConnectViewer = connectViewer;
            CommunicationPlatform = communicationPlatform;
            TransferredDocuments = transferredDocuments;
            TransferredDocumentRepository = transferredDocumentRepository;
        }

        public PlugUser PlugUser { get; private set; }
        public PlugAddress PlugAddress { get; private set; }
        public PlugTask PlugTask { get; private set; }
        public ConnectViewer ConnectViewer { get; private set; }
        public List<TransferredDocument> TransferredDocuments { get; private set; }
        public ICommunicationPlatform CommunicationPlatform { get; private set; }
        public ITransferredDocumentRepository TransferredDocumentRepository { get; private set; }


        public void QueryToFiles()
        {            
            ExecuteQuery executeQuery = new ExecuteQuery();

            if (ConnectViewer != null)
            {
                Logs.Write(PlugUser.IdCompany, PlugUser.UnitCode, $"Executando consulta ao banco de dados ({ConnectViewer.Type})...");
                ExecuteQueryOutput executeQueryOutput = executeQuery.Execute(new ExecuteQueryInput(ConnectViewer.Type, ConnectViewer.Str, ConnectViewer.Command, PlugUser.UnitCode));

                if (executeQueryOutput.Success)
                {
                    Logs.Write(PlugUser.IdCompany, PlugUser.UnitCode, "Consulta executada com sucesso!");
                    HandlerFiles.CreateFiles(PlugAddress.Path, executeQueryOutput.Dt, ConnectViewer.BlobToBase64, ConnectViewer.Base64ToString, ConnectViewer.CompressedBase64ToString);
                }
                else
                {
                    Logs.Write(PlugUser.IdCompany, PlugUser.UnitCode, $"Erro ao executar consulta");
                }
            }            
        }
        public List<FileInfo> SendFiles()
        {            
            ZipFilesOutput zipFilesOutput = HandlerFiles.CreateTemporaryZipFiles(PlugAddress.Path, PlugTask.ReadMode, Convert.ToDateTime(PlugTask.LastExecuteDate));
            Logs.Write(PlugUser.IdCompany, PlugUser.UnitCode, "Criando Arquivos Zip Temporários...");

            if (!zipFilesOutput.Success) 
            {
                Logs.Write(PlugUser.IdCompany, PlugUser.UnitCode, zipFilesOutput.Msg);
                return new List<FileInfo>();
            }           

            Upload upload = new Upload(CommunicationPlatform);
            PlatformUploadOutput uploadOutput;

            for (int i = 0; i < zipFilesOutput.ZipPaths.Count; i++)
            {
                uploadOutput = upload.Execute(PlugUser.IdCompany.ToString(), PlugUser.Email, PlugUser.Token, zipFilesOutput.ZipPaths[i]);

                if (uploadOutput.Sucesso)
                    Logs.Write(PlugUser.IdCompany, PlugUser.UnitCode, $"Arquivo {(i + 1)}/{zipFilesOutput.ZipPaths.Count} - {uploadOutput.Msg}");
                else
                    Logs.Write(PlugUser.IdCompany, PlugUser.UnitCode, $"Erro Arquivo {(i + 1)}/{zipFilesOutput.ZipPaths.Count} - {uploadOutput.Msg}");
            }

            for (int i = 0; i < zipFilesOutput.ValidFilesAfterFilter.Count; i++)
            {
                TransferredDocumentRepository.SaveIfNotExists(new TransferredDocument(zipFilesOutput.ValidFilesAfterFilter[i].Name, DateTime.Now));
            }

            Logs.Write(PlugUser.IdCompany, PlugUser.UnitCode, $"{zipFilesOutput.ValidFilesAfterFilter.Count} Registros Gravados!");

            HandlerFiles.DeleteRemainingTemporaryZipFiles(zipFilesOutput.ZipPaths);            

            return zipFilesOutput.ValidFilesAfterFilter;
        }
    }
}
