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

        private string currentPlayer = Red;

        private string field1 = null; // top left
        private string field2 = null; // top middle
        private string field3 = null; // top right
        private string field4 = null; // middle left
        private string field5 = null; // middle middle
        private string field6 = null; // middle right
        private string field7 = null; // bottom left
        private string field8 = null; // bottom middle
        private string field9 = null; // bottom right

        public FrmTicTacToe_v1()
        {
            InitializeComponent();
        }

        private void CheckWinPosition()
        {
            if ((field1 == currentPlayer && field2 == currentPlayer && field3 == currentPlayer)
                || (field4 == currentPlayer && field5 == currentPlayer && field6 == currentPlayer)
                || (field7 == currentPlayer && field8 == currentPlayer && field9 == currentPlayer)
                || (field1 == currentPlayer && field4 == currentPlayer && field7 == currentPlayer)
                || (field2 == currentPlayer && field5 == currentPlayer && field8 == currentPlayer)
                || (field3 == currentPlayer && field6 == currentPlayer && field9 == currentPlayer)
                || (field1 == currentPlayer && field5 == currentPlayer && field9 == currentPlayer)
                || (field3 == currentPlayer && field5 == currentPlayer && field7 == currentPlayer))
            {
                PnlWin.Visible = true;
                LblWinMessage.Text = LblWinMessage.Text.Replace("{0}", currentPlayer);
            }
            else if (field1 != null
                && field2 != null
                && field3 != null
                && field4 != null
                && field5 != null
                && field6 != null
                && field7 != null
                && field8 != null
                && field9 != null)
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
            if (field1 == null)
            {
                field1 = currentPlayer;
                BtnTopLeft.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnTopMiddle_Click(object sender, EventArgs e)
        {
            if (field2 == null)
            {
                field2 = currentPlayer;
                BtnTopMiddle.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnTopRight_Click(object sender, EventArgs e)
        {
            if (field3 == null)
            {
                field3 = currentPlayer;
                BtnTopRight.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleLeft_Click(object sender, EventArgs e)
        {
            if (field4 == null)
            {
                field4 = currentPlayer;
                BtnMiddleLeft.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleMiddle_Click(object sender, EventArgs e)
        {
            if (field5 == null)
            {
                field5 = currentPlayer;
                BtnMiddleMiddle.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnMiddleRight_Click(object sender, EventArgs e)
        {
            if (field6 == null)
            {
                field6 = currentPlayer;
                BtnMiddleRight.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomLeft_Click(object sender, EventArgs e)
        {
            if (field7 == null)
            {
                field7 = currentPlayer;
                BtnBottomLeft.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomMiddle_Click(object sender, EventArgs e)
        {
            if (field8 == null)
            {
                field8 = currentPlayer;
                BtnBottomMiddle.Text = currentPlayer;
                CheckWinPosition();
            }
        }

        private void BtnBottomRight_Click(object sender, EventArgs e)
        {
            if (field9 == null)
            {
                field9 = currentPlayer;
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
