using PlugDFe.Domain.Entities;

namespace PlugDFe.Domain.Repositories
{
    public interface IPlugAddressRepository
    {
        void Save(PlugAddress plugAddress);
        void Update(PlugAddress plugAddress);
        void Delete(int id);
    }
}
