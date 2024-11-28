
namespace Bwz.Rappi
{
    partial class FrmPythagoras
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPythagoras));
            this.LblPythagoras = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GpxHelp = new System.Windows.Forms.GroupBox();
            this.GpxInputElements = new System.Windows.Forms.GroupBox();
            this.TbxThird = new System.Windows.Forms.TextBox();
            this.TbxSecond = new System.Windows.Forms.TextBox();
            this.TbxFirst = new System.Windows.Forms.TextBox();
            this.LblThrid = new System.Windows.Forms.Label();
            this.LblSecond = new System.Windows.Forms.Label();
            this.LblFirst = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblErrorFirst = new System.Windows.Forms.Label();
            this.LblErrorSecond = new System.Windows.Forms.Label();
            this.LblErrorThird = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GpxHelp.SuspendLayout();
            this.GpxInputElements.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPythagoras
            // 
            this.LblPythagoras.AutoSize = true;
            this.LblPythagoras.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPythagoras.Location = new System.Drawing.Point(12, 9);
            this.LblPythagoras.Name = "LblPythagoras";
            this.LblPythagoras.Size = new System.Drawing.Size(309, 38);
            this.LblPythagoras.TabIndex = 0;
            this.LblPythagoras.Text = "Pythagoras berechnen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(15, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 149);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GpxHelp
            // 
            this.GpxHelp.Controls.Add(this.pictureBox1);
            this.GpxHelp.Location = new System.Drawing.Point(12, 62);
            this.GpxHelp.Name = "GpxHelp";
            this.GpxHelp.Size = new System.Drawing.Size(309, 192);
            this.GpxHelp.TabIndex = 2;
            this.GpxHelp.TabStop = false;
            this.GpxHelp.Text = "Pythagoras Triangle";
            // 
            // GpxInputElements
            // 
            this.GpxInputElements.Controls.Add(this.LblErrorThird);
            this.GpxInputElements.Controls.Add(this.LblErrorSecond);
            this.GpxInputElements.Controls.Add(this.LblErrorFirst);
            this.GpxInputElements.Controls.Add(this.TbxThird);
            this.GpxInputElements.Controls.Add(this.TbxSecond);
            this.GpxInputElements.Controls.Add(this.TbxFirst);
            this.GpxInputElements.Controls.Add(this.LblThrid);
            this.GpxInputElements.Controls.Add(this.LblSecond);
            this.GpxInputElements.Controls.Add(this.LblFirst);
            this.GpxInputElements.Location = new System.Drawing.Point(12, 260);
            this.GpxInputElements.Name = "GpxInputElements";
            this.GpxInputElements.Size = new System.Drawing.Size(309, 247);
            this.GpxInputElements.TabIndex = 3;
            this.GpxInputElements.TabStop = false;
            this.GpxInputElements.Text = "Calculation";
            // 
            // TbxThird
            // 
            this.TbxThird.Enabled = false;
            this.TbxThird.Location = new System.Drawing.Point(15, 195);
            this.TbxThird.Name = "TbxThird";
            this.TbxThird.Size = new System.Drawing.Size(275, 27);
            this.TbxThird.TabIndex = 5;
            // 
            // TbxSecond
            // 
            this.TbxSecond.Location = new System.Drawing.Point(15, 120);
            this.TbxSecond.Name = "TbxSecond";
            this.TbxSecond.Size = new System.Drawing.Size(275, 27);
            this.TbxSecond.TabIndex = 4;
            // 
            // TbxFirst
            // 
            this.TbxFirst.Location = new System.Drawing.Point(15, 50);
            this.TbxFirst.Name = "TbxFirst";
            this.TbxFirst.Size = new System.Drawing.Size(275, 27);
            this.TbxFirst.TabIndex = 3;
            // 
            // LblThrid
            // 
            this.LblThrid.AutoSize = true;
            this.LblThrid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblThrid.Location = new System.Drawing.Point(15, 172);
            this.LblThrid.Name = "LblThrid";
            this.LblThrid.Size = new System.Drawing.Size(133, 20);
            this.LblThrid.TabIndex = 2;
            this.LblThrid.Text = "c = √(a^2 + b^2)";
            // 
            // LblSecond
            // 
            this.LblSecond.AutoSize = true;
            this.LblSecond.Location = new System.Drawing.Point(15, 97);
            this.LblSecond.Name = "LblSecond";
            this.LblSecond.Size = new System.Drawing.Size(18, 20);
            this.LblSecond.TabIndex = 1;
            this.LblSecond.Text = "b";
            // 
            // LblFirst
            // 
            this.LblFirst.AutoSize = true;
            this.LblFirst.Location = new System.Drawing.Point(15, 27);
            this.LblFirst.Name = "LblFirst";
            this.LblFirst.Size = new System.Drawing.Size(17, 20);
            this.LblFirst.TabIndex = 0;
            this.LblFirst.Text = "a";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(227, 513);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(94, 29);
            this.BtnCalculate.TabIndex = 4;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(127, 513);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnClear.Size = new System.Drawing.Size(94, 29);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblErrorFirst
            // 
            this.LblErrorFirst.AutoSize = true;
            this.LblErrorFirst.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblErrorFirst.ForeColor = System.Drawing.Color.Red;
            this.LblErrorFirst.Location = new System.Drawing.Point(15, 80);
            this.LblErrorFirst.Name = "LblErrorFirst";
            this.LblErrorFirst.Size = new System.Drawing.Size(76, 15);
            this.LblErrorFirst.TabIndex = 6;
            this.LblErrorFirst.Text = "Invalid input!";
            this.LblErrorFirst.Visible = false;
            // 
            // LblErrorSecond
            // 
            this.LblErrorSecond.AutoSize = true;
            this.LblErrorSecond.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblErrorSecond.ForeColor = System.Drawing.Color.Red;
            this.LblErrorSecond.Location = new System.Drawing.Point(15, 150);
            this.LblErrorSecond.Name = "LblErrorSecond";
            this.LblErrorSecond.Size = new System.Drawing.Size(76, 15);
            this.LblErrorSecond.TabIndex = 7;
            this.LblErrorSecond.Text = "Invalid input!";
            this.LblErrorSecond.Visible = false;
            // 
            // LblErrorThird
            // 
            this.LblErrorThird.AutoSize = true;
            this.LblErrorThird.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblErrorThird.ForeColor = System.Drawing.Color.Red;
            this.LblErrorThird.Location = new System.Drawing.Point(15, 225);
            this.LblErrorThird.Name = "LblErrorThird";
            this.LblErrorThird.Size = new System.Drawing.Size(76, 15);
            this.LblErrorThird.TabIndex = 8;
            this.LblErrorThird.Text = "Invalid input!";
            this.LblErrorThird.Visible = false;
            // 
            // FrmPythagoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 554);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.GpxInputElements);
            this.Controls.Add(this.GpxHelp);
            this.Controls.Add(this.LblPythagoras);
            this.Name = "FrmPythagoras";
            this.Text = "Pythagoras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GpxHelp.ResumeLayout(false);
            this.GpxInputElements.ResumeLayout(false);
            this.GpxInputElements.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPythagoras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GpxHelp;
        private System.Windows.Forms.GroupBox GpxInputElements;
        private System.Windows.Forms.TextBox TbxThird;
        private System.Windows.Forms.TextBox TbxSecond;
        private System.Windows.Forms.TextBox TbxFirst;
        private System.Windows.Forms.Label LblThrid;
        private System.Windows.Forms.Label LblSecond;
        private System.Windows.Forms.Label LblFirst;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LblErrorThird;
        private System.Windows.Forms.Label LblErrorSecond;
        private System.Windows.Forms.Label LblErrorFirst;
    }
}

