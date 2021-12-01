using PlugDFe.ApplicationLayer.DTO.IntegrationIO;
using PlugDFe.ApplicationLayer.Query;
using PlugDFe.ApplicationLayer.Services;
using PlugDFe.ApplicationLayer.UseCases;
using PlugDFe.ApplicationLayer.UseCases.PlugUserCases;
using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Integration;
using PlugDFe.Domain.Repositories;
using PlugDFe.Domain.Services;
using PlugDFe.Infra.Database;
using PlugDFe.Infra.Integration;
using PlugDFe.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace PlugDFe.Forms
{
    public partial class frmMain : Form
    {
        private DatabaseConnection databaseConnection;

        #region Main

        public frmMain()
        {
            InitializeComponent();
            notifyIconApplication.Visible = true;
            notifyIconApplication.ShowBalloonTip(2000);
            databaseConnection = new DatabaseConnectionAdapter();
            grdMain.AutoGenerateColumns = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            FillGrdMain();
            SetTimerInterval();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            Hide();
        }

        private void SetTimerInterval()
        {
            GetConfig getConfig = new GetConfig(databaseConnection);
            timerMain.Interval = getConfig.GetIntervalTime() * 60000;
            timerMain.Start();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            ExecuteProcess();
        }

        #endregion

        private void btnShowFrmParameters_Click(object sender, EventArgs e)
        {
            FrmParameters frmParameters = new FrmParameters();
            frmParameters.ShowDialog();
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {             
            DialogResult dialog = MessageBox.Show("Deseja mesmo Finalizar a Aplicação ?", "Sait", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Logs.Write(0, "Aplicação finalizada pelo usuário", true);
                Environment.Exit(0);
            }
        }

        private void btnExecuteApplication_Click(object sender, EventArgs e)
        {
            ExecuteProcess();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }
                       
        private void ExecuteProcess()
        {            
            GetPlugUser getPlugUser = new GetPlugUser(databaseConnection);
            GetPlugAddress getPlugAddress = new GetPlugAddress(databaseConnection);
            GetPlugTask getPlugTask = new GetPlugTask(databaseConnection);
            GetConnectViewer getConnectViewer = new GetConnectViewer(databaseConnection);
            GetTransferredDocument getTransferredDocument = new GetTransferredDocument(databaseConnection);
            ManagePlugUserCrud managePlugUserCrud = new ManagePlugUserCrud(new PlugUserRepository(databaseConnection));
            ICommunicationPlatform communicationPlatform = new CommunicationPlatformDFe();           
            string token;
            List<PlugUser> plugUsers = getPlugUser.GetAll();
            List<PlugAddress> plugAdresses;
            List<PlugTask> plugTasks;
            ConnectViewer connectViewer = null;
            LogIn logIn = new LogIn(communicationPlatform);
            DateTime dateTime = DateTime.Now;

            if (plugUsers == null) { return; }

            foreach (PlugUser plugUser in plugUsers)
            {
                #region Login

                token = getPlugUser.GetValidTokenById(plugUser.Id);

                if (string.IsNullOrEmpty(token))
                {
                    PlatformLoginOutput output = logIn.Execute(plugUser.Email, PasswordEncryption.Decrypt(plugUser.Password));

                    if (output.autorizado && output.status == "N")
                    {
                        Logs.Write(plugUser.IdCompany, $"Login - Efetuado com sucesso! ({plugUser.Email})", false);
                        plugUser.SetToken(output.senha);
                        managePlugUserCrud.UpdateValidToken(plugUser.Id, output.senha);
                    }
                    else
                    {
                        Logs.Write(plugUser.IdCompany, $"Login - {output.msg} ({plugUser.Email})", false);
                        continue;                    
                    }                                   
                }
                
                Logs.Write(plugUser.IdCompany, $"Usuário logado! ({plugUser.Email})", true);
                                    
                #endregion

                plugAdresses = getPlugAddress.GetAll(plugUser.Id);

                if (plugAdresses == null) { continue; }

                foreach (PlugAddress plugAddress in plugAdresses)
                {
                    plugTasks = getPlugTask.GetAll(plugAddress.Id);

                    if (plugTasks == null) { continue; }

                    foreach (PlugTask plugTask in plugTasks)
                    {
                        if (plugTask.IdConnectViewer != 0)
                            connectViewer = getConnectViewer.GetById(plugTask.IdConnectViewer);

                        HandlerAction.Handle(
                            plugUser,
                            plugAddress,
                            plugTask,
                            connectViewer,
                            getTransferredDocument.GetLastDays(dateTime.AddDays(-30),
                            dateTime.AddDays(1)),
                            communicationPlatform,
                            databaseConnection
                        );
                    }
                }
            }

            FillGrdMain();
        }

        private void FillGrdMain()
        {
            GetTransferredDocument getTransferredDocument = new GetTransferredDocument(databaseConnection);
            grdMain.DataSource = getTransferredDocument.GetAll(100);
        }
    }
}
