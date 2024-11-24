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
    public partial class ComboBoxForm : Form
    {
        public ComboBoxForm()
        {
            InitializeComponent();
        }

        private void CmdInsert_Click(object sender, EventArgs e)
        {
            string toInsert = CbxInput.Text;

            if (toInsert.Length > 0)
            {
                LbxOutput.Items.Insert(0, toInsert);
                CbxInput.Text = "";
            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            LbxOutput.Items.Clear();
            CbxInput.Text = "";
        }
    }
}
