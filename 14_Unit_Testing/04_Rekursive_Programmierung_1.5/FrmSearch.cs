using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bwz.Rappi
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                LblFolder.Text = dialog.SelectedPath;
            }
        }

        private void BtnDoLoop_Click(object sender, EventArgs e)
        {
            TbxOutput.Text = "";

            if (Directory.Exists(LblFolder.Text))
            {
                DoSearchRecursive(LblFolder.Text);
            }
        }

        private void DoSearchRecursive(string path)
        {
            string[] subDirectories = Directory.GetDirectories(path);

            for (int i = 0; i < subDirectories.Length; ++i)
            {
                string directoryName = Path.GetDirectoryName(subDirectories[i]);

                if (directoryName.Contains(TbxSearchPattern.Text))
                {
                    TbxOutput.Text += $"{subDirectories[i]}{Environment.NewLine}";
                }
                DoSearchRecursive(subDirectories[i]);
            }
        }
    }
}
