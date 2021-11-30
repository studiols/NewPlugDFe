using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugDFe.ApplicationLayer.DTO.ConnectViewerIO
{
    public class ExecuteQueryInput
    {
        public ExecuteQueryInput(string type, string str, string command, string argUnit)
        {
            Type = type;
            Str = str;
            Command = command;
            ArgUnit = argUnit;            
        }
        
        public string Type { get;  set; }
        public string Str { get;  set; }
        public string Command { get;  set; }
        public string ArgUnit { get;  set; }
        public DateTime InitialDate { get; private set; }
        public DateTime FinalDate { get; private set; }
        public string TransferredKeys { get; private set; }

        public void AddInitialDate(DateTime initialDate)
        {
            InitialDate = initialDate;
        }

        public void AddFinalDate(DateTime finalDate)
        {
            FinalDate = finalDate;
        }

        public void AddTransferredKeys(string transferredKeys)
        {
            TransferredKeys = transferredKeys;
        }
    }
}
