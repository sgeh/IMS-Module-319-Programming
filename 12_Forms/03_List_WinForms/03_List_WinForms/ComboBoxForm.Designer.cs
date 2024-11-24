namespace Bwz.Rappi
{
    partial class ComboBoxForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CmdExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdClear = new System.Windows.Forms.Button();
            this.LbxOutput = new System.Windows.Forms.ListBox();
            this.CbxInput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CmdInsert
            // 
            this.CmdInsert.Location = new System.Drawing.Point(134, 90);
            this.CmdInsert.Margin = new System.Windows.Forms.Padding(2);
            this.CmdInsert.Name = "CmdInsert";
            this.CmdInsert.Size = new System.Drawing.Size(88, 29);
            this.CmdInsert.TabIndex = 0;
            this.CmdInsert.Text = "insert";
            this.CmdInsert.UseVisualStyleBackColor = true;
            this.CmdInsert.Click += new System.EventHandler(this.CmdInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ComboBox Applied";
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(385, 142);
            this.CmdExit.Margin = new System.Windows.Forms.Padding(2);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(88, 29);
            this.CmdExit.TabIndex = 4;
            this.CmdExit.Text = "exit";
            this.CmdExit.UseVisualStyleBackColor = true;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
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
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(284, 142);
            this.CmdClear.Margin = new System.Windows.Forms.Padding(2);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(88, 29);
            this.CmdClear.TabIndex = 8;
            this.CmdClear.Text = "clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // LbxOutput
            // 
            this.LbxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LbxOutput.FormattingEnabled = true;
            this.LbxOutput.ItemHeight = 16;
            this.LbxOutput.Location = new System.Drawing.Point(256, 60);
            this.LbxOutput.Margin = new System.Windows.Forms.Padding(2);
            this.LbxOutput.Name = "LbxOutput";
            this.LbxOutput.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LbxOutput.Size = new System.Drawing.Size(216, 64);
            this.LbxOutput.TabIndex = 9;
            // 
            // CbxInput
            // 
            this.CbxInput.FormattingEnabled = true;
            this.CbxInput.Items.AddRange(new object[] {
            "Pizza",
            "Cannelloni",
            "Spaghetti",
            "Lasagne"});
            this.CbxInput.Location = new System.Drawing.Point(10, 60);
            this.CbxInput.Margin = new System.Windows.Forms.Padding(2);
            this.CbxInput.Name = "CbxInput";
            this.CbxInput.Size = new System.Drawing.Size(214, 24);
            this.CbxInput.TabIndex = 10;
            // 
            // ComboBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 186);
            this.Controls.Add(this.CbxInput);
            this.Controls.Add(this.LbxOutput);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmdExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdInsert);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ComboBoxForm";
            this.Text = "ComboBox Exercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.ListBox LbxOutput;
        private System.Windows.Forms.ComboBox CbxInput;
    }
}

