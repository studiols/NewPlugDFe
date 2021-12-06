using PlugDFe.Domain.Entities;
using PlugDFe.Infra.Database;
using System;
using System.Collections.Generic;
using System.Data;

namespace PlugDFe.ApplicationLayer.Query
{
    public class GetTransferredDocument
    {
        public DatabaseConnection DatabaseConnection { get; private set; }
        public string SQL { get; private set; }

        public GetTransferredDocument(DatabaseConnection databaseConnection)
        {
            DatabaseConnection = databaseConnection;
        }

        public List<TransferredDocument> GetLastDays(DateTime initialDate, DateTime finalDate, int idPlugTask)
        {
            TransferredDocument transferredDocument;
            List<TransferredDocument> transferredDocuments = new List<TransferredDocument>();
            DataTable dt;

            SQL = "SELECT * FROM transferreddocuments " +
                 "WHERE trdoc_issuedate between @InitialDate AND @FinalDate AND trdoc_ptask_id = @IdPlugTask";            

            Dictionary<string, object> dBParameters = new Dictionary<string, object>();
            dBParameters.Add("@InitialDate", initialDate);
            dBParameters.Add("@FinalDate", finalDate);
            dBParameters.Add("@IdPlugTask", idPlugTask);

            DatabaseConnection.OpenConnection();
            dt = DatabaseConnection.QueryPar(SQL, dBParameters);
            DatabaseConnection.CloseConnection();

            if (dt.Rows.Count == 0) { return null; }

            foreach (DataRow dr in dt.Rows)
            {
                transferredDocument = new TransferredDocument(
                    dr["trdoc_key"].ToString(),
                    Convert.ToInt32(dr["trdoc_ptask_id"]),
                    Convert.ToDateTime(dr["trdoc_issuedate"])
                );

                transferredDocument.SetId(Convert.ToInt32(dr["trdoc_id"]));

                transferredDocuments.Add(transferredDocument);
            }

            return transferredDocuments;
        }


        public List<TransferredDocument> GetAll(int limit)
        {
            TransferredDocument transferredDocument;
            List<TransferredDocument> transferredDocuments = new List<TransferredDocument>();
            DataTable dt;

            SQL = "SELECT * FROM transferreddocuments " +
                  "ORDER BY trdoc_id DESC " +
                  "LIMIT " + limit;

            DatabaseConnection.OpenConnection();
            dt = DatabaseConnection.Query(SQL);
            DatabaseConnection.CloseConnection();

            if (dt.Rows.Count == 0) { return null; }

            foreach (DataRow dr in dt.Rows)
            {
                transferredDocument = new TransferredDocument(
                    dr["trdoc_key"].ToString(),
                    Convert.ToInt32(dr["trdoc_ptask_id"]),
                    Convert.ToDateTime(dr["trdoc_issuedate"])
                );

                transferredDocument.SetId(Convert.ToInt32(dr["trdoc_id"]));


                transferredDocuments.Add(transferredDocument);
            }

            return transferredDocuments;
        }        
    }
}
