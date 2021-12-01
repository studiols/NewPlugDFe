namespace PlugDFe.Forms
{
    partial class FrmPlugTask
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
            this.grdPlugTasks = new System.Windows.Forms.DataGridView();
            this.ColIdPlugTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdConnectViewerPlugTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReadModePlugTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColActionPlugTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastExecuteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeletePlugTask = new System.Windows.Forms.Button();
            this.btnUpdatePlugTask = new System.Windows.Forms.Button();
            this.btnNewPlugTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlugTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPlugTasks
            // 
            this.grdPlugTasks.AllowUserToAddRows = false;
            this.grdPlugTasks.AllowUserToDeleteRows = false;
            this.grdPlugTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPlugTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdPlugTask,
            this.ColIdConnectViewerPlugTask,
            this.ColReadModePlugTask,
            this.ColActionPlugTask,
            this.ColLastExecuteDate});
            this.grdPlugTasks.Location = new System.Drawing.Point(6, 6);
            this.grdPlugTasks.Name = "grdPlugTasks";
            this.grdPlugTasks.RowHeadersVisible = false;
            this.grdPlugTasks.Size = new System.Drawing.Size(584, 319);
            this.grdPlugTasks.TabIndex = 0;
            // 
            // ColIdPlugTask
            // 
            this.ColIdPlugTask.DataPropertyName = "Id";
            this.ColIdPlugTask.HeaderText = "Id";
            this.ColIdPlugTask.Name = "ColIdPlugTask";
            // 
            // ColIdConnectViewerPlugTask
            // 
            this.ColIdConnectViewerPlugTask.DataPropertyName = "IdConnectViewer";
            this.ColIdConnectViewerPlugTask.HeaderText = "Conexão";
            this.ColIdConnectViewerPlugTask.Name = "ColIdConnectViewerPlugTask";
            // 
            // ColReadModePlugTask
            // 
            this.ColReadModePlugTask.DataPropertyName = "ReadMode";
            this.ColReadModePlugTask.HeaderText = "Leitura";
            this.ColReadModePlugTask.Name = "ColReadModePlugTask";
            this.ColReadModePlugTask.ReadOnly = true;
            // 
            // ColActionPlugTask
            // 
            this.ColActionPlugTask.DataPropertyName = "Action";
            this.ColActionPlugTask.HeaderText = "Ação";
            this.ColActionPlugTask.Name = "ColActionPlugTask";
            this.ColActionPlugTask.ReadOnly = true;
            // 
            // ColLastExecuteDate
            // 
            this.ColLastExecuteDate.DataPropertyName = "LastExecuteDate";
            this.ColLastExecuteDate.HeaderText = "Ultima Dt. Exec.";
            this.ColLastExecuteDate.Name = "ColLastExecuteDate";
            this.ColLastExecuteDate.ReadOnly = true;
            this.ColLastExecuteDate.Width = 170;
            // 
            // btnDeletePlugTask
            // 
            this.btnDeletePlugTask.Location = new System.Drawing.Point(600, 58);
            this.btnDeletePlugTask.Name = "btnDeletePlugTask";
            this.btnDeletePlugTask.Size = new System.Drawing.Size(73, 21);
            this.btnDeletePlugTask.TabIndex = 3;
            this.btnDeletePlugTask.Text = "&Excluir";
            this.btnDeletePlugTask.UseVisualStyleBackColor = true;
            this.btnDeletePlugTask.Click += new System.EventHandler(this.btnDeletePlugTask_Click);
            // 
            // btnUpdatePlugTask
            // 
            this.btnUpdatePlugTask.Location = new System.Drawing.Point(600, 32);
            this.btnUpdatePlugTask.Name = "btnUpdatePlugTask";
            this.btnUpdatePlugTask.Size = new System.Drawing.Size(73, 21);
            this.btnUpdatePlugTask.TabIndex = 2;
            this.btnUpdatePlugTask.Text = "&Alterar";
            this.btnUpdatePlugTask.UseVisualStyleBackColor = true;
            this.btnUpdatePlugTask.Click += new System.EventHandler(this.btnUpdatePlugTask_Click);
            // 
            // btnNewPlugTask
            // 
            this.btnNewPlugTask.Location = new System.Drawing.Point(600, 6);
            this.btnNewPlugTask.Name = "btnNewPlugTask";
            this.btnNewPlugTask.Size = new System.Drawing.Size(73, 21);
            this.btnNewPlugTask.TabIndex = 1;
            this.btnNewPlugTask.Text = "&Novo";
            this.btnNewPlugTask.UseVisualStyleBackColor = true;
            this.btnNewPlugTask.Click += new System.EventHandler(this.btnNewPlugTask_Click);
            // 
            // FrmPlugTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 352);
            this.Controls.Add(this.btnDeletePlugTask);
            this.Controls.Add(this.btnUpdatePlugTask);
            this.Controls.Add(this.btnNewPlugTask);
            this.Controls.Add(this.grdPlugTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPlugTask";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefas";
            ((System.ComponentModel.ISupportInitialize)(this.grdPlugTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPlugTasks;
        private System.Windows.Forms.Button btnDeletePlugTask;
        private System.Windows.Forms.Button btnUpdatePlugTask;
        private System.Windows.Forms.Button btnNewPlugTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdPlugTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdConnectViewerPlugTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReadModePlugTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColActionPlugTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastExecuteDate;
    }
}