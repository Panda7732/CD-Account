using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CD_Account_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*GetCDData method accepts a CDAccount object as an
        argument. It assigns the data entered by the user to the o
        objects properties.
        */

        private void GetCDData(CDAccount account)
        {

            //temporary variables to hold interest rate and balance
            decimal interestRate;
            decimal balance;

            //get the account number
            account.AccountNumber = accountNumberTextBox.Text;

            //get the maturity date
            account.MaturityDate = maturityDateTextBox.Text;


            //get the interest rate
            if(decimal.TryParse(interestRateTextBox.Text, out interestRate))
            {
                account.InterestRate = interestRate;

                //get the balance
                if (decimal.TryParse(balanceTextBox.Text, out balance))
                {
                    account.Balance = balance;
                }

                else
                {
                    //display error message
                    MessageBox.Show("Invalid Balance");
                }
            }
            else
            {
                //display error message
                MessageBox.Show("Invalid Interest Rate");
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            //create a CDAccount object
            CDAccount myAccount = new CDAccount();
            //get the CD account data
            GetCDData(myAccount);

            //display the CDaccount data
            accountNumberLabel.Text = myAccount.AccountNumber;
            interestRateLabel.Text = myAccount.InterestRate.ToString("n2");
            balanceLabel.Text = myAccount.Balance.ToString("c");
            maturityDateLabel.Text = myAccount.MaturityDate;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
