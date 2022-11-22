using Mortgage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageCalculator
{
    public partial class Form1 : Form
    {
        List<PaymentModel> payments = new List<PaymentModel>();
        MortgageModel mortgage = new MortgageModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            StringBuilder query = new StringBuilder("insert into Mortgage (PaymentNumber, BeginningBalance, PaymentAmount, Principal, Interest, InterestPaid, EndingBalance) values ");
            payments.Clear();
            SQLAccess.ClearTable();
            mortgageAmortization.Rows.Clear();


            if (amountTextBox.Text.Length > 0 && lengthTextBox.Text.Length > 0 && rateTextBox.Text.Length > 0)
            {
                Boolean isdouble = double.TryParse(amountTextBox.Text, out double amount);
                if (isdouble)
                {
                mortgage.LoanAmount = Convert.ToDecimal(amountTextBox.Text);
                }
                else
                {
                    monthlyPaymentAmountLabel.Text = "Please Enter A Valid \nNumber For the Loan Amount";
                }
                mortgage.InterestRate = Convert.ToDouble(rateTextBox.Text) / 1200;
                mortgage.LoanLength = Convert.ToInt32(lengthTextBox.Text) * 12;

                decimal monthlyPayment = mortgage.CalculatePaymentAmount(mortgage.LoanAmount, mortgage.InterestRate, mortgage.LoanLength);
                monthlyPaymentAmountLabel.Text = monthlyPayment.ToString("C2");

                int length = mortgage.LoanLength;
                for (int i = 0; i < length; i++)
                {
                    payments.Add(PaymentModel.CalculatePayment(mortgage.LoanAmount, mortgage.LoanLength, mortgage.InterestRate, i + 1, mortgage.PaidInterest, monthlyPayment));
                    query.Append($"({payments[i].PaymentNumber}, {payments[i].BeginningBalance}, {payments[i].PaymentAmount}, {payments[i].Principal}, {payments[i].Interest}, {payments[i].InterestPaid}, {payments[i].EndingBalance}), ");

                    mortgage.LoanAmount -= payments[i].Principal;
                    mortgage.LoanLength--;
                    mortgage.PaidInterest += payments[i].Interest;
                    
                }

                query.Remove(query.Length - 2, 2);
                SQLAccess.SavePayment(query.ToString());

                for (int i = 0; i < length; i++)
                {
                    List<PaymentModel> payment = SQLAccess.LoadPayment();
                    mortgageAmortization.Rows.Add(payments[i].PaymentNumber, payment[i].BeginningBalance.ToString("C2"), payment[i].PaymentAmount.ToString("C2"), payment[i].Principal.ToString("C2"), payment[i].Interest.ToString("C2"), payment[i].InterestPaid.ToString("C2"), payment[i].EndingBalance.ToString("C2"));
                }
            }
            else
            {
                monthlyPaymentAmountLabel.Text = "Please Enter Your Loan Information Above";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            SQLAccess.ClearTable();
            mortgageAmortization.Rows.Clear();
        }
    }
}
