namespace Bwz.Rappi
{
    partial class FileForm
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
            this.LblFileList = new System.Windows.Forms.Label();
            this.CmdReadFile = new System.Windows.Forms.Button();
            this.LblFileSelection = new System.Windows.Forms.Label();
            this.TbxSelectedFile = new System.Windows.Forms.TextBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdReadFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblFileList
            // 
            this.LblFileList.AutoSize = true;
            this.LblFileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFileList.Location = new System.Drawing.Point(12, 9);
            this.LblFileList.Name = "LblFileList";
            this.LblFileList.Size = new System.Drawing.Size(78, 25);
            this.LblFileList.TabIndex = 0;
            this.LblFileList.Text = "File List";
            // 
            // CmdReadFile
            // 
            this.CmdReadFile.Location = new System.Drawing.Point(381, 91);
            this.CmdReadFile.Name = "CmdReadFile";
            this.CmdReadFile.Size = new System.Drawing.Size(116, 27);
            this.CmdReadFile.TabIndex = 1;
            this.CmdReadFile.Text = "Read File";
            this.CmdReadFile.UseVisualStyleBackColor = true;
            this.CmdReadFile.Click += new System.EventHandler(this.CmdReadFile_Click);
            // 
            // LblFileSelection
            // 
            this.LblFileSelection.AutoSize = true;
            this.LblFileSelection.Location = new System.Drawing.Point(14, 56);
            this.LblFileSelection.Name = "LblFileSelection";
            this.LblFileSelection.Size = new System.Drawing.Size(89, 17);
            this.LblFileSelection.TabIndex = 2;
            this.LblFileSelection.Text = "Selected file:";
            // 
            // TbxSelectedFile
            // 
            this.TbxSelectedFile.Enabled = false;
            this.TbxSelectedFile.Location = new System.Drawing.Point(173, 53);
            this.TbxSelectedFile.Name = "TbxSelectedFile";
            this.TbxSelectedFile.Size = new System.Drawing.Size(324, 22);
            this.TbxSelectedFile.TabIndex = 3;
            this.TbxSelectedFile.Text = "Nothing selected yet.";
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(259, 91);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(116, 27);
            this.CmdSave.TabIndex = 4;
            this.CmdSave.Text = "Save File";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdReadFolder
            // 
            this.CmdReadFolder.Location = new System.Drawing.Point(137, 90);
            this.CmdReadFolder.Name = "CmdReadFolder";
            this.CmdReadFolder.Size = new System.Drawing.Size(116, 27);
            this.CmdReadFolder.TabIndex = 5;
            this.CmdReadFolder.Text = "Read Folder";
            this.CmdReadFolder.UseVisualStyleBackColor = true;
            this.CmdReadFolder.Click += new System.EventHandler(this.CmdReadFolder_Click);
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 129);
            this.Controls.Add(this.CmdReadFolder);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.TbxSelectedFile);
            this.Controls.Add(this.LblFileSelection);
            this.Controls.Add(this.CmdReadFile);
            this.Controls.Add(this.LblFileList);
            this.Name = "FileForm";
            this.Text = "File Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFileList;
        private System.Windows.Forms.Button CmdReadFile;
        private System.Windows.Forms.Label LblFileSelection;
        private System.Windows.Forms.TextBox TbxSelectedFile;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdReadFolder;
    }
}

