using PlugDFe.ApplicationLayer.DTO.ConnectViewerIO;
using PlugDFe.ApplicationLayer.Services;
using PlugDFe.ApplicationLayer.UseCases.ConnectViewerCases;
using PlugDFe.Domain.Contracts;
using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Integration;
using PlugDFe.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.IO;

namespace PlugDFe.ApplicationLayer.UseCases.ActionCases
{
    public class SendLostFilesAndDeleteAction : GenericAction, IGenericAction
    {
        public SendLostFilesAndDeleteAction(PlugUser plugUser, PlugAddress plugAddress, PlugTask plugTask, ConnectViewer connectViewer, List<TransferredDocument> transferredDocuments, ICommunicationPlatform communicationPlatform, ITransferredDocumentRepository transferredDocumentRepository) : base(plugUser, plugAddress, plugTask, connectViewer, transferredDocuments, communicationPlatform, transferredDocumentRepository)
        {

        }

        public void Execute()
        {
            #region Consultando Documentos que não foram enviados

            ExecuteQuery executeQuery = new ExecuteQuery();
            ExecuteQueryInput executeQueryInput;
            DateTime dateTime = DateTime.Now;

            if (ConnectViewer != null && TransferredDocuments.Count > 0 && (dateTime.AddDays(1).Day <= 4))
            {
                List<string> listOfTransferredKeys = new List<string>();
                foreach (TransferredDocument document in TransferredDocuments)
                {
                    listOfTransferredKeys.Add(document.Key);
                }
                string stringListOfTransferredKeys = string.Join(",", listOfTransferredKeys);
                executeQueryInput = new ExecuteQueryInput(
                    ConnectViewer.Type,
                    ConnectViewer.Str,
                    ConnectViewer.Command,
                    PlugUser.UnitCode
                );
                executeQueryInput.AddInitialDate(dateTime.AddDays(-31));
                executeQueryInput.AddFinalDate(dateTime.AddDays(1));
                executeQueryInput.AddTransferredKeys(stringListOfTransferredKeys);
                ExecuteQueryOutput executeQueryOutput = executeQuery.Execute(executeQueryInput);

                if (executeQueryOutput.Success)
                    HandlerFiles.CreateFiles(
                        PlugAddress.Path,
                        executeQueryOutput.Dt,
                        ConnectViewer.BlobToBase64,
                        ConnectViewer.Base64ToString,
                        ConnectViewer.CompressedBase64ToString
                    );
                else 
                    return;
            }

            #endregion

            List<FileInfo> validFilesAfterFilter = SendFiles();

            #region Excluir Arquivos Filtrados

            HandlerFiles.DeleteFiles(validFilesAfterFilter);

            #endregion
        }
    }
}
