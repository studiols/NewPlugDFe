using PlugDFe.ApplicationLayer.UseCases.PlugAddressCases;
using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Enums;
using PlugDFe.Forms.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PlugDFe.Forms.Modal
{
    public partial class FrmModalPlugAddress : Form
    {        
        private ECommandAction CommandAction { get; set; }
        public int IdPlugUser { get; private set; }
        public ManagePlugAddressCrud ManagePlugAddressCrud { get; private set; }

        public FrmModalPlugAddress(ManagePlugAddressCrud managePlugAddressCrud, ECommandAction commandAction, int idPlugUser, PlugAddress plugAddress = null)
        {
            InitializeComponent();
            ManagePlugAddressCrud = managePlugAddressCrud;
            txtIdPlugAddress.Enabled = false;
            CommandAction = commandAction;
            IdPlugUser = idPlugUser;
               
            
            if (commandAction == ECommandAction.UPDATE)          
            {                
                if (plugAddress != null) 
                { 
                    txtIdPlugAddress.Text = plugAddress.Id.ToString();
                    txtPathPlugAddress.Text = plugAddress.Path;                  
                    cbbFileTypePlugAddress.SelectedIndex = (Convert.ToInt32(plugAddress.FileType) - 1);                                                        
                }
            }            
        }

        private void btnRecordPlugAddress_Click(object sender, EventArgs e)
        {
            if (ErrorHandler.ShowErrorMsg("Erro ao Gravar Endereço!", ValidateAllInputs())) { return; }

            if (CommandAction == ECommandAction.INSERT)
            {
                ManagePlugAddressCrud.Create(
                   IdPlugUser,
                   Convert.ToInt32(cbbFileTypePlugAddress.SelectedItem.ToString().Split('-')[0]),
                   txtPathPlugAddress.Text                   
               );
            }               
            else
            {
                ManagePlugAddressCrud.Update(
                   Convert.ToInt32(txtIdPlugAddress.Text),
                   IdPlugUser,
                   Convert.ToInt32(cbbFileTypePlugAddress.SelectedItem.ToString().Split('-')[0]),
                   txtPathPlugAddress.Text
               );
            }
               
            this.Close();
        }

        private void btnCancelPlugAddress_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<string> ValidateAllInputs()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(txtPathPlugAddress.Text)) { errors.Add("O Endereço deve ser preenchido corretamente!"); }            
            if (string.IsNullOrEmpty(txtPathPlugAddress.Text)) { errors.Add("O Endereço deve ser preenchido corretamente!"); }            
            if (cbbFileTypePlugAddress.SelectedItem == null) { errors.Add("O Tipo dos XMls deve ser preenchido!"); }            
      
            return errors;
        }        
    }
}
