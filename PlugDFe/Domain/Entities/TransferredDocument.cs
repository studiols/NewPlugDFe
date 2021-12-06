using System;

namespace PlugDFe.Domain.Entities
{
    public class TransferredDocument
    {
        public TransferredDocument(string key, int idPlugTask, DateTime issueDate)
        {
            Key = key;
            IdPlugTask = idPlugTask;
            IssueDate = issueDate;
        }

        public int Id { get; private set; }
        public string Key { get; private set; }
        public int IdPlugTask { get; private set; }
        public DateTime IssueDate { get; private set; }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetIdPlugTask(int idPlugTask)
        {
            IdPlugTask = idPlugTask;
        }
    }
}
