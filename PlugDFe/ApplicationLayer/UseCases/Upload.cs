using PlugDFe.ApplicationLayer.DTO.IntegrationIO;
using PlugDFe.Domain.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugDFe.ApplicationLayer.UseCases
{
    public class Upload
    {
        public ICommunicationPlatform CommunicationPlatform { get; set; }
        public Upload(ICommunicationPlatform communicationPlatform)
        {
            CommunicationPlatform = communicationPlatform;
        }

        public PlatformUploadOutput Execute(string idCompany, string email, string token, string path)
        {
            PlatformUploadInput input = new PlatformUploadInput(
                idCompany,
                email,
                token,
                path                
            );

            PlatformUploadOutput output = CommunicationPlatform.UploadDocuments(input);
            return output;
        }
    }
}
