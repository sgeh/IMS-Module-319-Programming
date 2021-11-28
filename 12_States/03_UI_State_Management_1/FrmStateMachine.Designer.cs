namespace Bwz.Rappi
{
    partial class FrmStateMachine
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
            this.LblDoWhileMode = new System.Windows.Forms.Label();
            this.CmdChangeMode = new System.Windows.Forms.Button();
            this.LblWhileMode = new System.Windows.Forms.Label();
            this.LblForMode = new System.Windows.Forms.Label();
            this.PnlDoWhileMode = new System.Windows.Forms.Panel();
            this.PnlForMode = new System.Windows.Forms.Panel();
            this.PnlWhileMode = new System.Windows.Forms.Panel();
            this.PnlDoWhileMode.SuspendLayout();
            this.PnlForMode.SuspendLayout();
            this.PnlWhileMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblDoWhileMode
            // 
            this.LblDoWhileMode.AutoSize = true;
            this.LblDoWhileMode.Location = new System.Drawing.Point(16, 9);
            this.LblDoWhileMode.Name = "LblDoWhileMode";
            this.LblDoWhileMode.Size = new System.Drawing.Size(60, 17);
            this.LblDoWhileMode.TabIndex = 0;
            this.LblDoWhileMode.Text = "do-while";
            // 
            // CmdChangeMode
            // 
            this.CmdChangeMode.Location = new System.Drawing.Point(130, 165);
            this.CmdChangeMode.Name = "CmdChangeMode";
            this.CmdChangeMode.Size = new System.Drawing.Size(128, 27);
            this.CmdChangeMode.TabIndex = 5;
            this.CmdChangeMode.Text = "Change Mode";
            this.CmdChangeMode.UseVisualStyleBackColor = true;
            this.CmdChangeMode.Click += new System.EventHandler(this.CmdChangeMode_Click);
            // 
            // LblWhileMode
            // 
            this.LblWhileMode.AutoSize = true;
            this.LblWhileMode.Location = new System.Drawing.Point(16, 9);
            this.LblWhileMode.Name = "LblWhileMode";
            this.LblWhileMode.Size = new System.Drawing.Size(39, 17);
            this.LblWhileMode.TabIndex = 0;
            this.LblWhileMode.Text = "while";
            // 
            // LblForMode
            // 
            this.LblForMode.AutoSize = true;
            this.LblForMode.Location = new System.Drawing.Point(16, 9);
            this.LblForMode.Name = "LblForMode";
            this.LblForMode.Size = new System.Drawing.Size(25, 17);
            this.LblForMode.TabIndex = 0;
            this.LblForMode.Text = "for";
            // 
            // PnlDoWhileMode
            // 
            this.PnlDoWhileMode.Controls.Add(this.LblDoWhileMode);
            this.PnlDoWhileMode.Location = new System.Drawing.Point(12, 12);
            this.PnlDoWhileMode.Name = "PnlDoWhileMode";
            this.PnlDoWhileMode.Size = new System.Drawing.Size(246, 36);
            this.PnlDoWhileMode.TabIndex = 6;
            // 
            // PnlForMode
            // 
            this.PnlForMode.Controls.Add(this.LblForMode);
            this.PnlForMode.Location = new System.Drawing.Point(12, 64);
            this.PnlForMode.Name = "PnlForMode";
            this.PnlForMode.Size = new System.Drawing.Size(246, 36);
            this.PnlForMode.TabIndex = 7;
            this.PnlForMode.Visible = false;
            // 
            // PnlWhileMode
            // 
            this.PnlWhileMode.Controls.Add(this.LblWhileMode);
            this.PnlWhileMode.Location = new System.Drawing.Point(12, 114);
            this.PnlWhileMode.Name = "PnlWhileMode";
            this.PnlWhileMode.Size = new System.Drawing.Size(246, 36);
            this.PnlWhileMode.TabIndex = 8;
            this.PnlWhileMode.Visible = false;
            // 
            // FrmStateMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(271, 206);
            this.Controls.Add(this.PnlDoWhileMode);
            this.Controls.Add(this.CmdChangeMode);
            this.Controls.Add(this.PnlForMode);
            this.Controls.Add(this.PnlWhileMode);
            this.Name = "FrmStateMachine";
            this.Text = "State Management";
            this.PnlDoWhileMode.ResumeLayout(false);
            this.PnlDoWhileMode.PerformLayout();
            this.PnlForMode.ResumeLayout(false);
            this.PnlForMode.PerformLayout();
            this.PnlWhileMode.ResumeLayout(false);
            this.PnlWhileMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CmdChangeMode;
        private System.Windows.Forms.Label LblDoWhileMode;
        private System.Windows.Forms.Label LblWhileMode;
        private System.Windows.Forms.Label LblForMode;
        private System.Windows.Forms.Panel PnlDoWhileMode;
        private System.Windows.Forms.Panel PnlForMode;
        private System.Windows.Forms.Panel PnlWhileMode;
    }
}

