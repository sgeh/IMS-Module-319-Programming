namespace Bwz.Rappi
{
    partial class EditorForm
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
            this.TbxFileContent = new System.Windows.Forms.TextBox();
            this.FlpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.FlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblFileList
            // 
            this.LblFileList.AutoSize = true;
            this.LblFileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFileList.Location = new System.Drawing.Point(12, 11);
            this.LblFileList.Name = "LblFileList";
            this.LblFileList.Size = new System.Drawing.Size(78, 25);
            this.LblFileList.TabIndex = 0;
            this.LblFileList.Text = "File List";
            // 
            // CmdReadFile
            // 
            this.CmdReadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdReadFile.Location = new System.Drawing.Point(369, 4);
            this.CmdReadFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdReadFile.Name = "CmdReadFile";
            this.CmdReadFile.Size = new System.Drawing.Size(116, 34);
            this.CmdReadFile.TabIndex = 1;
            this.CmdReadFile.Text = "Read File";
            this.CmdReadFile.UseVisualStyleBackColor = true;
            this.CmdReadFile.Click += new System.EventHandler(this.CmdReadFile_Click);
            // 
            // LblFileSelection
            // 
            this.LblFileSelection.AutoSize = true;
            this.LblFileSelection.Location = new System.Drawing.Point(14, 70);
            this.LblFileSelection.Name = "LblFileSelection";
            this.LblFileSelection.Size = new System.Drawing.Size(94, 20);
            this.LblFileSelection.TabIndex = 2;
            this.LblFileSelection.Text = "Selected file:";
            // 
            // TbxSelectedFile
            // 
            this.TbxSelectedFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxSelectedFile.Enabled = false;
            this.TbxSelectedFile.Location = new System.Drawing.Point(173, 66);
            this.TbxSelectedFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxSelectedFile.Name = "TbxSelectedFile";
            this.TbxSelectedFile.Size = new System.Drawing.Size(324, 27);
            this.TbxSelectedFile.TabIndex = 3;
            this.TbxSelectedFile.Text = "Nothing selected yet.";
            // 
            // CmdSave
            // 
            this.CmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdSave.Location = new System.Drawing.Point(247, 4);
            this.CmdSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(116, 34);
            this.CmdSave.TabIndex = 4;
            this.CmdSave.Text = "Save File";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdReadFolder
            // 
            this.CmdReadFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdReadFolder.Location = new System.Drawing.Point(125, 4);
            this.CmdReadFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdReadFolder.Name = "CmdReadFolder";
            this.CmdReadFolder.Size = new System.Drawing.Size(116, 34);
            this.CmdReadFolder.TabIndex = 5;
            this.CmdReadFolder.Text = "Read Folder";
            this.CmdReadFolder.UseVisualStyleBackColor = true;
            this.CmdReadFolder.Click += new System.EventHandler(this.CmdReadFolder_Click);
            // 
            // TbxFileContent
            // 
            this.TbxFileContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxFileContent.Location = new System.Drawing.Point(17, 114);
            this.TbxFileContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxFileContent.MinimumSize = new System.Drawing.Size(100, 300);
            this.TbxFileContent.Multiline = true;
            this.TbxFileContent.Name = "TbxFileContent";
            this.TbxFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbxFileContent.Size = new System.Drawing.Size(480, 337);
            this.TbxFileContent.TabIndex = 6;
            // 
            // FlpButtons
            // 
            this.FlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlpButtons.Controls.Add(this.CmdReadFile);
            this.FlpButtons.Controls.Add(this.CmdSave);
            this.FlpButtons.Controls.Add(this.CmdReadFolder);
            this.FlpButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpButtons.Location = new System.Drawing.Point(12, 458);
            this.FlpButtons.Name = "FlpButtons";
            this.FlpButtons.Size = new System.Drawing.Size(488, 83);
            this.FlpButtons.TabIndex = 7;
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 553);
            this.Controls.Add(this.FlpButtons);
            this.Controls.Add(this.TbxFileContent);
            this.Controls.Add(this.TbxSelectedFile);
            this.Controls.Add(this.LblFileSelection);
            this.Controls.Add(this.LblFileList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(300, 450);
            this.Name = "EditorForm";
            this.Text = "File Form";
            this.FlpButtons.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox TbxFileContent;
        private FlowLayoutPanel FlpButtons;
    }
}

