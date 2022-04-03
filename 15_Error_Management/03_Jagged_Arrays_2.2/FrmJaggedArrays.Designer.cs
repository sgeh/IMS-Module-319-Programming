
namespace Bwz.Rappi
{
    partial class FrmJaggedArrays
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
            this.TbxOutput = new System.Windows.Forms.TextBox();
            this.LblOutput = new System.Windows.Forms.Label();
            this.BtnPrintToTextbox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbxOutput
            // 
            this.TbxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxOutput.Location = new System.Drawing.Point(347, 12);
            this.TbxOutput.Multiline = true;
            this.TbxOutput.Name = "TbxOutput";
            this.TbxOutput.Size = new System.Drawing.Size(175, 145);
            this.TbxOutput.TabIndex = 1;
            // 
            // LblOutput
            // 
            this.LblOutput.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOutput.Location = new System.Drawing.Point(12, 12);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(329, 156);
            this.LblOutput.TabIndex = 2;
            this.LblOutput.Text = "Input:\r\nchar[][] jaggedArray = \r\n{\r\n new char[] { \'A\', \'B\', \'C\', \'D\', \'E\' },\r\n ne" +
    "w char[] { \'A\', \'B\', \'C\', \'D\' },\r\n new char[] { \'A\', \'B\', \'C\' },\r\n new char[] { " +
    "\'A\', \'B\' },\r\n new char[] { \'A\' }\r\n};";
            // 
            // BtnPrintToTextbox
            // 
            this.BtnPrintToTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrintToTextbox.Location = new System.Drawing.Point(388, 177);
            this.BtnPrintToTextbox.Name = "BtnPrintToTextbox";
            this.BtnPrintToTextbox.Size = new System.Drawing.Size(134, 28);
            this.BtnPrintToTextbox.TabIndex = 3;
            this.BtnPrintToTextbox.Text = "Print To Textbox";
            this.BtnPrintToTextbox.UseVisualStyleBackColor = true;
            this.BtnPrintToTextbox.Click += new System.EventHandler(this.BtnPrintToTextbox_Click);
            // 
            // FrmJaggedArrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 217);
            this.Controls.Add(this.BtnPrintToTextbox);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.TbxOutput);
            this.Name = "FrmJaggedArrays";
            this.Text = "Jagged Arrays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbxOutput;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.Button BtnPrintToTextbox;
    }
}

