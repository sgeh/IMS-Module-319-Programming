namespace Bwz.Rappi
{
    partial class FrmCalculator
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
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.NumLeftOperand = new System.Windows.Forms.NumericUpDown();
            this.LblOperator = new System.Windows.Forms.Label();
            this.NumRightOperand = new System.Windows.Forms.NumericUpDown();
            this.LblResult = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.GrpOperators = new System.Windows.Forms.GroupBox();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.BtnMultiplication = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumLeftOperand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRightOperand)).BeginInit();
            this.GrpOperators.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalculate.Location = new System.Drawing.Point(202, 201);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(92, 27);
            this.BtnCalculate.TabIndex = 9;
            this.BtnCalculate.Text = "=";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // NumLeftOperand
            // 
            this.NumLeftOperand.DecimalPlaces = 4;
            this.NumLeftOperand.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NumLeftOperand.Location = new System.Drawing.Point(40, 75);
            this.NumLeftOperand.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NumLeftOperand.Name = "NumLeftOperand";
            this.NumLeftOperand.Size = new System.Drawing.Size(120, 22);
            this.NumLeftOperand.TabIndex = 10;
            // 
            // LblOperator
            // 
            this.LblOperator.AutoSize = true;
            this.LblOperator.Location = new System.Drawing.Point(22, 103);
            this.LblOperator.Name = "LblOperator";
            this.LblOperator.Size = new System.Drawing.Size(12, 17);
            this.LblOperator.TabIndex = 11;
            this.LblOperator.Text = "/";
            // 
            // NumRightOperand
            // 
            this.NumRightOperand.DecimalPlaces = 4;
            this.NumRightOperand.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NumRightOperand.Location = new System.Drawing.Point(40, 103);
            this.NumRightOperand.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NumRightOperand.Name = "NumRightOperand";
            this.NumRightOperand.Size = new System.Drawing.Size(120, 22);
            this.NumRightOperand.TabIndex = 12;
            // 
            // LblResult
            // 
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(80, 22);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(80, 24);
            this.LblResult.TabIndex = 13;
            this.LblResult.Text = " ";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(77, 50);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(40, 17);
            this.LblError.TabIndex = 14;
            this.LblError.Text = "Div/0";
            this.LblError.Visible = false;
            // 
            // GrpOperators
            // 
            this.GrpOperators.Controls.Add(this.BtnPlus);
            this.GrpOperators.Controls.Add(this.BtnMinus);
            this.GrpOperators.Controls.Add(this.BtnMultiplication);
            this.GrpOperators.Controls.Add(this.BtnDivision);
            this.GrpOperators.Location = new System.Drawing.Point(202, 25);
            this.GrpOperators.Name = "GrpOperators";
            this.GrpOperators.Size = new System.Drawing.Size(92, 170);
            this.GrpOperators.TabIndex = 15;
            this.GrpOperators.TabStop = false;
            this.GrpOperators.Text = "Operators";
            // 
            // BtnDivision
            // 
            this.BtnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivision.Location = new System.Drawing.Point(16, 31);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(55, 27);
            this.BtnDivision.TabIndex = 16;
            this.BtnDivision.Text = "÷";
            this.BtnDivision.UseVisualStyleBackColor = true;
            this.BtnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // BtnMultiplication
            // 
            this.BtnMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiplication.Location = new System.Drawing.Point(16, 64);
            this.BtnMultiplication.Name = "BtnMultiplication";
            this.BtnMultiplication.Size = new System.Drawing.Size(55, 27);
            this.BtnMultiplication.TabIndex = 17;
            this.BtnMultiplication.Text = "x";
            this.BtnMultiplication.UseVisualStyleBackColor = true;
            this.BtnMultiplication.Click += new System.EventHandler(this.BtnMultiplication_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinus.Location = new System.Drawing.Point(16, 97);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(55, 27);
            this.BtnMinus.TabIndex = 18;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlus.Location = new System.Drawing.Point(16, 130);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(55, 27);
            this.BtnPlus.TabIndex = 19;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Result:";
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(306, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrpOperators);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.NumRightOperand);
            this.Controls.Add(this.LblOperator);
            this.Controls.Add(this.NumLeftOperand);
            this.Controls.Add(this.BtnCalculate);
            this.Name = "FrmCalculator";
            this.Text = "Calculator - Calc21";
            ((System.ComponentModel.ISupportInitialize)(this.NumLeftOperand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRightOperand)).EndInit();
            this.GrpOperators.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.NumericUpDown NumLeftOperand;
        private System.Windows.Forms.Label LblOperator;
        private System.Windows.Forms.NumericUpDown NumRightOperand;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.GroupBox GrpOperators;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnMultiplication;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.Label label1;
    }
}

