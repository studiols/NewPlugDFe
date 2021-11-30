using System.Windows.Forms;

namespace PlugDFe.Forms.Modal
{
    partial class FrmModalPlugUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModalPlugUser));
            this.labelIdPlugUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdPlugUser = new System.Windows.Forms.TextBox();
            this.txtIdCompanyPlugUser = new System.Windows.Forms.TextBox();
            this.txtEmailPlugUser = new System.Windows.Forms.TextBox();
            this.txtPasswordPlugUser = new System.Windows.Forms.TextBox();
            this.btnRecordPlugUser = new System.Windows.Forms.Button();
            this.btnCancelPlugUser = new System.Windows.Forms.Button();
            this.labelUnitCodePlugUser = new System.Windows.Forms.Label();
            this.txtUnitCodePlugUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelIdPlugUser
            // 
            this.labelIdPlugUser.AutoSize = true;
            this.labelIdPlugUser.Location = new System.Drawing.Point(11, 16);
            this.labelIdPlugUser.Name = "labelIdPlugUser";
            this.labelIdPlugUser.Size = new System.Drawing.Size(16, 13);
            this.labelIdPlugUser.TabIndex = 0;
            this.labelIdPlugUser.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id da Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha";
            // 
            // txtIdPlugUser
            // 
            this.txtIdPlugUser.Location = new System.Drawing.Point(115, 12);
            this.txtIdPlugUser.Name = "txtIdPlugUser";
            this.txtIdPlugUser.Size = new System.Drawing.Size(62, 20);
            this.txtIdPlugUser.TabIndex = 1;
            // 
            // txtIdCompanyPlugUser
            // 
            this.txtIdCompanyPlugUser.Location = new System.Drawing.Point(115, 38);
            this.txtIdCompanyPlugUser.Name = "txtIdCompanyPlugUser";
            this.txtIdCompanyPlugUser.Size = new System.Drawing.Size(62, 20);
            this.txtIdCompanyPlugUser.TabIndex = 3;
            // 
            // txtEmailPlugUser
            // 
            this.txtEmailPlugUser.Location = new System.Drawing.Point(115, 90);
            this.txtEmailPlugUser.Name = "txtEmailPlugUser";
            this.txtEmailPlugUser.Size = new System.Drawing.Size(435, 20);
            this.txtEmailPlugUser.TabIndex = 7;
            // 
            // txtPasswordPlugUser
            // 
            this.txtPasswordPlugUser.Location = new System.Drawing.Point(115, 116);
            this.txtPasswordPlugUser.MaxLength = 30;
            this.txtPasswordPlugUser.Name = "txtPasswordPlugUser";
            this.txtPasswordPlugUser.PasswordChar = '*';
            this.txtPasswordPlugUser.Size = new System.Drawing.Size(178, 20);
            this.txtPasswordPlugUser.TabIndex = 9;
            // 
            // btnRecordPlugUser
            // 
            this.btnRecordPlugUser.Location = new System.Drawing.Point(484, 170);
            this.btnRecordPlugUser.Name = "btnRecordPlugUser";
            this.btnRecordPlugUser.Size = new System.Drawing.Size(66, 25);
            this.btnRecordPlugUser.TabIndex = 11;
            this.btnRecordPlugUser.Text = "Gravar";
            this.btnRecordPlugUser.UseVisualStyleBackColor = true;
            this.btnRecordPlugUser.Click += new System.EventHandler(this.btnRecordPlugUser_Click);
            // 
            // btnCancelPlugUser
            // 
            this.btnCancelPlugUser.Location = new System.Drawing.Point(14, 170);
            this.btnCancelPlugUser.Name = "btnCancelPlugUser";
            this.btnCancelPlugUser.Size = new System.Drawing.Size(66, 25);
            this.btnCancelPlugUser.TabIndex = 10;
            this.btnCancelPlugUser.Text = "Cancelar";
            this.btnCancelPlugUser.UseVisualStyleBackColor = true;
            this.btnCancelPlugUser.Click += new System.EventHandler(this.btnCancelPlugUser_Click);
            // 
            // labelUnitCodePlugUser
            // 
            this.labelUnitCodePlugUser.AutoSize = true;
            this.labelUnitCodePlugUser.Location = new System.Drawing.Point(11, 68);
            this.labelUnitCodePlugUser.Name = "labelUnitCodePlugUser";
            this.labelUnitCodePlugUser.Size = new System.Drawing.Size(98, 13);
            this.labelUnitCodePlugUser.TabIndex = 4;
            this.labelUnitCodePlugUser.Text = "Código da Unidade";
            // 
            // txtUnitCodePlugUser
            // 
            this.txtUnitCodePlugUser.Location = new System.Drawing.Point(115, 64);
            this.txtUnitCodePlugUser.Name = "txtUnitCodePlugUser";
            this.txtUnitCodePlugUser.Size = new System.Drawing.Size(435, 20);
            this.txtUnitCodePlugUser.TabIndex = 5;
            // 
            // FrmModalPlugUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 201);
            this.Controls.Add(this.txtUnitCodePlugUser);
            this.Controls.Add(this.labelUnitCodePlugUser);
            this.Controls.Add(this.btnCancelPlugUser);
            this.Controls.Add(this.btnRecordPlugUser);
            this.Controls.Add(this.txtPasswordPlugUser);
            this.Controls.Add(this.txtEmailPlugUser);
            this.Controls.Add(this.txtIdCompanyPlugUser);
            this.Controls.Add(this.txtIdPlugUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIdPlugUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModalPlugUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelIdPlugUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdPlugUser;
        private TextBox txtIdCompanyPlugUser;
        private TextBox txtEmailPlugUser;
        private TextBox txtPasswordPlugUser;
        private Button btnRecordPlugUser;
        private Button btnCancelPlugUser;
        private Label labelUnitCodePlugUser;
        private TextBox txtUnitCodePlugUser;
    }
}