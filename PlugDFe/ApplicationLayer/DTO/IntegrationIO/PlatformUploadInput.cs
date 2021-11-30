namespace PlugDFe.ApplicationLayer.DTO.IntegrationIO
{
    public class PlatformUploadInput
    {
        public PlatformUploadInput(string idCompany, string email, string token, string path)
        {
            IdCompany = idCompany;
            Email = email;
            Token = token;
            Path = path;
        }

        public string IdCompany { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string Path { get; set; }
    }
}
