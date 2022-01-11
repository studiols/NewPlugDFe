using PlugDFe.Domain.Entities;
using PlugDFe.Infra.Database;
using System;
using System.Collections.Generic;
using System.Data;

namespace PlugDFe.ApplicationLayer.Query
{
    public class GetPlugTask
    {
        public DatabaseConnection DatabaseConnection { get; private set; }
        public string SQL { get; private set; }

        public GetPlugTask(DatabaseConnection databaseConnection)
        {
            DatabaseConnection = databaseConnection;
        }

        public List<PlugTask> GetAll(int idPlugAddress)
        {
            PlugTask plugTask;
            List<PlugTask> plugTasks = new List<PlugTask>();
            DataTable dt;

            SQL = "SELECT * FROM plugtasks " +
                 "WHERE ptask_paddr_id = " + idPlugAddress;     
            
            DatabaseConnection.OpenConnection();
            dt = DatabaseConnection.Query(SQL);
            DatabaseConnection.CloseConnection();

            if (dt.Rows.Count == 0) { return null; }

            foreach (DataRow dr in dt.Rows)
            {
                plugTask = new PlugTask(
                Convert.ToInt32(dr["ptask_paddr_id"]),
                Convert.ToInt32(dr["ptask_action"]),
                Convert.ToInt32(dr["ptask_readmode"]),
                Convert.ToDateTime(dr["ptask_lastdateexecute"]),
                Convert.ToDateTime(dr["ptask_startdate"])
                );
                plugTask.SetId(Convert.ToInt32(dr["ptask_id"]));
                plugTask.SetIdConnectViewer(Convert.ToInt32(dr["ptask_connv_id"]));
                plugTask.SetUnitCode(dr["ptask_unitcode"].ToString());
                plugTask.SetGroupCode(dr["ptask_groupcode"].ToString());

                plugTasks.Add(plugTask);
            }

            return plugTasks;
        }  
        
        public PlugTask GetById(int id) 
        {
            PlugTask plugTask;           
            DataTable dt;

            SQL = "SELECT * FROM plugtasks " +
                 "WHERE ptask_id = " + id;

            DatabaseConnection.OpenConnection();
            dt = DatabaseConnection.Query(SQL);
            DatabaseConnection.CloseConnection();

            if (dt.Rows.Count == 0) { return null; }          

            plugTask = new PlugTask(
            Convert.ToInt32(dt.Rows[0]["ptask_paddr_id"]),
            Convert.ToInt32(dt.Rows[0]["ptask_action"]),
            Convert.ToInt32(dt.Rows[0]["ptask_readmode"]),
            Convert.ToDateTime(dt.Rows[0]["ptask_lastdateexecute"]),
            Convert.ToDateTime(dt.Rows[0]["ptask_startdate"])
            );
            plugTask.SetId(Convert.ToInt32(dt.Rows[0]["ptask_id"]));
            plugTask.SetIdConnectViewer(Convert.ToInt32(dt.Rows[0]["ptask_connv_id"]));
            plugTask.SetUnitCode(dt.Rows[0]["ptask_unitcode"].ToString());
            plugTask.SetGroupCode(dt.Rows[0]["ptask_groupcode"].ToString());

            return plugTask;
        }
    }
}
