﻿using PlugDFe.Domain.Entities;
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
            SQL = "INSERT INTO plugtasks (ptask_paddr_id, ptask_connv_id, ptask_action, ptask_readmode, ptask_lastdateexecute) " +
                  "VALUES(" +                  
                    "@Address, " +
                    "@IdConnectViewer, " +
                    "@Action, " +
                    "@ReadMode, " +
                    "@LastExecuteDate" +
                  ")";

            Dictionary<string, object> dBParameters = new Dictionary<string, object>
            {
                { "@Address", plugTask.IdPlugAddress },
                { "@IdConnectViewer", plugTask.IdConnectViewer },
                { "@Action", (int)plugTask.Action },
                { "@ReadMode", (int)plugTask.ReadMode },
                { "@LastExecuteDate", FormatFullDate(plugTask.LastExecuteDate) }
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
                    "ptask_lastdateexecute = @LastExecuteDate " +
                  "WHERE ptask_id = @Id";

            Dictionary<string, object> dBParameters = new Dictionary<string, object>();
            dBParameters.Add("@Id", plugTask.Id);
            dBParameters.Add("@Address", plugTask.IdPlugAddress);            
            dBParameters.Add("@IdConnectViewer", plugTask.IdConnectViewer);            
            dBParameters.Add("@Action", (int)plugTask.Action);
            dBParameters.Add("@ReadMode", (int)plugTask.ReadMode);
            dBParameters.Add("@LastExecuteDate", FormatFullDate(plugTask.LastExecuteDate));

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