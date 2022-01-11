using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Repositories;
using PlugDFe.Infra.Database;
using System.Collections.Generic;

namespace PlugDFe.Infra.Repositories
{
    public class PlugTaskRepository : Repository, IPlugTaskRepository
    {     
        public PlugTaskRepository(DatabaseConnection databaseConnection) : base(databaseConnection)
        {            
        }
       
        public void Save(PlugTask plugTask)
        {            
            SQL = "INSERT INTO plugtasks (ptask_paddr_id, ptask_connv_id, ptask_action, ptask_readmode, ptask_unitcode, ptask_groupcode, ptask_lastdateexecute, ptask_startdate) " +
                  "VALUES(" +                  
                    "@Address, " +
                    "@IdConnectViewer, " +
                    "@Action, " +
                    "@ReadMode, " +
                    "@UnitCode, " +
                    "@GroupCode, " +
                    "@LastExecuteDate, " +
                    "@StartDate" +
                  ")";

            Dictionary<string, object> dBParameters = new Dictionary<string, object>
            {
                { "@Address", plugTask.IdPlugAddress },
                { "@IdConnectViewer", plugTask.IdConnectViewer },
                { "@Action", (int)plugTask.Action },
                { "@ReadMode", (int)plugTask.ReadMode },
                { "@UnitCode", plugTask.UnitCode },
                { "@GroupCode", plugTask.GroupCode },
                { "@LastExecuteDate", FormatFullDate(plugTask.LastExecuteDate) },
                { "@StartDate", FormatFullDate(plugTask.StartDate) }
            };

            DatabaseConnection.OpenConnection();
            DatabaseConnection.CommandPar(SQL, dBParameters);
            DatabaseConnection.CloseConnection();
        }

        public void Update(PlugTask plugTask)
        {
            SQL = "UPDATE plugtasks " +
                  "SET " +
                    "ptask_paddr_id = @Address, " +                                        
                    "ptask_connv_id = @IdConnectViewer, " +                                        
                    "ptask_action = @Action, " +
                    "ptask_readmode = @ReadMode, " +
                    "ptask_unitcode = @UnitCode, " +
                    "ptask_groupcode = @GroupCode, " +
                    "ptask_lastdateexecute = @LastExecuteDate, " +
                    "ptask_startdate = @StartDate " +
                  "WHERE ptask_id = @Id";

            Dictionary<string, object> dBParameters = new Dictionary<string, object>();
            dBParameters.Add("@Id", plugTask.Id);
            dBParameters.Add("@Address", plugTask.IdPlugAddress);            
            dBParameters.Add("@IdConnectViewer", plugTask.IdConnectViewer);            
            dBParameters.Add("@Action", (int)plugTask.Action);
            dBParameters.Add("@ReadMode", (int)plugTask.ReadMode);
            dBParameters.Add("@UnitCode", plugTask.UnitCode);
            dBParameters.Add("@GroupCode", plugTask.GroupCode);
            dBParameters.Add("@LastExecuteDate", FormatFullDate(plugTask.LastExecuteDate));
            dBParameters.Add("@StartDate", FormatFullDate(plugTask.StartDate));

            DatabaseConnection.OpenConnection();
            DatabaseConnection.CommandPar(SQL, dBParameters);
            DatabaseConnection.CloseConnection();
        }

        public void Delete(int id)
        {
            SQL = "DELETE FROM plugtasks " +
                  "WHERE ptask_id = " + id;
               
            DatabaseConnection.OpenConnection();
            DatabaseConnection.Command(SQL);
            DatabaseConnection.CloseConnection();
        }
    }
}
