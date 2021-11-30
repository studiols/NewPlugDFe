
using PlugDFe.ApplicationLayer.Query;
using PlugDFe.ApplicationLayer.UseCases.ConfigCases;
using PlugDFe.ApplicationLayer.UseCases.ConnectViewerCases;
using PlugDFe.ApplicationLayer.UseCases.PlugUserCases;
using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Enums;
using PlugDFe.Forms.Modal;
using PlugDFe.Infra.Database;
using PlugDFe.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PlugDFe.Forms
{
    public partial class FrmParameters : Form
    {
        public CreateConfig CreateConfig { get; private set; }        
        public GetConfig GetConfig { get; private set; }
        public ManagePlugUserCrud ManagePlugUserCrud { get; private set; }
        public ManageConnectViewerCrud ManageConnectViewerCrud { get; private set; }
        public GetPlugUser GetPlugUser { get; private set; }
        public GetConnectViewer GetConnectViewer { get; private set; }

        public FrmParameters()
        {
            InitializeComponent();
            LoadInstances();
            ApplySettings();
            FillConfigs();
            FillGrdPlugUsers();
            FillGrdConnectViewers();
        }

        #region Configs

        private void btnRecordConfigs_Click(object sender, EventArgs e)
        {
            decimal execInterval = numericUpDownExecInterval.Value;
            CreateConfig.Execute(execInterval);
            Application.Restart();
        }

        public void FillConfigs()
        {
            List<Config> configs = GetConfig.GetAll();

            if (configs == null) { return; }

            foreach (Config config in configs)
            {
                if (config.Name == "Connect_Config_IntervaloExecucao")                
                    numericUpDownExecInterval.Value = Convert.ToDecimal(config.Value);                
            }
        }

        #endregion

        #region PlugUser

        private void FillGrdPlugUsers()
        {
            grdPlugUsers.DataSource = GetPlugUser.GetAll();
        }

        private void btnNewPlugUser_Click(object sender, EventArgs e)
        {
            ShowCrudModalPlugUser(ECommandAction.INSERT);
        }

        private void btnUpdatePlugUser_Click(object sender, EventArgs e)
        {
            ShowCrudModalPlugUser(ECommandAction.UPDATE, GetPlugUser.GetById(GetCurrentPlugUserId()));
        }

        private void btnGetPlugAdresses_Click(object sender, EventArgs e)
        {
            FrmPlugAdresses frmPlugFilePaths = new FrmPlugAdresses(GetCurrentPlugUserId());
            frmPlugFilePaths.ShowDialog();
        }

        private void btnDeletePlugUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Excluir o Usuário Selecionado ?", "Excluir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) { ManagePlugUserCrud.Delete(GetCurrentPlugUserId()); }
            FillGrdPlugUsers();
        }

        private int GetCurrentPlugUserId()
        {
            return Convert.ToInt32(grdPlugUsers.CurrentRow.Cells[0].Value);
        }

        private void ShowCrudModalPlugUser(ECommandAction commandAction, PlugUser plugUser = null)
        {
            FrmModalPlugUser modalPlugUser = new FrmModalPlugUser(ManagePlugUserCrud, commandAction, plugUser);
            modalPlugUser.FormClosed += FormClosedModalPlugUser;
            modalPlugUser.ShowDialog();            
        }
        
        private void FormClosedModalPlugUser(object sender, FormClosedEventArgs e)
        {
            FillGrdPlugUsers();
        }

        #endregion

        #region ConnectViewer

        private void btnNewConnection_Click(object sender, EventArgs e)
        {
            ShowCrudModalConnectViewer(ECommandAction.INSERT);
        }

        private void btnUpdateConnection_Click(object sender, EventArgs e)
        {
            ShowCrudModalConnectViewer(ECommandAction.UPDATE, GetConnectViewer.GetById(GetCurrentConnectViewerId()));
        }

        private void btnDeleteConnection_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Excluir a Conexão Selecionada ?", "Excluir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) { ManageConnectViewerCrud.Delete(GetCurrentConnectViewerId()); }                                        
            FillGrdConnectViewers();
        }

        public void FillGrdConnectViewers()
        {
            grdConnectViewers.DataSource = GetConnectViewer.GetAll();
        }

        private int GetCurrentConnectViewerId()
        {
            return Convert.ToInt32(grdConnectViewers.CurrentRow.Cells[0].Value);
        }

        private void ShowCrudModalConnectViewer(ECommandAction commandAction, ConnectViewer connectViewer = null)
        {
            FrmModalConnectViewer modalConnectViewer = new FrmModalConnectViewer(ManageConnectViewerCrud, commandAction, connectViewer);
            modalConnectViewer.FormClosed += FormClosedModalConnectViewer;
            modalConnectViewer.ShowDialog();
        }

        private void FormClosedModalConnectViewer(object sender, FormClosedEventArgs e)
        {
            FillGrdConnectViewers();
        }

        #endregion      

        private void LoadInstances()
        {           
            DatabaseConnection databaseConnection = new DatabaseConnectionAdapter();
            PlugUserRepository plugUserRepository = new PlugUserRepository(databaseConnection);
            ConnectViewerRepository connectViewerRepository = new ConnectViewerRepository(databaseConnection);
            CreateConfig = new CreateConfig(new ConfigRepository(databaseConnection));
            ManagePlugUserCrud = new ManagePlugUserCrud(plugUserRepository);
            ManageConnectViewerCrud = new ManageConnectViewerCrud(connectViewerRepository);
            GetPlugUser = new GetPlugUser(databaseConnection);
            GetConnectViewer = new GetConnectViewer(databaseConnection);
            GetConfig = new GetConfig(databaseConnection);
        }       

        private void ApplySettings()
        {
            grdPlugUsers.AutoGenerateColumns = false;
            grdConnectViewers.AutoGenerateColumns = false;
        }        
    }
}
