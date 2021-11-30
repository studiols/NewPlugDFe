
using PlugDFe.ApplicationLayer.DTO.IntegrationIO;

namespace PlugDFe.Domain.Integration
{
    public interface ICommunicationPlatform
    {
        PlatformLoginOutput Login(PlatformLoginInput platformLogin);
        PlatformUploadOutput UploadDocuments(PlatformUploadInput platformUploadInput);
    }
}
