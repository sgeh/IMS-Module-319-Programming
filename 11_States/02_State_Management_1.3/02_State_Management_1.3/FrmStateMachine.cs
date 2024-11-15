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
        }

    }
}
