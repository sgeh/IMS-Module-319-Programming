namespace Bwz.Rappi
{
    partial class FrmAppLog
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAppLog));
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            this.TbxLogMessages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(385, 207);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 38);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(12, 12);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(105, 38);
            this.BtnSort.TabIndex = 1;
            this.BtnSort.Text = "Sort by Date";
            this.BtnSort.UseVisualStyleBackColor = true;
            // 
            // TbxLogMessages
            // 
            this.TbxLogMessages.Location = new System.Drawing.Point(12, 56);
            this.TbxLogMessages.Multiline = true;
            this.TbxLogMessages.Name = "TbxLogMessages";
            this.TbxLogMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbxLogMessages.Size = new System.Drawing.Size(448, 145);
            this.TbxLogMessages.TabIndex = 2;
            this.TbxLogMessages.Text = resources.GetString("TbxLogMessages.Text");
            // 
            // FrmAppLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 257);
            this.Controls.Add(this.TbxLogMessages);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.BtnClose);
            this.Name = "FrmAppLog";
            this.Text = "Application Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.TextBox TbxLogMessages;
    }
}

