using System.Windows.Forms;

namespace PlugDFe.Forms
{
    partial class FrmParameters
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
            this.tabControlParameters = new System.Windows.Forms.TabControl();
            this.tabConfigs = new System.Windows.Forms.TabPage();
            this.btnRecordConfigs = new System.Windows.Forms.Button();
            this.numericUpDownExecInterval = new System.Windows.Forms.NumericUpDown();
            this.labelExecInterval = new System.Windows.Forms.Label();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.btnDeletePlugUser = new System.Windows.Forms.Button();
            this.btnGetPlugAdresses = new System.Windows.Forms.Button();
            this.btnUpdatePlugUser = new System.Windows.Forms.Button();
            this.grdPlugUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewPlugUser = new System.Windows.Forms.Button();
            this.tabConnections = new System.Windows.Forms.TabPage();
            this.btnDeleteConnection = new System.Windows.Forms.Button();
            this.btnUpdateConnection = new System.Windows.Forms.Button();
            this.btnNewConnection = new System.Windows.Forms.Button();
            this.grdConnectViewers = new System.Windows.Forms.DataGridView();
            this.ConnecViewerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectViewerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectViewerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectViewerBlobToBase64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectViewerBase64ToString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectViewerCompressedBase64ToString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlParameters.SuspendLayout();
            this.tabConfigs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExecInterval)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlugUsers)).BeginInit();
            this.tabConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConnectViewers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlParameters
            // 
            this.tabControlParameters.Controls.Add(this.tabConfigs);
            this.tabControlParameters.Controls.Add(this.tabUsers);
            this.tabControlParameters.Controls.Add(this.tabConnections);
            this.tabControlParameters.Location = new System.Drawing.Point(0, 1);
            this.tabControlParameters.Name = "tabControlParameters";
            this.tabControlParameters.SelectedIndex = 0;
            this.tabControlParameters.Size = new System.Drawing.Size(680, 351);
            this.tabControlParameters.TabIndex = 0;
            // 
            // tabConfigs
            // 
            this.tabConfigs.Controls.Add(this.btnRecordConfigs);
            this.tabConfigs.Controls.Add(this.numericUpDownExecInterval);
            this.tabConfigs.Controls.Add(this.labelExecInterval);
            this.tabConfigs.Location = new System.Drawing.Point(4, 22);
            this.tabConfigs.Name = "tabConfigs";
            this.tabConfigs.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfigs.Size = new System.Drawing.Size(672, 325);
            this.tabConfigs.TabIndex = 0;
            this.tabConfigs.Text = "Configurações";
            this.tabConfigs.UseVisualStyleBackColor = true;
            // 
            // btnRecordConfigs
            // 
            this.btnRecordConfigs.Location = new System.Drawing.Point(592, 6);
            this.btnRecordConfigs.Name = "btnRecordConfigs";
            this.btnRecordConfigs.Size = new System.Drawing.Size(73, 21);
            this.btnRecordConfigs.TabIndex = 2;
            this.btnRecordConfigs.Text = "&Gravar";
            this.btnRecordConfigs.UseVisualStyleBackColor = true;
            this.btnRecordConfigs.Click += new System.EventHandler(this.btnRecordConfigs_Click);
            // 
            // numericUpDownExecInterval
            // 
            this.numericUpDownExecInterval.Location = new System.Drawing.Point(174, 5);
            this.numericUpDownExecInterval.Maximum = new decimal(new int[] {
            1420,
            0,
            0,
            0});
            this.numericUpDownExecInterval.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownExecInterval.Name = "numericUpDownExecInterval";
            this.numericUpDownExecInterval.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownExecInterval.TabIndex = 1;
            this.numericUpDownExecInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // labelExecInterval
            // 
            this.labelExecInterval.AutoSize = true;
            this.labelExecInterval.Location = new System.Drawing.Point(7, 11);
            this.labelExecInterval.Name = "labelExecInterval";
            this.labelExecInterval.Size = new System.Drawing.Size(169, 13);
            this.labelExecInterval.TabIndex = 0;
            this.labelExecInterval.Text = "Intervalo de execução em minutos";
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.btnDeletePlugUser);
            this.tabUsers.Controls.Add(this.btnGetPlugAdresses);
            this.tabUsers.Controls.Add(this.btnUpdatePlugUser);
            this.tabUsers.Controls.Add(this.grdPlugUsers);
            this.tabUsers.Controls.Add(this.btnNewPlugUser);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(672, 325);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "Usuários";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // btnDeletePlugUser
            // 
            this.btnDeletePlugUser.Location = new System.Drawing.Point(592, 84);
            this.btnDeletePlugUser.Name = "btnDeletePlugUser";
            this.btnDeletePlugUser.Size = new System.Drawing.Size(73, 21);
            this.btnDeletePlugUser.TabIndex = 4;
            this.btnDeletePlugUser.Text = "&Excluir";
            this.btnDeletePlugUser.UseVisualStyleBackColor = true;
            this.btnDeletePlugUser.Click += new System.EventHandler(this.btnDeletePlugUser_Click);
            // 
            // btnGetPlugAdresses
            // 
            this.btnGetPlugAdresses.Location = new System.Drawing.Point(592, 58);
            this.btnGetPlugAdresses.Name = "btnGetPlugAdresses";
            this.btnGetPlugAdresses.Size = new System.Drawing.Size(73, 21);
            this.btnGetPlugAdresses.TabIndex = 3;
            this.btnGetPlugAdresses.Text = "&Configurar";
            this.btnGetPlugAdresses.UseVisualStyleBackColor = true;
            this.btnGetPlugAdresses.Click += new System.EventHandler(this.btnGetPlugAdresses_Click);
            // 
            // btnUpdatePlugUser
            // 
            this.btnUpdatePlugUser.Location = new System.Drawing.Point(592, 32);
            this.btnUpdatePlugUser.Name = "btnUpdatePlugUser";
            this.btnUpdatePlugUser.Size = new System.Drawing.Size(73, 21);
            this.btnUpdatePlugUser.TabIndex = 2;
            this.btnUpdatePlugUser.Text = "&Alterar";
            this.btnUpdatePlugUser.UseVisualStyleBackColor = true;
            this.btnUpdatePlugUser.Click += new System.EventHandler(this.btnUpdatePlugUser_Click);
            // 
            // grdPlugUsers
            // 
            this.grdPlugUsers.AllowUserToAddRows = false;
            this.grdPlugUsers.AllowUserToDeleteRows = false;
            this.grdPlugUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPlugUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdCompany,
            this.Email});
            this.grdPlugUsers.Location = new System.Drawing.Point(8, 6);
            this.grdPlugUsers.MultiSelect = false;
            this.grdPlugUsers.Name = "grdPlugUsers";
            this.grdPlugUsers.ReadOnly = true;
            this.grdPlugUsers.RowHeadersVisible = false;
            this.grdPlugUsers.RowTemplate.Height = 25;
            this.grdPlugUsers.Size = new System.Drawing.Size(578, 312);
            this.grdPlugUsers.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id Usuário";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // IdCompany
            // 
            this.IdCompany.DataPropertyName = "IdCompany";
            this.IdCompany.HeaderText = "Id Empresa DF-e";
            this.IdCompany.Name = "IdCompany";
            this.IdCompany.ReadOnly = true;
            this.IdCompany.Width = 135;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 203;
            // 
            // btnNewPlugUser
            // 
            this.btnNewPlugUser.Location = new System.Drawing.Point(592, 6);
            this.btnNewPlugUser.Name = "btnNewPlugUser";
            this.btnNewPlugUser.Size = new System.Drawing.Size(73, 21);
            this.btnNewPlugUser.TabIndex = 1;
            this.btnNewPlugUser.Text = "&Novo";
            this.btnNewPlugUser.UseVisualStyleBackColor = true;
            this.btnNewPlugUser.Click += new System.EventHandler(this.btnNewPlugUser_Click);
            // 
            // tabConnections
            // 
            this.tabConnections.Controls.Add(this.btnDeleteConnection);
            this.tabConnections.Controls.Add(this.btnUpdateConnection);
            this.tabConnections.Controls.Add(this.btnNewConnection);
            this.tabConnections.Controls.Add(this.grdConnectViewers);
            this.tabConnections.Location = new System.Drawing.Point(4, 22);
            this.tabConnections.Name = "tabConnections";
            this.tabConnections.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnections.Size = new System.Drawing.Size(672, 325);
            this.tabConnections.TabIndex = 2;
            this.tabConnections.Text = "Conexões";
            this.tabConnections.UseVisualStyleBackColor = true;
            // 
            // btnDeleteConnection
            // 
            this.btnDeleteConnection.Location = new System.Drawing.Point(592, 58);
            this.btnDeleteConnection.Name = "btnDeleteConnection";
            this.btnDeleteConnection.Size = new System.Drawing.Size(73, 21);
            this.btnDeleteConnection.TabIndex = 3;
            this.btnDeleteConnection.Text = "&Excluir";
            this.btnDeleteConnection.UseVisualStyleBackColor = true;
            this.btnDeleteConnection.Click += new System.EventHandler(this.btnDeleteConnection_Click);
            // 
            // btnUpdateConnection
            // 
            this.btnUpdateConnection.Location = new System.Drawing.Point(592, 32);
            this.btnUpdateConnection.Name = "btnUpdateConnection";
            this.btnUpdateConnection.Size = new System.Drawing.Size(73, 21);
            this.btnUpdateConnection.TabIndex = 2;
            this.btnUpdateConnection.Text = "&Alterar";
            this.btnUpdateConnection.UseVisualStyleBackColor = true;
            this.btnUpdateConnection.Click += new System.EventHandler(this.btnUpdateConnection_Click);
            // 
            // btnNewConnection
            // 
            this.btnNewConnection.Location = new System.Drawing.Point(592, 6);
            this.btnNewConnection.Name = "btnNewConnection";
            this.btnNewConnection.Size = new System.Drawing.Size(73, 21);
            this.btnNewConnection.TabIndex = 1;
            this.btnNewConnection.Text = "&Novo";
            this.btnNewConnection.UseVisualStyleBackColor = true;
            this.btnNewConnection.Click += new System.EventHandler(this.btnNewConnection_Click);
            // 
            // grdConnectViewers
            // 
            this.grdConnectViewers.AllowUserToAddRows = false;
            this.grdConnectViewers.AllowUserToDeleteRows = false;
            this.grdConnectViewers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConnectViewers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConnecViewerId,
            this.ConnectViewerName,
            this.ConnectViewerType,
            this.ConnectViewerBlobToBase64,
            this.ConnectViewerBase64ToString,
            this.ConnectViewerCompressedBase64ToString});
            this.grdConnectViewers.Location = new System.Drawing.Point(7, 6);
            this.grdConnectViewers.Name = "grdConnectViewers";
            this.grdConnectViewers.RowHeadersVisible = false;
            this.grdConnectViewers.Size = new System.Drawing.Size(578, 312);
            this.grdConnectViewers.TabIndex = 0;
            // 
            // ConnecViewerId
            // 
            this.ConnecViewerId.DataPropertyName = "Id";
            this.ConnecViewerId.HeaderText = "Id";
            this.ConnecViewerId.Name = "ConnecViewerId";
            this.ConnecViewerId.ReadOnly = true;
            this.ConnecViewerId.Width = 50;
            // 
            // ConnectViewerName
            // 
            this.ConnectViewerName.DataPropertyName = "Name";
            this.ConnectViewerName.HeaderText = "Nome";
            this.ConnectViewerName.Name = "ConnectViewerName";
            this.ConnectViewerName.ReadOnly = true;
            // 
            // ConnectViewerType
            // 
            this.ConnectViewerType.DataPropertyName = "Type";
            this.ConnectViewerType.HeaderText = "Tipo";
            this.ConnectViewerType.Name = "ConnectViewerType";
            this.ConnectViewerType.ReadOnly = true;
            // 
            // ConnectViewerBlobToBase64
            // 
            this.ConnectViewerBlobToBase64.DataPropertyName = "BlobToBase64";
            this.ConnectViewerBlobToBase64.HeaderText = "BlobToBase64";
            this.ConnectViewerBlobToBase64.Name = "ConnectViewerBlobToBase64";
            this.ConnectViewerBlobToBase64.ReadOnly = true;
            this.ConnectViewerBlobToBase64.Width = 80;
            // 
            // ConnectViewerBase64ToString
            // 
            this.ConnectViewerBase64ToString.DataPropertyName = "Base64ToString";
            this.ConnectViewerBase64ToString.HeaderText = "Base64ToString";
            this.ConnectViewerBase64ToString.Name = "ConnectViewerBase64ToString";
            this.ConnectViewerBase64ToString.ReadOnly = true;
            this.ConnectViewerBase64ToString.Width = 90;
            // 
            // ConnectViewerCompressedBase64ToString
            // 
            this.ConnectViewerCompressedBase64ToString.DataPropertyName = "CompressedBase64ToString";
            this.ConnectViewerCompressedBase64ToString.HeaderText = "CompressedBase64ToString";
            this.ConnectViewerCompressedBase64ToString.Name = "ConnectViewerCompressedBase64ToString";
            this.ConnectViewerCompressedBase64ToString.ReadOnly = true;
            this.ConnectViewerCompressedBase64ToString.Width = 150;
            // 
            // FrmParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 352);
            this.Controls.Add(this.tabControlParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmParameters";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parâmetros";
            this.tabControlParameters.ResumeLayout(false);
            this.tabConfigs.ResumeLayout(false);
            this.tabConfigs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExecInterval)).EndInit();
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPlugUsers)).EndInit();
            this.tabConnections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdConnectViewers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
       
        private TabControl tabControlParameters;
        private TabPage tabConfigs;
        private TabPage tabUsers;
        private Button btnRecordConfigs;
        private NumericUpDown numericUpDownExecInterval;
        private Label labelExecInterval;
        private Button btnNewPlugUser;
        private TabPage tabConnections;
        private Button btnDeletePlugUser;
        private Button btnGetPlugAdresses;
        private Button btnUpdatePlugUser;
        private DataGridView grdPlugUsers;
        private Button btnDeleteConnection;
        private Button btnUpdateConnection;
        private Button btnNewConnection;
        private DataGridView grdConnectViewers;
        private DataGridViewTextBoxColumn ConnecViewerId;
        private DataGridViewTextBoxColumn ConnectViewerName;
        private DataGridViewTextBoxColumn ConnectViewerType;
        private DataGridViewTextBoxColumn ConnectViewerBlobToBase64;
        private DataGridViewTextBoxColumn ConnectViewerBase64ToString;
        private DataGridViewTextBoxColumn ConnectViewerCompressedBase64ToString;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdCompany;
        private DataGridViewTextBoxColumn Email;
    }
}