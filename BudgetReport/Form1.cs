using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetReport
{
    public partial class BudgetReportForm : Form
    {
        ExcelWriter ew = null;
        string currentDate = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() +
                                DateTime.Now.Day.ToString();
        string dateInit = "";
        string dateFin = "";
        string category = "";
        double estimate, toSpend;
        int timeSpanFin, timeSpanCurr;

        public BudgetReportForm()
        {
            InitializeComponent();

            CalcButton.Click += new System.EventHandler(CalcButton_Click);

            ew = new ExcelWriter();
            AddressLabel.Text = ew.getDocPath();

            this.FormClosing += Form_Closing;
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            // checks: notify the user

            // All fields must have entry

            // Estimate must be a numeric value
            dateInit = DateITextY.Text + DateITextM.Text + DateITextD.Text;
            dateFin = DateFTextY.Text + DateFTextM.Text + DateFTextD.Text;
            category = CategoryTextBox.Text;
            estimate = Convert.ToDouble(EstimateTextBox.Text);

            timeSpanFin = ew.calcDateRange(dateInit, dateFin);
            timeSpanCurr = ew.calcDateRange(dateInit, currentDate);
            toSpend = ew.calculateProg(category, dateInit, dateFin, estimate);

            MessageBox.Show(timeSpanFin + " " + timeSpanCurr + " " + toSpend);
        }

        private void Form_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ew.Close();
        }
    }
}
