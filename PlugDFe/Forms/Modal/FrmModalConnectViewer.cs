using PlugDFe.ApplicationLayer.DTO.ConnectViewerIO;
using PlugDFe.ApplicationLayer.UseCases.ConnectViewerCases;
using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Enums;
using PlugDFe.Forms.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PlugDFe.Forms.Modal
{
    public partial class FrmModalConnectViewer : Form
    {
        public ManageConnectViewerCrud ManageConnectViewerCrud { get; private set; }
        public ECommandAction CommandAction { get; private set; }

        public FrmModalConnectViewer(ManageConnectViewerCrud manageConnectViewerCrud, ECommandAction commandAction, ConnectViewer connectViewer)
        {
            InitializeComponent();
            ManageConnectViewerCrud = manageConnectViewerCrud;
            CommandAction = commandAction;
            txtConnectViewerId.Enabled = false;

            this.Size = new System.Drawing.Size(this.Width, 435);
            fmDados.Location = new System.Drawing.Point(1, 1);           
            
            if (CommandAction == ECommandAction.UPDATE)
            {
                txtConnectViewerId.Text = connectViewer.Id.ToString();
                txtConnectViewerName.Text = connectViewer.Name;
                txtConnectViewerType.Text = connectViewer.Type;
                txtConnectViewerStr.Text = connectViewer.Str;
                txtConnectViewerCommand.Text = connectViewer.Command;
                chkConnectViewerBlobToBase64.Checked = connectViewer.BlobToBase64 == "S" ? true : false;
                chkConnectViewerBase64ToString.Checked = connectViewer.Base64ToString == "S" ? true : false;
                chkConnectViewerCompressedBase64ToString.Checked = connectViewer.CompressedBase64ToString == "S" ? true : false;
            }
        }

        private void btnRecordConnectViewer_Click(object sender, EventArgs e)
        {
            if (ErrorHandler.ShowErrorMsg("Erro ao Gravar Conexão!", ValidateAllInputs())) { return; }

            if (CommandAction == ECommandAction.INSERT)
            {
                ManageConnectViewerCrud.Create(
                   txtConnectViewerName.Text,
                   txtConnectViewerType.Text,
                   txtConnectViewerStr.Text,
                   txtConnectViewerCommand.Text,
                   chkConnectViewerBlobToBase64.Checked ? "S" : "N",
                   chkConnectViewerBase64ToString.Checked ? "S" : "N",
                   chkConnectViewerCompressedBase64ToString.Checked ? "S" : "N"
               );

                Close();
            }
            else
            {
                ManageConnectViewerCrud.Update(
                   Convert.ToInt32(txtConnectViewerId.Text),
                   txtConnectViewerName.Text,
                   txtConnectViewerType.Text,
                   txtConnectViewerStr.Text,
                   txtConnectViewerCommand.Text,
                    chkConnectViewerBlobToBase64.Checked ? "S" : "N",
                   chkConnectViewerBase64ToString.Checked ? "S" : "N",
                   chkConnectViewerCompressedBase64ToString.Checked ? "S" : "N"
               );
            }            
        }

        private List<string> ValidateAllInputs()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(txtConnectViewerName.Text)) { errors.Add("O Nome deve ser preenchido corretamente!"); }
            if (string.IsNullOrEmpty(txtConnectViewerType.Text)) { errors.Add("O Tipo da conexão deve ser preenchido corretamente!"); }
            if (string.IsNullOrEmpty(txtConnectViewerStr.Text)) { errors.Add("O Tipo deve ser preenchido corretamente!"); }
            if (string.IsNullOrEmpty(txtConnectViewerCommand.Text)) { errors.Add("A Ação que será realizada nos XMLs deve ser preenchida corretamente!"); }            

            return errors;
        }        
       
        private void cmdSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTestConnectViewer_Click(object sender, EventArgs e)
        {
            ExecuteTest();
        }

        private void ExecuteTest()
        {
            DataTable dt = new DataTable();

            ExecuteQuery query = new ExecuteQuery();

            ExecuteQueryInput input = new ExecuteQueryInput(
                txtConnectViewerType.Text,
                txtConnectViewerStr.Text,
                txtConnectViewerCommand.Text,
                "01"
            );

            ExecuteQueryOutput output = query.Execute(input);

            if (!output.Success) { return; }
            
            MessageBox.Show("Teste executado com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (!chkDebug.Checked) { return;  }

            FillGrdDataQueryConnectViewer(output.Dt);
            ShowFrmDataQuery();
        }

        private void FillGrdDataQueryConnectViewer(DataTable dt)
        {
            grdDataQueryConnectViewer.DataSource = dt;
            grdDataQueryConnectViewer.Refresh();

            lblRegCount.Text = "Número de registros: " + dt.Rows.Count;
        }

        private void ShowFrmDataQuery()
        {
            fmDados.Visible = true;
            grdDataQueryConnectViewer.Focus();
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            fmDados.Visible = false;
        }

        private void FrmConnectViewer_Load(object sender, EventArgs e)
        {

        }

        private void txtComandoSQL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                string msg = "[CURRENT_DATE]\t\t Data Corrente (Formato 2021-01-01)\n" +
                             "[CURRENT_DATE_STRING]\t Data Corrente (Formato 20210101)\n" +
                             "[DATA_ATUAL]\t Data Atual (Formato 01/01/2022)\n" +
                             "[DATA_ANTERIOR]\t Data Anterior (Formato 01/01/2022)\n" +
                             "[UNIDADE]\t\t Unidade passada no argumento\n" +
                             "[KEYS]\t\t\t Chaves encontradas\n" +
                             "[INITIAL_DATE]\t\t Data Inicial\n" +
                             "[FINAL_DATE]\t\t Data Final\n" +
                             "[DIVISION]\t\t Separador de Query/Command\n";

                MessageBox.Show(msg, "Variáveis disponíveis");
            }
        }

        private void txtComandoSQLExportBody_TextChanged(object sender, EventArgs e)
        {

        }        
    }
}
 