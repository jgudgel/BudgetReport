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
        const string HINTCAT = "All, Food, Housing...";
        const string HINTEST = "436, 2788, 10.99...";
        const string HINTY = "yyyy";
        const string HINTM = "mm";
        const string HINTD = "dd";
        const string EMPTY = "";

        ExcelWriter ew = null;
        string currentDate = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() +
                                DateTime.Now.ToString("dd");
        bool emptyE = false, formatE = false;
        string dateInit = "";
        string dateFin = "";
        string category = "";
        double estimate, toSpend;
        int timeSpanFin, timeSpanRemain;

        public BudgetReportForm()
        {
            InitializeComponent();
            #region More Initializing
            DateITextY.Text = DateTime.Now.Year.ToString();
            DateITextM.Text = DateTime.Now.ToString("MM");
            DateITextD.Text = "01";
            DateFTextY.Text = DateTime.Now.Year.ToString();
            DateFTextM.Text = DateTime.Now.ToString("MM");
            DateFTextD.Text = DateTime.DaysInMonth(DateTime.Now.Year, 
                                            DateTime.Now.Month).ToString();
            /* hint default
            DateITextY.Text = HINTY;
            DateITextM.Text = HINTM;
            DateITextD.Text = HINTD;
            DateFTextY.Text = HINTY;
            DateFTextM.Text = HINTM;
            DateFTextD.Text = HINTD;
            DateITextY.ForeColor = SystemColors.GrayText;
            DateITextM.ForeColor = SystemColors.GrayText;
            DateITextD.ForeColor = SystemColors.GrayText;
            DateFTextY.ForeColor = SystemColors.GrayText;
            DateFTextM.ForeColor = SystemColors.GrayText;
            DateFTextD.ForeColor = SystemColors.GrayText;*/
            CategoryTextBox.Text = HINTCAT;
            EstimateTextBox.Text = HINTEST;
            CategoryTextBox.ForeColor = SystemColors.GrayText;
            EstimateTextBox.ForeColor = SystemColors.GrayText;
            #endregion

            #region Event Handlers
            CalcButton.Click += new System.EventHandler(CalcButton_Click);

            DateITextY.Enter += new System.EventHandler(DateITextY_EnterHint);
            DateITextM.Enter += new System.EventHandler(DateITextM_EnterHint);
            DateITextD.Enter += new System.EventHandler(DateITextD_EnterHint);
            DateFTextY.Enter += new System.EventHandler(DateFTextY_EnterHint);
            DateFTextM.Enter += new System.EventHandler(DateFTextM_EnterHint);
            DateFTextD.Enter += new System.EventHandler(DateFTextD_EnterHint);
            CategoryTextBox.Enter += new System.EventHandler(CategoryTextBox_EnterHint);
            EstimateTextBox.Enter += new System.EventHandler(EstimateTextBox_EnterHint);

            DateITextY.Leave += new System.EventHandler(DateITextY_LeaveEmpty);
            DateITextM.Leave += new System.EventHandler(DateITextM_LeaveEmpty);
            DateITextD.Leave += new System.EventHandler(DateITextD_LeaveEmpty);
            DateFTextY.Leave += new System.EventHandler(DateFTextY_LeaveEmpty);
            DateFTextM.Leave += new System.EventHandler(DateFTextM_LeaveEmpty);
            DateFTextD.Leave += new System.EventHandler(DateFTextD_LeaveEmpty);
            CategoryTextBox.Leave += new System.EventHandler(CategoryTextBox_LeaveEmpty);
            EstimateTextBox.Leave += new System.EventHandler(EstimateTextBox_LeaveEmpty);
            #endregion

            this.FormClosing += Form_Closing;
            
            ew = new ExcelWriter();
            AddressLabel.Text = ew.getDocPath();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            dateInit = DateITextY.Text + DateITextM.Text + DateITextD.Text;
            dateFin = DateFTextY.Text + DateFTextM.Text + DateFTextD.Text;
            category = CategoryTextBox.Text;

            // All fields must have entry
            emptyE = (CategoryTextBox.Text == HINTCAT || EstimateTextBox.Text == HINTEST ||
                DateITextY.Text == HINTY || DateITextM.Text == HINTM || DateITextD.Text == HINTD ||
                DateFTextY.Text == HINTY || DateFTextM.Text == HINTM || DateFTextD.Text == HINTD)
                ? true : false;

            // Estimate must be a numeric value
            // Dates must have format yyyy mm and dd 
            formatE = formatCheck(dateInit, dateFin, EstimateTextBox.Text);

            if (emptyE)
            {
                MessageBox.Show("Please enter a value in all fields.");
            }
            else if(formatE)
            {
                MessageBox.Show("Invalid entry, please double check each field.");
            }
            else
            {
                estimate = Convert.ToDouble(EstimateTextBox.Text);
                timeSpanFin = ew.calcDateRange(dateInit, dateFin);
                timeSpanRemain = ew.calcDateRange(currentDate, dateFin);
                toSpend = ew.calculateProg(category, dateInit, dateFin, estimate);

                MessageBox.Show("$"+Math.Round(toSpend,2).ToString()+" left to spend over\n"
                    +timeSpanRemain.ToString()+" days in your\n"
                    +category+" budget.");
            }
        }

        bool formatCheck(string dateInit, string dateFin, string estimate)
        {
            bool convertE = false, lengthE = false;

            try
            {
                int dateInitInt = Convert.ToInt32(dateInit);
                int dateFinInt = Convert.ToInt32(dateFin);
                Convert.ToDouble(estimate);

                DateTime initDate = new DateTime(dateInitInt / 10000,
                                                (dateInitInt / 100) % 100,
                                                dateInitInt % 100);
                DateTime finDate = new DateTime(dateFinInt / 10000,
                                                (dateFinInt / 100) % 100,
                                                dateFinInt % 100);
            }
            catch (FormatException)
            {
                convertE = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                convertE = true;
            }

            if (dateInit.Length != 8 && dateInit.Length != 8)
            {
                lengthE = true;
            }

            return convertE || lengthE;
        }

        private void Form_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ew.Close();
        }


        #region Entering textbox with hints
        private void CategoryTextBox_EnterHint(object sender, EventArgs e)
        {
            if (CategoryTextBox.Text == HINTCAT)
            {
                CategoryTextBox.Text = EMPTY;
                CategoryTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void EstimateTextBox_EnterHint(object sender, EventArgs e)
        {
            if (EstimateTextBox.Text == HINTEST)
            {
                EstimateTextBox.Text = EMPTY;
                EstimateTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void DateITextY_EnterHint(object sender, EventArgs e)
        {
            if (DateITextY.Text == HINTY)
            {
                DateITextY.Text = EMPTY;
                DateITextY.ForeColor = SystemColors.WindowText;
            }
        }

        private void DateITextM_EnterHint(object sender, EventArgs e)
        {
            if (DateITextM.Text == HINTM)
            {
                DateITextM.Text = EMPTY;
                DateITextM.ForeColor = SystemColors.WindowText;
            }
        }

        private void DateITextD_EnterHint(object sender, EventArgs e)
        {
            if (DateITextD.Text == HINTD)
            {
                DateITextD.Text = EMPTY;
                DateITextD.ForeColor = SystemColors.WindowText;
            }
        }

        private void DateFTextY_EnterHint(object sender, EventArgs e)
        {
            if (DateFTextY.Text == HINTY)
            {
                DateFTextY.Text = EMPTY;
                DateFTextY.ForeColor = SystemColors.WindowText;
            }
        }

        private void DateFTextM_EnterHint(object sender, EventArgs e)
        {
            if (DateFTextM.Text == HINTM)
            {
                DateFTextM.Text = EMPTY;
                DateFTextM.ForeColor = SystemColors.WindowText;
            }
        }

        private void DateFTextD_EnterHint(object sender, EventArgs e)
        {
            if (DateFTextD.Text == HINTD)
            {
                DateFTextD.Text = EMPTY;
                DateFTextD.ForeColor = SystemColors.WindowText;
            }
        }

        #endregion

        #region Leaving blank text box shows hints
        private void CategoryTextBox_LeaveEmpty(object sender, EventArgs e)
        {
            if (CategoryTextBox.Text == EMPTY)
            {
                CategoryTextBox.Text = HINTCAT;
                CategoryTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void EstimateTextBox_LeaveEmpty(object sender, EventArgs e)
        {
            if (EstimateTextBox.Text == EMPTY)
            {
                EstimateTextBox.Text = HINTEST;
                EstimateTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void DateITextY_LeaveEmpty(object sender, EventArgs e)
        {
            if (DateITextY.Text == EMPTY)
            {
                DateITextY.Text = HINTY;
                DateITextY.ForeColor = SystemColors.GrayText;
            }
        }

        private void DateITextM_LeaveEmpty(object sender, EventArgs e)
        {
            if (DateITextM.Text == EMPTY)
            {
                DateITextM.Text = HINTM;
                DateITextM.ForeColor = SystemColors.GrayText;
            }
        }

        private void DateITextD_LeaveEmpty(object sender, EventArgs e)
        {
            if (DateITextD.Text == EMPTY)
            {
                DateITextD.Text = HINTD;
                DateITextD.ForeColor = SystemColors.GrayText;
            }
        }

        private void DateFTextY_LeaveEmpty(object sender, EventArgs e)
        {
            if (DateFTextY.Text == EMPTY)
            {
                DateFTextY.Text = HINTY;
                DateFTextY.ForeColor = SystemColors.GrayText;
            }
        }

        private void DateFTextM_LeaveEmpty(object sender, EventArgs e)
        {
            if (DateFTextM.Text == EMPTY)
            {
                DateFTextM.Text = HINTM;
                DateFTextM.ForeColor = SystemColors.GrayText;
            }
        }

        private void DateFTextD_LeaveEmpty(object sender, EventArgs e)
        {
            if (DateFTextD.Text == EMPTY)
            {
                DateFTextD.Text = HINTD;
                DateFTextD.ForeColor = SystemColors.GrayText;
            }
        }
        #endregion
    }
}
