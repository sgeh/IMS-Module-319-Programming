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
    public partial class FrmRistorante : Form
    {
        int sum = 0;

        public FrmRistorante()
        {
            InitializeComponent();
        }

         private void CmdSelection_Click(object sender, EventArgs e)
        {
            if (LbxFood.SelectedIndex != -1)
            {
                string toAssign = (string)LbxFood.SelectedItem;
                LbxSelection.Items.Add(toAssign);

                switch (LbxFood.SelectedIndex)
                {
                    case 0:
                        sum += 15; // Spaghetti
                        break;
                    case 1:
                        sum += 17; // Canelloni
                        break;
                    case 2:
                        sum += 20; // Pizza
                        break;
                }

                LblSum.Text = $"{sum}.-";
                CmdOrder.Enabled = (LbxSelection.Items.Count > 0);
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void CmdOrder_Click(object sender, EventArgs e)
        {
            string order = "";

            for (int i = 0; i < LbxSelection.Items.Count; ++i)
            {
                order += $"\n{LbxSelection.Items[i]}";
            }

            MessageBox.Show($"Vielen Dank für Ihre Bestellung:{order}\nSumme total: {sum}.-", "Bestellung abgeschlossen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
        }

        private void ResetForm()
        {
            sum = 0;
            LblSum.Text = "";

            LbxSelection.Items.Clear();
            CmdOrder.Enabled = false;
        }
    }
}
