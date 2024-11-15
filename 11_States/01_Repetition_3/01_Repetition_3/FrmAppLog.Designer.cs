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
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnEnum = new System.Windows.Forms.Button();
            this.TbxLogMessages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(385, 259);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 48);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnEnum
            // 
            this.BtnEnum.Location = new System.Drawing.Point(12, 15);
            this.BtnEnum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEnum.Name = "BtnEnum";
            this.BtnEnum.Size = new System.Drawing.Size(105, 48);
            this.BtnEnum.TabIndex = 1;
            this.BtnEnum.Text = "Enumerate Array";
            this.BtnEnum.UseVisualStyleBackColor = true;
            this.BtnEnum.Click += new System.EventHandler(this.BtnEnum_Click);
            // 
            // TbxLogMessages
            // 
            this.TbxLogMessages.Location = new System.Drawing.Point(12, 70);
            this.TbxLogMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxLogMessages.Multiline = true;
            this.TbxLogMessages.Name = "TbxLogMessages";
            this.TbxLogMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbxLogMessages.Size = new System.Drawing.Size(448, 180);
            this.TbxLogMessages.TabIndex = 2;
            // 
            // FrmAppLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 321);
            this.Controls.Add(this.TbxLogMessages);
            this.Controls.Add(this.BtnEnum);
            this.Controls.Add(this.BtnClose);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAppLog";
            this.Text = "Application Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnEnum;
        private System.Windows.Forms.TextBox TbxLogMessages;
    }
}

