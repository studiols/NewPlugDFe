using System;

namespace PlugDFe.Forms.Services
{
    public static class InputValidator
    {        

        public static bool IsNullOrEmpty(string value)
        {
            if (string.IsNullOrEmpty(value)) { return true; }

            return false;
        }

        public static bool IsNumeric(string value)
        {
            int result;

            bool parseSuccess = Int32.TryParse(value, out result);

            if (parseSuccess) { return true; }
            else { return false; }
        }

        public static int SplitOption(string value)
        {
            int result = Convert.ToInt32(value.Split('-')[0]);
            return result;
        }
    }
}
