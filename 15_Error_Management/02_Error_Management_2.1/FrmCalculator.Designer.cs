
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
            this.BtnConvert = new System.Windows.Forms.Button();
            this.LblInput = new System.Windows.Forms.Label();
            this.LblCurrencyConverter = new System.Windows.Forms.Label();
            this.TbxInput = new System.Windows.Forms.TextBox();
            this.TbxRate = new System.Windows.Forms.TextBox();
            this.TbxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDirection = new System.Windows.Forms.Label();
            this.LblInputError = new System.Windows.Forms.Label();
            this.LblRateError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConvert
            // 
            this.BtnConvert.Location = new System.Drawing.Point(326, 74);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(100, 29);
            this.BtnConvert.TabIndex = 0;
            this.BtnConvert.Text = "Convert";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // LblInput
            // 
            this.LblInput.AutoSize = true;
            this.LblInput.Location = new System.Drawing.Point(15, 9);
            this.LblInput.Name = "LblInput";
            this.LblInput.Size = new System.Drawing.Size(86, 17);
            this.LblInput.TabIndex = 1;
            this.LblInput.Text = "Input: (EUR)";
            // 
            // LblCurrencyConverter
            // 
            this.LblCurrencyConverter.AutoSize = true;
            this.LblCurrencyConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrencyConverter.Location = new System.Drawing.Point(12, 9);
            this.LblCurrencyConverter.Name = "LblCurrencyConverter";
            this.LblCurrencyConverter.Size = new System.Drawing.Size(0, 25);
            this.LblCurrencyConverter.TabIndex = 2;
            // 
            // TbxInput
            // 
            this.TbxInput.Location = new System.Drawing.Point(18, 29);
            this.TbxInput.Name = "TbxInput";
            this.TbxInput.Size = new System.Drawing.Size(100, 22);
            this.TbxInput.TabIndex = 3;
            // 
            // TbxRate
            // 
            this.TbxRate.Location = new System.Drawing.Point(146, 29);
            this.TbxRate.Name = "TbxRate";
            this.TbxRate.Size = new System.Drawing.Size(100, 22);
            this.TbxRate.TabIndex = 5;
            this.TbxRate.Text = "0.98";
            // 
            // TbxResult
            // 
            this.TbxResult.Enabled = false;
            this.TbxResult.Location = new System.Drawing.Point(326, 29);
            this.TbxResult.Name = "TbxResult";
            this.TbxResult.Size = new System.Drawing.Size(100, 22);
            this.TbxResult.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output: (CHF)";
            // 
            // LblDirection
            // 
            this.LblDirection.AutoSize = true;
            this.LblDirection.Location = new System.Drawing.Point(143, 9);
            this.LblDirection.Name = "LblDirection";
            this.LblDirection.Size = new System.Drawing.Size(161, 17);
            this.LblDirection.TabIndex = 7;
            this.LblDirection.Text = "Rate: (1 CHF -> ... EUR)";
            // 
            // LblInputError
            // 
            this.LblInputError.AutoSize = true;
            this.LblInputError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInputError.ForeColor = System.Drawing.Color.Red;
            this.LblInputError.Location = new System.Drawing.Point(15, 54);
            this.LblInputError.Name = "LblInputError";
            this.LblInputError.Size = new System.Drawing.Size(89, 13);
            this.LblInputError.TabIndex = 7;
            this.LblInputError.Text = "Input must be >0.";
            this.LblInputError.Visible = false;
            // 
            // LblRateError
            // 
            this.LblRateError.AutoSize = true;
            this.LblRateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRateError.ForeColor = System.Drawing.Color.Red;
            this.LblRateError.Location = new System.Drawing.Point(143, 54);
            this.LblRateError.Name = "LblRateError";
            this.LblRateError.Size = new System.Drawing.Size(87, 13);
            this.LblRateError.TabIndex = 8;
            this.LblRateError.Text = "Rate must be >0.";
            this.LblRateError.Visible = false;
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 114);
            this.Controls.Add(this.LblRateError);
            this.Controls.Add(this.LblInputError);
            this.Controls.Add(this.LblDirection);
            this.Controls.Add(this.TbxRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxResult);
            this.Controls.Add(this.TbxInput);
            this.Controls.Add(this.LblCurrencyConverter);
            this.Controls.Add(this.LblInput);
            this.Controls.Add(this.BtnConvert);
            this.Name = "FrmCalculator";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.Label LblInput;
        private System.Windows.Forms.Label LblCurrencyConverter;
        private System.Windows.Forms.TextBox TbxInput;
        private System.Windows.Forms.TextBox TbxRate;
        private System.Windows.Forms.TextBox TbxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDirection;
        private System.Windows.Forms.Label LblInputError;
        private System.Windows.Forms.Label LblRateError;
    }
}

