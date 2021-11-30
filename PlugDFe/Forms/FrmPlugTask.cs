using PlugDFe.ApplicationLayer.Query;
using PlugDFe.ApplicationLayer.UseCases.PlugTaskCases;
using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Enums;
using PlugDFe.Domain.Repositories;
using PlugDFe.Forms.Modal;
using PlugDFe.Infra.Database;
using PlugDFe.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PlugDFe.Forms
{
    public partial class FrmPlugTask : Form
    {
        public int IdPlugAddress  { get; private set; }
        public ManagePlugTaskCrud ManagePlugTaskCrud { get; private set; }
        public GetPlugTask GetPlugTask { get; private set; }
        public GetConnectViewer GetConnectViewer { get; private set; }

        public FrmPlugTask(int idPlugAddress)
        {
            InitializeComponent();
            LoadInstances(idPlugAddress);
            ApplySettings();
            FillGrdPlugTasks();
        }

        #region Buttons

        private void btnNewPlugTask_Click(object sender, EventArgs e)
        {
            ShowCrudModalPlugTasks(ECommandAction.INSERT);
        }

        private void btnUpdatePlugTask_Click(object sender, EventArgs e)
        {
            ShowCrudModalPlugTasks(ECommandAction.UPDATE, GetPlugTask.GetById(GetCurrentPlugTaskId()));
        }

        private void btnDeletePlugTask_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Excluir a Tarefa Selecionada ?", "Excluir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) { ManagePlugTaskCrud.Delete(GetCurrentPlugTaskId()); }
            FillGrdPlugTasks();
        }

        #endregion

        #region Events

        private void FormClosedModalPlugTask(object sender, FormClosedEventArgs e)
        {
            FillGrdPlugTasks();
        }

        #endregion

        #region Helpers

        private void ShowCrudModalPlugTasks(ECommandAction commandAction, PlugTask plugTask = null)
        {
            FrmModalPlugTask modalPlugFilePath = new FrmModalPlugTask(ManagePlugTaskCrud, commandAction, IdPlugAddress, GetConnectViewer.GetAll(), plugTask);
            modalPlugFilePath.FormClosed += FormClosedModalPlugTask;
            modalPlugFilePath.Show();
        }

        private int GetCurrentPlugTaskId()
        {
            return Convert.ToInt32(grdPlugTasks.CurrentRow.Cells[0].Value);
        }

        public void FillGrdPlugTasks()
        {
            grdPlugTasks.DataSource = GetPlugTask.GetAll(IdPlugAddress);                     
        }
        

        private void LoadInstances(int idPlugAddress)
        {
            IdPlugAddress = idPlugAddress;
            DatabaseConnection databaseConnection = new DatabaseConnectionAdapter();
            IPlugTaskRepository plugTaskRepository = new PlugTaskRepository(databaseConnection);
            ManagePlugTaskCrud = new ManagePlugTaskCrud(plugTaskRepository);
            GetPlugTask = new GetPlugTask(databaseConnection);
            GetConnectViewer = new GetConnectViewer(databaseConnection);
        }

        private void ApplySettings()
        {
            grdPlugTasks.AutoGenerateColumns = false;
        }

        #endregion
    }
}
