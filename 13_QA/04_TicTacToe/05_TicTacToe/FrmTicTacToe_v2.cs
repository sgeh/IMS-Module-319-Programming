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

        private string currentPlayer = Red;

        private string[][] fields = new string[][]
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
            if ((fields[0][0] == currentPlayer && fields[0][1] == currentPlayer && fields[0][2] == currentPlayer)
                || (fields[1][0] == currentPlayer && fields[1][1] == currentPlayer && fields[1][2] == currentPlayer)
                || (fields[2][0] == currentPlayer && fields[2][1] == currentPlayer && fields[2][2] == currentPlayer)
                || (fields[0][0] == currentPlayer && fields[1][0] == currentPlayer && fields[2][0] == currentPlayer)
                || (fields[0][1] == currentPlayer && fields[1][1] == currentPlayer && fields[2][1] == currentPlayer)
                || (fields[0][2] == currentPlayer && fields[1][2] == currentPlayer && fields[2][2] == currentPlayer)
                || (fields[0][0] == currentPlayer && fields[1][1] == currentPlayer && fields[2][2] == currentPlayer)
                || (fields[2][0] == currentPlayer && fields[1][1] == currentPlayer && fields[0][2] == currentPlayer))
            {
                PnlWin.Visible = true;
                LblWinMessage.Text = LblWinMessage.Text.Replace("{0}", currentPlayer);
            }
            else if (fields[0][0] != null
                && fields[0][1] != null
                && fields[0][2] != null
                && fields[1][0] != null
                && fields[1][1] != null
                && fields[1][2] != null
                && fields[2][0] != null
                && fields[2][1] != null
                && fields[2][2] != null)
            {
                PnlDraw.Visible = true;
            }
            else
            {
                currentPlayer = (currentPlayer == Red) ? Blue : Red;
                PnlPlayerRed.Visible = (currentPlayer == Red);
                PnlPlayerBlue.Visible = (currentPlayer == Blue);
                LblPlayer.BackColor = (currentPlayer == Red) ? Color.DarkRed : Color.DarkBlue;
            }
        }

        private void BtnTopLeft_Click(object sender, EventArgs e)
        {
            if (fields[0][0] == null)
            {
                fields[0][0] = currentPlayer;
                BtnTopLeft.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnTopMiddle_Click(object sender, EventArgs e)
        {
            if (fields[0][1] == null)
            {
                fields[0][1] = currentPlayer;
                BtnTopMiddle.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnTopRight_Click(object sender, EventArgs e)
        {
            if (fields[0][2] == null)
            {
                fields[0][2] = currentPlayer;
                BtnTopRight.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleLeft_Click(object sender, EventArgs e)
        {
            if (fields[1][0] == null)
            {
                fields[1][0] = currentPlayer;
                BtnMiddleLeft.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleMiddle_Click(object sender, EventArgs e)
        {
            if (fields[1][1] == null)
            {
                fields[1][1] = currentPlayer;
                BtnMiddleMiddle.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleRight_Click(object sender, EventArgs e)
        {
            if (fields[1][2] == null)
            {
                fields[1][2] = currentPlayer;
                BtnMiddleRight.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomLeft_Click(object sender, EventArgs e)
        {
            if (fields[2][0] == null)
            {
                fields[2][0] = currentPlayer;
                BtnBottomLeft.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomMiddle_Click(object sender, EventArgs e)
        {
            if (fields[2][1] == null)
            {
                fields[2][1] = currentPlayer;
                BtnBottomMiddle.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomRight_Click(object sender, EventArgs e)
        {
            if (fields[2][2] == null)
            {
                fields[2][2] = currentPlayer;
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
