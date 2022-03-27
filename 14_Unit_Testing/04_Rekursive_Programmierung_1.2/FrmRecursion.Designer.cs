
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 217);
            this.Controls.Add(this.TbxOutput);
            this.Controls.Add(this.BtnDoLoop);
            this.Name = "Form1";
            this.Text = "Rekursion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDoLoop;
        private System.Windows.Forms.TextBox TbxOutput;
    }
}

