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
        int _tryCount = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (TbxPassword.Text.Length < 3 || TbxUserName.Text.Length < 3)
            {
                LblErrorMessage.Text = "Ungültige Eingabe!";
                _tryCount++;
            }
            else
            {
                if (TbxUserName.Text == "user1" && TbxPassword.Text == "1234"
                    || TbxUserName.Text == "user2" && TbxPassword.Text == "4567"
                    || TbxUserName.Text == "user3" && TbxPassword.Text == "7890")
                {
                    LblErrorMessage.Text = "";
                    MessageBox.Show("Eingabe korrekt!", "Eingabe abgeschlossen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    LblErrorMessage.Text = "Ungültige Eingabe!";
                    _tryCount++;
                }
            }

            if (_tryCount == 3)
            {
                TbxUserName.Enabled = false;
                TbxPassword.Enabled = false;
                BtnCancel.Enabled = false;
                BtnOK.Enabled = false;
                Text = "Gesperrt";
                MessageBox.Show("Account gesperrt!", "Eingabe inkorrekt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Application.Exit();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie wirklich abbrechen?", "Eingabe beenden", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
