using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Repositories;
using System;

namespace PlugDFe.ApplicationLayer.UseCases.PlugTaskCases
{
    public class ManagePlugTaskCrud
    {
        public IPlugTaskRepository PlugTaskRepository { get; private set; }

        public ManagePlugTaskCrud(IPlugTaskRepository plugTaskRepository)
        {
            PlugTaskRepository = plugTaskRepository;
        }

        public void Create(int idPlugAddress, int idConnectViewer, int action, int readMode, DateTime lastExecuteDate)
        {
            PlugTask plugTask = new PlugTask(idPlugAddress, action, readMode, lastExecuteDate);
            plugTask.SetIdConnectViewer(idConnectViewer);
            PlugTaskRepository.Save(plugTask);            
        }

        public void Update(int id, int idPlugAddress, int idConnectViewer, int action, int readMode, DateTime lastExecuteDate)
        {
            PlugTask plugTask = new PlugTask(idPlugAddress, action, readMode, lastExecuteDate);
            plugTask.SetId(id);
            plugTask.SetIdConnectViewer(idConnectViewer);
            PlugTaskRepository.Update(plugTask);
        }

        public void Delete(int id)
        {
            PlugTaskRepository.Delete(id);
        }        
    }
}
