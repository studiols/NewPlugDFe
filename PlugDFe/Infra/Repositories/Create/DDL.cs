using PlugDFe.ApplicationLayer.Query;
using PlugDFe.ApplicationLayer.UseCases.ConfigCases;
using PlugDFe.Domain.Entities;
using PlugDFe.Infra.Database;
using System;
using System.Collections.Generic;

namespace PlugDFe.Infra.Repositories.Create
{
    public class DDL
    {        
        public DatabaseConnection DatabaseConnection { get; set; }
        public string SQL { get; set; }        
        public GetConfig GetConfig { get; private set; }

        public DDL(DatabaseConnection databaseConnection)
        {
            DatabaseConnection = databaseConnection;
            SQL = "";            
            GetConfig = new GetConfig(databaseConnection);
        }       

        /// <summary>
        /// Cria o Schema/Database e as tabelas que serão utilizadas
        /// </summary>
        public void Execute()
        {
            DatabaseConnection.OpenConnection();

            #region config

            SQL = "CREATE TABLE IF NOT EXISTS config (" +
                  "  cfg_id INTEGER PRIMARY KEY AUTOINCREMENT," +
                  "  cfg_name varchar(100) DEFAULT NULL," +
                  "  cfg_type varchar(2) DEFAULT NULL," +
                  "  cfg_value text DEFAULT NULL" +
                  ")";

            DatabaseConnection.Command(SQL);

            #endregion

            #region logs

            SQL = "CREATE TABLE IF NOT EXISTS logs (" +
                  "  log_id INTEGER PRIMARY KEY AUTOINCREMENT," +
                  "  log_dthr timestamp DEFAULT now," +
                  "  log_descricao varchar(100)," +
                  "  log_complemento varchar(100)," +
                  "  log_usua_id INTEGER" +
                  ")";

            DatabaseConnection.Command(SQL);

            #endregion

            #region DocumentTypes

            SQL = "CREATE TABLE IF NOT EXISTS documenttypes (" +
                    " doct_id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    " doct_name Varchar(50)" +
                 ")";

            DatabaseConnection.Command(SQL);

            #endregion

            #region PlugUser

            SQL = "CREATE TABLE IF NOT EXISTS plugusers (" +
                 "  puser_id INTEGER PRIMARY KEY AUTOINCREMENT," +
                 "  puser_idcompany bigint DEFAULT NULL," +                                             
                 "  puser_email varchar(80) DEFAULT NULL," +
                 "  puser_password varchar(25) DEFAULT NULL," +
                 "  puser_token varchar(255) DEFAULT NULL," +
                 "  puser_validate date DEFAULT NULL" +
                 ")";

            DatabaseConnection.Command(SQL);

            #endregion

            #region PlugAddress

            SQL = "CREATE TABLE IF NOT EXISTS plugadresses (" +
                 "  paddr_id INTEGER PRIMARY KEY AUTOINCREMENT," +
                 "  paddr_puser_id INTEGER DEFAULT NULL," +                
                 "  paddr_path TEXT DEFAULT NULL," +
                 "  paddr_filetype INTEGER DEFAULT NULL" +
                 ")";

            DatabaseConnection.Command(SQL);

            #endregion

            #region PlugTask

            SQL = "CREATE TABLE IF NOT EXISTS plugtasks (" +
                 "  ptask_id INTEGER PRIMARY KEY AUTOINCREMENT," +
                 "  ptask_paddr_id INTEGER DEFAULT NULL," +
                 "  ptask_connv_id INTEGER DEFAULT NULL," +
                 "  ptask_action INTEGER DEFAULT NULL," +
                 "  ptask_readmode INTEGER DEFAULT NULL," +
                 "  ptask_unitcode varchar(25) DEFAULT NULL," +
                 "  ptask_groupcode varchar(25) DEFAULT NULL," +
                 "  ptask_lastdateexecute datetime DEFAULT NULL," +
                 "  ptask_startdate datetime DEFAULT NULL" +
                 ")";

            DatabaseConnection.Command(SQL);

            #endregion

            #region TransferredDocuments

            SQL = "CREATE TABLE IF NOT EXISTS transferreddocuments (" +
                  " trdoc_id INTEGER PRIMARY KEY AUTOINCREMENT," +
                  " trdoc_key varchar(50) NOT NULL," +
                  " trdoc_unitcode varchar(25) DEFAULT NULL," +
                  " trdoc_groupcode varchar(25) DEFAULT NULL," +
                  " trdoc_issuedate date DEFAULT NULL" +
                  ")";

            DatabaseConnection.Command(SQL);

            #endregion

            #region ConnectViewer

            SQL = "CREATE TABLE IF NOT EXISTS connectviewers (" +
                    " connv_id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    " connv_name varchar(200) DEFAULT NULL," +
                    " connv_type varchar(50) DEFAULT NULL," +
                    " connv_str text DEFAULT NULL," +
                    " connv_command text DEFAULT NULL," +                    
                    " connv_blobtobase64 varchar(1) DEFAULT NULL," +                    
                    " connv_compressedbase64tostring varchar(1) DEFAULT NULL," +                    
                    " connv_base64tostring varchar(1) DEFAULT NULL" +                    
                  ")";

            DatabaseConnection.Command(SQL);

            #endregion

            #region Preset Config

            List<Config> configs = GetConfig.GetAll();

            DatabaseConnection.OpenConnection();
            
            if (configs == null)
            {
                SQL = "INSERT INTO config (cfg_name, cfg_type, cfg_value) " +
                      "VALUES (" +
                        "@Name, " +
                        "@Type, " +
                        "@Value" +
                      ")";

                Dictionary<string, object> dBParameters = new Dictionary<string, object>();
                dBParameters.Add("@Name", "Connect_Config_IntervaloExecucao");
                dBParameters.Add("@Type", "N");
                dBParameters.Add("@Value", "180");

                DatabaseConnection.CommandPar(SQL, dBParameters);
            }
           
            #endregion

            DatabaseConnection.CloseConnection();
        }

        private void AddColumn(string nameTable, string nameColumn, string typeColumn, string defaultColumn = "")
        {
            DatabaseConnection.OpenConnection();

            SQL = "SELECT 1 " +
                  "FROM INFORMATION_SCHEMA.COLUMNS " +
                  "WHERE table_schema='price' AND table_name='" + nameTable + "' AND column_name='" + nameColumn + "'";

            if (DatabaseConnection.Query(SQL).Rows.Count == 0)
            {
                SQL = "ALTER TABLE " + nameTable + " ADD COLUMN " + nameColumn + " " + typeColumn;

                if (defaultColumn != "")
                    SQL += " DEFAULT " + defaultColumn;

                DatabaseConnection.Command(SQL);
            }

            DatabaseConnection.CloseConnection();
        }
    }
}
