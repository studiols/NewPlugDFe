using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Repositories;
using PlugDFe.Infra.Database;
using System.Collections.Generic;


namespace PlugDFe.Infra.Repositories
{
    public class ConnectViewerRepository : Repository, IConnectViewerRepository
    {        
        public ConnectViewerRepository(DatabaseConnection databaseConnection) : base(databaseConnection)
        {           
        }

        public void Delete(int id)
        {
            SQL = "DELETE FROM connectviewers " +
                  "WHERE connv_id = " + id;
          
            DatabaseConnection.OpenConnection();
            DatabaseConnection.Command(SQL);
            DatabaseConnection.CloseConnection();
        }
        
        public void Save(ConnectViewer connectViewer)
        {
            SQL = "INSERT INTO connectviewers (connv_name, connv_type, connv_str, connv_command, connv_blobtobase64, connv_base64tostring, connv_compressedbase64tostring) " +
                  "VALUES(" +
                    "@Name," +
                    "@Type," +
                    "@Str," +
                    "@Command," +
                    "@BlobToBase64," +
                    "@Base64ToString," +
                    "@CompressedBase64ToString" +
                  ")";

            Dictionary<string, object> dBParameters = new Dictionary<string, object>();
            dBParameters.Add("@Name", connectViewer.Name);
            dBParameters.Add("@Type", connectViewer.Type);
            dBParameters.Add("@Str", connectViewer.Str);
            dBParameters.Add("@Command", connectViewer.Command);
            dBParameters.Add("@BlobToBase64", connectViewer.BlobToBase64);
            dBParameters.Add("@Base64ToString", connectViewer.Base64ToString);
            dBParameters.Add("@CompressedBase64ToString", connectViewer.CompressedBase64ToString);

            DatabaseConnection.OpenConnection();
            DatabaseConnection.CommandPar(SQL, dBParameters);
            DatabaseConnection.CloseConnection();
        }

        public void Update(ConnectViewer connectViewer)
        {
            SQL = "UPDATE connectviewers " +
                  "SET " +
                    "connv_name = @Name," +
                    "connv_type = @Type," +
                    "connv_str = @Str," +
                    "connv_command = @Command," +
                    "connv_blobtobase64 = @BlobToBase64," +
                    "connv_base64tostring = @Base64ToString," +
                    "connv_compressedbase64tostring = @CompressedBase64ToString " +
                  "WHERE connv_id = @Id";

            Dictionary<string, object> dBParameters = new Dictionary<string, object>();
            dBParameters.Add("@Id", connectViewer.Id);
            dBParameters.Add("@Name", connectViewer.Name);
            dBParameters.Add("@Type", connectViewer.Type);
            dBParameters.Add("@Str", connectViewer.Str);
            dBParameters.Add("@Command", connectViewer.Command);
            dBParameters.Add("@BlobToBase64", connectViewer.BlobToBase64);
            dBParameters.Add("@Base64ToString", connectViewer.Base64ToString);
            dBParameters.Add("@CompressedBase64ToString", connectViewer.CompressedBase64ToString);

            DatabaseConnection.OpenConnection();
            DatabaseConnection.CommandPar(SQL, dBParameters);
            DatabaseConnection.CloseConnection();
        }
    }
}
