namespace PlugDFe.Forms.Modal
{
    partial class FrmModalPlugAddress
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathPlugAddress = new System.Windows.Forms.TextBox();
            this.btnCancelPlugAddress = new System.Windows.Forms.Button();
            this.btnRecordPlugAddress = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdPlugAddress = new System.Windows.Forms.TextBox();
            this.cbbFileTypePlugAddress = new System.Windows.Forms.ComboBox();
            this.gpPlugAddress = new System.Windows.Forms.GroupBox();
            this.gpPlugAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Caminho";
            // 
            // txtPathPlugAddress
            // 
            this.txtPathPlugAddress.Location = new System.Drawing.Point(82, 49);
            this.txtPathPlugAddress.Name = "txtPathPlugAddress";
            this.txtPathPlugAddress.Size = new System.Drawing.Size(283, 20);
            this.txtPathPlugAddress.TabIndex = 3;
            // 
            // btnCancelPlugAddress
            // 
            this.btnCancelPlugAddress.Location = new System.Drawing.Point(398, 38);
            this.btnCancelPlugAddress.Name = "btnCancelPlugAddress";
            this.btnCancelPlugAddress.Size = new System.Drawing.Size(73, 21);
            this.btnCancelPlugAddress.TabIndex = 1;
            this.btnCancelPlugAddress.Text = "&Cancelar";
            this.btnCancelPlugAddress.UseVisualStyleBackColor = true;
            this.btnCancelPlugAddress.Click += new System.EventHandler(this.btnCancelPlugAddress_Click);
            // 
            // btnRecordPlugAddress
            // 
            this.btnRecordPlugAddress.Location = new System.Drawing.Point(398, 12);
            this.btnRecordPlugAddress.Name = "btnRecordPlugAddress";
            this.btnRecordPlugAddress.Size = new System.Drawing.Size(73, 21);
            this.btnRecordPlugAddress.TabIndex = 2;
            this.btnRecordPlugAddress.Text = "&Gravar";
            this.btnRecordPlugAddress.UseVisualStyleBackColor = true;
            this.btnRecordPlugAddress.Click += new System.EventHandler(this.btnRecordPlugAddress_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id";
            // 
            // txtIdPlugAddress
            // 
            this.txtIdPlugAddress.Location = new System.Drawing.Point(82, 23);
            this.txtIdPlugAddress.Name = "txtIdPlugAddress";
            this.txtIdPlugAddress.Size = new System.Drawing.Size(46, 20);
            this.txtIdPlugAddress.TabIndex = 1;
            // 
            // cbbFileTypePlugAddress
            // 
            this.cbbFileTypePlugAddress.FormattingEnabled = true;
            this.cbbFileTypePlugAddress.Items.AddRange(new object[] {
            "1-NFe Emissão Própria",
            "2-NFe Emissão Própria Evento Cancelamento",
            "3-SAT",
            "4-SAT Evento Cancelamento",
            "5-NFCe",
            "6-NFCe Evento Cancelamento"});
            this.cbbFileTypePlugAddress.Location = new System.Drawing.Point(82, 75);
            this.cbbFileTypePlugAddress.Name = "cbbFileTypePlugAddress";
            this.cbbFileTypePlugAddress.Size = new System.Drawing.Size(283, 21);
            this.cbbFileTypePlugAddress.TabIndex = 5;
            // 
            // gpPlugAddress
            // 
            this.gpPlugAddress.Controls.Add(this.label6);
            this.gpPlugAddress.Controls.Add(this.cbbFileTypePlugAddress);
            this.gpPlugAddress.Controls.Add(this.txtPathPlugAddress);
            this.gpPlugAddress.Controls.Add(this.txtIdPlugAddress);
            this.gpPlugAddress.Controls.Add(this.label2);
            this.gpPlugAddress.Controls.Add(this.label1);
            this.gpPlugAddress.Location = new System.Drawing.Point(12, 12);
            this.gpPlugAddress.Name = "gpPlugAddress";
            this.gpPlugAddress.Size = new System.Drawing.Size(380, 113);
            this.gpPlugAddress.TabIndex = 0;
            this.gpPlugAddress.TabStop = false;
            this.gpPlugAddress.Text = "Endereço";
            // 
            // FrmModalPlugAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 132);
            this.Controls.Add(this.gpPlugAddress);
            this.Controls.Add(this.btnRecordPlugAddress);
            this.Controls.Add(this.btnCancelPlugAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModalPlugAddress";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endereço";
            this.gpPlugAddress.ResumeLayout(false);
            this.gpPlugAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathPlugAddress;
        private System.Windows.Forms.Button btnCancelPlugAddress;
        private System.Windows.Forms.Button btnRecordPlugAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdPlugAddress;
        private System.Windows.Forms.ComboBox cbbFileTypePlugAddress;
        private System.Windows.Forms.GroupBox gpPlugAddress;
    }
}