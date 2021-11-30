using PlugDFe.Domain.Entities;
using PlugDFe.Infra.Database;
using System;
using System.Collections.Generic;
using System.Data;

namespace PlugDFe.ApplicationLayer.Query
{
    public class GetPlugAddress
    {
        public DatabaseConnection DatabaseConnection { get; private set; }
        public string SQL { get; private set; }

        public GetPlugAddress(DatabaseConnection databaseConnection)
        {
            DatabaseConnection = databaseConnection;
        }

        public List<PlugAddress> GetAll(int idPlugUser)
        {
            PlugAddress plugAddress;
            List<PlugAddress> plugAdresses = new List<PlugAddress>();
            DataTable dt;

            SQL = "SELECT * FROM plugadresses " +
                 "WHERE paddr_puser_id = " + idPlugUser;

            DatabaseConnection.OpenConnection();
            dt = DatabaseConnection.Query(SQL);
            DatabaseConnection.CloseConnection();

            if (dt.Rows.Count == 0) { return null; }

            foreach (DataRow dr in dt.Rows)
            {
                plugAddress = new PlugAddress(
                    Convert.ToInt32(dr["paddr_puser_id"]),
                    dr["paddr_path"].ToString(),                   
                    Convert.ToInt32(dr["paddr_filetype"])
                );

                plugAddress.SetId(Convert.ToInt32(dr["paddr_id"]));
               

                plugAdresses.Add(plugAddress);
            }

            return plugAdresses;
        }

        public PlugAddress GetById(int id)
        {
            PlugAddress plugAddress;
            DataTable dt;

            SQL = "SELECT * FROM plugadresses " +
                 "WHERE paddr_id = " + id;

            DatabaseConnection.OpenConnection();
            dt = DatabaseConnection.Query(SQL);
            DatabaseConnection.CloseConnection();

            if (dt.Rows.Count == 0) { return null; }

            plugAddress = new PlugAddress(
                    Convert.ToInt32(dt.Rows[0]["paddr_puser_id"]),
                    dt.Rows[0]["paddr_path"].ToString(),
                    Convert.ToInt32(dt.Rows[0]["paddr_filetype"])
                );

            plugAddress.SetId(Convert.ToInt32(dt.Rows[0]["paddr_id"]));

            return plugAddress;
        }
    }
}
