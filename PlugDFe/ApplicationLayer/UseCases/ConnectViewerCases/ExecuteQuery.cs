using FirebirdSql.Data.FirebirdClient;
using MySql.Data.MySqlClient;
using Npgsql;
using Oracle.ManagedDataAccess.Client;
using PlugDFe.ApplicationLayer.DTO.ConnectViewerIO;
using PlugDFe.Domain.Services;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PlugDFe.ApplicationLayer.UseCases.ConnectViewerCases
{
    public class ExecuteQuery
    {
        public ExecuteQueryOutput Execute(ExecuteQueryInput input)
        {
            if (input.Str.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("String de conexão não informada", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return new ExecuteQueryOutput(null, false);
            }

            if (input.Command.IndexOf("[DIVISION]") >= 0)
                input.Command = input.Command.Split(new[] { "[DIVISION]" }, StringSplitOptions.None)[input.CommandSequence];
         
            if (input.Command.IndexOf("[CURRENT_DATE]") >= 0)
                input.Command = input.Command.Replace("[CURRENT_DATE]", "CURRENT_DATE");

            if (input.Command.IndexOf("[CURRENT_DATE_STRING]") >= 0)
                input.Command = input.Command.Replace("[CURRENT_DATE_STRING]", DateTime.Now.ToString("yyyyMMdd"));

            if (input.Command.IndexOf("[DATA_ATUAL]") >= 0)
                input.Command = input.Command.Replace("[DATA_ATUAL]", DateTime.Now.ToString("dd/MM/yyyy"));

            if (input.Command.IndexOf("[DATA_ANTERIOR]") >= 0)
                input.Command = input.Command.Replace("[DATA_ANTERIOR]", DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy"));

            if (input.Command.IndexOf("[UNIDADE]") >= 0)
            {
                if (input.ArgUnit == "") { input.ArgUnit = "'1'"; }

                input.Command = input.Command.Replace("[UNIDADE]", $"'{input.ArgUnit}'");
            }

            if (input.Command.IndexOf("[INITIAL_DATE]") >= 0)            
                input.Command = input.Command.Replace("[INITIAL_DATE]", input.InitialDate);

            if (input.Command.IndexOf("[FINAL_DATE]") >= 0)
                input.Command = input.Command.Replace("[FINAL_DATE]", input.InitialDate);

            if (input.Command.IndexOf("[KEYS]") >= 0)
                input.Command = input.Command.Replace("[KEYS]", input.KeysToSend);

            System.Windows.Forms.Clipboard.SetText(input.Command); //CTRL+C

            DataTable dt = new DataTable();

            Logs.Write(0, $"Query Executada: {input.Command}");

            if (input.Type == "MYSQL")
            {
                #region MySql

                try
                {
                    MySqlConnection connMySql = new MySqlConnection(input.Str);
                    connMySql.Open();

                    MySqlCommand sqlCommandMySql = connMySql.CreateCommand();
                    sqlCommandMySql.CommandText = input.Command;

                    MySqlDataAdapter sqlDataAdapterMySql = new MySqlDataAdapter(sqlCommandMySql);
                    sqlDataAdapterMySql.Fill(dt);

                    connMySql.Close();

                    return new ExecuteQueryOutput(dt, true);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Erro ao executar comando SQL", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return new ExecuteQueryOutput(null, false);
                }

                #endregion
            }
            else if (input.Type == "POSTGRESQL")
            {
                #region PostgreSql

                try
                {
                    NpgsqlConnection connPostgres = new NpgsqlConnection(input.Str);
                    connPostgres.Open();

                    NpgsqlCommand sqlCommandPostgres = connPostgres.CreateCommand();
                    sqlCommandPostgres.CommandText = input.Command;

                    NpgsqlDataAdapter sqlDataAdapterPostgres = new NpgsqlDataAdapter(sqlCommandPostgres);
                    sqlDataAdapterPostgres.Fill(dt);

                    connPostgres.Close();

                    return new ExecuteQueryOutput(dt, true);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Erro ao executar comando SQL", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return new ExecuteQueryOutput(null, false);
                }

                #endregion
            }
            else if (input.Type == "ORACLE")
            {
                #region Oracle

                try
                {
                    OracleConnection connOracle = new OracleConnection(input.Str);
                    connOracle.Open();

                    OracleCommand sqlCommandOracle = connOracle.CreateCommand();
                    sqlCommandOracle.CommandText = input.Command;

                    OracleDataAdapter sqlDataAdapterOracle = new OracleDataAdapter(sqlCommandOracle);
                    sqlDataAdapterOracle.Fill(dt);

                    connOracle.Close();

                    return new ExecuteQueryOutput(dt, true);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Erro ao executar comando SQL", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return new ExecuteQueryOutput(null, false);
                }

                #endregion
            }
            else if (input.Type == "SQLSERVER")
            {
                #region Microsoft SqlServer

                try
                {
                    SqlConnection connMSql = new SqlConnection(input.Str);
                    connMSql.Open();

                    SqlCommand sqlCommandSql = connMSql.CreateCommand();
                    sqlCommandSql.CommandText = input.Command;

                    SqlDataAdapter sqlDataAdapterMSql = new SqlDataAdapter(sqlCommandSql);
                    sqlDataAdapterMSql.Fill(dt);

                    connMSql.Close();

                    return new ExecuteQueryOutput(dt, true);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Erro ao executar comando SQL", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return new ExecuteQueryOutput(null, false);
                }

                #endregion
            }
            else if (input.Type == "FIREBIRD")
            {
                #region Firebird

                try
                {
                    FbConnection connFb = new FbConnection(input.Str);
                    connFb.Open();

                    FbCommand sqlCommandFb = connFb.CreateCommand();
                    sqlCommandFb.CommandText = input.Command;

                    FbDataAdapter sqlDataAdapterFb = new FbDataAdapter(sqlCommandFb);
                    sqlDataAdapterFb.Fill(dt);

                    connFb.Close();

                    return new ExecuteQueryOutput(dt, true);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Erro ao executar comando SQL", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return new ExecuteQueryOutput(null, false);
                }

                #endregion
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Tipo de conexão não definada", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return new ExecuteQueryOutput(null, false);
            }
        }
    }
}
