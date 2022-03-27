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
    public partial class FrmRecursion : Form
    {
        public FrmRecursion()
        {
            InitializeComponent();
        }

        private void BtnDoLoop_Click(object sender, EventArgs e)
        {
            TbxOutput.Text = "";
            DoLoop(0);
        }

        private void DoLoop(int i)
        {
            if (i < 2)
            {
                TbxOutput.Text += $"{i}{Environment.NewLine}";
                DoLoop(i + 1);
            }
        }
    }
}
