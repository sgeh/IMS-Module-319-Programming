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
    public partial class FrmTicTacToe_v2 : Form
    {
        private const string Red = "0";
        private const string Blue = "X";

        private string _currentPlayer = Red;

        private string[][] _fields = new string[][]
        {
            new string[] { null /*field1 [0][0]*/ , null /*field2 [0][1]*/, null /*field3 [0][2]*/ },
            new string[] { null /*field4 [1][0]*/ , null /*field5 [1][1]*/, null /*field6 [1][2]*/ },
            new string[] { null /*field7 [2][0]*/ , null /*field8 [2][1]*/, null /*field9 [2][2]*/ }
        };

        public FrmTicTacToe_v2()
        {
            InitializeComponent();
        }

        private void CheckWinPosition()
        {
            if ((_fields[0][0] == _currentPlayer && _fields[0][1] == _currentPlayer && _fields[0][2] == _currentPlayer)
                || (_fields[1][0] == _currentPlayer && _fields[1][1] == _currentPlayer && _fields[1][2] == _currentPlayer)
                || (_fields[2][0] == _currentPlayer && _fields[2][1] == _currentPlayer && _fields[2][2] == _currentPlayer)
                || (_fields[0][0] == _currentPlayer && _fields[1][0] == _currentPlayer && _fields[2][0] == _currentPlayer)
                || (_fields[0][1] == _currentPlayer && _fields[1][1] == _currentPlayer && _fields[2][1] == _currentPlayer)
                || (_fields[0][2] == _currentPlayer && _fields[1][2] == _currentPlayer && _fields[2][2] == _currentPlayer)
                || (_fields[0][0] == _currentPlayer && _fields[1][1] == _currentPlayer && _fields[2][2] == _currentPlayer)
                || (_fields[2][0] == _currentPlayer && _fields[1][1] == _currentPlayer && _fields[0][2] == _currentPlayer))
            {
                PnlWin.Visible = true;
                LblWinMessage.Text = LblWinMessage.Text.Replace("{0}", _currentPlayer);
            }
            else if (_fields[0][0] != null
                && _fields[0][1] != null
                && _fields[0][2] != null
                && _fields[1][0] != null
                && _fields[1][1] != null
                && _fields[1][2] != null
                && _fields[2][0] != null
                && _fields[2][1] != null
                && _fields[2][2] != null)
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
            if (_fields[0][0] == null)
            {
                _fields[0][0] = _currentPlayer;
                BtnTopLeft.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnTopMiddle_Click(object sender, EventArgs e)
        {
            if (_fields[0][1] == null)
            {
                _fields[0][1] = _currentPlayer;
                BtnTopMiddle.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnTopRight_Click(object sender, EventArgs e)
        {
            if (_fields[0][2] == null)
            {
                _fields[0][2] = _currentPlayer;
                BtnTopRight.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleLeft_Click(object sender, EventArgs e)
        {
            if (_fields[1][0] == null)
            {
                _fields[1][0] = _currentPlayer;
                BtnMiddleLeft.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleMiddle_Click(object sender, EventArgs e)
        {
            if (_fields[1][1] == null)
            {
                _fields[1][1] = _currentPlayer;
                BtnMiddleMiddle.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleRight_Click(object sender, EventArgs e)
        {
            if (_fields[1][2] == null)
            {
                _fields[1][2] = _currentPlayer;
                BtnMiddleRight.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomLeft_Click(object sender, EventArgs e)
        {
            if (_fields[2][0] == null)
            {
                _fields[2][0] = _currentPlayer;
                BtnBottomLeft.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomMiddle_Click(object sender, EventArgs e)
        {
            if (_fields[2][1] == null)
            {
                _fields[2][1] = _currentPlayer;
                BtnBottomMiddle.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomRight_Click(object sender, EventArgs e)
        {
            if (_fields[2][2] == null)
            {
                _fields[2][2] = _currentPlayer;
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
