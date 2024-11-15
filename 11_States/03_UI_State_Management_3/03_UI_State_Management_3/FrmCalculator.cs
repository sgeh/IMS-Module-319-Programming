using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bwz.Rappi
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            
            double leftValue = (double)NumLeftOperand.Value;
            double rightValue = (double)NumRightOperand.Value;
            double result = 0;

            LblError.Visible = false;

            switch (LblOperator.Text)
            {
                case "/":
                    {
                        if (rightValue != 0.0)
                        {
                            result = leftValue / rightValue;
                        }
                        else
                        {
                            LblError.Visible = true;
                        }
                        break;
                    }
                case "*":
                    {
                        result = leftValue * rightValue;
                        break;
                    }
                case "-":
                    {
                        result = leftValue - rightValue;
                        break;
                    }
                case "+":
                    {
                        result = leftValue + rightValue;
                        break;
                    }
            }

            LblResult.Text = $"{result:0.0000}";
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            LblOperator.Text = "/";
        }

        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            LblOperator.Text = "*";
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            LblOperator.Text = "-";
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            LblOperator.Text = "+";
        }
    }
}
