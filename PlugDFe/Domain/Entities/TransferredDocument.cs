using System;

namespace PlugDFe.Domain.Entities
{
    public class TransferredDocument
    {
        public TransferredDocument(string key, string unitCode, string groupCode, DateTime issueDate)
        {
            Key = key;
            UnitCode = unitCode;
            GroupCode = groupCode;
            IssueDate = issueDate;
        }

        public int Id { get; private set; }
        public string Key { get; private set; }
        public string UnitCode { get; private set; }
        public string GroupCode { get; private set; }
        public DateTime IssueDate { get; private set; }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetUnitCode(string unitCode)
        {
            UnitCode = unitCode;
        }

        public void SetGroupCode(string groupCode)
        {
            GroupCode = groupCode;
        }
    }
}
