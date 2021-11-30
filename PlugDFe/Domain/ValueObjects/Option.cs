namespace PlugDFe.Domain.ValueObjects
{
    public class Option
    {
        public Option(int id, string key, string value)
        {
            Id = id;
            Key = key;
            Value = value;
        }

        public int Id { get; private set; }
        public string Key { get; private set; }
        public string Value { get; private set; }
    }
}
