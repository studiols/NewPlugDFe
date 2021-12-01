using System.Windows.Forms;

namespace PlugDFe.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grdMain = new System.Windows.Forms.DataGridView();
            this.ColKeyTransferredDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIssueDateTransferredDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.btnExecuteApplication = new System.Windows.Forms.Button();
            this.btnShowFrmParameters = new System.Windows.Forms.Button();
            this.notifyIconApplication = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.contextMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdMain
            // 
            this.grdMain.AllowUserToAddRows = false;
            this.grdMain.AllowUserToDeleteRows = false;
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColKeyTransferredDocument,
            this.ColIssueDateTransferredDocument});
            this.grdMain.Location = new System.Drawing.Point(12, 6);
            this.grdMain.Name = "grdMain";
            this.grdMain.RowHeadersVisible = false;
            this.grdMain.RowTemplate.Height = 25;
            this.grdMain.Size = new System.Drawing.Size(582, 334);
            this.grdMain.TabIndex = 0;
            // 
            // ColKeyTransferredDocument
            // 
            this.ColKeyTransferredDocument.DataPropertyName = "Key";
            this.ColKeyTransferredDocument.HeaderText = "Chave";
            this.ColKeyTransferredDocument.Name = "ColKeyTransferredDocument";
            this.ColKeyTransferredDocument.ReadOnly = true;
            this.ColKeyTransferredDocument.Width = 380;
            // 
            // ColIssueDateTransferredDocument
            // 
            this.ColIssueDateTransferredDocument.DataPropertyName = "IssueDate";
            this.ColIssueDateTransferredDocument.HeaderText = "Data";
            this.ColIssueDateTransferredDocument.Name = "ColIssueDateTransferredDocument";
            this.ColIssueDateTransferredDocument.ReadOnly = true;
            this.ColIssueDateTransferredDocument.Width = 180;
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Location = new System.Drawing.Point(600, 60);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(73, 21);
            this.btnExitApplication.TabIndex = 1;
            this.btnExitApplication.Text = "Sair";
            this.btnExitApplication.UseVisualStyleBackColor = true;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // btnExecuteApplication
            // 
            this.btnExecuteApplication.Location = new System.Drawing.Point(600, 6);
            this.btnExecuteApplication.Name = "btnExecuteApplication";
            this.btnExecuteApplication.Size = new System.Drawing.Size(73, 21);
            this.btnExecuteApplication.TabIndex = 2;
            this.btnExecuteApplication.Text = "Executar";
            this.btnExecuteApplication.UseVisualStyleBackColor = true;
            this.btnExecuteApplication.Click += new System.EventHandler(this.btnExecuteApplication_Click);
            // 
            // btnShowFrmParameters
            // 
            this.btnShowFrmParameters.Location = new System.Drawing.Point(600, 33);
            this.btnShowFrmParameters.Name = "btnShowFrmParameters";
            this.btnShowFrmParameters.Size = new System.Drawing.Size(73, 21);
            this.btnShowFrmParameters.TabIndex = 3;
            this.btnShowFrmParameters.Text = "Parâmetros";
            this.btnShowFrmParameters.UseVisualStyleBackColor = true;
            this.btnShowFrmParameters.Click += new System.EventHandler(this.btnShowFrmParameters_Click);
            // 
            // notifyIconApplication
            // 
            this.notifyIconApplication.BalloonTipText = "O PlugDFe foi iniciado!";
            this.notifyIconApplication.BalloonTipTitle = "PlugDFe";
            this.notifyIconApplication.ContextMenuStrip = this.contextMenuStripMain;
            this.notifyIconApplication.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconApplication.Icon")));
            this.notifyIconApplication.Text = "PlugDFe FourLions";
            this.notifyIconApplication.Visible = true;
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(101, 26);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // timerMain
            // 
            this.timerMain.Interval = 2000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 352);
            this.Controls.Add(this.btnShowFrmParameters);
            this.Controls.Add(this.btnExecuteApplication);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.grdMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.contextMenuStripMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdMain;
        private Button btnExitApplication;
        private Button btnExecuteApplication;
        private Button btnShowFrmParameters;
        private NotifyIcon notifyIconApplication;
        private ContextMenuStrip contextMenuStripMain;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private Timer timerMain;
        private DataGridViewTextBoxColumn ColKeyTransferredDocument;
        private DataGridViewTextBoxColumn ColIssueDateTransferredDocument;
    }
}