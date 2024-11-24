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
            this.FplButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.TplInput = new System.Windows.Forms.TableLayoutPanel();
            this.FplButtons.SuspendLayout();
            this.TplInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdInsert
            // 
            this.CmdInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdInsert.Location = new System.Drawing.Point(124, 48);
            this.CmdInsert.Margin = new System.Windows.Forms.Padding(2);
            this.CmdInsert.Name = "CmdInsert";
            this.CmdInsert.Size = new System.Drawing.Size(88, 29);
            this.CmdInsert.TabIndex = 0;
            this.CmdInsert.Text = "insert";
            this.CmdInsert.UseVisualStyleBackColor = true;
            // 
            // CmdPrint
            // 
            this.CmdPrint.Location = new System.Drawing.Point(285, 2);
            this.CmdPrint.Margin = new System.Windows.Forms.Padding(2);
            this.CmdPrint.Name = "CmdPrint";
            this.CmdPrint.Size = new System.Drawing.Size(88, 29);
            this.CmdPrint.TabIndex = 1;
            this.CmdPrint.Text = "print all";
            this.CmdPrint.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Collections Applied";
            // 
            // TbxToInsert
            // 
            this.TbxToInsert.Location = new System.Drawing.Point(2, 22);
            this.TbxToInsert.Margin = new System.Windows.Forms.Padding(2);
            this.TbxToInsert.Name = "TbxToInsert";
            this.TbxToInsert.Size = new System.Drawing.Size(210, 22);
            this.TbxToInsert.TabIndex = 3;
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(377, 2);
            this.CmdExit.Margin = new System.Windows.Forms.Padding(2);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(88, 29);
            this.CmdExit.TabIndex = 4;
            this.CmdExit.Text = "exit";
            this.CmdExit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Value to insert:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stored values:";
            // 
            // TbxOutput
            // 
            this.TbxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxOutput.Location = new System.Drawing.Point(261, 60);
            this.TbxOutput.Margin = new System.Windows.Forms.Padding(2);
            this.TbxOutput.Multiline = true;
            this.TbxOutput.Name = "TbxOutput";
            this.TbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbxOutput.Size = new System.Drawing.Size(214, 54);
            this.TbxOutput.TabIndex = 7;
            // 
            // CmdClear
            // 
            this.CmdClear.Enabled = false;
            this.CmdClear.Location = new System.Drawing.Point(193, 2);
            this.CmdClear.Margin = new System.Windows.Forms.Padding(2);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(88, 29);
            this.CmdClear.TabIndex = 8;
            this.CmdClear.Text = "clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            // 
            // FplButtons
            // 
            this.FplButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FplButtons.Controls.Add(this.CmdExit);
            this.FplButtons.Controls.Add(this.CmdPrint);
            this.FplButtons.Controls.Add(this.CmdClear);
            this.FplButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FplButtons.Location = new System.Drawing.Point(9, 148);
            this.FplButtons.Name = "FplButtons";
            this.FplButtons.Size = new System.Drawing.Size(467, 69);
            this.FplButtons.TabIndex = 9;
            // 
            // TplInput
            // 
            this.TplInput.ColumnCount = 1;
            this.TplInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.TplInput.Controls.Add(this.TbxToInsert, 0, 1);
            this.TplInput.Controls.Add(this.label2, 0, 0);
            this.TplInput.Controls.Add(this.CmdInsert, 0, 2);
            this.TplInput.Location = new System.Drawing.Point(9, 45);
            this.TplInput.Name = "TplInput";
            this.TplInput.RowCount = 3;
            this.TplInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TplInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.TplInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TplInput.Size = new System.Drawing.Size(214, 81);
            this.TplInput.TabIndex = 10;
            // 
            // CollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 229);
            this.Controls.Add(this.TplInput);
            this.Controls.Add(this.FplButtons);
            this.Controls.Add(this.TbxOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(506, 276);
            this.Name = "CollectionForm";
            this.Text = "Collections Exercise";
            this.FplButtons.ResumeLayout(false);
            this.TplInput.ResumeLayout(false);
            this.TplInput.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel FplButtons;
        private System.Windows.Forms.TableLayoutPanel TplInput;
    }
}

