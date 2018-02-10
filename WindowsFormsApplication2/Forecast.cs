using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAManagment
{
    public partial class frmForecast : Form
    {
        public frmForecast()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string s;
            double amount = 0;
            double interestRate = 0;
            double frequency = 0;
            double years = 0;
            double sum = 0;

            // validate amount         
            s = txtAmount.Text;
            // check every char in string for number or dot
            foreach (char c in s)
            {
                if (!char.IsDigit(c) && c != '.')
                {
                    MessageBox.Show("Please type in the correct number");
                    txtAmount.Focus();
                    return;
                }
                // convert string for double
                else amount = double.Parse(s);
            }

            // validate the duration (term in years)
            s = txtYears.Text;
            // check every char in string for number or dot
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Please type in the correct number, only whole number.");
                    txtYears.Focus();
                    return;
                }
                // convert string for double
                else years = double.Parse(s);
            }

            // validate the rate of interest            
            s = txtInterest.Text;
            // check every char in string for number or dot
            foreach (char c in s)
            {
                if (!char.IsDigit(c) && c != '.')
                {
                    MessageBox.Show("Please type in the correct number");
                    txtInterest.Focus();
                    return;
                }
                // convert string for double
                else
                {
                    interestRate = double.Parse(s);
                    interestRate /= 100;
                }
            }

            // take a frequency
            if (rbDaily.Checked) frequency = 365;
            if (rbWeekly.Checked) frequency = 52;
            if (rbForthnightly.Checked) frequency = 26;
            if (rbMonthly.Checked) frequency = 12;
            if (rbQuartely.Checked) frequency = 4;
            if (rbSemiAnnually.Checked) frequency = 2;
            if (rbAnnually.Checked) frequency = 1;            
            
            // calculation of compound interest
            sum = (Math.Pow(interestRate / frequency + 1, frequency * years))*amount;
            // round number to 2 places
            lblSum.Text = Math.Round(sum, 2).ToString();
        }
    }
}
