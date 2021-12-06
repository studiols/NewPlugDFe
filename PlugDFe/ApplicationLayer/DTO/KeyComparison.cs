namespace PlugDFe.ApplicationLayer.DTO
{
    public class KeyComparison
    {
        public KeyComparison(string fKey, string tkey)
        {
            FKey = fKey;
            Tkey = tkey;
        }

        public string FKey { get; set; }
        public string Tkey { get; set; }
    }
}
