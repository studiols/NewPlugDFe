using PlugDFe.Domain.Entities;
using PlugDFe.Infra.Database;
using System;
using System.Collections.Generic;
using System.Data;

namespace PlugDFe.ApplicationLayer.Query
{
    public class GetConnectViewer
    {
        public DatabaseConnection DatabaseConnection { get; private set; }
        public string SQL { get; private set; }

        public GetConnectViewer(DatabaseConnection databaseConnection)
        {
            DatabaseConnection = databaseConnection;
        }

        public List<ConnectViewer> GetAll()
        {
            SQL = "SELECT * FROM connectviewers";
      
            DatabaseConnection.OpenConnection();
            DataTable dt = DatabaseConnection.Query(SQL);
            DatabaseConnection.CloseConnection();

            if (dt.Rows.Count == 0) { return null; }

            List<ConnectViewer> connectViewers = new List<ConnectViewer>();
            ConnectViewer connectViewer;

            foreach (DataRow dr in dt.Rows)
            {
                connectViewer = new ConnectViewer(
                    dr["connv_name"].ToString(),
                    dr["connv_type"].ToString(),
                    dr["connv_str"].ToString(),
                    dr["connv_command"].ToString(),
                    dr["connv_blobtobase64"].ToString(),
                    dr["connv_base64tostring"].ToString(),
                    dr["connv_compressedbase64tostring"].ToString()
                );

                connectViewer.SetId(Convert.ToInt32(dr["connv_id"]));

                connectViewers.Add(connectViewer);
            }

            return connectViewers;
        }

        public ConnectViewer GetById(int id)
        {
            SQL = "SELECT * FROM connectviewers " +
                  "WHERE connv_id = " + id;

            Dictionary<string, object> dBParameters = new Dictionary<string, object>();
            dBParameters.Add("@Id", id);

            DatabaseConnection.OpenConnection();
            DataTable dt = DatabaseConnection.QueryPar(SQL, dBParameters);
            DatabaseConnection.CloseConnection();

            if (dt.Rows.Count == 0) { return null; }

            ConnectViewer connectViewer;

            connectViewer = new ConnectViewer(
                dt.Rows[0]["connv_name"].ToString(),
                dt.Rows[0]["connv_type"].ToString(),
                dt.Rows[0]["connv_str"].ToString(),
                dt.Rows[0]["connv_command"].ToString(),
                dt.Rows[0]["connv_blobtobase64"].ToString(),
                dt.Rows[0]["connv_base64tostring"].ToString(),
                dt.Rows[0]["connv_compressedbase64tostring"].ToString()
            );

            connectViewer.SetId(Convert.ToInt32(dt.Rows[0]["connv_id"]));

            return connectViewer;
        }
    }
}
