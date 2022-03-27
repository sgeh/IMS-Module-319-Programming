
namespace PythagorasWinApp
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
            this.LblErrorC = new System.Windows.Forms.Label();
            this.LblErrorB = new System.Windows.Forms.Label();
            this.LblErrorA = new System.Windows.Forms.Label();
            this.TbxC = new System.Windows.Forms.TextBox();
            this.TbxB = new System.Windows.Forms.TextBox();
            this.TbxA = new System.Windows.Forms.TextBox();
            this.LblC = new System.Windows.Forms.Label();
            this.LblB = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.GpxMode = new System.Windows.Forms.GroupBox();
            this.CbxCalcA = new System.Windows.Forms.RadioButton();
            this.CbxCalcB = new System.Windows.Forms.RadioButton();
            this.CbxCalcC = new System.Windows.Forms.RadioButton();
            this.RbtUseHeron = new System.Windows.Forms.RadioButton();
            this.CbxUseMath = new System.Windows.Forms.RadioButton();
            this.GpxSettings = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GpxHelp.SuspendLayout();
            this.GpxInputElements.SuspendLayout();
            this.GpxMode.SuspendLayout();
            this.GpxSettings.SuspendLayout();
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
            this.GpxInputElements.Controls.Add(this.LblErrorC);
            this.GpxInputElements.Controls.Add(this.LblErrorB);
            this.GpxInputElements.Controls.Add(this.LblErrorA);
            this.GpxInputElements.Controls.Add(this.TbxC);
            this.GpxInputElements.Controls.Add(this.TbxB);
            this.GpxInputElements.Controls.Add(this.TbxA);
            this.GpxInputElements.Controls.Add(this.LblC);
            this.GpxInputElements.Controls.Add(this.LblB);
            this.GpxInputElements.Controls.Add(this.LblA);
            this.GpxInputElements.Location = new System.Drawing.Point(12, 260);
            this.GpxInputElements.Name = "GpxInputElements";
            this.GpxInputElements.Size = new System.Drawing.Size(309, 247);
            this.GpxInputElements.TabIndex = 3;
            this.GpxInputElements.TabStop = false;
            this.GpxInputElements.Text = "Calculation";
            // 
            // LblErrorC
            // 
            this.LblErrorC.AutoSize = true;
            this.LblErrorC.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblErrorC.ForeColor = System.Drawing.Color.Red;
            this.LblErrorC.Location = new System.Drawing.Point(15, 225);
            this.LblErrorC.Name = "LblErrorC";
            this.LblErrorC.Size = new System.Drawing.Size(76, 15);
            this.LblErrorC.TabIndex = 8;
            this.LblErrorC.Text = "Invalid input!";
            this.LblErrorC.Visible = false;
            // 
            // LblErrorB
            // 
            this.LblErrorB.AutoSize = true;
            this.LblErrorB.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblErrorB.ForeColor = System.Drawing.Color.Red;
            this.LblErrorB.Location = new System.Drawing.Point(15, 150);
            this.LblErrorB.Name = "LblErrorB";
            this.LblErrorB.Size = new System.Drawing.Size(76, 15);
            this.LblErrorB.TabIndex = 7;
            this.LblErrorB.Text = "Invalid input!";
            this.LblErrorB.Visible = false;
            // 
            // LblErrorA
            // 
            this.LblErrorA.AutoSize = true;
            this.LblErrorA.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblErrorA.ForeColor = System.Drawing.Color.Red;
            this.LblErrorA.Location = new System.Drawing.Point(15, 80);
            this.LblErrorA.Name = "LblErrorA";
            this.LblErrorA.Size = new System.Drawing.Size(76, 15);
            this.LblErrorA.TabIndex = 6;
            this.LblErrorA.Text = "Invalid input!";
            this.LblErrorA.Visible = false;
            // 
            // TbxC
            // 
            this.TbxC.Enabled = false;
            this.TbxC.Location = new System.Drawing.Point(15, 195);
            this.TbxC.Name = "TbxC";
            this.TbxC.Size = new System.Drawing.Size(275, 27);
            this.TbxC.TabIndex = 5;
            // 
            // TbxB
            // 
            this.TbxB.Location = new System.Drawing.Point(15, 120);
            this.TbxB.Name = "TbxB";
            this.TbxB.Size = new System.Drawing.Size(275, 27);
            this.TbxB.TabIndex = 4;
            // 
            // TbxA
            // 
            this.TbxA.Location = new System.Drawing.Point(15, 50);
            this.TbxA.Name = "TbxA";
            this.TbxA.Size = new System.Drawing.Size(275, 27);
            this.TbxA.TabIndex = 3;
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblC.Location = new System.Drawing.Point(15, 172);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(125, 20);
            this.LblC.TabIndex = 2;
            this.LblC.Text = "c = √(a^2 + b^2)";
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Location = new System.Drawing.Point(15, 97);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(18, 20);
            this.LblB.TabIndex = 1;
            this.LblB.Text = "b";
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(15, 27);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(17, 20);
            this.LblA.TabIndex = 0;
            this.LblA.Text = "a";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(452, 477);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(94, 29);
            this.BtnCalculate.TabIndex = 4;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(343, 478);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnClear.Size = new System.Drawing.Size(94, 29);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // GpxMode
            // 
            this.GpxMode.Controls.Add(this.CbxCalcA);
            this.GpxMode.Controls.Add(this.CbxCalcB);
            this.GpxMode.Controls.Add(this.CbxCalcC);
            this.GpxMode.Location = new System.Drawing.Point(343, 62);
            this.GpxMode.Name = "GpxMode";
            this.GpxMode.Size = new System.Drawing.Size(200, 192);
            this.GpxMode.TabIndex = 3;
            this.GpxMode.TabStop = false;
            this.GpxMode.Text = "Mode";
            // 
            // CbxCalcA
            // 
            this.CbxCalcA.AutoSize = true;
            this.CbxCalcA.Location = new System.Drawing.Point(27, 97);
            this.CbxCalcA.Name = "CbxCalcA";
            this.CbxCalcA.Size = new System.Drawing.Size(103, 24);
            this.CbxCalcA.TabIndex = 11;
            this.CbxCalcA.Text = "Calculate a";
            this.CbxCalcA.UseVisualStyleBackColor = true;
            this.CbxCalcA.CheckedChanged += new System.EventHandler(this.CbxCalcA_CheckedChanged);
            // 
            // CbxCalcB
            // 
            this.CbxCalcB.AutoSize = true;
            this.CbxCalcB.Location = new System.Drawing.Point(27, 67);
            this.CbxCalcB.Name = "CbxCalcB";
            this.CbxCalcB.Size = new System.Drawing.Size(104, 24);
            this.CbxCalcB.TabIndex = 10;
            this.CbxCalcB.Text = "Calculate b";
            this.CbxCalcB.UseVisualStyleBackColor = true;
            this.CbxCalcB.CheckedChanged += new System.EventHandler(this.CbxCalcB_CheckedChanged);
            // 
            // CbxCalcC
            // 
            this.CbxCalcC.AutoSize = true;
            this.CbxCalcC.Checked = true;
            this.CbxCalcC.Location = new System.Drawing.Point(27, 37);
            this.CbxCalcC.Name = "CbxCalcC";
            this.CbxCalcC.Size = new System.Drawing.Size(102, 24);
            this.CbxCalcC.TabIndex = 9;
            this.CbxCalcC.TabStop = true;
            this.CbxCalcC.Text = "Calculate c";
            this.CbxCalcC.UseVisualStyleBackColor = true;
            this.CbxCalcC.CheckedChanged += new System.EventHandler(this.CbxCalcC_CheckedChanged);
            // 
            // RbtUseHeron
            // 
            this.RbtUseHeron.AutoSize = true;
            this.RbtUseHeron.Checked = true;
            this.RbtUseHeron.Location = new System.Drawing.Point(27, 40);
            this.RbtUseHeron.Name = "RbtUseHeron";
            this.RbtUseHeron.Size = new System.Drawing.Size(135, 24);
            this.RbtUseHeron.TabIndex = 0;
            this.RbtUseHeron.TabStop = true;
            this.RbtUseHeron.Text = "Use Heron Algo";
            this.RbtUseHeron.UseVisualStyleBackColor = true;
            // 
            // CbxUseMath
            // 
            this.CbxUseMath.AutoSize = true;
            this.CbxUseMath.Location = new System.Drawing.Point(27, 71);
            this.CbxUseMath.Name = "CbxUseMath";
            this.CbxUseMath.Size = new System.Drawing.Size(132, 24);
            this.CbxUseMath.TabIndex = 1;
            this.CbxUseMath.Text = "Use Math.Sqrt()";
            this.CbxUseMath.UseVisualStyleBackColor = true;
            // 
            // GpxSettings
            // 
            this.GpxSettings.Controls.Add(this.RbtUseHeron);
            this.GpxSettings.Controls.Add(this.CbxUseMath);
            this.GpxSettings.Location = new System.Drawing.Point(343, 260);
            this.GpxSettings.Name = "GpxSettings";
            this.GpxSettings.Size = new System.Drawing.Size(203, 192);
            this.GpxSettings.TabIndex = 6;
            this.GpxSettings.TabStop = false;
            this.GpxSettings.Text = "Settings";
            // 
            // FrmPythagoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 525);
            this.Controls.Add(this.GpxSettings);
            this.Controls.Add(this.GpxMode);
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
            this.GpxMode.ResumeLayout(false);
            this.GpxMode.PerformLayout();
            this.GpxSettings.ResumeLayout(false);
            this.GpxSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPythagoras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GpxHelp;
        private System.Windows.Forms.GroupBox GpxInputElements;
        private System.Windows.Forms.TextBox TbxC;
        private System.Windows.Forms.TextBox TbxB;
        private System.Windows.Forms.TextBox TbxA;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LblErrorC;
        private System.Windows.Forms.Label LblErrorB;
        private System.Windows.Forms.Label LblErrorA;
        private System.Windows.Forms.GroupBox GpxMode;
        private System.Windows.Forms.RadioButton CbxUseMath;
        private System.Windows.Forms.RadioButton RbtUseHeron;
        private System.Windows.Forms.RadioButton CbxCalcA;
        private System.Windows.Forms.RadioButton CbxCalcB;
        private System.Windows.Forms.RadioButton CbxCalcC;
        private System.Windows.Forms.GroupBox GpxSettings;
    }
}

