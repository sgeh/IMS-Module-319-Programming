using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PythagorasWinApp
{
    public partial class FrmPythagoras : Form
    {
        public FrmPythagoras()
        {
            InitializeComponent();
        }

        private void CbxCalcC_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            TbxA.Enabled = true;
            LblA.Text = "a";
            TbxB.Enabled = true;
            LblB.Text = "b";
            TbxC.Enabled = false;
            LblC.Text = "c = √(a^2 + b^2)";
        }

        private void CbxCalcB_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            TbxA.Enabled = true;
            LblA.Text = "a";
            TbxB.Enabled = false;
            LblB.Text = "b = √(c^2 - a^2)";
            TbxC.Enabled = true;
            LblC.Text = "c";
        }

        private void CbxCalcA_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            TbxA.Enabled = false;
            LblA.Text = "a = √(c^2 - b^2)";
            TbxB.Enabled = true;
            LblB.Text = "b";
            TbxC.Enabled = true;
            LblC.Text = "c";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (CbxCalcC.Checked)
            {
                CalculateC();
            }
            else if (CbxCalcB.Checked)
            {
                CalculateB();
            }
            else
            {
                CalculateA();
            }
        }

        private void CalculateC()
        {
            double a;
            double b;

            double.TryParse(TbxA.Text, out a);
            double.TryParse(TbxB.Text, out b);

            bool aIsValid = (a > 0);
            bool bIsValid = (b > 0);

            LblErrorA.Visible = (aIsValid == false);
            LblErrorB.Visible = (bIsValid == false);

            if (aIsValid && bIsValid)
            {
                TbxC.Text = $"{Bwz.Rappi.Program.CalculatePythagorasC(a, b)}";
            }
        }

        private void CalculateB()
        {
            double a;
            double c;

            double.TryParse(TbxA.Text, out a);
            double.TryParse(TbxC.Text, out c);

            bool aIsValid = (a > 0);
            bool cIsValid = (c > 0);

            LblErrorA.Visible = (aIsValid == false);
            LblErrorC.Visible = (cIsValid == false);

            if (aIsValid && cIsValid)
            {
                TbxC.Text = $"{Bwz.Rappi.Program.CalculatePythagorasB(c, a)}";
            }
        }

        private void CalculateA()
        {
            double b;
            double c;

            double.TryParse(TbxB.Text, out b);
            double.TryParse(TbxC.Text, out c);

            bool bIsValid = (b > 0);
            bool cIsValid = (c > 0);

            LblErrorB.Visible = (bIsValid == false);
            LblErrorC.Visible = (cIsValid == false);

            if (cIsValid && bIsValid)
            {
                TbxA.Text = $"{Bwz.Rappi.Program.CalculatePythagorasA(c, b)}";
            }
        }

        private void Clear()
        {
            TbxA.Text = "";
            LblErrorA.Visible = false;

            TbxB.Text = "";
            LblErrorB.Visible = false;

            TbxC.Text = "";
            LblErrorB.Visible = false;
        }
    }
}
