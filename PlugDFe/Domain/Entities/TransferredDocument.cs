using System;

namespace PlugDFe.Domain.Entities
{
    public class TransferredDocument
    {
        public TransferredDocument(string key, DateTime issueDate)
        {
            Key = key;
            IssueDate = issueDate;
        }

        public int Id { get; private set; }
        public string Key { get; private set; }
        public DateTime IssueDate { get; private set; }

        public void SetId(int id)
        {
            Id = id;
        }
    }
}
