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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIdPlugUser
            // 
            this.labelIdPlugUser.AutoSize = true;
            this.labelIdPlugUser.Location = new System.Drawing.Point(17, 31);
            this.labelIdPlugUser.Name = "labelIdPlugUser";
            this.labelIdPlugUser.Size = new System.Drawing.Size(16, 13);
            this.labelIdPlugUser.TabIndex = 0;
            this.labelIdPlugUser.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id da Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // txtIdPlugUser
            // 
            this.txtIdPlugUser.Location = new System.Drawing.Point(116, 27);
            this.txtIdPlugUser.Name = "txtIdPlugUser";
            this.txtIdPlugUser.Size = new System.Drawing.Size(62, 20);
            this.txtIdPlugUser.TabIndex = 1;
            // 
            // txtIdCompanyPlugUser
            // 
            this.txtIdCompanyPlugUser.Location = new System.Drawing.Point(116, 55);
            this.txtIdCompanyPlugUser.Name = "txtIdCompanyPlugUser";
            this.txtIdCompanyPlugUser.Size = new System.Drawing.Size(62, 20);
            this.txtIdCompanyPlugUser.TabIndex = 3;
            // 
            // txtEmailPlugUser
            // 
            this.txtEmailPlugUser.Location = new System.Drawing.Point(116, 83);
            this.txtEmailPlugUser.Name = "txtEmailPlugUser";
            this.txtEmailPlugUser.Size = new System.Drawing.Size(349, 20);
            this.txtEmailPlugUser.TabIndex = 5;
            // 
            // txtPasswordPlugUser
            // 
            this.txtPasswordPlugUser.Location = new System.Drawing.Point(116, 111);
            this.txtPasswordPlugUser.MaxLength = 30;
            this.txtPasswordPlugUser.Name = "txtPasswordPlugUser";
            this.txtPasswordPlugUser.PasswordChar = '*';
            this.txtPasswordPlugUser.Size = new System.Drawing.Size(178, 20);
            this.txtPasswordPlugUser.TabIndex = 7;
            // 
            // btnRecordPlugUser
            // 
            this.btnRecordPlugUser.Location = new System.Drawing.Point(504, 12);
            this.btnRecordPlugUser.Name = "btnRecordPlugUser";
            this.btnRecordPlugUser.Size = new System.Drawing.Size(73, 21);
            this.btnRecordPlugUser.TabIndex = 2;
            this.btnRecordPlugUser.Text = " &Gravar";
            this.btnRecordPlugUser.UseVisualStyleBackColor = true;
            this.btnRecordPlugUser.Click += new System.EventHandler(this.btnRecordPlugUser_Click);
            // 
            // btnCancelPlugUser
            // 
            this.btnCancelPlugUser.Location = new System.Drawing.Point(504, 43);
            this.btnCancelPlugUser.Name = "btnCancelPlugUser";
            this.btnCancelPlugUser.Size = new System.Drawing.Size(73, 21);
            this.btnCancelPlugUser.TabIndex = 1;
            this.btnCancelPlugUser.Text = "&Cancelar";
            this.btnCancelPlugUser.UseVisualStyleBackColor = true;
            this.btnCancelPlugUser.Click += new System.EventHandler(this.btnCancelPlugUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelIdPlugUser);
            this.groupBox1.Controls.Add(this.txtIdPlugUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmailPlugUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdCompanyPlugUser);
            this.groupBox1.Controls.Add(this.txtPasswordPlugUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário";
            // 
            // FrmModalPlugUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 159);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelPlugUser);
            this.Controls.Add(this.btnRecordPlugUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModalPlugUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private GroupBox groupBox1;
    }
}