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
    public partial class FrmPythagoras : Form
    {
        public FrmPythagoras()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TbxFirst.Text = "";
            LblErrorFirst.Visible = false;
            TbxSecond.Text = "";
            LblErrorSecond.Visible = false;
            TbxThird.Text = "";
            LblErrorThird.Visible = false;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double first;
            double second;

            double.TryParse(TbxFirst.Text, out first);
            double.TryParse(TbxSecond.Text, out second);

            bool firstIsValid = (first > 0);
            bool secondIsValid = (second > 0);

            LblErrorFirst.Visible = (firstIsValid == false); // also !firstIsValid
            LblErrorSecond.Visible = (secondIsValid == false); // also !secondIsValid

            if (firstIsValid && secondIsValid)
            {
                TbxThird.Text = $"{CalculatePythagorasC(first, second)}";
            }
        }

        double CalculatePythagorasC(double a, double b)
        {
            return CalculateSqrt(a * a + b * b);
        }

        double CalculateSqrt(double input)
        {
            double last = 0;
            double sqrt = 1;

            do
            {
                last = sqrt;
                sqrt = (sqrt + (input  / sqrt)) / 2;
            }
            while (Math.Abs(last - sqrt) > 0.000006);
            return sqrt;
        }
    }
}
