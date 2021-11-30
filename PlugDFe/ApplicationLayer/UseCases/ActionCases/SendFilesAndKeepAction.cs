using PlugDFe.Domain.Contracts;
using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Integration;
using PlugDFe.Domain.Repositories;
using System.Collections.Generic;

namespace PlugDFe.ApplicationLayer.UseCases.ActionCases
{
    internal class SendFilesAndKeepAction : GenericAction, IGenericAction
    {
        public SendFilesAndKeepAction(PlugUser plugUser, PlugAddress plugAddress, PlugTask plugTask, ConnectViewer connectViewer, List<TransferredDocument> transferredDocuments, ICommunicationPlatform communicationPlatform, ITransferredDocumentRepository transferredDocumentRepository) : base(plugUser, plugAddress, plugTask, connectViewer, transferredDocuments, communicationPlatform, transferredDocumentRepository)
        {

        }

        public void Execute()
        {
            QueryToFiles();
            SendFiles();
        }
    }
}
