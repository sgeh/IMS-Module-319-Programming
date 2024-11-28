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
    public partial class FrmTicTacToe_v4 : Form
    {
        private const string Red = "0";
        private const string Blue = "X";

        private string currentPlayer = Red;

        public FrmTicTacToe_v4()
        {
            InitializeComponent();
        }

        private void SwitchPlayer()
        {
            currentPlayer = (currentPlayer == Red) ? Blue : Red;
            PnlPlayerRed.Visible = (currentPlayer == Red);
            PnlPlayerBlue.Visible = (currentPlayer == Blue);
            LblPlayer.BackColor = GetCurrentPlayerColor();
        }

        private void CheckWinPosition()
        {
            if (SetMatch(BtnTopLeft, BtnTopMiddle, BtnTopRight)
                || SetMatch(BtnMiddleLeft, BtnMiddleMiddle, BtnMiddleRight)
                || SetMatch(BtnBottomLeft, BtnBottomMiddle, BtnBottomRight)
                || SetMatch(BtnTopLeft, BtnMiddleLeft, BtnBottomLeft)
                || SetMatch(BtnTopMiddle, BtnMiddleMiddle, BtnBottomMiddle)
                || SetMatch(BtnTopRight, BtnMiddleRight, BtnBottomRight)
                || SetMatch(BtnTopLeft, BtnMiddleMiddle, BtnBottomRight)
                || SetMatch(BtnBottomLeft, BtnMiddleMiddle, BtnTopRight))
            {
                LockAllPositions();
                ShowWinPanel();
            }
            else if (HasNoEmptyPositions())
            {
                ShowDrawPanel();
            }
        }

        private bool HasNoEmptyPositions()
        {
            return (IsPositionLocked(BtnTopLeft)
                && IsPositionLocked(BtnTopMiddle)
                && IsPositionLocked(BtnTopRight)
                && IsPositionLocked(BtnMiddleLeft)
                && IsPositionLocked(BtnMiddleMiddle)
                && IsPositionLocked(BtnMiddleRight)
                && IsPositionLocked(BtnBottomLeft)
                && IsPositionLocked(BtnBottomMiddle)
                && IsPositionLocked(BtnBottomRight));
        }

        private void LockAllPositions()
        {
            TryLockPosition(BtnTopLeft);
            TryLockPosition(BtnTopMiddle);
            TryLockPosition(BtnTopRight);
            TryLockPosition(BtnMiddleLeft);
            TryLockPosition(BtnMiddleMiddle);
            TryLockPosition(BtnMiddleRight);
            TryLockPosition(BtnBottomLeft);
            TryLockPosition(BtnBottomMiddle);
            TryLockPosition(BtnBottomRight);
        }

        private bool IsPositionLocked(Button toLock)
        {
            return (toLock.Text != "");
        }

        private bool TryLockPosition(Button toLock, string lockSign = "?")
        {
            if (!IsPositionLocked(toLock))
            { 
                Color foreColor;
                if (TryGetPlayerColor(lockSign, out foreColor))
                {
                    toLock.ForeColor = foreColor;
                }

                toLock.Text = lockSign;
                toLock.Cursor = Cursors.No;
                return true;
            }
            return false;
        }

        private void ShowWinPanel()
        {
            PnlWin.Visible = true;
            LblWinMessage.Text = LblWinMessage.Text.Replace("{0}", currentPlayer);
        }

        private void ShowDrawPanel()
        {
            PnlDraw.Visible = true;
        }

        private void SetWinPositions(Button first, Button second, Button third)
        {
            SetWinPosition(first);
            SetWinPosition(second);
            SetWinPosition(third);
        }

        private void SetWinPosition(Button toSetWinPosition)
        {
            toSetWinPosition.BackColor = GetCurrentPlayerColor();
            toSetWinPosition.ForeColor = Color.White;
        }

        private Color GetCurrentPlayerColor()
        {
            Color playerColor;
            if (TryGetPlayerColor(currentPlayer, out playerColor))
            {
                return playerColor;
            }
            return Color.Red;
        }

        private bool TryGetPlayerColor(string playerSign, out Color color)
        {
            switch (playerSign)
            {
                case Red:
                    color = Color.DarkRed;
                    return true;
                case Blue:
                    color = Color.DarkBlue;
                    return true;
                default:
                    color = Color.Transparent;
                    return false;
            }
        }

        private void ClickPosition(Button toClick)
        {
            if (TryLockPosition(toClick, currentPlayer))
            {
                CheckWinPosition();
                SwitchPlayer();
            }
        }

        private bool IsMatch(Button first, Button second, Button third)
        {
            return (first.Text == currentPlayer
                && second.Text == currentPlayer
                && third.Text == currentPlayer);
        }

        private bool SetMatch(Button first, Button second, Button third)
        {
            if (IsMatch(first, second, third))
            {
                SetWinPositions(first, second, third);
                return true;
            }
            return false;
        }


        private void BtnTopLeft_Click(object sender, EventArgs e)
        {
            ClickPosition(BtnTopLeft);
        }

        private void BtnTopMiddle_Click(object sender, EventArgs e)
        {
            ClickPosition(BtnTopMiddle);
        }

        private void BtnTopRight_Click(object sender, EventArgs e)
        {
            ClickPosition(BtnTopRight);
        }

        private void BtnMiddleLeft_Click(object sender, EventArgs e)
        {
            ClickPosition(BtnMiddleLeft);
        }

        private void BtnMiddleMiddle_Click(object sender, EventArgs e)
        {
            ClickPosition(BtnMiddleMiddle);
        }

        private void BtnMiddleRight_Click(object sender, EventArgs e)
        {
            ClickPosition(BtnMiddleRight);
        }

        private void BtnBottomLeft_Click(object sender, EventArgs e)
        {
            ClickPosition(BtnBottomLeft);
        }

        private void BtnBottomMiddle_Click(object sender, EventArgs e)
        {
            ClickPosition(BtnBottomMiddle);
        }

        private void BtnBottomRight_Click(object sender, EventArgs e)
        {
            ClickPosition(BtnBottomRight);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
