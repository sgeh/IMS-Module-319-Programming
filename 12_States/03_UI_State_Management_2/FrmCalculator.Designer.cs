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
            ((System.ComponentModel.ISupportInitialize)(this.NumLeftOperand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRightOperand)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalculate.Location = new System.Drawing.Point(292, 40);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(38, 27);
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
            this.NumLeftOperand.Location = new System.Drawing.Point(12, 43);
            this.NumLeftOperand.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumLeftOperand.Name = "NumLeftOperand";
            this.NumLeftOperand.Size = new System.Drawing.Size(120, 22);
            this.NumLeftOperand.TabIndex = 10;
            // 
            // LblOperator
            // 
            this.LblOperator.AutoSize = true;
            this.LblOperator.Location = new System.Drawing.Point(138, 45);
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
            this.NumRightOperand.Location = new System.Drawing.Point(156, 43);
            this.NumRightOperand.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumRightOperand.Name = "NumRightOperand";
            this.NumRightOperand.Size = new System.Drawing.Size(120, 22);
            this.NumRightOperand.TabIndex = 12;
            // 
            // LblResult
            // 
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(347, 45);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(209, 27);
            this.LblResult.TabIndex = 13;
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(347, 75);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(40, 17);
            this.LblError.TabIndex = 14;
            this.LblError.Text = "Div/0";
            this.LblError.Visible = false;
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 101);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.NumRightOperand);
            this.Controls.Add(this.LblOperator);
            this.Controls.Add(this.NumLeftOperand);
            this.Controls.Add(this.BtnCalculate);
            this.Name = "FrmCalculator";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.NumLeftOperand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRightOperand)).EndInit();
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
    }
}

