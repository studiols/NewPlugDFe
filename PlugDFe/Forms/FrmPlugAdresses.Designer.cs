namespace PlugDFe.Forms
{
    partial class FrmPlugAdresses
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
            this.grdPlugAdresses = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewPlugAddress = new System.Windows.Forms.Button();
            this.btnUpdatePlugAddress = new System.Windows.Forms.Button();
            this.btnDeletePlugAddress = new System.Windows.Forms.Button();
            this.btnPlugTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlugAdresses)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPlugAdresses
            // 
            this.grdPlugAdresses.AllowUserToAddRows = false;
            this.grdPlugAdresses.AllowUserToDeleteRows = false;
            this.grdPlugAdresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPlugAdresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FileType,
            this.Path});
            this.grdPlugAdresses.Location = new System.Drawing.Point(12, 6);
            this.grdPlugAdresses.Name = "grdPlugAdresses";
            this.grdPlugAdresses.RowHeadersVisible = false;
            this.grdPlugAdresses.Size = new System.Drawing.Size(578, 335);
            this.grdPlugAdresses.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // FileType
            // 
            this.FileType.DataPropertyName = "FileType";
            this.FileType.HeaderText = "Tipo";
            this.FileType.Name = "FileType";
            this.FileType.ReadOnly = true;
            this.FileType.Width = 198;
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "Caminho";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 337;
            // 
            // btnNewPlugAddress
            // 
            this.btnNewPlugAddress.Location = new System.Drawing.Point(600, 6);
            this.btnNewPlugAddress.Name = "btnNewPlugAddress";
            this.btnNewPlugAddress.Size = new System.Drawing.Size(64, 20);
            this.btnNewPlugAddress.TabIndex = 1;
            this.btnNewPlugAddress.Text = "Novo";
            this.btnNewPlugAddress.UseVisualStyleBackColor = true;
            this.btnNewPlugAddress.Click += new System.EventHandler(this.btnNewPlugAddress_Click);
            // 
            // btnUpdatePlugAddress
            // 
            this.btnUpdatePlugAddress.Location = new System.Drawing.Point(600, 32);
            this.btnUpdatePlugAddress.Name = "btnUpdatePlugAddress";
            this.btnUpdatePlugAddress.Size = new System.Drawing.Size(64, 20);
            this.btnUpdatePlugAddress.TabIndex = 2;
            this.btnUpdatePlugAddress.Text = "Alterar";
            this.btnUpdatePlugAddress.UseVisualStyleBackColor = true;
            this.btnUpdatePlugAddress.Click += new System.EventHandler(this.btnUpdatePlugAddress_Click);
            // 
            // btnDeletePlugAddress
            // 
            this.btnDeletePlugAddress.Location = new System.Drawing.Point(600, 84);
            this.btnDeletePlugAddress.Name = "btnDeletePlugAddress";
            this.btnDeletePlugAddress.Size = new System.Drawing.Size(64, 20);
            this.btnDeletePlugAddress.TabIndex = 3;
            this.btnDeletePlugAddress.Text = "Excluir";
            this.btnDeletePlugAddress.UseVisualStyleBackColor = true;
            this.btnDeletePlugAddress.Click += new System.EventHandler(this.btnDeletePlugAddress_Click);
            // 
            // btnPlugTask
            // 
            this.btnPlugTask.Location = new System.Drawing.Point(600, 58);
            this.btnPlugTask.Name = "btnPlugTask";
            this.btnPlugTask.Size = new System.Drawing.Size(64, 20);
            this.btnPlugTask.TabIndex = 4;
            this.btnPlugTask.Text = "Tarefa";
            this.btnPlugTask.UseVisualStyleBackColor = true;
            this.btnPlugTask.Click += new System.EventHandler(this.btnPlugTask_Click);
            // 
            // FrmPlugAdresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 352);
            this.Controls.Add(this.btnPlugTask);
            this.Controls.Add(this.btnDeletePlugAddress);
            this.Controls.Add(this.btnUpdatePlugAddress);
            this.Controls.Add(this.btnNewPlugAddress);
            this.Controls.Add(this.grdPlugAdresses);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPlugAdresses";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endereços";
            ((System.ComponentModel.ISupportInitialize)(this.grdPlugAdresses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPlugAdresses;
        private System.Windows.Forms.Button btnNewPlugAddress;
        private System.Windows.Forms.Button btnUpdatePlugAddress;
        private System.Windows.Forms.Button btnDeletePlugAddress;
        private System.Windows.Forms.Button btnPlugTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
    }
}