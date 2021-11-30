using PlugDFe.Domain.Entities;
using PlugDFe.Infra.Database;
using System;
using System.Collections.Generic;
using System.Data;

namespace PlugDFe.ApplicationLayer.Query
{
    public class GetConfig
    {
        public DatabaseConnection DatabaseConnection { get; private set; }
        public string SQL { get; private set; }

        public GetConfig(DatabaseConnection databaseConnection)
        {
            DatabaseConnection = databaseConnection;
        }

        public List<Config> GetAll()
        {
            SQL = "SELECT * FROM config";

            DatabaseConnection.OpenConnection();
            DataTable dt = DatabaseConnection.Query(SQL);
            DatabaseConnection.CloseConnection();

            if (dt.Rows.Count == 0) { return null; }

            List<Config> configs = new List<Config>();
            Config config;

            foreach (DataRow dr in dt.Rows)
            {
                config = new Config(
                    dr["cfg_name"].ToString(),
                    dr["cfg_type"].ToString(),
                    dr["cfg_value"].ToString()
                );

                config.SetId(Convert.ToInt32(dr["cfg_id"]));

                configs.Add(config);
            }

            return configs;
        }        

        public int GetIntervalTime()
        {
            SQL = "SELECT * FROM config " +
                  "WHERE cfg_name = @Name";

            Dictionary<string, object> dBParameters = new Dictionary<string, object>();
            dBParameters.Add("@Name", "Connect_Config_IntervaloExecucao");            

            DatabaseConnection.OpenConnection();
            DataTable dt = DatabaseConnection.QueryPar(SQL, dBParameters);
            DatabaseConnection.CloseConnection();

            return Convert.ToInt32(dt.Rows[0]["cfg_value"]);
        }
    }
}
