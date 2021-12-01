using PlugDFe.ApplicationLayer.DTO.IntegrationIO;
using PlugDFe.Domain.Integration;

namespace PlugDFe.ApplicationLayer.UseCases
{
    public class LogIn
    {
        public ICommunicationPlatform CommunicationPlatform { get; set; }
        public LogIn(ICommunicationPlatform communicationPlatform)
        {
            CommunicationPlatform = communicationPlatform;
        }

        public PlatformLoginOutput Execute(string email, string senha)
        {
            PlatformLoginInput input = new PlatformLoginInput();
            input.Email = email;
            input.Senha = senha;
            PlatformLoginOutput output =  CommunicationPlatform.Login(input);                        
            
            return output;
        }
    }
}
