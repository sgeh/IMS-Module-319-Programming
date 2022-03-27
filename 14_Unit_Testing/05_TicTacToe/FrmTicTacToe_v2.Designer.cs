namespace Bwz.Rappi
{
    partial class FrmTicTacToe_v2
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
            this.BtnTopLeft = new System.Windows.Forms.Button();
            this.BtnTopMiddle = new System.Windows.Forms.Button();
            this.BtnTopRight = new System.Windows.Forms.Button();
            this.BtnMiddleLeft = new System.Windows.Forms.Button();
            this.BtnMiddleMiddle = new System.Windows.Forms.Button();
            this.BtnMiddleRight = new System.Windows.Forms.Button();
            this.BtnBottomLeft = new System.Windows.Forms.Button();
            this.BtnBottomMiddle = new System.Windows.Forms.Button();
            this.BtnBottomRight = new System.Windows.Forms.Button();
            this.PnlPlayerRed = new System.Windows.Forms.Panel();
            this.PnlPlayerBlue = new System.Windows.Forms.Panel();
            this.LblPlayer = new System.Windows.Forms.Label();
            this.PnlWin = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblWinMessage = new System.Windows.Forms.Label();
            this.PnlDraw = new System.Windows.Forms.Panel();
            this.BtnExitDraw = new System.Windows.Forms.Button();
            this.LblDraw = new System.Windows.Forms.Label();
            this.PnlWin.SuspendLayout();
            this.PnlDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTopLeft
            // 
            this.BtnTopLeft.BackColor = System.Drawing.Color.White;
            this.BtnTopLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTopLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTopLeft.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTopLeft.Location = new System.Drawing.Point(12, 12);
            this.BtnTopLeft.Name = "BtnTopLeft";
            this.BtnTopLeft.Size = new System.Drawing.Size(100, 100);
            this.BtnTopLeft.TabIndex = 0;
            this.BtnTopLeft.UseVisualStyleBackColor = false;
            this.BtnTopLeft.Click += new System.EventHandler(this.BtnTopLeft_Click);
            // 
            // BtnTopMiddle
            // 
            this.BtnTopMiddle.BackColor = System.Drawing.Color.White;
            this.BtnTopMiddle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTopMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTopMiddle.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold);
            this.BtnTopMiddle.Location = new System.Drawing.Point(118, 12);
            this.BtnTopMiddle.Name = "BtnTopMiddle";
            this.BtnTopMiddle.Size = new System.Drawing.Size(100, 100);
            this.BtnTopMiddle.TabIndex = 1;
            this.BtnTopMiddle.UseVisualStyleBackColor = false;
            this.BtnTopMiddle.Click += new System.EventHandler(this.BtnTopMiddle_Click);
            // 
            // BtnTopRight
            // 
            this.BtnTopRight.BackColor = System.Drawing.Color.White;
            this.BtnTopRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTopRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTopRight.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold);
            this.BtnTopRight.Location = new System.Drawing.Point(224, 12);
            this.BtnTopRight.Name = "BtnTopRight";
            this.BtnTopRight.Size = new System.Drawing.Size(100, 100);
            this.BtnTopRight.TabIndex = 2;
            this.BtnTopRight.UseVisualStyleBackColor = false;
            this.BtnTopRight.Click += new System.EventHandler(this.BtnTopRight_Click);
            // 
            // BtnMiddleLeft
            // 
            this.BtnMiddleLeft.BackColor = System.Drawing.Color.White;
            this.BtnMiddleLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMiddleLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMiddleLeft.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold);
            this.BtnMiddleLeft.Location = new System.Drawing.Point(12, 118);
            this.BtnMiddleLeft.Name = "BtnMiddleLeft";
            this.BtnMiddleLeft.Size = new System.Drawing.Size(100, 100);
            this.BtnMiddleLeft.TabIndex = 3;
            this.BtnMiddleLeft.UseVisualStyleBackColor = false;
            this.BtnMiddleLeft.Click += new System.EventHandler(this.BtnMiddleLeft_Click);
            // 
            // BtnMiddleMiddle
            // 
            this.BtnMiddleMiddle.BackColor = System.Drawing.Color.White;
            this.BtnMiddleMiddle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMiddleMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMiddleMiddle.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold);
            this.BtnMiddleMiddle.Location = new System.Drawing.Point(118, 118);
            this.BtnMiddleMiddle.Name = "BtnMiddleMiddle";
            this.BtnMiddleMiddle.Size = new System.Drawing.Size(100, 100);
            this.BtnMiddleMiddle.TabIndex = 4;
            this.BtnMiddleMiddle.UseVisualStyleBackColor = false;
            this.BtnMiddleMiddle.Click += new System.EventHandler(this.BtnMiddleMiddle_Click);
            // 
            // BtnMiddleRight
            // 
            this.BtnMiddleRight.BackColor = System.Drawing.Color.White;
            this.BtnMiddleRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMiddleRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMiddleRight.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold);
            this.BtnMiddleRight.Location = new System.Drawing.Point(224, 118);
            this.BtnMiddleRight.Name = "BtnMiddleRight";
            this.BtnMiddleRight.Size = new System.Drawing.Size(100, 100);
            this.BtnMiddleRight.TabIndex = 5;
            this.BtnMiddleRight.UseVisualStyleBackColor = false;
            this.BtnMiddleRight.Click += new System.EventHandler(this.BtnMiddleRight_Click);
            // 
            // BtnBottomLeft
            // 
            this.BtnBottomLeft.BackColor = System.Drawing.Color.White;
            this.BtnBottomLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBottomLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBottomLeft.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold);
            this.BtnBottomLeft.Location = new System.Drawing.Point(12, 224);
            this.BtnBottomLeft.Name = "BtnBottomLeft";
            this.BtnBottomLeft.Size = new System.Drawing.Size(100, 100);
            this.BtnBottomLeft.TabIndex = 6;
            this.BtnBottomLeft.UseVisualStyleBackColor = false;
            this.BtnBottomLeft.Click += new System.EventHandler(this.BtnBottomLeft_Click);
            // 
            // BtnBottomMiddle
            // 
            this.BtnBottomMiddle.BackColor = System.Drawing.Color.White;
            this.BtnBottomMiddle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBottomMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBottomMiddle.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold);
            this.BtnBottomMiddle.Location = new System.Drawing.Point(118, 224);
            this.BtnBottomMiddle.Name = "BtnBottomMiddle";
            this.BtnBottomMiddle.Size = new System.Drawing.Size(100, 100);
            this.BtnBottomMiddle.TabIndex = 7;
            this.BtnBottomMiddle.UseVisualStyleBackColor = false;
            this.BtnBottomMiddle.Click += new System.EventHandler(this.BtnBottomMiddle_Click);
            // 
            // BtnBottomRight
            // 
            this.BtnBottomRight.BackColor = System.Drawing.Color.White;
            this.BtnBottomRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBottomRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBottomRight.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold);
            this.BtnBottomRight.Location = new System.Drawing.Point(224, 224);
            this.BtnBottomRight.Name = "BtnBottomRight";
            this.BtnBottomRight.Size = new System.Drawing.Size(100, 100);
            this.BtnBottomRight.TabIndex = 8;
            this.BtnBottomRight.UseVisualStyleBackColor = false;
            this.BtnBottomRight.Click += new System.EventHandler(this.BtnBottomRight_Click);
            // 
            // PnlPlayerRed
            // 
            this.PnlPlayerRed.BackColor = System.Drawing.Color.DarkRed;
            this.PnlPlayerRed.Location = new System.Drawing.Point(12, 336);
            this.PnlPlayerRed.Name = "PnlPlayerRed";
            this.PnlPlayerRed.Size = new System.Drawing.Size(312, 30);
            this.PnlPlayerRed.TabIndex = 10;
            // 
            // PnlPlayerBlue
            // 
            this.PnlPlayerBlue.BackColor = System.Drawing.Color.DarkBlue;
            this.PnlPlayerBlue.Location = new System.Drawing.Point(12, 336);
            this.PnlPlayerBlue.Name = "PnlPlayerBlue";
            this.PnlPlayerBlue.Size = new System.Drawing.Size(312, 30);
            this.PnlPlayerBlue.TabIndex = 11;
            this.PnlPlayerBlue.Visible = false;
            // 
            // LblPlayer
            // 
            this.LblPlayer.BackColor = System.Drawing.Color.DarkRed;
            this.LblPlayer.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer.ForeColor = System.Drawing.Color.White;
            this.LblPlayer.Location = new System.Drawing.Point(12, 336);
            this.LblPlayer.Name = "LblPlayer";
            this.LblPlayer.Size = new System.Drawing.Size(151, 30);
            this.LblPlayer.TabIndex = 12;
            this.LblPlayer.Text = "Current Player";
            // 
            // PnlWin
            // 
            this.PnlWin.BackColor = System.Drawing.Color.White;
            this.PnlWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlWin.Controls.Add(this.BtnExit);
            this.PnlWin.Controls.Add(this.LblWinMessage);
            this.PnlWin.Location = new System.Drawing.Point(24, 278);
            this.PnlWin.Name = "PnlWin";
            this.PnlWin.Size = new System.Drawing.Size(289, 136);
            this.PnlWin.TabIndex = 13;
            this.PnlWin.Visible = false;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(201, 104);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(77, 23);
            this.BtnExit.TabIndex = 15;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblWinMessage
            // 
            this.LblWinMessage.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWinMessage.Location = new System.Drawing.Point(12, 56);
            this.LblWinMessage.Name = "LblWinMessage";
            this.LblWinMessage.Size = new System.Drawing.Size(272, 33);
            this.LblWinMessage.TabIndex = 14;
            this.LblWinMessage.Text = "Player {0} won!";
            // 
            // PnlDraw
            // 
            this.PnlDraw.BackColor = System.Drawing.Color.White;
            this.PnlDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDraw.Controls.Add(this.BtnExitDraw);
            this.PnlDraw.Controls.Add(this.LblDraw);
            this.PnlDraw.Location = new System.Drawing.Point(24, 278);
            this.PnlDraw.Name = "PnlDraw";
            this.PnlDraw.Size = new System.Drawing.Size(289, 136);
            this.PnlDraw.TabIndex = 16;
            this.PnlDraw.Visible = false;
            // 
            // BtnExitDraw
            // 
            this.BtnExitDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExitDraw.Location = new System.Drawing.Point(201, 104);
            this.BtnExitDraw.Name = "BtnExitDraw";
            this.BtnExitDraw.Size = new System.Drawing.Size(77, 23);
            this.BtnExitDraw.TabIndex = 15;
            this.BtnExitDraw.Text = "Exit";
            this.BtnExitDraw.UseVisualStyleBackColor = true;
            this.BtnExitDraw.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblDraw
            // 
            this.LblDraw.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDraw.Location = new System.Drawing.Point(62, 56);
            this.LblDraw.Name = "LblDraw";
            this.LblDraw.Size = new System.Drawing.Size(169, 33);
            this.LblDraw.TabIndex = 14;
            this.LblDraw.Text = "No winner, draw!";
            // 
            // FrmTicTacToe_v1
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(343, 434);
            this.Controls.Add(this.PnlDraw);
            this.Controls.Add(this.PnlWin);
            this.Controls.Add(this.LblPlayer);
            this.Controls.Add(this.BtnMiddleRight);
            this.Controls.Add(this.BtnTopMiddle);
            this.Controls.Add(this.PnlPlayerBlue);
            this.Controls.Add(this.PnlPlayerRed);
            this.Controls.Add(this.BtnBottomRight);
            this.Controls.Add(this.BtnBottomMiddle);
            this.Controls.Add(this.BtnBottomLeft);
            this.Controls.Add(this.BtnMiddleMiddle);
            this.Controls.Add(this.BtnMiddleLeft);
            this.Controls.Add(this.BtnTopRight);
            this.Controls.Add(this.BtnTopLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "FrmTicTacToe_v1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.PnlWin.ResumeLayout(false);
            this.PnlDraw.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTopLeft;
        private System.Windows.Forms.Button BtnTopMiddle;
        private System.Windows.Forms.Button BtnTopRight;
        private System.Windows.Forms.Button BtnMiddleLeft;
        private System.Windows.Forms.Button BtnMiddleMiddle;
        private System.Windows.Forms.Button BtnMiddleRight;
        private System.Windows.Forms.Button BtnBottomLeft;
        private System.Windows.Forms.Button BtnBottomMiddle;
        private System.Windows.Forms.Button BtnBottomRight;
        private System.Windows.Forms.Panel PnlPlayerRed;
        private System.Windows.Forms.Panel PnlPlayerBlue;
        private System.Windows.Forms.Label LblPlayer;
        private System.Windows.Forms.Panel PnlWin;
        private System.Windows.Forms.Label LblWinMessage;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel PnlDraw;
        private System.Windows.Forms.Button BtnExitDraw;
        private System.Windows.Forms.Label LblDraw;
    }
}

