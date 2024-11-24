namespace Bwz.Rappi
{
    partial class CollectionForm
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
            this.CmdInsert = new System.Windows.Forms.Button();
            this.CmdPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxToInsert = new System.Windows.Forms.TextBox();
            this.CmdExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxOutput = new System.Windows.Forms.TextBox();
            this.CmdClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdInsert
            // 
            this.CmdInsert.Location = new System.Drawing.Point(268, 174);
            this.CmdInsert.Name = "CmdInsert";
            this.CmdInsert.Size = new System.Drawing.Size(176, 57);
            this.CmdInsert.TabIndex = 0;
            this.CmdInsert.Text = "insert";
            this.CmdInsert.UseVisualStyleBackColor = true;
            this.CmdInsert.Click += new System.EventHandler(this.CmdInsert_Click);
            // 
            // CmdPrint
            // 
            this.CmdPrint.Location = new System.Drawing.Point(571, 276);
            this.CmdPrint.Name = "CmdPrint";
            this.CmdPrint.Size = new System.Drawing.Size(176, 57);
            this.CmdPrint.TabIndex = 1;
            this.CmdPrint.Text = "print all";
            this.CmdPrint.UseVisualStyleBackColor = true;
            this.CmdPrint.Click += new System.EventHandler(this.CmdPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Collections Applied";
            // 
            // TbxToInsert
            // 
            this.TbxToInsert.Location = new System.Drawing.Point(19, 116);
            this.TbxToInsert.Name = "TbxToInsert";
            this.TbxToInsert.Size = new System.Drawing.Size(415, 38);
            this.TbxToInsert.TabIndex = 3;
            this.TbxToInsert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxToInsert_KeyPress);
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(770, 276);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(176, 57);
            this.CmdExit.TabIndex = 4;
            this.CmdExit.Text = "exit";
            this.CmdExit.UseVisualStyleBackColor = true;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Value to insert:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stored values:";
            // 
            // TbxOutput
            // 
            this.TbxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxOutput.Location = new System.Drawing.Point(522, 116);
            this.TbxOutput.Multiline = true;
            this.TbxOutput.Name = "TbxOutput";
            this.TbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbxOutput.Size = new System.Drawing.Size(424, 101);
            this.TbxOutput.TabIndex = 7;
            // 
            // CmdClear
            // 
            this.CmdClear.Enabled = false;
            this.CmdClear.Location = new System.Drawing.Point(372, 276);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(176, 57);
            this.CmdClear.TabIndex = 8;
            this.CmdClear.Text = "clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 360);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.TbxOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmdExit);
            this.Controls.Add(this.TbxToInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdPrint);
            this.Controls.Add(this.CmdInsert);
            this.Name = "CollectionForm";
            this.Text = "Collections Exercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdInsert;
        private System.Windows.Forms.Button CmdPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxToInsert;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxOutput;
        private System.Windows.Forms.Button CmdClear;
    }
}

