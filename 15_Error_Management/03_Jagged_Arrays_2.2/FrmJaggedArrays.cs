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
    public partial class FrmJaggedArrays : Form
    {
        char[][] jaggedArray =
        {
            new char[] { 'A', 'B', 'C', 'D', 'E' },
            new char[] { 'A', 'B', 'C', 'D' },
            new char[] { 'A', 'B', 'C' },
            new char[] { 'A', 'B' },
            new char[] { 'A' }
        };


        public FrmJaggedArrays()
        {
            InitializeComponent();
        }

        private void BtnPrintToTextbox_Click(object sender, EventArgs e)
        {
            /* b)
            TbxOutput.Text = "";

            for (int i = 0; i < jaggedArray.Length; ++i)
            {
                for (int j = 0; j < jaggedArray[i].Length; ++j)
                {
                    TbxOutput.Text += $"{jaggedArray[i][j]}";
                }
            } */

            /* c)
            TbxOutput.Text = "";

            for (int i = 0; i < jaggedArray.Length; ++i)
            {
                for (int j = 0; j < jaggedArray[i].Length; ++j)
                {
                    TbxOutput.Text += $"{jaggedArray[i][j]} ";
                }
                TbxOutput.Text += $"{Environment.NewLine}";
            } */

            /* d)
            TbxOutput.Text = "";

            for (int i = jaggedArray.Length - 1; i > -1; --i)
            {
                for (int j = 0; j < jaggedArray[i].Length; ++j)
                {
                    TbxOutput.Text += $"{jaggedArray[i][j]} ";
                }
                TbxOutput.Text += $"{Environment.NewLine}";
            } */
        }
    }
}
