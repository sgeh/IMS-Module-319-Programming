
namespace Bwz.Rappi
{
    partial class FrmSearch
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
            this.LblSearchPatternCaption = new System.Windows.Forms.Label();
            this.LblFolderCaption = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LblFolder = new System.Windows.Forms.Label();
            this.TbxSearchPattern = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDoLoop
            // 
            this.BtnDoLoop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDoLoop.Location = new System.Drawing.Point(405, 236);
            this.BtnDoLoop.Name = "BtnDoLoop";
            this.BtnDoLoop.Size = new System.Drawing.Size(117, 29);
            this.BtnDoLoop.TabIndex = 0;
            this.BtnDoLoop.Text = "Search";
            this.BtnDoLoop.UseVisualStyleBackColor = true;
            this.BtnDoLoop.Click += new System.EventHandler(this.BtnDoLoop_Click);
            // 
            // TbxOutput
            // 
            this.TbxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxOutput.Location = new System.Drawing.Point(15, 69);
            this.TbxOutput.Multiline = true;
            this.TbxOutput.Name = "TbxOutput";
            this.TbxOutput.ReadOnly = true;
            this.TbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbxOutput.Size = new System.Drawing.Size(507, 145);
            this.TbxOutput.TabIndex = 1;
            // 
            // LblSearchPatternCaption
            // 
            this.LblSearchPatternCaption.AutoSize = true;
            this.LblSearchPatternCaption.Location = new System.Drawing.Point(12, 15);
            this.LblSearchPatternCaption.Name = "LblSearchPatternCaption";
            this.LblSearchPatternCaption.Size = new System.Drawing.Size(107, 17);
            this.LblSearchPatternCaption.TabIndex = 4;
            this.LblSearchPatternCaption.Text = "Search Pattern:";
            // 
            // LblFolderCaption
            // 
            this.LblFolderCaption.AutoSize = true;
            this.LblFolderCaption.Location = new System.Drawing.Point(12, 43);
            this.LblFolderCaption.Name = "LblFolderCaption";
            this.LblFolderCaption.Size = new System.Drawing.Size(111, 17);
            this.LblFolderCaption.TabIndex = 5;
            this.LblFolderCaption.Text = "Selected Folder:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(282, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblFolder
            // 
            this.LblFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFolder.Location = new System.Drawing.Point(132, 43);
            this.LblFolder.Name = "LblFolder";
            this.LblFolder.Size = new System.Drawing.Size(390, 23);
            this.LblFolder.TabIndex = 7;
            this.LblFolder.Text = " ";
            // 
            // TbxSearchPattern
            // 
            this.TbxSearchPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxSearchPattern.Location = new System.Drawing.Point(132, 15);
            this.TbxSearchPattern.Name = "TbxSearchPattern";
            this.TbxSearchPattern.Size = new System.Drawing.Size(390, 22);
            this.TbxSearchPattern.TabIndex = 8;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 277);
            this.Controls.Add(this.TbxSearchPattern);
            this.Controls.Add(this.LblFolder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblFolderCaption);
            this.Controls.Add(this.LblSearchPatternCaption);
            this.Controls.Add(this.TbxOutput);
            this.Controls.Add(this.BtnDoLoop);
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "FrmSearch";
            this.Text = "Rekursion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDoLoop;
        private System.Windows.Forms.TextBox TbxOutput;
        private System.Windows.Forms.Label LblSearchPatternCaption;
        private System.Windows.Forms.Label LblFolderCaption;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblFolder;
        private System.Windows.Forms.TextBox TbxSearchPattern;
    }
}

