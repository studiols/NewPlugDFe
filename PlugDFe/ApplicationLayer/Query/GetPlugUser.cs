using PlugDFe.Domain.Entities;
using PlugDFe.Infra.Database;
using System;
using System.Collections.Generic;
using System.Data;

namespace PlugDFe.ApplicationLayer.Query
{
    public class GetPlugUser
    {
        public DatabaseConnection DatabaseConnection { get; private set; }
        public string SQL { get; private set; }

        public GetPlugUser(DatabaseConnection databaseConnection)
        {
            DatabaseConnection = databaseConnection;
        }

        public List<PlugUser> GetAll()
        {
            SQL = "SELECT * FROM plugusers";

            DataTable dt;
            DatabaseConnection.OpenConnection();
            dt = DatabaseConnection.QueryPar(SQL, null);
            DatabaseConnection.CloseConnection();

            if (dt.Rows.Count == 0) { return null; }

            List<PlugUser> plugUsers = new List<PlugUser>();
            PlugUser plugUser;

            foreach (DataRow dr in dt.Rows)
            {
                plugUser = new PlugUser(
                    dr["puser_email"].ToString(),
                    dr["puser_password"].ToString(),
                    Convert.ToInt32(dr["puser_idcompany"])                    
                );

                plugUser.SetId(Convert.ToInt32(dr["puser_id"]));

                if (!string.IsNullOrEmpty(dr["puser_token"].ToString()))                
                    plugUser.SetToken(dr["puser_token"].ToString());
                
                plugUsers.Add(plugUser);
            }

            return plugUsers;
        }

        public PlugUser GetById(int id)
        {
            SQL = "SELECT * FROM plugusers " +
                  "WHERE puser_id = " + id;
         
            DataTable dt;
            DatabaseConnection.OpenConnection();
            dt = DatabaseConnection.Query(SQL);
            DatabaseConnection.CloseConnection();

            if (dt.Rows.Count == 0) { return null; }

            PlugUser plugUser;

            plugUser = new PlugUser(
                dt.Rows[0]["puser_email"].ToString(),
                dt.Rows[0]["puser_password"].ToString(),
                Convert.ToInt32(dt.Rows[0]["puser_idcompany"])                
            );

            plugUser.SetId(Convert.ToInt32(dt.Rows[0]["puser_id"]));

            if (!string.IsNullOrEmpty(dt.Rows[0]["puser_token"].ToString()))
                plugUser.SetToken(dt.Rows[0]["puser_token"].ToString());

            return plugUser;
        }

        public string GetValidTokenById(int id)
        {
            SQL = "SELECT puser_token, puser_validate FROM plugusers " +
                 "WHERE puser_id = " + id;
     
            DataTable dt;
            DatabaseConnection.OpenConnection();
            dt = DatabaseConnection.Query(SQL);
            DatabaseConnection.CloseConnection();

            if (dt.Rows.Count == 0) { return ""; }

            string token = dt.Rows[0]["puser_token"].ToString();
            string date = dt.Rows[0]["puser_validate"].ToString();
            if (string.IsNullOrEmpty(date)) { return ""; }
            DateTime validateDate = Convert.ToDateTime(dt.Rows[0]["puser_validate"]);
            if (validateDate.Day == DateTime.Now.Day) { return token; }
            else { return ""; }
        }
    }
}
