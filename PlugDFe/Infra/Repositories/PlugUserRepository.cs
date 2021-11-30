using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Repositories;
using PlugDFe.Infra.Database;
using System;
using System.Collections.Generic;

namespace PlugDFe.Infra.Repositories
{
    public class PlugUserRepository : Repository, IPlugUserRepository
    {        
        public PlugUserRepository(DatabaseConnection databaseConnection) : base(databaseConnection)
        {            
        }      
        public void Save(PlugUser plugUser)
        {
            SQL = "INSERT INTO plugusers (puser_idcompany, puser_unitcode, puser_email, puser_password) " +
                  "VALUES(" +
                    "@IdCompany," +
                    "@UnitCode," +
                    "@Email," +
                    "@Password" +
                  ")";

            Dictionary<string, object> dBParameters = new Dictionary<string, object>();            
            dBParameters.Add("@IdCompany", plugUser.IdCompany);
            dBParameters.Add("@UnitCode", plugUser.UnitCode);
            dBParameters.Add("@Email", plugUser.Email);
            dBParameters.Add("@Password", plugUser.Password);

            DatabaseConnection.OpenConnection();
            DatabaseConnection.CommandPar(SQL, dBParameters);
            DatabaseConnection.CloseConnection();
        }

        public void Update(PlugUser plugUser)
        {
            SQL = "UPDATE plugusers " +
                  "SET " +
                    "puser_idcompany = @IdCompany, " +
                    "puser_unitcode = @UnitCode, " +
                    "puser_email = @Email, " +
                    "puser_password = @Password " +
                  "WHERE puser_id = @Id";

            Dictionary<string, object> dBParameters = new Dictionary<string, object>();
            dBParameters.Add("@Id", plugUser.Id);
            dBParameters.Add("@IdCompany", plugUser.IdCompany);
            dBParameters.Add("@UnitCode", plugUser.UnitCode);
            dBParameters.Add("@Email", plugUser.Email);
            dBParameters.Add("@Password", plugUser.Password);

            DatabaseConnection.OpenConnection();
            DatabaseConnection.CommandPar(SQL, dBParameters);
            DatabaseConnection.CloseConnection();
        }

        public void SetValidToken(int id, string token)
        {
            DateTime date = DateTime.Now;            

            SQL = "UPDATE plugusers " +
                 "SET " +
                   "puser_token = @Token, " +                   
                   "puser_validate = @Validate " +
                 "WHERE puser_id = @Id";

            Dictionary<string, object> dBParameters = new Dictionary<string, object>();
            dBParameters.Add("@Id", id);
            dBParameters.Add("@Token", token);
            dBParameters.Add("@Validate", FormatShortDate(date));

            DatabaseConnection.OpenConnection();
            DatabaseConnection.CommandPar(SQL, dBParameters);
            DatabaseConnection.CloseConnection();
        }

        public void Delete(int id)
        {
            SQL = "DELETE FROM plugusers " +
                  "WHERE puser_id = " + id;

            DatabaseConnection.OpenConnection();
            DatabaseConnection.Command(SQL);
            DatabaseConnection.CloseConnection();
        }
    }
}
