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
    public partial class ListBoxForm : Form
    {
        public ListBoxForm()
        {
            InitializeComponent();
        }

        private void CmdInsert_Click(object sender, EventArgs e)
        {
            string toInsert = TbxToInsert.Text;
            
            if (toInsert.Length > 0)
            {
                LbxOutput.Items.Insert(0, toInsert);
                TbxToInsert.Text = "";
            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            LbxOutput.Items.Clear();
            TbxToInsert.Text = "";
        }
    }
}
