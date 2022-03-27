using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareRootWinApp
{
    public partial class FrmSquareRoot : Form
    {
        public FrmSquareRoot()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double input;
            bool inputOk = double.TryParse(TbxRadicand.Text, out input);

            if (inputOk && input > 0)
            {
                LblErrorMessage.Visible = false;
                double result = Bwz.Rappi.Program.CalculateSqrt(input);
                TbxResult.Text = $"{result}";
            }
            else
            {
                LblErrorMessage.Visible = true;
                TbxResult.Text = "";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LblErrorMessage.Visible = false;
            TbxResult.Text = "";
            TbxRadicand.Text = "";
        }
    }
}
