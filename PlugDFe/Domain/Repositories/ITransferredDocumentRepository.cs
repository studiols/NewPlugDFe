using PlugDFe.Domain.Entities;
using System;

namespace PlugDFe.Domain.Repositories
{
    public interface ITransferredDocumentRepository
    {
        void SaveIfNotExists(TransferredDocument transferredDocument);
        void Update(TransferredDocument transferredDocument);
        void Delete(DateTime dateTime);
    }
}
