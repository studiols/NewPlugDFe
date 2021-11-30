using System;

namespace PlugDFe.Domain.Services
{
    public static class PasswordEncryption
    {
        public static string Encrypt(string pass)
        {
            string response = "";

            for (int i = 0; i < pass.Length; i++)
            {
                int original = (int)pass[i];
                int encrypted = original + 45;
                response += Char.ConvertFromUtf32(encrypted).ToString();
            }

            return response;
        }

        public static string Decrypt(string pass)
        {
            string response = "";

            for (int i = 0; i < pass.Length; i++)
            {
                int encrypted = (int)pass[i];
                int original = encrypted - 45;
                response += Char.ConvertFromUtf32(original).ToString();
            }

            return response;
        }
    }
}
