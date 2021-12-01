using PlugDFe.ApplicationLayer.UseCases.PlugTaskCases;
using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Enums;
using PlugDFe.Forms.Services;
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
                    txtUnitCodePlugTask.Text = plugTask.UnitCode;
                    txtLastDateExecutePlugTask.Text = plugTask.LastExecuteDate.ToString();
                    txtStartDatePlugTask.Text = plugTask.StartDate.ToString();
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
                  InputValidator.SplitOption(cbbIdConnectViewerPlugTask.SelectedItem.ToString().Split('-')[0]),
                  InputValidator.SplitOption(cbbActionPlugTask.SelectedItem.ToString().Split('-')[0]),
                  InputValidator.SplitOption(cbbReadModePlugTask.SelectedItem.ToString().Split('-')[0]),
                  txtUnitCodePlugTask.Text,
                  Convert.ToDateTime(txtLastDateExecutePlugTask.Text),
                  Convert.ToDateTime(txtStartDatePlugTask.Text)
               );
            }
            else
            {
                ManagePlugTaskCrud.Update(
                    Convert.ToInt32(txtIdPlugTask.Text),
                    IdPlugAddress,
                    InputValidator.SplitOption(cbbIdConnectViewerPlugTask.SelectedItem.ToString()),
                    InputValidator.SplitOption(cbbActionPlugTask.SelectedItem.ToString().Split('-')[0]),
                    InputValidator.SplitOption(cbbReadModePlugTask.SelectedItem.ToString().Split('-')[0]),
                    txtUnitCodePlugTask.Text,
                    Convert.ToDateTime(txtLastDateExecutePlugTask.Text),
                    Convert.ToDateTime(txtStartDatePlugTask.Text)
               );
            }

            this.Close();
        }

        private List<string> ValidateAllInputs()
        {
            List<string> errors = new List<string>();

            if (cbbIdConnectViewerPlugTask.SelectedItem == null) { errors.Add("A conexão deve ser preenchido!"); }            
            if (cbbActionPlugTask.SelectedItem == null) { errors.Add("A Ação executada deve ser preenchida!"); }
            if (cbbReadModePlugTask.SelectedItem == null) { errors.Add("O Modo de leitura deve ser preenchido!"); }
            if (string.IsNullOrEmpty(txtUnitCodePlugTask.Text)) { errors.Add("O Código da Unidade deve ser preenchido!"); }
            if (!txtLastDateExecutePlugTask.MaskCompleted) { errors.Add("A Data da Ultima Execução deve ser preenchida corretamente!"); }
            if (!txtStartDatePlugTask.MaskCompleted) { errors.Add("A Data de Início deve ser preenchida corretamente!"); }

            int connectionCode = InputValidator.SplitOption(cbbIdConnectViewerPlugTask.SelectedItem.ToString());
            int actionCode = InputValidator.SplitOption(cbbActionPlugTask.SelectedItem.ToString());            

            if (connectionCode == 0)
            {
                if (actionCode == 2 || actionCode == 3) { errors.Add("Toda e qualquer ação de exclusão não pode ser utilizada sem uma conexão com o Connect Viewer!"); }
            }
            else
            {
                if (actionCode == 1 || actionCode == 4 || actionCode == 5) { errors.Add("Toda e qualquer ação que mantenha os XMLs não pode ser utilizada com uma conexão do Connect Viewer, apenas com pastas!"); }
            }
            
            return errors;
        }
       
        private void btnCancelPlugTask_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
