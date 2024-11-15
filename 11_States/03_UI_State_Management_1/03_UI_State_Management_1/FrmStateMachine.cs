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
            if (PnlDoWhileMode.Visible)
            {
                PnlDoWhileMode.Visible = false;
                PnlForMode.Visible = true;
                // Logik für PnlForMode
            }
            else if (PnlForMode.Visible)
            {
                PnlForMode.Visible = false;
                PnlWhileMode.Visible = true;
                // Logik für PnlWhileMode
            }
            else if (PnlWhileMode.Visible)
            {
                PnlWhileMode.Visible = false;
                PnlDoWhileMode.Visible = true;
                // Logik für PnlDoWhileMode
            }
        }
    }
}
