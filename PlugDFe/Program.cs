using PlugDFe.Forms;
using System;
using System.Windows.Forms;

namespace PlugDFe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            if (System.Diagnostics.Process.GetProcessesByName("PlugDFe").Length > 1)
            {
                MessageBox.Show("Atenção: Sistema já em execução. Verifique!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }            

            Infra.Repositories.Create.DDL ddl = new Infra.Repositories.Create.DDL(new Infra.Database.DatabaseConnectionAdapter());

            try
            {
                ddl.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível abrir/configurar o banco de dados. Verifique as configurações de acesso e tente novamente.\n" + ex.Message);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}