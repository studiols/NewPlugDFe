using Newtonsoft.Json;
using PlugDFe.ApplicationLayer.DTO.IntegrationIO;
using PlugDFe.Domain.Integration;
using RestSharp;
using System.IO;

namespace PlugDFe.Infra.Integration
{
    public class CommunicationPlatformDFe : ICommunicationPlatform
    {
        public string URL { get; private set; }
        
        public CommunicationPlatformDFe()
        {
            URL = "https://back-dfe.4lions.tec.br/dfe/v1/public";                                                                        
        }

        public PlatformLoginOutput Login(PlatformLoginInput platformLogin)
        {
            string url = $"{URL}/PostLogin";
            RestClient client = new RestClient(url);
            client.Timeout = 10000;
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", JsonConvert.SerializeObject(platformLogin, Formatting.None), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return JsonConvert.DeserializeObject<PlatformLoginOutput>(response.Content);
        }

        public PlatformUploadOutput UploadDocuments(PlatformUploadInput platformUploadInput)
        {
            string url = $"{URL}/PostXMLDFeCompact?empresa={platformUploadInput.IdCompany}";
            RestClient client = new RestClient(url);
            client.Timeout = 300000;
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddHeader("email", platformUploadInput.Email);
            request.AddHeader("senha", platformUploadInput.Token);
            request.AddFile(Path.GetFileName(platformUploadInput.Path), platformUploadInput.Path);
            request.AddParameter("overwrite", "true", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return JsonConvert.DeserializeObject<PlatformUploadOutput>(response.Content);

        }        
    }
}
