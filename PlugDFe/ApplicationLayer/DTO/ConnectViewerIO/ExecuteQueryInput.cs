namespace PlugDFe.ApplicationLayer.DTO.ConnectViewerIO
{
    public class ExecuteQueryInput
    {
        public ExecuteQueryInput(string type, string str, string command, string argUnit)
        {
            int commandSequence = 1;
            Type = type;
            Str = str;
            Command = command;
            ArgUnit = argUnit;
            CommandSequence = commandSequence;
        }
        
        public string Type { get;  set; }
        public string Str { get;  set; }
        public string Command { get;  set; }
        public int CommandSequence { get; set; }
        public string ArgUnit { get;  set; }
        public string InitialDate { get; private set; }
        public string FinalDate { get; private set; }
        public string KeysToSend { get; private set; }

        public void AddInitialDate(string initialDate)
        {
            InitialDate = initialDate;
        }

        public void AddFinalDate(string finalDate)
        {
            FinalDate = finalDate;
        }

        public void AddKeysToSend(string keysToSend)
        {
            KeysToSend = keysToSend;
        }
    }
}
