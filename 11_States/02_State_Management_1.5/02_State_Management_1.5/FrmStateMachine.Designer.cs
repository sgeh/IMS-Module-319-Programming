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
            this.LblOutput = new System.Windows.Forms.Label();
            this.TbxOutput = new System.Windows.Forms.TextBox();
            this.CmdRun = new System.Windows.Forms.Button();
            this.NumStart = new System.Windows.Forms.NumericUpDown();
            this.LblStart = new System.Windows.Forms.Label();
            this.LblEnd = new System.Windows.Forms.Label();
            this.NumEnd = new System.Windows.Forms.NumericUpDown();
            this.LblStep = new System.Windows.Forms.Label();
            this.NumStep = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumStep)).BeginInit();
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
            this.CmdChangeMode.Location = new System.Drawing.Point(314, 296);
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
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(387, 12);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(55, 17);
            this.LblOutput.TabIndex = 7;
            this.LblOutput.Text = "Output:";
            // 
            // TbxOutput
            // 
            this.TbxOutput.Location = new System.Drawing.Point(390, 36);
            this.TbxOutput.Multiline = true;
            this.TbxOutput.Name = "TbxOutput";
            this.TbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbxOutput.Size = new System.Drawing.Size(190, 126);
            this.TbxOutput.TabIndex = 8;
            // 
            // CmdRun
            // 
            this.CmdRun.Location = new System.Drawing.Point(452, 296);
            this.CmdRun.Name = "CmdRun";
            this.CmdRun.Size = new System.Drawing.Size(128, 27);
            this.CmdRun.TabIndex = 9;
            this.CmdRun.Text = "Run Algo";
            this.CmdRun.UseVisualStyleBackColor = true;
            this.CmdRun.Click += new System.EventHandler(this.CmdRun_Click);
            // 
            // NumStart
            // 
            this.NumStart.Location = new System.Drawing.Point(71, 190);
            this.NumStart.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NumStart.Name = "NumStart";
            this.NumStart.Size = new System.Drawing.Size(120, 22);
            this.NumStart.TabIndex = 10;
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.Location = new System.Drawing.Point(13, 190);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(38, 17);
            this.LblStart.TabIndex = 11;
            this.LblStart.Text = "Start";
            // 
            // LblEnd
            // 
            this.LblEnd.AutoSize = true;
            this.LblEnd.Location = new System.Drawing.Point(13, 228);
            this.LblEnd.Name = "LblEnd";
            this.LblEnd.Size = new System.Drawing.Size(33, 17);
            this.LblEnd.TabIndex = 12;
            this.LblEnd.Text = "End";
            // 
            // NumEnd
            // 
            this.NumEnd.Location = new System.Drawing.Point(71, 228);
            this.NumEnd.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NumEnd.Name = "NumEnd";
            this.NumEnd.Size = new System.Drawing.Size(120, 22);
            this.NumEnd.TabIndex = 13;
            this.NumEnd.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // LblStep
            // 
            this.LblStep.AutoSize = true;
            this.LblStep.Location = new System.Drawing.Point(13, 269);
            this.LblStep.Name = "LblStep";
            this.LblStep.Size = new System.Drawing.Size(56, 17);
            this.LblStep.TabIndex = 14;
            this.LblStep.Text = "Step by";
            // 
            // NumStep
            // 
            this.NumStep.Location = new System.Drawing.Point(71, 267);
            this.NumStep.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NumStep.Name = "NumStep";
            this.NumStep.Size = new System.Drawing.Size(120, 22);
            this.NumStep.TabIndex = 15;
            this.NumStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmStateMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 330);
            this.Controls.Add(this.LblWhileMode);
            this.Controls.Add(this.LblForMode);
            this.Controls.Add(this.LblDoWhileMode);
            this.Controls.Add(this.NumStep);
            this.Controls.Add(this.LblStep);
            this.Controls.Add(this.NumEnd);
            this.Controls.Add(this.LblEnd);
            this.Controls.Add(this.LblStart);
            this.Controls.Add(this.NumStart);
            this.Controls.Add(this.CmdRun);
            this.Controls.Add(this.TbxOutput);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.CmdChangeMode);
            this.Name = "FrmStateMachine";
            this.Text = "State Management";
            ((System.ComponentModel.ISupportInitialize)(this.NumStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdChangeMode;
        private System.Windows.Forms.Label LblDoWhileMode;
        private System.Windows.Forms.Label LblWhileMode;
        private System.Windows.Forms.Label LblForMode;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.TextBox TbxOutput;
        private System.Windows.Forms.Button CmdRun;
        private System.Windows.Forms.NumericUpDown NumStart;
        private System.Windows.Forms.Label LblStart;
        private System.Windows.Forms.Label LblEnd;
        private System.Windows.Forms.NumericUpDown NumEnd;
        private System.Windows.Forms.Label LblStep;
        private System.Windows.Forms.NumericUpDown NumStep;
    }
}

