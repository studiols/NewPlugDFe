using PlugDFe.ApplicationLayer.UseCases.PlugTaskCases;
using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Enums;
using PlugDFe.Forms.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlugDFe.Forms.Modal
{
    public partial class FrmModalPlugTask : Form
    {
        public ManagePlugTaskCrud ManagePlugTaskCrud { get; private set; }
        public int IdPlugAddress { get; set; }
        public ECommandAction CommandAction { get; set; }

        public FrmModalPlugTask(ManagePlugTaskCrud managePlugTaskCrud, ECommandAction commandAction, int idPlugAddress, List<ConnectViewer> connectViewers, PlugTask plugTask = null)
        {
            InitializeComponent();
            txtIdPlugTask.Enabled = false;
            ManagePlugTaskCrud = managePlugTaskCrud;
            IdPlugAddress = idPlugAddress;
            CommandAction = commandAction;

            int indexIdSelectedConnectViewer = 0;

            cbbIdConnectViewerPlugTask.Items.Add("0-Não Possui Conexão");

            if (connectViewers != null)
            {
                for (int index = 0; index < connectViewers.Count; index++)
                {
                    cbbIdConnectViewerPlugTask.Items.Add($"{connectViewers[index].Id}-{connectViewers[index].Name}");

                    if (plugTask != null)
                    {
                        if (connectViewers[index].Id == plugTask.IdConnectViewer)
                        {
                            indexIdSelectedConnectViewer = index + 1;
                        }
                    }
                }
            }            

            if (plugTask != null)
            {                
                if (CommandAction == ECommandAction.UPDATE)
                {
                    txtIdPlugTask.Text = plugTask.Id.ToString();
                    cbbIdConnectViewerPlugTask.SelectedIndex = indexIdSelectedConnectViewer;
                    cbbActionPlugTask.SelectedIndex = (Convert.ToInt32(plugTask.Action) - 1);
                    cbbReadModePlugTask.SelectedIndex = (Convert.ToInt32(plugTask.ReadMode) - 1);
                    txtLastDateExecutePlugTask.Text = plugTask.LastExecuteDate.ToString();
                }               
            }            
        }

        private void btnRecordPlugTask_Click(object sender, EventArgs e)
        {
            if (ErrorHandler.ShowErrorMsg("Erro ao Gravar Tarefa!", ValidateAllInputs())) { return; }

            if (CommandAction == ECommandAction.INSERT)
            {
                ManagePlugTaskCrud.Create(
                  IdPlugAddress,
                  Convert.ToInt32(cbbIdConnectViewerPlugTask.SelectedItem.ToString().Split('-')[0]),
                  Convert.ToInt32(cbbActionPlugTask.SelectedItem.ToString().Split('-')[0]),
                  Convert.ToInt32(cbbReadModePlugTask.SelectedItem.ToString().Split('-')[0]),
                  Convert.ToDateTime(txtLastDateExecutePlugTask.Text)
               );
            }
            else
            {
                ManagePlugTaskCrud.Update(
                    Convert.ToInt32(txtIdPlugTask.Text),
                    IdPlugAddress,
                    Convert.ToInt32(cbbIdConnectViewerPlugTask.SelectedItem.ToString().Split('-')[0]),
                    Convert.ToInt32(cbbActionPlugTask.SelectedItem.ToString().Split('-')[0]),
                    Convert.ToInt32(cbbReadModePlugTask.SelectedItem.ToString().Split('-')[0]),
                    Convert.ToDateTime(txtLastDateExecutePlugTask.Text)
               );
            }

            this.Close();
        }

        private List<string> ValidateAllInputs()
        {
            List<string> errors = new List<string>();

            if (!txtLastDateExecutePlugTask.MaskCompleted) { errors.Add("A Data da Ultima Execução deve ser preenchida corretamente!"); }
            if (cbbActionPlugTask.SelectedItem == null) { errors.Add("A Ação executada deve ser preenchida!"); }
            if (cbbReadModePlugTask.SelectedItem == null) { errors.Add("O Modo de leitura deve ser preenchido!"); }
            if (cbbIdConnectViewerPlugTask.SelectedItem == null) { errors.Add("A conexão deve ser preenchido!"); }            

            return errors;
        }

        private void btnCancelPlugTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
