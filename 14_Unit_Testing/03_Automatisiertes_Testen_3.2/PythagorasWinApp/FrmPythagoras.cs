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
                TbxThird.Text = $"{Bwz.Rappi.Program.CalculatePythagorasC(first, second)}";
            }
        }
    }
}
