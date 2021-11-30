using PlugDFe.Domain.Entities;
using System.Collections.Generic;

namespace PlugDFe.Domain.Repositories
{
    public interface IConnectViewerRepository
    {
        void Save(ConnectViewer connectViewer);
        void Update(ConnectViewer connectViewer);    
        void Delete(int id);
    }
}
