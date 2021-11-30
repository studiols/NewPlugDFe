namespace PlugDFe.Forms.Modal
{
    partial class FrmModalPlugTask
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
            this.label6 = new System.Windows.Forms.Label();
            this.cbbIdConnectViewerPlugTask = new System.Windows.Forms.ComboBox();
            this.txtIdPlugTask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelPlugTask = new System.Windows.Forms.Button();
            this.btnRecordPlugTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbReadModePlugTask = new System.Windows.Forms.ComboBox();
            this.cbbActionPlugTask = new System.Windows.Forms.ComboBox();
            this.txtLastDateExecutePlugTask = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Conexão";
            // 
            // cbbIdConnectViewerPlugTask
            // 
            this.cbbIdConnectViewerPlugTask.FormattingEnabled = true;
            this.cbbIdConnectViewerPlugTask.Location = new System.Drawing.Point(147, 52);
            this.cbbIdConnectViewerPlugTask.Name = "cbbIdConnectViewerPlugTask";
            this.cbbIdConnectViewerPlugTask.Size = new System.Drawing.Size(347, 21);
            this.cbbIdConnectViewerPlugTask.TabIndex = 3;
            // 
            // txtIdPlugTask
            // 
            this.txtIdPlugTask.Location = new System.Drawing.Point(147, 17);
            this.txtIdPlugTask.Name = "txtIdPlugTask";
            this.txtIdPlugTask.Size = new System.Drawing.Size(82, 20);
            this.txtIdPlugTask.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id";
            // 
            // btnCancelPlugTask
            // 
            this.btnCancelPlugTask.Location = new System.Drawing.Point(16, 202);
            this.btnCancelPlugTask.Name = "btnCancelPlugTask";
            this.btnCancelPlugTask.Size = new System.Drawing.Size(64, 20);
            this.btnCancelPlugTask.TabIndex = 10;
            this.btnCancelPlugTask.Text = "Cancelar";
            this.btnCancelPlugTask.UseVisualStyleBackColor = true;
            // 
            // btnRecordPlugTask
            // 
            this.btnRecordPlugTask.Location = new System.Drawing.Point(430, 202);
            this.btnRecordPlugTask.Name = "btnRecordPlugTask";
            this.btnRecordPlugTask.Size = new System.Drawing.Size(64, 20);
            this.btnRecordPlugTask.TabIndex = 11;
            this.btnRecordPlugTask.Text = "Gravar";
            this.btnRecordPlugTask.UseVisualStyleBackColor = true;
            this.btnRecordPlugTask.Click += new System.EventHandler(this.btnRecordPlugTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ultima Data de Execução";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ultima Data de Execução";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Leitura Ação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ação";
            // 
            // cbbReadModePlugTask
            // 
            this.cbbReadModePlugTask.FormattingEnabled = true;
            this.cbbReadModePlugTask.Items.AddRange(new object[] {
            "1-Documentos Atuais",
            "2-Documentos Do Dia Anterior",
            "3-Documentos Criados Após Ultima Data De Execução"});
            this.cbbReadModePlugTask.Location = new System.Drawing.Point(147, 124);
            this.cbbReadModePlugTask.Name = "cbbReadModePlugTask";
            this.cbbReadModePlugTask.Size = new System.Drawing.Size(347, 21);
            this.cbbReadModePlugTask.TabIndex = 7;
            // 
            // cbbActionPlugTask
            // 
            this.cbbActionPlugTask.FormattingEnabled = true;
            this.cbbActionPlugTask.Items.AddRange(new object[] {
            "1-Manter",
            "2-Excluir",
            "3-Enviar Documentos Perdidos E Excluir",
            "4-Excluir Registros Velhos"});
            this.cbbActionPlugTask.Location = new System.Drawing.Point(147, 90);
            this.cbbActionPlugTask.Name = "cbbActionPlugTask";
            this.cbbActionPlugTask.Size = new System.Drawing.Size(347, 21);
            this.cbbActionPlugTask.TabIndex = 5;
            // 
            // txtLastDateExecutePlugTask
            // 
            this.txtLastDateExecutePlugTask.Location = new System.Drawing.Point(147, 160);
            this.txtLastDateExecutePlugTask.Mask = "00/00/0000 90:00:00";
            this.txtLastDateExecutePlugTask.Name = "txtLastDateExecutePlugTask";
            this.txtLastDateExecutePlugTask.Size = new System.Drawing.Size(115, 20);
            this.txtLastDateExecutePlugTask.TabIndex = 9;
            this.txtLastDateExecutePlugTask.ValidatingType = typeof(System.DateTime);
            // 
            // FrmModalPlugTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 229);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbIdConnectViewerPlugTask);
            this.Controls.Add(this.txtIdPlugTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelPlugTask);
            this.Controls.Add(this.btnRecordPlugTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbReadModePlugTask);
            this.Controls.Add(this.cbbActionPlugTask);
            this.Controls.Add(this.txtLastDateExecutePlugTask);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModalPlugTask";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbIdConnectViewerPlugTask;
        private System.Windows.Forms.TextBox txtIdPlugTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelPlugTask;
        private System.Windows.Forms.Button btnRecordPlugTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbReadModePlugTask;
        private System.Windows.Forms.ComboBox cbbActionPlugTask;
        private System.Windows.Forms.MaskedTextBox txtLastDateExecutePlugTask;
    }
}