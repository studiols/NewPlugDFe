using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Repositories;

namespace PlugDFe.ApplicationLayer.UseCases.PlugAddressCases
{
    public class ManagePlugAddressCrud
    {
        public IPlugAddressRepository PlugAddressRepository { get; set; }

        public ManagePlugAddressCrud(IPlugAddressRepository plugAddressRepository)
        {
            PlugAddressRepository = plugAddressRepository;
        }

        public void Create(int idPlugUser, int fileType, string path)
        {
            PlugAddress plugAddress = new PlugAddress(idPlugUser,path,fileType);
            if (!plugAddress.PathIsValid()) { return; } //Retornar Erro
            PlugAddressRepository.Save(plugAddress);
        }        

        public void Update(int id, int idPlugUser, int fileType, string path)
        {
            PlugAddress plugAddress = new PlugAddress(idPlugUser,path,fileType);
            plugAddress.SetId(id);
            if (!plugAddress.PathIsValid()) { return; } //Retornar Erro
            PlugAddressRepository.Update(plugAddress);
        }
        
        public void Delete(int id)
        {
            PlugAddressRepository.Delete(id);
        }
    }
}
