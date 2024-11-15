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


        private void CmdRun_Click(object sender, EventArgs e)
        {
            RunAlgo();
        }

        private void CmdChangeMode_Click(object sender, EventArgs e)
        {
            if (LblDoWhileMode.Visible)
            {
                LblDoWhileMode.Visible = false;
                LblForMode.Visible = true;
                // Logik für PnlForMode
            }
            else if (LblForMode.Visible)
            {
                LblForMode.Visible = false;
                LblWhileMode.Visible = true;
                // Logik für PnlWhileMode
            }
            else if (LblWhileMode.Visible)
            {
                LblWhileMode.Visible = false;
                LblDoWhileMode.Visible = true;
                // Logik für PnlDoWhileMode
            }
            RunAlgo();
        }

        private void RunAlgo()
        {
            if (LblDoWhileMode.Visible)
            {
                DoWhileMode();
            }
            else if (LblForMode.Visible)
            {
                ForMode();
            }
            else if (LblWhileMode.Visible)
            {
                WhileMode();
            }
        }

        private void ForMode()
        {
            TbxOutput.Text = "";
            for (int i = (int)NumStart.Value; i < NumEnd.Value; i += (int)NumStep.Value)
            {
                TbxOutput.Text += $"{i}\r\n";
            }
        }

        private void WhileMode()
        {
            TbxOutput.Text = "";
            int i = (int)NumStart.Value;
            while (i < NumEnd.Value)
            {
                TbxOutput.Text += $"{i}\r\n";
                i += (int)NumStep.Value;
            }
        }

        private void DoWhileMode()
        {
            TbxOutput.Text = "";
            int i = (int)NumStart.Value;
            do
            {
                TbxOutput.Text += $"{i}\r\n";
                i += (int)NumStep.Value;
            }
            while (i < NumEnd.Value);
        }

    }
}
