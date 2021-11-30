using System.Collections.Generic;
using System.Linq;

namespace PlugDFe.Domain.Entities
{
    public class ConnectViewer
    {
        private IList<string> _behaviors;

        public ConnectViewer(string name, string type, string str, string command, string blobToBase64, string base64ToString, string compressedBase64ToString)
        {
            Name = name;
            Type = type;
            Str = str;
            Command = command;
            BlobToBase64 = blobToBase64;
            Base64ToString = base64ToString;
            CompressedBase64ToString = compressedBase64ToString;
            _behaviors = new List<string>();
        }

        public void AddBehavior(string behavior)
        {
            _behaviors.Add(behavior);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Str { get; private set; }
        public string Command { get; private set; }
        public string BlobToBase64 { get; private set; }
        public string Base64ToString { get; private set; }
        public string CompressedBase64ToString { get; private set; }
        public IReadOnlyCollection<string> Behaviors { get => _behaviors.ToList(); }
    }
}
