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
    public partial class FrmTicTacToe : Form
    {
        private const string Red = "0";
        private const string Blue = "X";

        private string _currentPlayer = Red;

        /**
         * Field Definition:
         * [ BtnTopLeft     BtnTopMiddle     BtnTopRight    ]
         * [ BtnMiddleLeft  BtnMiddleMiddle  BtnMiddleRight ]
         * [ BtnBottomLeft  BtnBottomMiddle  BtnBottomRight ]
         */

        public FrmTicTacToe()
        {
            InitializeComponent();
        }

        private void CheckWinPosition()
        {
            if ((BtnTopLeft.Text == _currentPlayer && BtnTopMiddle.Text == _currentPlayer && BtnTopRight.Text == _currentPlayer)
                || (BtnMiddleLeft.Text == _currentPlayer && BtnMiddleMiddle.Text == _currentPlayer && BtnMiddleRight.Text == _currentPlayer)
                || (BtnBottomLeft.Text == _currentPlayer && BtnBottomMiddle.Text == _currentPlayer && BtnBottomRight.Text == _currentPlayer)
                || (BtnTopLeft.Text == _currentPlayer && BtnMiddleLeft.Text == _currentPlayer && BtnBottomLeft.Text == _currentPlayer)
                || (BtnTopMiddle.Text == _currentPlayer && BtnMiddleMiddle.Text == _currentPlayer && BtnBottomMiddle.Text == _currentPlayer)
                || (BtnTopRight.Text == _currentPlayer && BtnMiddleRight.Text == _currentPlayer && BtnBottomRight.Text == _currentPlayer)
                || (BtnTopLeft.Text == _currentPlayer && BtnMiddleMiddle.Text == _currentPlayer && BtnBottomRight.Text == _currentPlayer)
                || (BtnTopRight.Text == _currentPlayer && BtnMiddleMiddle.Text == _currentPlayer && BtnBottomLeft.Text == _currentPlayer))
            {
                PnlWin.Visible = true;
                LblWinMessage.Text = $"Player {_currentPlayer} won!";
            }
            else if (BtnTopLeft.Text != ""
                && BtnTopMiddle.Text != ""
                && BtnTopRight.Text != ""
                && BtnMiddleLeft.Text != ""
                && BtnMiddleMiddle.Text != ""
                && BtnMiddleRight.Text != ""
                && BtnBottomLeft.Text != ""
                && BtnBottomMiddle.Text != ""
                && BtnBottomRight.Text != "")
            {
                PnlDraw.Visible = true;
            }
            else
            {
                _currentPlayer = (_currentPlayer == Red) ? Blue : Red; // switch player
                PnlPlayerRed.Visible = (_currentPlayer == Red);
                PnlPlayerBlue.Visible = (_currentPlayer == Blue);
                LblPlayer.BackColor = (_currentPlayer == Red) ? Color.DarkRed : Color.DarkBlue;
            }
        }

        private void BtnTopLeft_Click(object sender, EventArgs e)
        {
            if (BtnTopLeft.Text == "")
            {
                BtnTopLeft.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnTopMiddle_Click(object sender, EventArgs e)
        {
            if (BtnTopMiddle.Text == "")
            {
                BtnTopMiddle.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnTopRight_Click(object sender, EventArgs e)
        {
            if (BtnTopRight.Text == "")
            {
                BtnTopRight.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleLeft_Click(object sender, EventArgs e)
        {
            if (BtnMiddleLeft.Text == "")
            {
                BtnMiddleLeft.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleMiddle_Click(object sender, EventArgs e)
        {
            if (BtnMiddleMiddle.Text == "")
            {
                BtnMiddleMiddle.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleRight_Click(object sender, EventArgs e)
        {
            if (BtnMiddleRight.Text == "")
            {
                BtnMiddleRight.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomLeft_Click(object sender, EventArgs e)
        {
            if (BtnBottomLeft.Text == "")
            {
                BtnBottomLeft.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomMiddle_Click(object sender, EventArgs e)
        {
            if (BtnBottomMiddle.Text == "")
            {
                BtnBottomMiddle.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomRight_Click(object sender, EventArgs e)
        {
            if (BtnBottomRight.Text == "")
            {
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
