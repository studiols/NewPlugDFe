using PlugDFe.Domain.Services;
using PlugDFe.Domain.ValueObjects;

namespace PlugDFe.Domain.Entities
{
    public class Config : Notifiable<Notification>
    {
        public Config(string name, string type, string value) : base()
        {
            Name = name;
            Type = type;
            Value = value;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Value { get; private set; }

        public void SetId(int id)
        {
            Id = id;
        }
    }
}
