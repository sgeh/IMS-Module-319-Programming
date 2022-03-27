
namespace Bwz.Rappi
{
    partial class FrmRecursion
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
            this.BtnDoLoop = new System.Windows.Forms.Button();
            this.TbxOutput = new System.Windows.Forms.TextBox();
            this.NumStart = new System.Windows.Forms.NumericUpDown();
            this.NumEnd = new System.Windows.Forms.NumericUpDown();
            this.LblStart = new System.Windows.Forms.Label();
            this.LblEnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDoLoop
            // 
            this.BtnDoLoop.Location = new System.Drawing.Point(405, 176);
            this.BtnDoLoop.Name = "BtnDoLoop";
            this.BtnDoLoop.Size = new System.Drawing.Size(117, 29);
            this.BtnDoLoop.TabIndex = 0;
            this.BtnDoLoop.Text = "Loop Yay!";
            this.BtnDoLoop.UseVisualStyleBackColor = true;
            this.BtnDoLoop.Click += new System.EventHandler(this.BtnDoLoop_Click);
            // 
            // TbxOutput
            // 
            this.TbxOutput.Location = new System.Drawing.Point(330, 12);
            this.TbxOutput.Multiline = true;
            this.TbxOutput.Name = "TbxOutput";
            this.TbxOutput.Size = new System.Drawing.Size(192, 145);
            this.TbxOutput.TabIndex = 1;
            // 
            // NumStart
            // 
            this.NumStart.Location = new System.Drawing.Point(126, 13);
            this.NumStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumStart.Name = "NumStart";
            this.NumStart.Size = new System.Drawing.Size(120, 22);
            this.NumStart.TabIndex = 2;
            this.NumStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumEnd
            // 
            this.NumEnd.Location = new System.Drawing.Point(126, 41);
            this.NumEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumEnd.Name = "NumEnd";
            this.NumEnd.Size = new System.Drawing.Size(120, 22);
            this.NumEnd.TabIndex = 3;
            this.NumEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.Location = new System.Drawing.Point(12, 15);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(38, 17);
            this.LblStart.TabIndex = 4;
            this.LblStart.Text = "Start";
            // 
            // LblEnd
            // 
            this.LblEnd.AutoSize = true;
            this.LblEnd.Location = new System.Drawing.Point(12, 43);
            this.LblEnd.Name = "LblEnd";
            this.LblEnd.Size = new System.Drawing.Size(41, 17);
            this.LblEnd.TabIndex = 5;
            this.LblEnd.Text = "Ende";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 217);
            this.Controls.Add(this.LblEnd);
            this.Controls.Add(this.LblStart);
            this.Controls.Add(this.NumEnd);
            this.Controls.Add(this.NumStart);
            this.Controls.Add(this.TbxOutput);
            this.Controls.Add(this.BtnDoLoop);
            this.Name = "Form1";
            this.Text = "Rekursion";
            ((System.ComponentModel.ISupportInitialize)(this.NumStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDoLoop;
        private System.Windows.Forms.TextBox TbxOutput;
        private System.Windows.Forms.NumericUpDown NumStart;
        private System.Windows.Forms.NumericUpDown NumEnd;
        private System.Windows.Forms.Label LblStart;
        private System.Windows.Forms.Label LblEnd;
    }
}

