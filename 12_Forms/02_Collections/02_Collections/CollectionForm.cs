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
    public partial class CollectionForm : Form
    {
        // Solution 1.3
        List<string> values = new List<string>();

        public CollectionForm()
        {
            InitializeComponent();
        }

        private void CmdInsert_Click(object sender, EventArgs e)
        {
            // Solution 1.3
            string toInsert = TbxToInsert.Text;

            if (toInsert.Length > 0)
            {
                // Solution 1.7
                values.Insert(0, toInsert);
                TbxToInsert.Text = "";
            }
        }

        private void CmdPrint_Click(object sender, EventArgs e)
        {
            TbxOutput.Text = "";

            // Solution 1.5
            for (int i = 0; i < values.Count; ++i)
            {
                // output list content
                TbxOutput.Text += $"{values[i]}\r\n";
            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            // Solution 1.6
            values.Clear();
            TbxToInsert.Text = "";
            TbxOutput.Text = "";
        }
    }
}
