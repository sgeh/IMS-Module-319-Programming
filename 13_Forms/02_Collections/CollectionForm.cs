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
        List<string> _values = new List<string>();

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
                _values.Insert(0, toInsert);
                TbxToInsert.Text = "";
            }
        }

        private void CmdPrint_Click(object sender, EventArgs e)
        {
            TbxOutput.Text = "";

            // Solution 1.5
            for (int i = 0; i < _values.Count; ++i)
            {
                // output list content
                TbxOutput.Text += $"{_values[i]}{Environment.NewLine}";
            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            // Solution 1.6
            _values.Clear();
            TbxToInsert.Text = "";
            TbxOutput.Text = "";
        }
    }
}
