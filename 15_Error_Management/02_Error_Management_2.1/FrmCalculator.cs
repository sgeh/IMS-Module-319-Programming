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

        private void BtnDoLoop_Click(object sender, EventArgs e)
        {
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            TbxResult.Text = "";
            LblInputError.Visible = false;
            LblRateError.Visible = false;

            double input = 0;
            double rate = 0;

            try
            {
                input = Convert.ToDouble(TbxInput.Text);

                if (input <= 0)
                {
                    LblInputError.Visible = true;
                }
            }
            catch (FormatException)
            {
                LblInputError.Visible = true;
            }

            try
            {
                rate = Convert.ToDouble(TbxRate.Text);

                if (rate <= 0)
                {
                    LblInputError.Visible = true;
                }
            }
            catch (FormatException)
            {
                LblRateError.Visible = true;
            }

            if (rate > 0 && input > 0)
            {
                double result = input / rate;
                TbxResult.Text = $"{result}";
            }
        }
    }
}
