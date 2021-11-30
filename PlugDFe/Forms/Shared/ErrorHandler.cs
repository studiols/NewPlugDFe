using System.Collections.Generic;
using System.Windows.Forms;

namespace PlugDFe.Forms.Shared
{
    public static class ErrorHandler
    {
        public static bool ShowErrorMsg(string mainMsg, List<string> errors)
        {
            if (errors.Count > 0)
            {
                string msg = $"{mainMsg} \n";

                for (int i = 0; i < errors.Count; i++)
                {
                    msg += $"{i + 1} - {errors[i]} \n";
                }

                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }
    }
}
