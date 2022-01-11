using PlugDFe.ApplicationLayer.DTO;
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
using System.Data;
using System.IO;
using System.Linq;

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
            if (PlugTask.LastExecuteDate.Day == DateTime.Now.Day) { return; }

            ExecuteQuery executeQuery = new ExecuteQuery();

            if (ConnectViewer != null)
            {
                Logs.Write(PlugUser.IdCompany, $"Executando consulta ao banco de dados ({ConnectViewer.Type})...");
                ExecuteQueryOutput executeQueryOutput = executeQuery.Execute(new ExecuteQueryInput(ConnectViewer.Type, ConnectViewer.Str, ConnectViewer.Command, PlugTask.UnitCode));

                if (executeQueryOutput.Success)
                {
                    Logs.Write(PlugUser.IdCompany, $"Consulta executada com sucesso! Arquivos Encontrados:{executeQueryOutput.Dt.Rows.Count}");
                    HandlerFiles.CreateFiles(PlugAddress.Path, executeQueryOutput.Dt, ConnectViewer.BlobToBase64, ConnectViewer.Base64ToString, ConnectViewer.CompressedBase64ToString);
                }
                else
                {
                    Logs.Write(PlugUser.IdCompany, $"Erro ao executar consulta");
                }
            }            
        }
        
        public List<FileInfo> SendFiles(bool redundancy = false)
        {            
            ZipFilesOutput zipFilesOutput = HandlerFiles.CreateTemporaryZipFiles(PlugAddress.Path, PlugTask.ReadMode, Convert.ToDateTime(PlugTask.LastExecuteDate), PlugTask.StartDate, redundancy);
            
            if (!zipFilesOutput.Success) 
            {
                Logs.Write(PlugUser.IdCompany, zipFilesOutput.Msg);
                return new List<FileInfo>();
            }

            string msgRedundancy = redundancy ? "(Redundância)" : "";

            Logs.Write(PlugUser.IdCompany, $"Criando Arquivos Zip Temporários... {msgRedundancy}");

            Upload upload = new Upload(CommunicationPlatform);
            PlatformUploadOutput uploadOutput;

            for (int i = 0; i < zipFilesOutput.ZipPaths.Count; i++)
            {
                uploadOutput = upload.Execute(PlugUser.IdCompany.ToString(), PlugUser.Email, PlugUser.Token, zipFilesOutput.ZipPaths[i]);

                if (uploadOutput.Sucesso)
                {
                    Logs.Write(PlugUser.IdCompany, $"Arquivo {(i + 1)}/{zipFilesOutput.ZipPaths.Count} - {uploadOutput.Msg}");
                }
                else
                {
                    Logs.Write(PlugUser.IdCompany, $"Erro Arquivo {(i + 1)}/{zipFilesOutput.ZipPaths.Count} - {uploadOutput.Msg}");
                }
            }

            for (int i = 0; i < zipFilesOutput.ValidFilesAfterFilter.Count; i++)
            {
                // Salvo tudo, pois não sei quais foram rejeitados
                TransferredDocumentRepository.SaveIfNotExists(new TransferredDocument(zipFilesOutput.ValidFilesAfterFilter[i].Name.Replace(".XML", "").Replace(".xml", ""), PlugTask.UnitCode, PlugTask.GroupCode, DateTime.Now));
            }            

            HandlerFiles.DeleteRemainingTemporaryZipFiles(zipFilesOutput.ZipPaths);            

            return zipFilesOutput.ValidFilesAfterFilter;
        }

        public void RedundancyHandleLostDocuments()
        {
            ExecuteQuery executeQuery = new ExecuteQuery();
            ExecuteQueryInput executeQueryInput;
            DateTime finalDate = DateTime.Now;

            if (TransferredDocuments == null)
            {
                Logs.Write(PlugUser.IdCompany, $"Não existem chaves gravadas para executar a consulta de redundância!");
                return;
            }
            else if (ConnectViewer == null)
            {
                Logs.Write(PlugUser.IdCompany, $"O modo de redundância não é feito para se utilizar com pastas, por favor troque a ação executada imediatamente!");
                return;
            }
            else if (finalDate.AddDays(1).Day > 4)
            {
                Logs.Write(PlugUser.IdCompany, $"Redundância não executada, pois só pode ser executada do dia 30 ao dia 3");
                return;
            }
            else if (finalDate.AddDays(1).AddMonths(-1).Month < PlugTask.StartDate.Month)
            {
                Logs.Write(PlugUser.IdCompany, $"Redundância não executada, pois só pode ser executada quando a data for superior ao mês de início, salvo o último dia do Mês");
                return;
            }

            List<string> listOfTransferredKeys = new List<string>();
            List<string> listOfFoundKeys = new List<string>();
            List<string> listOfLostDocumentKeys = new List<string>();

            foreach (TransferredDocument document in TransferredDocuments)
            {
                listOfTransferredKeys.Add("'" + document.Key + "'");
            }

            executeQueryInput = new ExecuteQueryInput(
                ConnectViewer.Type,
                ConnectViewer.Str,
                ConnectViewer.Command,
                PlugTask.UnitCode
            );

            DateTime initialDate = new DateTime(finalDate.Year, finalDate.Month, 1);

            if (finalDate.Day >= 1 && finalDate.Day <= 3)
            {
                int year = finalDate.AddMonths(-1).Year;
                int month = finalDate.AddMonths(-1).Month;

                initialDate = new DateTime(year, month, 1);
            }

            executeQueryInput.AddInitialDate("'" + initialDate.ToString("yyyy-MM-dd") + "'");
            executeQueryInput.AddFinalDate("'" + finalDate.ToString("yyyy-MM-dd") + "'");
            executeQueryInput.CommandSequence = 0;

            Logs.Write(PlugUser.IdCompany, $"Executando consulta ao banco de dados ({ConnectViewer.Type}) para descobrir enviadas");

            ExecuteQueryOutput executeQueryOutput = executeQuery.Execute(executeQueryInput);

            if (executeQueryOutput.Success)
            {
                Logs.Write(PlugUser.IdCompany, $"Consulta (Todos Documentos do período) executada com sucesso! Chaves Encontradas:{executeQueryOutput.Dt.Rows.Count}");

                foreach (DataRow dr in executeQueryOutput.Dt.Rows)
                {
                    listOfFoundKeys.Add($"'{dr["chave"].ToString()}'");
                }

                var divergences =
                from fk in listOfFoundKeys
                join tk in listOfTransferredKeys on fk equals tk into merge
                from tk in merge.DefaultIfEmpty()
                select new KeyComparison(fk, tk == null ? "(Não Encontrada)" : tk);

                List<KeyComparison> listOfDivergences = divergences.ToList();

                foreach (KeyComparison keyComparison in listOfDivergences)
                {
                    if (keyComparison.Tkey == "(Não Encontrada)") { listOfLostDocumentKeys.Add($"{keyComparison.FKey}"); }
                }

                executeQueryInput = new ExecuteQueryInput(
                    ConnectViewer.Type,
                    ConnectViewer.Str,
                    ConnectViewer.Command,
                    PlugTask.UnitCode
                );

                string keysToSend = string.Join(",", listOfLostDocumentKeys);
                executeQueryInput.CommandSequence = 1;
                executeQueryInput.AddInitialDate("'" + initialDate.ToString("yyyy-MM-dd") + "'");
                executeQueryInput.AddFinalDate("'" + finalDate.ToString("yyyy-MM-dd") + "'");
                executeQueryInput.AddKeysToSend(keysToSend);

                Logs.Write(PlugUser.IdCompany, $"Executando consulta ao banco de dados ({ConnectViewer.Type}) para pegar os XMLs que faltam enviar...");

                executeQueryOutput = executeQuery.Execute(executeQueryInput);

                if (executeQueryOutput.Success)
                {
                    Logs.Write(PlugUser.IdCompany, $"Consulta (Documentos Perdidos) executada com sucesso! Chaves Encontradas:{executeQueryOutput.Dt.Rows.Count}");

                    HandlerFiles.CreateFiles(
                        PlugAddress.Path,
                        executeQueryOutput.Dt,
                        ConnectViewer.BlobToBase64,
                        ConnectViewer.Base64ToString,
                        ConnectViewer.CompressedBase64ToString
                    );
                }
                else
                {
                    Logs.Write(PlugUser.IdCompany, "Erro Ao realizar consulta");
                    return;
                }
            }
            else
            {
                Logs.Write(PlugUser.IdCompany, "Erro Ao realizar consulta");
                return;
            }
        }
    }
}
