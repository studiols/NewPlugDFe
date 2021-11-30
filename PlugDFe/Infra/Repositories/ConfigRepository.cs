using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Repositories;
using PlugDFe.Infra.Database;
using System.Collections.Generic;
using System.Data;

namespace PlugDFe.Infra.Repositories
{
    public class ConfigRepository : Repository, IConfigRepository
    {        
        public ConfigRepository(DatabaseConnection databaseConnection) : base(databaseConnection)
        {            
        }

        public void Save(string name, string type, string value)
        {
            SQL = "SELECT * FROM config " +
                  "WHERE cfg_name = @Name";

            Dictionary<string, object> dBParameters = new Dictionary<string, object>();
            dBParameters.Add("@Name", name);

            DatabaseConnection.OpenConnection();
            DataTable dt = DatabaseConnection.QueryPar(SQL, dBParameters);
            DatabaseConnection.CloseConnection();

            if (dt.Rows.Count > 0)
            {
                SQL = "UPDATE config " +
                      "SET " +
                        "cfg_type = @Type, " +
                        "cfg_value = @Value " +
                      "WHERE cfg_name = @Name";
            }
            else
            {
                SQL = "INSERT INTO config (cfg_name, cfg_type, cfg_value) " +
                 "VALUES(" +
                   "@Name," +
                   "@Type," +
                   "@Value" +
                 ")";
            }           

            dBParameters = new Dictionary<string, object>();
            dBParameters.Add("@Name", name);
            dBParameters.Add("@Type", type);
            dBParameters.Add("@Value",value);

            DatabaseConnection.OpenConnection();
            DatabaseConnection.CommandPar(SQL, dBParameters);
            DatabaseConnection.CloseConnection();
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

                configs.Add(config);
            }

            return configs;
        }
    }
}
