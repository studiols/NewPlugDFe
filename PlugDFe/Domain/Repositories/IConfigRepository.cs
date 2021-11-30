using PlugDFe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugDFe.Domain.Repositories
{
    public interface IConfigRepository
    {
        void Save(string name, string type, string value);
        List<Config> GetAll();
    }
}
