using PlugDFe.ApplicationLayer.UseCases.PlugUserCases;
using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Enums;
using PlugDFe.Domain.Services;
using PlugDFe.Forms.Services;
using PlugDFe.Forms.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PlugDFe.Forms.Modal
{
    public partial class FrmModalPlugUser : Form
    {
        private ManagePlugUserCrud ManagePlugUserCrud { get; set; }
        private ECommandAction CommandAction { get; set; }        

        public FrmModalPlugUser(ManagePlugUserCrud managePlugUserCrud, ECommandAction commandAction, PlugUser plugUser = null)
        {
            InitializeComponent();
            ManagePlugUserCrud = managePlugUserCrud;
            txtIdPlugUser.Enabled = false;
            CommandAction = commandAction;           
            
            if (commandAction == ECommandAction.UPDATE)
            {                
                if (plugUser != null) 
                { 
                    txtIdPlugUser.Text = plugUser.Id.ToString();
                    txtIdCompanyPlugUser.Text = plugUser.IdCompany.ToString();
                    txtUnitCodePlugUser.Text = plugUser.UnitCode.ToString();
                    txtEmailPlugUser.Text = plugUser.Email.ToString();
                    txtPasswordPlugUser.Text = PasswordEncryption.Decrypt(plugUser.Password.ToString()); 
                }
            }
        }

        private void btnRecordPlugUser_Click(object sender, EventArgs e)
        {
            if (ErrorHandler.ShowErrorMsg("Erro ao Gravar Usuário!", ValidateAllInputs())) { return; }            
                        
            if (CommandAction == ECommandAction.INSERT)            
                ManagePlugUserCrud.Create(
                    Convert.ToInt32(txtIdCompanyPlugUser.Text),
                    txtUnitCodePlugUser.Text,
                    txtEmailPlugUser.Text,
                    PasswordEncryption.Encrypt(txtPasswordPlugUser.Text)
                );            
            else            
                ManagePlugUserCrud.Update(
                    Convert.ToInt32(txtIdPlugUser.Text),
                    Convert.ToInt32(txtIdCompanyPlugUser.Text),
                    txtUnitCodePlugUser.Text,
                    txtEmailPlugUser.Text,
                    PasswordEncryption.Encrypt(txtPasswordPlugUser.Text)
                );

            this.Close();
        }

        private void btnCancelPlugUser_Click(object sender, EventArgs e)
        {                        
            this.Close();
        }
        
        private List<string> ValidateAllInputs()
        {
            List<string> errors = new List<string>();
            
            if (InputValidator.IsNullOrEmpty(txtIdCompanyPlugUser.Text)) { errors.Add("O Id da Empresa deve ser preenchido corretamente!"); }
            if (InputValidator.IsNullOrEmpty(txtUnitCodePlugUser.Text)) { errors.Add("O Código da Unidade deve ser preenchido corretamente!"); }
            if (InputValidator.IsNullOrEmpty(txtEmailPlugUser.Text)) { errors.Add("O Email deve ser preenchido corretamente!"); }
            if (InputValidator.IsNullOrEmpty(txtPasswordPlugUser.Text)) { errors.Add("A Senha deve ser preenchido corretamente!"); }

            if (!InputValidator.IsNumeric(txtIdCompanyPlugUser.Text)) { errors.Add("O Id da Empresa deve ser do tipo inteiro!"); }

            return errors;
        }        
    }
}
