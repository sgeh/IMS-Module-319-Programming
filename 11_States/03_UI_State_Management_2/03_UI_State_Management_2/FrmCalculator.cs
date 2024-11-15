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

            if (rightValue != 0.0)
            {
                LblError.Visible = false;
                LblResult.Text = $"{leftValue / rightValue:0.0000}";
            }
            else
            {
                LblError.Visible = true;
            }
        }
    }
}
