using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bwz.Rappi
{
    public partial class TimeTableForm : Form
    {
        private double _salaryPerHour = 0;
        private double _salaryTotal = 0;

        public TimeTableForm()
        {
            InitializeComponent();
        }

        private void CmdDateOk_Click(object sender, EventArgs e)
        {
            double salaryPerHour;
            double.TryParse(TbxSalary.Text, out salaryPerHour);

            if (TbxFirstName.Text.Length >= 2
                && TbxLastName.Text.Length >= 2
                && salaryPerHour > 0
                && TbxDate.Text.Length == 10)
            {
                _salaryPerHour = salaryPerHour;
                LblDateError.Text = "";
                LblTick.Visible = true;
            }
            else
            {
                LblDateError.Text = "Ungültige Eingabe!";
            }
        }

        private void AddTimeListEntry(double from, double to, double timeRange, double salary)
        {
            _salaryTotal += salary;
            LblTotal.Text = $"{_salaryTotal:0.00} CHF";

            LbxFrom.Items.Add(from);
            LbxTo.Items.Add(to);
            LbxTimeRange.Items.Add(timeRange);
            LbxSalary.Items.Add(salary);
        }

        private void CmdClearAll_Click(object sender, EventArgs e)
        {
            _salaryTotal = 0;
            LblTotal.Text = "";

            LbxFrom.Items.Clear();
            LbxTo.Items.Clear();
            LbxTimeRange.Items.Clear();
            LbxSalary.Items.Clear();
        }

        private void CmdClearSingle_Click(object sender, EventArgs e)
        {
            if (LbxSalary.SelectedIndex != -1)
            {
                _salaryTotal -= (double)LbxSalary.Items[LbxSalary.SelectedIndex];
                LblTotal.Text = $"{_salaryTotal:0.00} CHF";

                LbxFrom.Items.RemoveAt(LbxSalary.SelectedIndex);
                LbxTo.Items.RemoveAt(LbxSalary.SelectedIndex);
                LbxTimeRange.Items.RemoveAt(LbxSalary.SelectedIndex);
                LbxSalary.Items.RemoveAt(LbxSalary.SelectedIndex);
            }
        }

        private void CmdInsert_Click(object sender, EventArgs e)
        {
            if (NumFrom.Value < NumTo.Value)
            {
                LblInsertError.Text = "";

                double to = (double)NumTo.Value;
                double from = (double)NumFrom.Value;

                AddTimeListEntry(
                    from,
                    to,
                    to - from,
                    (to - from) * _salaryPerHour);
            }
            else
            {
                LblInsertError.Text = "Ungültige Eingabe!";
            }
        }
    }
}
