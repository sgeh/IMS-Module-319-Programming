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
            AddElement();

            // Solution 1.5 (advanced)
            PrintElements();
        }

        private void CmdPrint_Click(object sender, EventArgs e)
        {
            PrintElements();
        }

        private void AddElement()
        {
            if (TbxToInsert.Text.Length > 0)
            {
                // Solution 1.7
                _values.Insert(0, TbxToInsert.Text);
                TbxToInsert.Text = "";

                // Solution 1.6 (advanced)
                CmdClear.Text = $"clear ({_values.Count})";
                CmdClear.Enabled = true;
            }
        }

        private void PrintElements()
        {
            TbxOutput.Text = "";

            // Solution 1.5
            for (int i = 0; i < _values.Count; ++i)
            {
                // output list content
                TbxOutput.Text += $"{_values[i]}{Environment.NewLine}";
            }

            // Solution 1.5 (advanced)
            //foreach (string item in _values)
            //{
            //    TbxOutput.Text += $"{item}{Environment.NewLine}";
            //}
        }

        private void TbxToInsert_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solution 1.3 (advanced)
            if (e.KeyChar == '\r')
            {
                AddElement();

                // Solution 1.5 (advanced)
                PrintElements();
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

            // Solution 1.6 (advanced)
            CmdClear.Text = "clear";
            CmdClear.Enabled = false;
        }
    }
}
