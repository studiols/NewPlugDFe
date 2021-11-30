namespace PlugDFe.Domain.ValueObjects
{
    public class Notification
    {
        public Notification(string key, string msg)
        {
            Key = key;
            Msg = msg;
        }

        public string Key { get; private set; }
        public string Msg { get; private set; }
    }
}
