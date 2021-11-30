using PlugDFe.ApplicationLayer.DTO.IntegrationIO;
using PlugDFe.Domain.Integration;
using PlugDFe.Domain.Services;

namespace PlugDFe.ApplicationLayer.UseCases
{
    public class LogIn
    {
        public ICommunicationPlatform CommunicationPlatform { get; set; }
        public LogIn(ICommunicationPlatform communicationPlatform)
        {
            CommunicationPlatform = communicationPlatform;
        }

        public PlatformLoginOutput Execute(string email, string senha, int idCompany, string unitCode)
        {
            PlatformLoginInput input = new PlatformLoginInput();
            input.Email = email;
            input.Senha = senha;
            PlatformLoginOutput output =  CommunicationPlatform.Login(input);

            if (output.autorizado && output.status == "N")            
                Logs.Write(idCompany, unitCode, $"Login - Efetuado com sucesso! ({email} - {unitCode})", true);            
            else            
                Logs.Write(idCompany, unitCode, $"Login - {output.msg} ({email} - {unitCode})", true);                
            
            return output;
        }
    }
}
