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
    public partial class FrmTicTacToe_v3 : Form
    {
        private const string Red = "0";
        private const string Blue = "X";

        private string _currentPlayer = Red;

        private string[][] fields = new string[][]
        {
            new string[] { null /*field 1 [0][0]*/ , null /*field 2 [0][1]*/, null /*field 3 [0][2]*/ },
            new string[] { null /*field 4 [1][0]*/ , null /*field 5 [1][1]*/, null /*field 6 [1][2]*/ },
            new string[] { null /*field 7 [2][0]*/ , null /*field 8 [2][1]*/, null /*field 9 [2][2]*/ }
        };

        public FrmTicTacToe_v3()
        {
            InitializeComponent();
        }

        private bool RowHasWinPosition(int row)
        {
            return fields[row][0] == _currentPlayer
                && fields[row][1] == _currentPlayer
                && fields[row][2] == _currentPlayer;
        }

        private bool ColumnHasWinPosition(int column)
        {
            return fields[0][column] == _currentPlayer
                && fields[1][column] == _currentPlayer
                && fields[2][column] == _currentPlayer;
        }

        private bool FieldsAreFull()
        {
            bool allFieldsSet = true;
            for (int i = 0; i < fields.Length; i++)
            {
                for (int j = 0; j < fields[i].Length; j++)
                {
                    if (fields[i][j] == null)
                    {
                        allFieldsSet = false;
                    }
                }
            }
            return allFieldsSet;
        }

        private void CheckWinPosition()
        {
            if (RowHasWinPosition(0)
                || RowHasWinPosition(1)
                || RowHasWinPosition(2)
                || ColumnHasWinPosition(0)
                || ColumnHasWinPosition(1)
                || ColumnHasWinPosition(2)
                || (fields[0][0] == _currentPlayer && fields[1][1] == _currentPlayer && fields[2][2] == _currentPlayer)
                || (fields[2][0] == _currentPlayer && fields[1][1] == _currentPlayer && fields[0][2] == _currentPlayer))
            {
                PnlWin.Visible = true;
                LblWinMessage.Text = LblWinMessage.Text.Replace("{0}", _currentPlayer);
            }
            else if (FieldsAreFull())
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

        private void SetPosition(Button selectedPosition, int x, int y)
        {
            if (fields[x][y] == null)
            {
                fields[x][y] = _currentPlayer;
                selectedPosition.Text = _currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnTopLeft_Click(object sender, EventArgs e)
        {
            SetPosition(BtnTopLeft, 0, 0);
        }

        private void BtnTopMiddle_Click(object sender, EventArgs e)
        {
            SetPosition(BtnTopMiddle, 0, 1);
        }

        private void BtnTopRight_Click(object sender, EventArgs e)
        {
            SetPosition(BtnTopRight, 0, 2);
        }

        private void BtnMiddleLeft_Click(object sender, EventArgs e)
        {
            SetPosition(BtnMiddleLeft, 1, 0);
        }

        private void BtnMiddleMiddle_Click(object sender, EventArgs e)
        {
            SetPosition(BtnMiddleMiddle, 1, 1);
        }

        private void BtnMiddleRight_Click(object sender, EventArgs e)
        {
            SetPosition(BtnMiddleRight, 1, 2);
        }

        private void BtnBottomLeft_Click(object sender, EventArgs e)
        {
            SetPosition(BtnBottomLeft, 2, 0);
        }

        private void BtnBottomMiddle_Click(object sender, EventArgs e)
        {
            SetPosition(BtnBottomMiddle, 2, 1);
        }

        private void BtnBottomRight_Click(object sender, EventArgs e)
        {
            SetPosition(BtnBottomRight, 2, 2);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
