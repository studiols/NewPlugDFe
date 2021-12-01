using PlugDFe.ApplicationLayer.UseCases.ActionCases;
using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Enums;
using PlugDFe.Domain.Integration;
using PlugDFe.Domain.Repositories;
using PlugDFe.Domain.Services;
using PlugDFe.Infra.Database;
using PlugDFe.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace PlugDFe.ApplicationLayer.Services
{
    public static class HandlerAction
    {
        public static void Handle(PlugUser plugUser, PlugAddress plugAddress, PlugTask plugTask, ConnectViewer connectViewer, List<TransferredDocument> transferredDocuments, ICommunicationPlatform communicationPlatform, DatabaseConnection databaseConnection)
        {
            ITransferredDocumentRepository transferredDocumentRepository = new TransferredDocumentRepository(databaseConnection);
            IPlugTaskRepository plugTaskRepository = new PlugTaskRepository(databaseConnection);
            DateTime lastExecuteDate = DateTime.Now;

            if (plugTask.Action == EAction.MANTER)
            {
                new SendFilesAndKeepAction(plugUser, plugAddress, plugTask, connectViewer, transferredDocuments, communicationPlatform, transferredDocumentRepository).Execute();                
            }
            else if (plugTask.Action == EAction.EXCLUIR)
            {
                new SendFilesAndDeleteAction(plugUser, plugAddress, plugTask, connectViewer, transferredDocuments,  communicationPlatform, transferredDocumentRepository).Execute();
            }
            else if (plugTask.Action == EAction.ENVIAR_PERDIDOS_E_EXCLUIR)
            {
                new SendLostFilesAndDeleteAction(plugUser, plugAddress, plugTask, connectViewer, transferredDocuments, communicationPlatform, transferredDocumentRepository).Execute();
            }
            else if (plugTask.Action == EAction.ENVIAR_PERDIDOS_E_MANTER)
            {
                new SendLostFilesAndKeepAction(plugUser, plugAddress, plugTask, connectViewer, transferredDocuments, communicationPlatform, transferredDocumentRepository).Execute();
            }
            else if (plugTask.Action == EAction.EXCLUIR_REGISTROS_VELHOS)
            {
                new DeleteOldRecordsAction(transferredDocumentRepository).Execute();
            }

            plugTask.SetLastExecuteDate(lastExecuteDate);
            plugTaskRepository.Update(plugTask);
            Logs.Write(plugUser.IdCompany, $"Ação - {plugTask.GetAction()} - {plugAddress.Path}", true);
        }
    }
}
