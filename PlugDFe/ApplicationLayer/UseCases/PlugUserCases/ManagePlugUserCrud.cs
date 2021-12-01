using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Repositories;

namespace PlugDFe.ApplicationLayer.UseCases.PlugUserCases
{
    public class ManagePlugUserCrud
    {
        public IPlugUserRepository PlugUserRepository { get; private set; }

        public ManagePlugUserCrud(IPlugUserRepository plugUserRepository)
        {
            PlugUserRepository = plugUserRepository;
        }

        public void Create(int idCompany, string email, string password)
        {
            PlugUserRepository.Save(
                new PlugUser(
                    email,
                    password,
                    idCompany                
                )
            );
        }

        public void Update(int id, int idCompany, string email, string password)
        {
            PlugUser plugUser = new PlugUser(
                email,
                password,
                idCompany                
            );
            plugUser.SetId(id);
            PlugUserRepository.Update(plugUser);
        }
        
        public void Delete(int id)
        {
            PlugUserRepository.Delete(id);
        }   
        
        public void UpdateValidToken(int id, string token)
        {
            PlugUserRepository.SetValidToken(id, token);
        }
    }
}
