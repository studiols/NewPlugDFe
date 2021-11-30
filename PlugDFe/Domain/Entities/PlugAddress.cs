using PlugDFe.Domain.Enums;
using System.IO;

namespace PlugDFe.Domain.Entities
{
    public class PlugAddress
    {
        public PlugAddress(int idPlugUser, string path, int fileType)
        {
            IdPlugUser = idPlugUser;
            Path = path;
            FileType = ConvertFileType(fileType);
        }

        public int Id { get; private set; }
        public int IdPlugUser { get; private set; }        
        public string Path { get; private set; }
        public EFileType FileType { get; private set; }

        public void SetId(int id)
        {
            Id = id;
        }
        
        public bool PathIsValid()
        {            
            if (Directory.Exists(Path)) { return true; }
            else { return false; }
        }

        public string GetFileType()
        {
            if (FileType == EFileType.NFE_EMISSAO_PROPRIA) { return "NFe Emissão Própria"; }
            else if (FileType == EFileType.NFE_EMISSAO_PROPRIA_EVENTO_CANCELAMENTO) { return "NFe Emissão Própria Evento Cancelamento"; }
            else if (FileType == EFileType.SAT) { return "SAT"; }
            else if (FileType == EFileType.SAT_EVENTO_CANCELAMENTO) { return "SAT Evento Cancelamento"; }
            else if (FileType == EFileType.NFCE) { return "NFCe"; }
            else if (FileType == EFileType.NFCE_EVENTO_CANCELAMENTO) { return "NFCe Evento Cancelamento"; }
            else { return "Inválido"; }
        }

        private EFileType ConvertFileType(int fileType)
        {
            if (fileType == 1) { return EFileType.NFE_EMISSAO_PROPRIA; }
            else if (fileType == 2) { return EFileType.NFE_EMISSAO_PROPRIA_EVENTO_CANCELAMENTO; }
            else if (fileType == 3) { return EFileType.SAT; }
            else if (fileType == 4) { return EFileType.SAT_EVENTO_CANCELAMENTO; }
            else if (fileType == 5) { return EFileType.NFCE; }
            else if (fileType == 6) { return EFileType.NFCE_EVENTO_CANCELAMENTO; }
            else { return EFileType.INVALIDO; }
        }
    }
}
