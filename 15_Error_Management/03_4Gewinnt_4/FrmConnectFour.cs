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
    public partial class FrmConnectFour : Form
    {
        private const string Red = "1";
        private const string Blue = "2";

        private string _currentPlayer = Red;

        private Button[][] _fields;

        public FrmConnectFour()
        {
            InitializeComponent();

            _fields = new Button[][]
            {
                new Button[] { Btn00, Btn01, Btn02, Btn03, Btn04, Btn05, Btn06 },
                new Button[] { Btn10, Btn11, Btn12, Btn13, Btn14, Btn15, Btn16 },
                new Button[] { Btn20, Btn21, Btn22, Btn23, Btn24, Btn25, Btn26 },
                new Button[] { Btn30, Btn31, Btn32, Btn33, Btn34, Btn35, Btn36 },
                new Button[] { Btn40, Btn41, Btn42, Btn43, Btn44, Btn45, Btn46 },
                new Button[] { Btn50, Btn51, Btn52, Btn53, Btn54, Btn55, Btn56 }
            };
        }

        private int Count(int row, int column, int directionRow, int directionColumn)
        {
            int count = 0;
            row += directionRow;
            column += directionColumn;

            while (row > -1
                && column > -1
                && row < _fields.Length
                && column < _fields[row].Length)
            {
                if (_fields[row][column].Text == _currentPlayer)
                {
                    count++;
                    row += directionRow;
                    column += directionColumn;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        private bool FieldsAreFull()
        {
            bool allFieldsSet = true;
            for (int i = 0; i < _fields.Length; i++)
            {
                for (int j = 0; j < _fields[i].Length; j++)
                {
                    if (_fields[i][j].Text == "")
                    {
                        allFieldsSet = false;
                    }
                }
            }
            return allFieldsSet;
        }

        private void CheckWinPosition(int row, int column)
        {
            if (Count(row, column, +1, 0) + Count(row, column, -1, 0) + 1 >= 4
                || Count(row, column, 0, +1) + Count(row, column, 0, -1) + 1 >= 4
                || Count(row, column, +1, +1) + Count(row, column, -1, -1) + 1 >= 4
                || Count(row, column, -1, +1) + Count(row, column, -1, +1) + 1 >= 4)
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

        private int GetEmptyRow(int column)
        {
            for (int i = _fields.Length - 1; i > -1; i--)
            {
                if (_fields[i][column].Text == "")
                {
                    return i;
                }
            }
            return -1;
        }

        private void SetPosition(int column)
        {
            int freeRow = GetEmptyRow(column);
            if (freeRow != -1)
            {
                _fields[freeRow][column].Text = _currentPlayer;
                _fields[freeRow][column].BackColor = (_currentPlayer == Red) ? Color.DarkRed : Color.DarkBlue;
                CheckWinPosition(freeRow, column);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn00_Click(object sender, EventArgs e)
        {
            SetPosition(0);
        }

        private void Btn01_Click(object sender, EventArgs e)
        {
            SetPosition(1);
        }

        private void Btn02_Click(object sender, EventArgs e)
        {
            SetPosition(2);
        }

        private void Btn03_Click(object sender, EventArgs e)
        {
            SetPosition(3);
        }

        private void Btn04_Click(object sender, EventArgs e)
        {
            SetPosition(4);
        }

        private void Btn05_Click(object sender, EventArgs e)
        {
            SetPosition(5);
        }

        private void Btn06_Click(object sender, EventArgs e)
        {
            SetPosition(6);
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            SetPosition(0);
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            SetPosition(1);
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            SetPosition(2);
        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            SetPosition(3);
        }

        private void Btn14_Click(object sender, EventArgs e)
        {
            SetPosition(4);
        }

        private void Btn15_Click(object sender, EventArgs e)
        {
            SetPosition(5);
        }

        private void Btn16_Click(object sender, EventArgs e)
        {
            SetPosition(6);
        }

        private void Btn20_Click(object sender, EventArgs e)
        {
            SetPosition(0);
        }

        private void Btn21_Click(object sender, EventArgs e)
        {
            SetPosition(1);
        }

        private void Btn22_Click(object sender, EventArgs e)
        {
            SetPosition(2);
        }

        private void Btn23_Click(object sender, EventArgs e)
        {
            SetPosition(3);
        }

        private void Btn24_Click(object sender, EventArgs e)
        {
            SetPosition(4);
        }

        private void Btn25_Click(object sender, EventArgs e)
        {
            SetPosition(5);
        }

        private void Btn26_Click(object sender, EventArgs e)
        {
            SetPosition(6);
        }

        private void Btn30_Click(object sender, EventArgs e)
        {
            SetPosition(0);
        }

        private void Btn31_Click(object sender, EventArgs e)
        {
            SetPosition(1);
        }

        private void Btn32_Click(object sender, EventArgs e)
        {
            SetPosition(2);
        }

        private void Btn33_Click(object sender, EventArgs e)
        {
            SetPosition(3);
        }

        private void Btn34_Click(object sender, EventArgs e)
        {
            SetPosition(4);
        }

        private void Btn35_Click(object sender, EventArgs e)
        {
            SetPosition(5);
        }

        private void Btn36_Click(object sender, EventArgs e)
        {
            SetPosition(6);
        }

        private void Btn40_Click(object sender, EventArgs e)
        {
            SetPosition(0);
        }

        private void Btn41_Click(object sender, EventArgs e)
        {
            SetPosition(1);
        }

        private void Btn42_Click(object sender, EventArgs e)
        {
            SetPosition(2);
        }

        private void Btn43_Click(object sender, EventArgs e)
        {
            SetPosition(3);
        }

        private void Btn44_Click(object sender, EventArgs e)
        {
            SetPosition(4);
        }

        private void Btn45_Click(object sender, EventArgs e)
        {
            SetPosition(5);
        }

        private void Btn46_Click(object sender, EventArgs e)
        {
            SetPosition(6);
        }

        private void Btn50_Click(object sender, EventArgs e)
        {
            SetPosition(0);
        }

        private void Btn51_Click(object sender, EventArgs e)
        {
            SetPosition(1);
        }

        private void Btn52_Click(object sender, EventArgs e)
        {
            SetPosition(2);
        }

        private void Btn53_Click(object sender, EventArgs e)
        {
            SetPosition(3);
        }

        private void Btn54_Click(object sender, EventArgs e)
        {
            SetPosition(4);
        }

        private void Btn55_Click(object sender, EventArgs e)
        {
            SetPosition(5);
        }

        private void Btn56_Click(object sender, EventArgs e)
        {
            SetPosition(6);
        }
    }
}
