namespace PlugDFe.Forms.Modal
{
    partial class FrmModalConnectViewer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnectViewerType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRecordConnectViewer = new System.Windows.Forms.Button();
            this.btnCancelConnectViewer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.fmDados = new System.Windows.Forms.GroupBox();
            this.lblRegCount = new System.Windows.Forms.Label();
            this.cmdFechar = new System.Windows.Forms.Button();
            this.grdDataQueryConnectViewer = new System.Windows.Forms.DataGridView();
            this.colChave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabImport = new System.Windows.Forms.TabPage();
            this.btnTestConnectViewer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConnectViewerCommand = new System.Windows.Forms.TextBox();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.chkConnectViewerBase64ToString = new System.Windows.Forms.CheckBox();
            this.chkConnectViewerBlobToBase64 = new System.Windows.Forms.CheckBox();
            this.chkConnectViewerCompressedBase64ToString = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConnectViewerId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConnectViewerStr = new System.Windows.Forms.TextBox();
            this.txtConnectViewerName = new System.Windows.Forms.TextBox();
            this.fmDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataQueryConnectViewer)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabImport.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo Conexão";
            // 
            // txtConnectViewerType
            // 
            this.txtConnectViewerType.FormattingEnabled = true;
            this.txtConnectViewerType.Items.AddRange(new object[] {
            "POSTGRESQL",
            "MYSQL",
            "ORACLE",
            "SQLSERVER",
            "FIREBIRD"});
            this.txtConnectViewerType.Location = new System.Drawing.Point(94, 33);
            this.txtConnectViewerType.Name = "txtConnectViewerType";
            this.txtConnectViewerType.Size = new System.Drawing.Size(237, 21);
            this.txtConnectViewerType.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "String Conexão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Comando SQL";
            // 
            // btnRecordConnectViewer
            // 
            this.btnRecordConnectViewer.Location = new System.Drawing.Point(94, 367);
            this.btnRecordConnectViewer.Name = "btnRecordConnectViewer";
            this.btnRecordConnectViewer.Size = new System.Drawing.Size(75, 23);
            this.btnRecordConnectViewer.TabIndex = 14;
            this.btnRecordConnectViewer.Text = "&Gravar";
            this.btnRecordConnectViewer.UseVisualStyleBackColor = true;
            this.btnRecordConnectViewer.Click += new System.EventHandler(this.btnRecordConnectViewer_Click);
            // 
            // btnCancelConnectViewer
            // 
            this.btnCancelConnectViewer.Location = new System.Drawing.Point(175, 367);
            this.btnCancelConnectViewer.Name = "btnCancelConnectViewer";
            this.btnCancelConnectViewer.Size = new System.Drawing.Size(75, 23);
            this.btnCancelConnectViewer.TabIndex = 13;
            this.btnCancelConnectViewer.Text = "&Sair";
            this.btnCancelConnectViewer.UseVisualStyleBackColor = true;
            this.btnCancelConnectViewer.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(517, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data Source=<string conexão>; User Id=<usuário>; Password=<senha>; Database=<nome" +
    " base de dados>;";
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(379, 373);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(326, 17);
            this.chkDebug.TabIndex = 12;
            this.chkDebug.Text = "Debug (Ativando ao fazer o teste abrirá uma tela com os dados)";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // fmDados
            // 
            this.fmDados.Controls.Add(this.lblRegCount);
            this.fmDados.Controls.Add(this.cmdFechar);
            this.fmDados.Controls.Add(this.grdDataQueryConnectViewer);
            this.fmDados.Location = new System.Drawing.Point(0, 397);
            this.fmDados.Name = "fmDados";
            this.fmDados.Size = new System.Drawing.Size(895, 417);
            this.fmDados.TabIndex = 0;
            this.fmDados.TabStop = false;
            this.fmDados.Visible = false;
            // 
            // lblRegCount
            // 
            this.lblRegCount.AutoSize = true;
            this.lblRegCount.Location = new System.Drawing.Point(6, 368);
            this.lblRegCount.Name = "lblRegCount";
            this.lblRegCount.Size = new System.Drawing.Size(65, 13);
            this.lblRegCount.TabIndex = 1;
            this.lblRegCount.Text = "lblRegCount";
            this.lblRegCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdFechar
            // 
            this.cmdFechar.Location = new System.Drawing.Point(813, 363);
            this.cmdFechar.Name = "cmdFechar";
            this.cmdFechar.Size = new System.Drawing.Size(75, 23);
            this.cmdFechar.TabIndex = 2;
            this.cmdFechar.Text = "&Fechar";
            this.cmdFechar.UseVisualStyleBackColor = true;
            this.cmdFechar.Click += new System.EventHandler(this.cmdFechar_Click);
            // 
            // grdDataQueryConnectViewer
            // 
            this.grdDataQueryConnectViewer.AllowUserToAddRows = false;
            this.grdDataQueryConnectViewer.AllowUserToDeleteRows = false;
            this.grdDataQueryConnectViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataQueryConnectViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChave,
            this.colXML});
            this.grdDataQueryConnectViewer.Location = new System.Drawing.Point(6, 19);
            this.grdDataQueryConnectViewer.Name = "grdDataQueryConnectViewer";
            this.grdDataQueryConnectViewer.ReadOnly = true;
            this.grdDataQueryConnectViewer.Size = new System.Drawing.Size(883, 293);
            this.grdDataQueryConnectViewer.TabIndex = 0;
            // 
            // colChave
            // 
            this.colChave.DataPropertyName = "chave";
            this.colChave.HeaderText = "Chave";
            this.colChave.Name = "colChave";
            this.colChave.ReadOnly = true;
            // 
            // colXML
            // 
            this.colXML.DataPropertyName = "xml";
            this.colXML.HeaderText = "XML";
            this.colXML.Name = "colXML";
            this.colXML.ReadOnly = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabImport);
            this.tabControl.Controls.Add(this.tabConfig);
            this.tabControl.Location = new System.Drawing.Point(96, 97);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(785, 264);
            this.tabControl.TabIndex = 11;
            // 
            // tabImport
            // 
            this.tabImport.BackColor = System.Drawing.SystemColors.Control;
            this.tabImport.Controls.Add(this.btnTestConnectViewer);
            this.tabImport.Controls.Add(this.label7);
            this.tabImport.Controls.Add(this.label4);
            this.tabImport.Controls.Add(this.txtConnectViewerCommand);
            this.tabImport.Location = new System.Drawing.Point(4, 22);
            this.tabImport.Name = "tabImport";
            this.tabImport.Padding = new System.Windows.Forms.Padding(3);
            this.tabImport.Size = new System.Drawing.Size(777, 238);
            this.tabImport.TabIndex = 0;
            this.tabImport.Text = "Import";
            // 
            // btnTestConnectViewer
            // 
            this.btnTestConnectViewer.Location = new System.Drawing.Point(696, 211);
            this.btnTestConnectViewer.Name = "btnTestConnectViewer";
            this.btnTestConnectViewer.Size = new System.Drawing.Size(75, 23);
            this.btnTestConnectViewer.TabIndex = 3;
            this.btnTestConnectViewer.Text = "&Testar";
            this.btnTestConnectViewer.UseVisualStyleBackColor = true;
            this.btnTestConnectViewer.Click += new System.EventHandler(this.btnTestConnectViewer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "F12 = Variáveis";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(460, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "O comando SQL deve conter os campos \'CHAVE\' e \'XML\' (nenhum outro campo é conside" +
    "rado)";
            // 
            // txtConnectViewerCommand
            // 
            this.txtConnectViewerCommand.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtConnectViewerCommand.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnectViewerCommand.Location = new System.Drawing.Point(6, 6);
            this.txtConnectViewerCommand.Multiline = true;
            this.txtConnectViewerCommand.Name = "txtConnectViewerCommand";
            this.txtConnectViewerCommand.Size = new System.Drawing.Size(765, 199);
            this.txtConnectViewerCommand.TabIndex = 0;
            this.txtConnectViewerCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComandoSQL_KeyDown);
            // 
            // tabConfig
            // 
            this.tabConfig.BackColor = System.Drawing.SystemColors.Control;
            this.tabConfig.Controls.Add(this.chkConnectViewerBase64ToString);
            this.tabConfig.Controls.Add(this.chkConnectViewerBlobToBase64);
            this.tabConfig.Controls.Add(this.chkConnectViewerCompressedBase64ToString);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(777, 238);
            this.tabConfig.TabIndex = 1;
            this.tabConfig.Text = "Config";
            // 
            // chkConnectViewerBase64ToString
            // 
            this.chkConnectViewerBase64ToString.AutoSize = true;
            this.chkConnectViewerBase64ToString.Location = new System.Drawing.Point(15, 29);
            this.chkConnectViewerBase64ToString.Name = "chkConnectViewerBase64ToString";
            this.chkConnectViewerBase64ToString.Size = new System.Drawing.Size(184, 17);
            this.chkConnectViewerBase64ToString.TabIndex = 2;
            this.chkConnectViewerBase64ToString.Text = "Converte Base64 em XML (string)";
            this.chkConnectViewerBase64ToString.UseVisualStyleBackColor = true;
            // 
            // chkConnectViewerBlobToBase64
            // 
            this.chkConnectViewerBlobToBase64.AutoSize = true;
            this.chkConnectViewerBlobToBase64.Location = new System.Drawing.Point(15, 6);
            this.chkConnectViewerBlobToBase64.Name = "chkConnectViewerBlobToBase64";
            this.chkConnectViewerBlobToBase64.Size = new System.Drawing.Size(319, 17);
            this.chkConnectViewerBlobToBase64.TabIndex = 1;
            this.chkConnectViewerBlobToBase64.Text = "Converter Blob para base64 (Campo do banco de dados Blob)";
            this.chkConnectViewerBlobToBase64.UseVisualStyleBackColor = true;
            // 
            // chkConnectViewerCompressedBase64ToString
            // 
            this.chkConnectViewerCompressedBase64ToString.AutoSize = true;
            this.chkConnectViewerCompressedBase64ToString.Location = new System.Drawing.Point(15, 52);
            this.chkConnectViewerCompressedBase64ToString.Name = "chkConnectViewerCompressedBase64ToString";
            this.chkConnectViewerCompressedBase64ToString.Size = new System.Drawing.Size(225, 17);
            this.chkConnectViewerCompressedBase64ToString.TabIndex = 0;
            this.chkConnectViewerCompressedBase64ToString.Text = "Converte Base64 zipado para XML (string)";
            this.chkConnectViewerCompressedBase64ToString.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id";
            // 
            // txtConnectViewerId
            // 
            this.txtConnectViewerId.Location = new System.Drawing.Point(94, 5);
            this.txtConnectViewerId.Name = "txtConnectViewerId";
            this.txtConnectViewerId.Size = new System.Drawing.Size(39, 20);
            this.txtConnectViewerId.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nome";
            // 
            // txtConnectViewerStr
            // 
            this.txtConnectViewerStr.Location = new System.Drawing.Point(94, 61);
            this.txtConnectViewerStr.Name = "txtConnectViewerStr";
            this.txtConnectViewerStr.Size = new System.Drawing.Size(797, 20);
            this.txtConnectViewerStr.TabIndex = 7;
            // 
            // txtConnectViewerName
            // 
            this.txtConnectViewerName.Location = new System.Drawing.Point(189, 5);
            this.txtConnectViewerName.Name = "txtConnectViewerName";
            this.txtConnectViewerName.Size = new System.Drawing.Size(702, 20);
            this.txtConnectViewerName.TabIndex = 3;
            // 
            // FrmModalConnectViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 816);
            this.Controls.Add(this.fmDados);
            this.Controls.Add(this.chkDebug);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelConnectViewer);
            this.Controls.Add(this.btnRecordConnectViewer);
            this.Controls.Add(this.txtConnectViewerStr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConnectViewerType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.txtConnectViewerId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtConnectViewerName);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModalConnectViewer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Viewer";
            this.Load += new System.EventHandler(this.FrmConnectViewer_Load);
            this.fmDados.ResumeLayout(false);
            this.fmDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataQueryConnectViewer)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabImport.ResumeLayout(false);
            this.tabImport.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtConnectViewerType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRecordConnectViewer;
        private System.Windows.Forms.Button btnCancelConnectViewer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.GroupBox fmDados;
        private System.Windows.Forms.Button cmdFechar;
        private System.Windows.Forms.DataGridView grdDataQueryConnectViewer;
        private System.Windows.Forms.Label lblRegCount;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabImport;
        private System.Windows.Forms.Button btnTestConnectViewer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConnectViewerCommand;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.CheckBox chkConnectViewerCompressedBase64ToString;
        private System.Windows.Forms.CheckBox chkConnectViewerBlobToBase64;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXML;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConnectViewerId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConnectViewerStr;
        private System.Windows.Forms.TextBox txtConnectViewerName;
        private System.Windows.Forms.CheckBox chkConnectViewerBase64ToString;
    }
}