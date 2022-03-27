using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// ---------------------------------------------------------------------------
/// Übungsserie TicTacToe
/// Thema: Praxisaufgabe "Game"
/// Author: Silvan Gehrig
/// Version: 1.0
/// -------------------------------------------------------------------- 2022 -
/// </summary>
namespace Bwz.Rappi
{
    public partial class FrmTicTacToe_v1 : Form
    {
        private const string Red = "0";
        private const string Blue = "X";

        private string _currentPlayer = Red;

        private string _field1 = null; // top left
        private string _field2 = null; // top middle
        private string _field3 = null; // top right
        private string _field4 = null; // middle left
        private string _field5 = null; // middle middle
        private string _field6 = null; // middle right
        private string _field7 = null; // bottom left
        private string _field8 = null; // bottom middle
        private string _field9 = null; // bottom right

        public FrmTicTacToe_v1()
        {
            InitializeComponent();
        }

        private void CheckWinPosition()
        {
            if ((_field1 == _currentPlayer && _field2 == _currentPlayer && _field3 == _currentPlayer)
                || (_field4 == _currentPlayer && _field5 == _currentPlayer && _field6 == _currentPlayer)
                || (_field7 == _currentPlayer && _field8 == _currentPlayer && _field9 == _currentPlayer)
                || (_field1 == _currentPlayer && _field4 == _currentPlayer && _field7 == _currentPlayer)
                || (_field2 == _currentPlayer && _field5 == _currentPlayer && _field8 == _currentPlayer)
                || (_field3 == _currentPlayer && _field6 == _currentPlayer && _field9 == _currentPlayer)
                || (_field1 == _currentPlayer && _field5 == _currentPlayer && _field9 == _currentPlayer)
                || (_field3 == _currentPlayer && _field5 == _currentPlayer && _field7 == _currentPlayer))
            {
                PnlWin.Visible = true;
                LblWinMessage.Text = LblWinMessage.Text.Replace("{0}", _currentPlayer);
            }
            else if (_field1 != null
                && _field2 != null
                && _field3 != null
                && _field4 != null
                && _field5 != null
                && _field6 != null
                && _field7 != null
                && _field8 != null
                && _field9 != null)
            {
                PnlDraw.Visible = true;
            }
            else
            {
                _currentPlayer = (_currentPlayer == Red) ? Blue : Red;
                PnlPlayerRed.Visible = (_currentPlayer == Red);
                PnlPlayerBlue.Visible = (_currentPlayer == Blue);
                LblPlayer.BackColor = (_currentPlayer == Red) ? Color.DarkRed : Color.DarkBlue;
            }
        }

        private void BtnTopLeft_Click(object sender, EventArgs e)
        {
            if (_field1 == null)
            {
                _field1 = _currentPlayer;
                BtnTopLeft.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnTopMiddle_Click(object sender, EventArgs e)
        {
            if (_field2 == null)
            {
                _field2 = _currentPlayer;
                BtnTopMiddle.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnTopRight_Click(object sender, EventArgs e)
        {
            if (_field3 == null)
            {
                _field3 = _currentPlayer;
                BtnTopRight.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleLeft_Click(object sender, EventArgs e)
        {
            if (_field4 == null)
            {
                _field4 = _currentPlayer;
                BtnMiddleLeft.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleMiddle_Click(object sender, EventArgs e)
        {
            if (_field5 == null)
            {
                _field5 = _currentPlayer;
                BtnMiddleMiddle.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleRight_Click(object sender, EventArgs e)
        {
            if (_field6 == null)
            {
                _field6 = _currentPlayer;
                BtnMiddleRight.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomLeft_Click(object sender, EventArgs e)
        {
            if (_field7 == null)
            {
                _field7 = _currentPlayer;
                BtnBottomLeft.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomMiddle_Click(object sender, EventArgs e)
        {
            if (_field8 == null)
            {
                _field8 = _currentPlayer;
                BtnBottomMiddle.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomRight_Click(object sender, EventArgs e)
        {
            if (_field9 == null)
            {
                _field9 = _currentPlayer;
                BtnBottomRight.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
