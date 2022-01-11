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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbReadModePlugTask = new System.Windows.Forms.ComboBox();
            this.cbbActionPlugTask = new System.Windows.Forms.ComboBox();
            this.txtLastDateExecutePlugTask = new System.Windows.Forms.MaskedTextBox();
            this.txtUnitCodePlugTask = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStartDatePlugTask = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGroupCodePlugTask = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Conexão";
            // 
            // cbbIdConnectViewerPlugTask
            // 
            this.cbbIdConnectViewerPlugTask.FormattingEnabled = true;
            this.cbbIdConnectViewerPlugTask.Location = new System.Drawing.Point(154, 52);
            this.cbbIdConnectViewerPlugTask.Name = "cbbIdConnectViewerPlugTask";
            this.cbbIdConnectViewerPlugTask.Size = new System.Drawing.Size(291, 21);
            this.cbbIdConnectViewerPlugTask.TabIndex = 3;
            // 
            // txtIdPlugTask
            // 
            this.txtIdPlugTask.Location = new System.Drawing.Point(154, 21);
            this.txtIdPlugTask.Name = "txtIdPlugTask";
            this.txtIdPlugTask.Size = new System.Drawing.Size(53, 20);
            this.txtIdPlugTask.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id";
            // 
            // btnCancelPlugTask
            // 
            this.btnCancelPlugTask.Location = new System.Drawing.Point(472, 38);
            this.btnCancelPlugTask.Name = "btnCancelPlugTask";
            this.btnCancelPlugTask.Size = new System.Drawing.Size(73, 21);
            this.btnCancelPlugTask.TabIndex = 1;
            this.btnCancelPlugTask.Text = "&Cancelar";
            this.btnCancelPlugTask.UseVisualStyleBackColor = true;
            this.btnCancelPlugTask.Click += new System.EventHandler(this.btnCancelPlugTask_Click_1);
            // 
            // btnRecordPlugTask
            // 
            this.btnRecordPlugTask.Location = new System.Drawing.Point(472, 12);
            this.btnRecordPlugTask.Name = "btnRecordPlugTask";
            this.btnRecordPlugTask.Size = new System.Drawing.Size(73, 21);
            this.btnRecordPlugTask.TabIndex = 2;
            this.btnRecordPlugTask.Text = "&Gravar";
            this.btnRecordPlugTask.UseVisualStyleBackColor = true;
            this.btnRecordPlugTask.Click += new System.EventHandler(this.btnRecordPlugTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ultima Data de Execução";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Documentos Para Leitura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ação A Ser Executada";
            // 
            // cbbReadModePlugTask
            // 
            this.cbbReadModePlugTask.FormattingEnabled = true;
            this.cbbReadModePlugTask.Items.AddRange(new object[] {
            "1-Documentos Atuais",
            "2-Documentos Do Dia Anterior",
            "3-Documentos Criados Após Ultima Data De Execução"});
            this.cbbReadModePlugTask.Location = new System.Drawing.Point(154, 114);
            this.cbbReadModePlugTask.Name = "cbbReadModePlugTask";
            this.cbbReadModePlugTask.Size = new System.Drawing.Size(291, 21);
            this.cbbReadModePlugTask.TabIndex = 7;
            // 
            // cbbActionPlugTask
            // 
            this.cbbActionPlugTask.FormattingEnabled = true;
            this.cbbActionPlugTask.Items.AddRange(new object[] {
            "1-Manter",
            "2-Excluir",
            "3-Enviar Documentos Perdidos E Excluir",
            "4-Excluir Registros Velhos",
            "5-Enviar Documentos Perdidos E Manter"});
            this.cbbActionPlugTask.Location = new System.Drawing.Point(154, 83);
            this.cbbActionPlugTask.Name = "cbbActionPlugTask";
            this.cbbActionPlugTask.Size = new System.Drawing.Size(291, 21);
            this.cbbActionPlugTask.TabIndex = 5;
            // 
            // txtLastDateExecutePlugTask
            // 
            this.txtLastDateExecutePlugTask.Location = new System.Drawing.Point(154, 207);
            this.txtLastDateExecutePlugTask.Mask = "00/00/0000 90:00:00";
            this.txtLastDateExecutePlugTask.Name = "txtLastDateExecutePlugTask";
            this.txtLastDateExecutePlugTask.Size = new System.Drawing.Size(115, 20);
            this.txtLastDateExecutePlugTask.TabIndex = 13;
            this.txtLastDateExecutePlugTask.ValidatingType = typeof(System.DateTime);
            // 
            // txtUnitCodePlugTask
            // 
            this.txtUnitCodePlugTask.Location = new System.Drawing.Point(154, 145);
            this.txtUnitCodePlugTask.Name = "txtUnitCodePlugTask";
            this.txtUnitCodePlugTask.Size = new System.Drawing.Size(53, 20);
            this.txtUnitCodePlugTask.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Código da Unidade";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGroupCodePlugTask);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtStartDatePlugTask);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLastDateExecutePlugTask);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUnitCodePlugTask);
            this.groupBox1.Controls.Add(this.cbbActionPlugTask);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbReadModePlugTask);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbIdConnectViewerPlugTask);
            this.groupBox1.Controls.Add(this.txtIdPlugTask);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarefa";
            // 
            // txtStartDatePlugTask
            // 
            this.txtStartDatePlugTask.Location = new System.Drawing.Point(154, 238);
            this.txtStartDatePlugTask.Mask = "00/00/0000 90:00:00";
            this.txtStartDatePlugTask.Name = "txtStartDatePlugTask";
            this.txtStartDatePlugTask.Size = new System.Drawing.Size(115, 20);
            this.txtStartDatePlugTask.TabIndex = 15;
            this.txtStartDatePlugTask.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data de Início";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Código do Grupo";
            // 
            // txtGroupCodePlugTask
            // 
            this.txtGroupCodePlugTask.Location = new System.Drawing.Point(154, 176);
            this.txtGroupCodePlugTask.Name = "txtGroupCodePlugTask";
            this.txtGroupCodePlugTask.Size = new System.Drawing.Size(115, 20);
            this.txtGroupCodePlugTask.TabIndex = 11;
            // 
            // FrmModalPlugTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelPlugTask);
            this.Controls.Add(this.btnRecordPlugTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModalPlugTask";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbIdConnectViewerPlugTask;
        private System.Windows.Forms.TextBox txtIdPlugTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelPlugTask;
        private System.Windows.Forms.Button btnRecordPlugTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbReadModePlugTask;
        private System.Windows.Forms.ComboBox cbbActionPlugTask;
        private System.Windows.Forms.MaskedTextBox txtLastDateExecutePlugTask;
        private System.Windows.Forms.TextBox txtUnitCodePlugTask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtStartDatePlugTask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGroupCodePlugTask;
        private System.Windows.Forms.Label label8;
    }
}