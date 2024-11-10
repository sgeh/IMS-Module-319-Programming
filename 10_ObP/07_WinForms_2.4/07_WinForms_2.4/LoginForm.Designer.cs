
namespace Bwz.Rappi
{
    partial class LoginForm
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
            LblTitle = new Label();
            LblUserName = new Label();
            LblPassword = new Label();
            TbxUserName = new TextBox();
            TbxPassword = new TextBox();
            BtnOK = new Button();
            BtnCancel = new Button();
            LblErrorMessage = new Label();
            SuspendLayout();
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            LblTitle.Location = new Point(12, 11);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(187, 25);
            LblTitle.TabIndex = 0;
            LblTitle.Text = "Passwort-Eingabe";
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.Location = new Point(14, 60);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(82, 20);
            LblUserName.TabIndex = 1;
            LblUserName.Text = "User name:";
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Location = new Point(14, 94);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(73, 20);
            LblPassword.TabIndex = 2;
            LblPassword.Text = "Password:";
            // 
            // TbxUserName
            // 
            TbxUserName.BackColor = Color.Black;
            TbxUserName.ForeColor = Color.White;
            TbxUserName.Location = new Point(111, 56);
            TbxUserName.Margin = new Padding(3, 4, 3, 4);
            TbxUserName.Name = "TbxUserName";
            TbxUserName.Size = new Size(293, 27);
            TbxUserName.TabIndex = 3;
            // 
            // TbxPassword
            // 
            TbxPassword.BackColor = Color.Black;
            TbxPassword.ForeColor = Color.White;
            TbxPassword.Location = new Point(111, 94);
            TbxPassword.Margin = new Padding(3, 4, 3, 4);
            TbxPassword.Name = "TbxPassword";
            TbxPassword.PasswordChar = '*';
            TbxPassword.Size = new Size(293, 27);
            TbxPassword.TabIndex = 4;
            // 
            // BtnOK
            // 
            BtnOK.FlatStyle = FlatStyle.Flat;
            BtnOK.Location = new Point(329, 142);
            BtnOK.Margin = new Padding(3, 4, 3, 4);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(75, 38);
            BtnOK.TabIndex = 5;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Location = new Point(248, 142);
            BtnCancel.Margin = new Padding(3, 4, 3, 4);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 38);
            BtnCancel.TabIndex = 6;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // LblErrorMessage
            // 
            LblErrorMessage.AutoSize = true;
            LblErrorMessage.ForeColor = Color.FromArgb(255, 192, 192);
            LblErrorMessage.Location = new Point(108, 142);
            LblErrorMessage.Name = "LblErrorMessage";
            LblErrorMessage.Size = new Size(0, 20);
            LblErrorMessage.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(416, 195);
            Controls.Add(LblErrorMessage);
            Controls.Add(BtnCancel);
            Controls.Add(BtnOK);
            Controls.Add(TbxPassword);
            Controls.Add(TbxUserName);
            Controls.Add(LblPassword);
            Controls.Add(LblUserName);
            Controls.Add(LblTitle);
            ForeColor = Color.White;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "Bitte anmelden...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TbxUserName;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblErrorMessage;
    }
}

