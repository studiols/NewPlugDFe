using PlugDFe.Domain.Contracts;
using PlugDFe.Domain.Repositories;
using System;

namespace PlugDFe.ApplicationLayer.UseCases.ActionCases
{
    public class DeleteOldRecordsAction : IGenericAction
    {
        public DeleteOldRecordsAction(ITransferredDocumentRepository transferredDocumentRepository)
        {
            TransferredDocumentRepository = transferredDocumentRepository;
        }

        public ITransferredDocumentRepository TransferredDocumentRepository { get; private set; }

        public void Execute()
        {
            DateTime dateTime = DateTime.Now.AddDays(-35);
            TransferredDocumentRepository.Delete(dateTime);
        }
    }
}
