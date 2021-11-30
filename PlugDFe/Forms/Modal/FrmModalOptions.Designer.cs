namespace PlugDFe.Forms.Modal
{
    partial class FrmModalOptions
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
            this.grdOptions = new System.Windows.Forms.DataGridView();
            this.OptionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOptions
            // 
            this.grdOptions.AllowUserToAddRows = false;
            this.grdOptions.AllowUserToDeleteRows = false;
            this.grdOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OptionId,
            this.OptionKey,
            this.OptionValue});
            this.grdOptions.Location = new System.Drawing.Point(0, 0);
            this.grdOptions.MultiSelect = false;
            this.grdOptions.Name = "grdOptions";
            this.grdOptions.ReadOnly = true;
            this.grdOptions.RowHeadersVisible = false;
            this.grdOptions.Size = new System.Drawing.Size(587, 264);
            this.grdOptions.TabIndex = 0;
            // 
            // OptionId
            // 
            this.OptionId.HeaderText = "#";
            this.OptionId.Name = "OptionId";
            this.OptionId.ReadOnly = true;
            // 
            // OptionKey
            // 
            this.OptionKey.HeaderText = "Chave";
            this.OptionKey.Name = "OptionKey";
            this.OptionKey.ReadOnly = true;
            this.OptionKey.Width = 200;
            // 
            // OptionValue
            // 
            this.OptionValue.HeaderText = "Valor";
            this.OptionValue.Name = "OptionValue";
            this.OptionValue.ReadOnly = true;
            this.OptionValue.Width = 284;
            // 
            // FrmModalOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 274);
            this.Controls.Add(this.grdOptions);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModalOptions";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opções";
            ((System.ComponentModel.ISupportInitialize)(this.grdOptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionValue;
    }
}