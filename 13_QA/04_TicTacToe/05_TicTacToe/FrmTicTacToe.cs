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

        private string currentPlayer = Red;

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
            if ((BtnTopLeft.Text == currentPlayer && BtnTopMiddle.Text == currentPlayer && BtnTopRight.Text == currentPlayer)
                || (BtnMiddleLeft.Text == currentPlayer && BtnMiddleMiddle.Text == currentPlayer && BtnMiddleRight.Text == currentPlayer)
                || (BtnBottomLeft.Text == currentPlayer && BtnBottomMiddle.Text == currentPlayer && BtnBottomRight.Text == currentPlayer)
                || (BtnTopLeft.Text == currentPlayer && BtnMiddleLeft.Text == currentPlayer && BtnBottomLeft.Text == currentPlayer)
                || (BtnTopMiddle.Text == currentPlayer && BtnMiddleMiddle.Text == currentPlayer && BtnBottomMiddle.Text == currentPlayer)
                || (BtnTopRight.Text == currentPlayer && BtnMiddleRight.Text == currentPlayer && BtnBottomRight.Text == currentPlayer)
                || (BtnTopLeft.Text == currentPlayer && BtnMiddleMiddle.Text == currentPlayer && BtnBottomRight.Text == currentPlayer)
                || (BtnTopRight.Text == currentPlayer && BtnMiddleMiddle.Text == currentPlayer && BtnBottomLeft.Text == currentPlayer))
            {
                PnlWin.Visible = true;
                LblWinMessage.Text = $"Player {currentPlayer} won!";
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
                currentPlayer = (currentPlayer == Red) ? Blue : Red; // switch player
                PnlPlayerRed.Visible = (currentPlayer == Red);
                PnlPlayerBlue.Visible = (currentPlayer == Blue);
                LblPlayer.BackColor = (currentPlayer == Red) ? Color.DarkRed : Color.DarkBlue;
            }
        }

        private void BtnTopLeft_Click(object sender, EventArgs e)
        {
            if (BtnTopLeft.Text == "")
            {
                BtnTopLeft.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnTopMiddle_Click(object sender, EventArgs e)
        {
            if (BtnTopMiddle.Text == "")
            {
                BtnTopMiddle.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnTopRight_Click(object sender, EventArgs e)
        {
            if (BtnTopRight.Text == "")
            {
                BtnTopRight.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleLeft_Click(object sender, EventArgs e)
        {
            if (BtnMiddleLeft.Text == "")
            {
                BtnMiddleLeft.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleMiddle_Click(object sender, EventArgs e)
        {
            if (BtnMiddleMiddle.Text == "")
            {
                BtnMiddleMiddle.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleRight_Click(object sender, EventArgs e)
        {
            if (BtnMiddleRight.Text == "")
            {
                BtnMiddleRight.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomLeft_Click(object sender, EventArgs e)
        {
            if (BtnBottomLeft.Text == "")
            {
                BtnBottomLeft.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomMiddle_Click(object sender, EventArgs e)
        {
            if (BtnBottomMiddle.Text == "")
            {
                BtnBottomMiddle.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomRight_Click(object sender, EventArgs e)
        {
            if (BtnBottomRight.Text == "")
            {
                BtnBottomRight.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
