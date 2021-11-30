using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Repositories;
using PlugDFe.Infra.Database;
using System;
using System.Collections.Generic;
using System.Data;

namespace PlugDFe.Infra.Repositories
{
    public class TransferredDocumentRepository : Repository, ITransferredDocumentRepository
    {
        public TransferredDocumentRepository(DatabaseConnection databaseConnection) : base(databaseConnection)
        {
        }

        public void Delete(DateTime dateTime)
        {
            SQL = "DELETE from transferreddocuments " +
                 "WHERE trdoc_issuedate < " + dateTime.AddDays(-4);

            DatabaseConnection.OpenConnection();
            DatabaseConnection.Command(SQL);
            DatabaseConnection.CloseConnection();
        }

        public void SaveIfNotExists(TransferredDocument transferredDocument)
        {            
            DataTable dt;

            SQL = "SELECT * FROM transferreddocuments " +
                  "WHERE trdoc_key = @Key";

            Dictionary<string, object> dBParameters = new Dictionary<string, object>();
            dBParameters.Add("@Key", transferredDocument.Key);

            DatabaseConnection.OpenConnection();
            dt = DatabaseConnection.QueryPar(SQL, dBParameters);
            

            if (dt.Rows.Count == 0)
            {
                SQL = "INSERT INTO transferreddocuments " +
                    "(" +
                        "trdoc_key," +
                        "trdoc_issuedate" +
                    ") " +
                  "VALUES(" +
                    "@Key," +
                    "@IssueDate" +
                  ")";

                dBParameters = new Dictionary<string, object>();
                dBParameters.Add("@Key", transferredDocument.Key);
                dBParameters.Add("@IssueDate", FormatShortDate(transferredDocument.IssueDate));

                DatabaseConnection.CommandPar(SQL, dBParameters);
                DatabaseConnection.CloseConnection();
            }            
        }

        public void Update(TransferredDocument transferredDocument)
        {
            SQL = "UPDATE transferreddocuments " +                    
                  "SET " +
                    "trdoc_key = @Key," +
                    "trdoc_issuedate = @IssueDate" +
                  "WHERE trdoc_id = @Id";

            Dictionary<string, object> dBParameters = new Dictionary<string, object>();
            dBParameters.Add("@Id", transferredDocument.Id);
            dBParameters.Add("@Key", transferredDocument.Key);
            dBParameters.Add("@IssueDate", FormatShortDate(transferredDocument.IssueDate));

            DatabaseConnection.OpenConnection();
            DatabaseConnection.CommandPar(SQL, dBParameters);
            DatabaseConnection.CloseConnection();
        }
    }
}
