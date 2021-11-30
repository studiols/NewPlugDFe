using PlugDFe.ApplicationLayer.Query;
using PlugDFe.ApplicationLayer.UseCases.PlugAddressCases;
using PlugDFe.ApplicationLayer.UseCases.PlugTaskCases;
using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Enums;
using PlugDFe.Domain.Repositories;
using PlugDFe.Forms.Modal;
using PlugDFe.Infra.Database;
using PlugDFe.Infra.Repositories;
using System;
using System.Windows.Forms;

namespace PlugDFe.Forms
{
    public partial class FrmPlugAdresses : Form
    {                
        public ManagePlugAddressCrud ManagePlugAddressCrud { get; private set; }
        public ManagePlugTaskCrud ManagePlugTaskCrud { get; private set; }
        public GetPlugAddress GetPlugAddress { get; private set; }
        public GetPlugTask GetPlugTask { get; private set; }        
        public int IdPlugUser { get; private set; }

        public FrmPlugAdresses(int idPlugUser)
        {            
            InitializeComponent();
            LoadInstances(idPlugUser);
            ApplySettings();
            FillGrdPlugAdresses();
        }
       
        #region Buttons

        private void btnNewPlugAddress_Click(object sender, EventArgs e)
        {
            ShowCrudModalAddress(ECommandAction.INSERT);
        }

        private void btnUpdatePlugAddress_Click(object sender, EventArgs e)
        {
            ShowCrudModalAddress(ECommandAction.UPDATE, GetPlugAddress.GetById(GetCurrentPlugAddressId()));
        }

        private void btnPlugTask_Click(object sender, EventArgs e)
        {                                                
            FrmPlugTask frmPlugTask = new FrmPlugTask(GetCurrentPlugAddressId());
            frmPlugTask.ShowDialog();
        }

        private void btnDeletePlugAddress_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Excluir o Endereço Selecionado ?", "Excluir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) { ManagePlugAddressCrud.Delete(GetCurrentPlugAddressId()); ; }                        
            FillGrdPlugAdresses();
        }

        #endregion

        #region Events

        private void FormClosedModalAddress(object sender, FormClosedEventArgs e)
        {
            FillGrdPlugAdresses();
        }

        #endregion

        private void ShowCrudModalAddress(ECommandAction commandAction, PlugAddress plugAddress = null)
        {
            FrmModalPlugAddress modalPlugFilePath = new FrmModalPlugAddress(ManagePlugAddressCrud, commandAction, IdPlugUser, plugAddress);
            modalPlugFilePath.FormClosed += FormClosedModalAddress;
            modalPlugFilePath.ShowDialog();
        }

        private int GetCurrentPlugAddressId()
        {
            return Convert.ToInt32(grdPlugAdresses.CurrentRow.Cells[0].Value);
        }       

        private void LoadInstances(int idPlugUser)
        {
            IdPlugUser = idPlugUser;
            DatabaseConnection databaseConnection = new DatabaseConnectionAdapter();
            IPlugAddressRepository plugAddressRepository = new PlugAddressRepository(databaseConnection);
            IPlugTaskRepository plugTaskRepository = new PlugTaskRepository(databaseConnection);    
            ManagePlugAddressCrud = new ManagePlugAddressCrud(plugAddressRepository);
            ManagePlugTaskCrud = new ManagePlugTaskCrud(plugTaskRepository);
            GetPlugAddress = new GetPlugAddress(databaseConnection);
            GetPlugTask = new GetPlugTask(databaseConnection);            
        }

        private void ApplySettings()
        {
            grdPlugAdresses.AutoGenerateColumns = false;
        }

        private void FillGrdPlugAdresses()
        {
            grdPlugAdresses.DataSource = GetPlugAddress.GetAll(IdPlugUser);
        }
    }
}
