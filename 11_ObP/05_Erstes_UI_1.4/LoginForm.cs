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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // TODO: login, check password, a.s.o.
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Möchten Sie wirklich abbrechen?",
                "Eingabe beenden",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
        }
    }
}
