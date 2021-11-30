using System;
using System.IO;
using System.Reflection;

namespace PlugDFe.Domain.Services
{
    public static class Logs
    {
        public static void Write(int idCompany, string unityCode, string msg, bool dashedLine = false)
        {
            string logName = Create(idCompany, unityCode);

            TextWriter logFile = File.AppendText(logName);

            logFile.WriteLine($"{Convert.ToString(DateTime.Now).Replace('/', '-').Replace(':', '-')} - {msg}");

            if (dashedLine) { logFile.WriteLine(new string('-', 100)); }            

            logFile.Close();
        }

        private static string Create(int idCompany, string unityCode)
        {
            string today  = Convert.ToString(DateTime.Now).Split(' ')[0].Replace('/', '-');            
            string currentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string logName;

            if (!Directory.Exists(currentDirectory + "/Logs"))
            {
                Directory.CreateDirectory(currentDirectory + "/Logs");
            }

            if (idCompany != 0)
                logName = $"{Path.GetFullPath("Logs")}/log {today} - Empresa {idCompany} - Unidade {unityCode}.log";
            else
                logName = $"{Path.GetFullPath("Logs")}/log {today} - Geral.log";

            if (!File.Exists(logName))
            {
                File.Create(logName).Close();
            }

            return logName;
        }
    }
}
