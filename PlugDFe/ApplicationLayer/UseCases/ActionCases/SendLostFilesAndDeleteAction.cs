using PlugDFe.ApplicationLayer.Services;
using PlugDFe.Domain.Contracts;
using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Integration;
using PlugDFe.Domain.Repositories;
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
            RedundancyHandleLostDocuments();
            List<FileInfo> validFilesAfterFilter = SendFiles();            
            HandlerFiles.DeleteFiles(validFilesAfterFilter);
        }
    }
}
