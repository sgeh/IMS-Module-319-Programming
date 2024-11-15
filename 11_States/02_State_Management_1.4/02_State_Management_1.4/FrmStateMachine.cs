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
    public partial class FrmStateMachine : Form
    {
        public FrmStateMachine()
        {
            InitializeComponent();
        }

        private void CmdChangeMode_Click(object sender, EventArgs e)
        {
            if (LblDoWhileMode.Visible)
            {
                LblDoWhileMode.Visible = false;
                LblForMode.Visible = true;

                // Logik für PnlForMode
                TbxOutput.Text = "";
                for (int i = 0; i < 20; i++)
                {
                    TbxOutput.Text += $"{i}\r\n";
                }
            }
            else if (LblForMode.Visible)
            {
                LblForMode.Visible = false;
                LblWhileMode.Visible = true;

                // Logik für PnlWhileMode
                TbxOutput.Text = "";
                int i = 0;
                while (i < 20)
                {
                    TbxOutput.Text += $"{i}\r\n";
                    i++;
                }

            }
            else if (LblWhileMode.Visible)
            {
                LblWhileMode.Visible = false;
                LblDoWhileMode.Visible = true;

                // Logik für PnlDoWhileMode
                TbxOutput.Text = "";
                int i = 0;
                do
                {
                    TbxOutput.Text += $"{i}\r\n";
                    i++;
                }
                while (i < 20);
            }
        }
    }
}
