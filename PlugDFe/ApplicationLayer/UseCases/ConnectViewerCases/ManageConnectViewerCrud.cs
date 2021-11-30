using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Repositories;

namespace PlugDFe.ApplicationLayer.UseCases.ConnectViewerCases
{
    public class ManageConnectViewerCrud
    {
        public IConnectViewerRepository ConnectViewerRepository { get; set; }

        public ManageConnectViewerCrud(IConnectViewerRepository connectViewerRepository)
        {
            ConnectViewerRepository = connectViewerRepository;
        }

        public void Create(string name, string type, string str, string command, string blobToBase64, string base64ToString, string compressedBase64ToString)
        {
            ConnectViewer connectViewer = new ConnectViewer(
                name,
                type,
                str,
                command,
                blobToBase64,
                base64ToString,
                compressedBase64ToString
            );
            ConnectViewerRepository.Save(connectViewer);
        }

        public void Update(int id, string name, string type, string str, string command, string blobToBase64, string base64ToString, string compressedBase64ToString)
        {
            ConnectViewer connectViewer = new ConnectViewer(
               name,
               type,
               str,
               command,
               blobToBase64,
               base64ToString,
               compressedBase64ToString
           );
            connectViewer.SetId(id);
            ConnectViewerRepository.Update(connectViewer);
        }

        public void Delete(int id)
        {
            ConnectViewerRepository.Delete(id);
        }
    }
}
