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
    public partial class FrmAppLog : Form
    {
        public FrmAppLog()
        {
            InitializeComponent();
        }

        private void BtnEnum_Click(object sender, EventArgs e)
        {
            string[] data = { "hallo", "welt", "!" };

            for (int i = 0; i < data.Length; ++i)
            {
                int j = 0;
                Square(i, out j);
                TbxLogMessages.Text += $"{j}: {data[i]}\r\n";
            }
        }

        void Square(int x, out int result)
        {
            result = x* x;
        }

        private void BtnEnum_Click_Vorlage(object sender, EventArgs e)
        {
            string[] data = { "hallo", "welt", "!" };

            for (int i = 0; i < data.Length; ++i)
            {
                Square(i, out i);
                TbxLogMessages.Text += $"{i}: {data[i]}\r\n";
            }
        }
    }
}
