using PlugDFe.Domain.Entities;
using System.Collections.Generic;

namespace PlugDFe.Domain.Repositories
{
    public interface IPlugUserRepository
    {
        void Save(PlugUser plugUser);
        void Update(PlugUser plugUser);
        void Delete(int id);
        void SetValidToken(int id, string token);
    }
}
