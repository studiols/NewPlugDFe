using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace PlugDFe.Infra.Database
{
    public class DatabaseConnectionAdapter : DatabaseConnection
    {       
        public SQLiteConnection SqLiteConnection { get; private set; }        

        public DatabaseConnectionAdapter(string caminhoDados = "")
        {            
            if (caminhoDados == "")
                caminhoDados = System.AppDomain.CurrentDomain.BaseDirectory + "/dados.db";

            string connectionString = "Data Source=" + caminhoDados + ";" +
                      "Version=3;" +
                      "New=False;" +
                      "Cache Size=8000;" +
                      "Page Size=8192;";

            SqLiteConnection = new SQLiteConnection(connectionString);
        }    

        public int Command(string txtSql)
        {
            try
            {                
                SQLiteCommand sqlCommand = SqLiteConnection.CreateCommand();                
                sqlCommand.CommandType = CommandType.Text;              
                sqlCommand.CommandTimeout = 30; //em segundos
                sqlCommand.CommandText = txtSql;
                               
                int retorno = sqlCommand.ExecuteNonQuery();                              
                return Convert.ToInt32(retorno);
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }
        }     
        
        public int CommandPar(string txtSql, Dictionary<string, object> parameters)
        {
            try
            {
                SQLiteCommand sqlCommand = SqLiteConnection.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandTimeout = 30; //em segundos
                sqlCommand.CommandText = txtSql;

                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {                        
                        sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }

                int retorno = sqlCommand.ExecuteNonQuery();
                return Convert.ToInt32(retorno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Query(string txtSql)
        {
            try
            {                              
                SQLiteCommand sqlCommand = SqLiteConnection.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;                                
                sqlCommand.CommandTimeout = 30;
                sqlCommand.CommandText = txtSql;                      
                SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);                
                DataTable dataTable = new DataTable();                
                sqlDataAdapter.Fill(dataTable);                
                return dataTable;
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }
        }

        public DataTable QueryPar(string txtSql, Dictionary<string, object> parameters)
        {
            try
            {
                SQLiteCommand sqlCommand = SqLiteConnection.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandTimeout = 30;
                sqlCommand.CommandText = txtSql;

                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }

                SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void OpenConnection()
        {
            if (SqLiteConnection.State == ConnectionState.Closed) { SqLiteConnection.Open(); }
        }

        public void CloseConnection()
        {
            if (SqLiteConnection.State == ConnectionState.Open) { SqLiteConnection.Close(); }
        }
    }
}
