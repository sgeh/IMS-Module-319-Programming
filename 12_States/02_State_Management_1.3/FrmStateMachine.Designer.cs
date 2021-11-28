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
            this.SuspendLayout();
            // 
            // LblDoWhileMode
            // 
            this.LblDoWhileMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDoWhileMode.Location = new System.Drawing.Point(16, 12);
            this.LblDoWhileMode.Name = "LblDoWhileMode";
            this.LblDoWhileMode.Size = new System.Drawing.Size(294, 36);
            this.LblDoWhileMode.TabIndex = 0;
            this.LblDoWhileMode.Text = "do-while";
            // 
            // CmdChangeMode
            // 
            this.CmdChangeMode.Location = new System.Drawing.Point(182, 180);
            this.CmdChangeMode.Name = "CmdChangeMode";
            this.CmdChangeMode.Size = new System.Drawing.Size(128, 27);
            this.CmdChangeMode.TabIndex = 5;
            this.CmdChangeMode.Text = "Change Mode";
            this.CmdChangeMode.UseVisualStyleBackColor = true;
            this.CmdChangeMode.Click += new System.EventHandler(this.CmdChangeMode_Click);
            // 
            // LblWhileMode
            // 
            this.LblWhileMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblWhileMode.Location = new System.Drawing.Point(16, 114);
            this.LblWhileMode.Name = "LblWhileMode";
            this.LblWhileMode.Size = new System.Drawing.Size(294, 36);
            this.LblWhileMode.TabIndex = 0;
            this.LblWhileMode.Text = "while";
            this.LblWhileMode.Visible = false;
            // 
            // LblForMode
            // 
            this.LblForMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblForMode.Location = new System.Drawing.Point(16, 64);
            this.LblForMode.Name = "LblForMode";
            this.LblForMode.Size = new System.Drawing.Size(294, 36);
            this.LblForMode.TabIndex = 0;
            this.LblForMode.Text = "for";
            this.LblForMode.Visible = false;
            // 
            // FrmStateMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(325, 219);
            this.Controls.Add(this.LblWhileMode);
            this.Controls.Add(this.LblForMode);
            this.Controls.Add(this.LblDoWhileMode);
            this.Controls.Add(this.CmdChangeMode);
            this.Name = "FrmStateMachine";
            this.Text = "State Management";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CmdChangeMode;
        private System.Windows.Forms.Label LblDoWhileMode;
        private System.Windows.Forms.Label LblWhileMode;
        private System.Windows.Forms.Label LblForMode;
    }
}

