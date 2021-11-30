using PlugDFe.Domain.Entities;

namespace PlugDFe.Domain.Repositories
{
    public interface IPlugTaskRepository
    {
        void Save(PlugTask plugTask);
        void Update(PlugTask plugTask);
        void Delete(int id);      
    }
}
