using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Repositories;
using PlugDFe.Infra.Database;
using System.Collections.Generic;

namespace PlugDFe.Infra.Repositories
{
    public class PlugAddressRepository : Repository, IPlugAddressRepository
    {
        public PlugAddressRepository(DatabaseConnection databaseConnection) : base(databaseConnection)
        {
        }

        public void Save(PlugAddress plugAddress)
        {
            SQL = "INSERT INTO plugadresses (paddr_puser_id, paddr_path, paddr_filetype) " +
                  "VALUES(" +
                    "@PlugUser, " +                    
                    "@Path, " +
                    "@FileType" +
                  ")";

            Dictionary<string, object> dBParameters = new Dictionary<string, object>();
            dBParameters.Add("@PlugUser", plugAddress.IdPlugUser);            
            dBParameters.Add("@Path", plugAddress.Path);
            dBParameters.Add("@FileType", (int)plugAddress.FileType);            

            DatabaseConnection.OpenConnection();
            DatabaseConnection.CommandPar(SQL, dBParameters);
            DatabaseConnection.CloseConnection();
        }

        public void Update(PlugAddress plugAddress)
        {
            SQL = "UPDATE plugadresses " +
                  "SET " +
                    "paddr_puser_id = @PlugUser, " +                    
                    "paddr_path = @Path, " +
                    "paddr_filetype = @FileType " +
                  "WHERE paddr_id = @Id";

            Dictionary<string, object> dBParameters = new Dictionary<string, object>();
            dBParameters.Add("@Id", plugAddress.Id);
            dBParameters.Add("@PlugUser", plugAddress.IdPlugUser);            
            dBParameters.Add("@Path", plugAddress.Path);
            dBParameters.Add("@FileType", (int)plugAddress.FileType);

            DatabaseConnection.OpenConnection();
            DatabaseConnection.CommandPar(SQL, dBParameters);
            DatabaseConnection.CloseConnection();
        }

        public void Delete(int id)
        {
            SQL = "DELETE FROM plugadresses " +
                  "WHERE paddr_id = " + id;

            DatabaseConnection.OpenConnection();
            DatabaseConnection.Command(SQL);
            DatabaseConnection.CloseConnection();
        }
    }
}
