using Mortgage;
using System.Text;

namespace MortgageCalculatorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Creates new MortgageModel object named mortgage.
        MortgageModel mortgage = new MortgageModel();
        private void submitButton_Click(object sender, EventArgs e)
        {
            // Clears the PaidInterest property in the mortgage object and Mortgage table in the MortgageDB.db
            // database for each new mortgage calculation.
            SQLAccess.ClearTable();
            mortgage.PaidInterest = 0;

            // Instantiates a StringBuilder object called query with the beginning of a SQLite insert statement.
            StringBuilder query = new StringBuilder("insert into Mortgage (PaymentNumber, BeginningBalance, " +
                "PaymentAmount, Principal, Interest, InterestPaid, EndingBalance) values ");

            // Clears the rows in the mortgageAmortization dataGridView for each new mortgage calculation.
            mortgageAmortization.Rows.Clear();


            if (amountTextBox.Text.Length > 0 && lengthTextBox.Text.Length > 0 && rateTextBox.Text.Length > 0)
            {
                // Adds values to the properties for the mortgage object, values come from text boxes.
                mortgage.LoanAmount = Convert.ToDecimal(amountTextBox.Text);
                // This is divided by 1200 because interest rate is expected as a percent and the value needs to be in months
                mortgage.InterestRate = Convert.ToDouble(rateTextBox.Text) / 1200;
                // This value is multiplied by 12 because the input is expected to years 
                mortgage.LoanLength = Convert.ToInt32(lengthTextBox.Text) * 12;


                // Calls the CalculatePaymentAmount method from thre MortgageModel class and saves return into monthlyPayment variable.
                decimal monthlyPayment = mortgage.CalculatePaymentAmount(mortgage.LoanAmount, mortgage.InterestRate, mortgage.LoanLength);
                // Prints monthlyPayment as a formatted string in the USD currency
                monthlyPaymentAmountLabel.Text = monthlyPayment.ToString("C2");


                // Loops for the length of the mortgage and adds each payment to the database.
                int length = mortgage.LoanLength;
                for (int i = 0; i < length; i++)
                {
                    // Creates a new payment object called new payment in each iteration and calculates the values for each payment with the 
                    // CalculatePayment method.
                    PaymentModel newPayment = PaymentModel.CalculatePayment(mortgage.LoanAmount, mortgage.InterestRate,
                        i + 1, mortgage.PaidInterest, monthlyPayment);

                    // Appends the StringBuilder object query with each new payment.
                    query.Append($"({newPayment.PaymentNumber}, {newPayment.BeginningBalance}, {newPayment.PaymentAmount}," +
                        $" {newPayment.Principal}, {newPayment.Interest}, {newPayment.InterestPaid}, {newPayment.EndingBalance}), ");

                    // Updates the values in the mortgage object to reflect each payment.
                    mortgage.LoanAmount -= newPayment.Principal;
                    mortgage.LoanLength--;
                    mortgage.PaidInterest += newPayment.Interest;

                }

                // Removes the ", " from the end of query.
                query.Remove(query.Length - 2, 2);
                // Saves query to MortgageDB.db database using the SavePayment method.
                SQLAccess.SavePayment(query.ToString());

                // Creates a list of PaymentModels called payments and generates values from the MortgageDB.db using the LoadPayment method.
                List<PaymentModel> payments = SQLAccess.LoadPayment();
                for (int i = 0; i < length; i++)
                {
                    mortgageAmortization.Rows.Add(payments[i].PaymentNumber, payments[i].BeginningBalance.ToString("C2"),
                        payments[i].PaymentAmount.ToString("C2"), payments[i].Principal.ToString("C2"), payments[i].Interest.ToString("C2"),
                        payments[i].InterestPaid.ToString("C2"), payments[i].EndingBalance.ToString("C2"));
                }
            }
            else
            {

                monthlyPaymentAmountLabel.Text = "Please Enter Your Loan Information Above";
            }


        }

        // This button resets the dataGridView, textboxes, as well as the SQLite database.
        private void resetButton_Click(object sender, EventArgs e)
        {
            SQLAccess.ClearTable();
            mortgageAmortization.Rows.Clear();
            amountTextBox.Clear();
            lengthTextBox.Clear();
            rateTextBox.Clear();
        }

        // The below methods are for input validation. They only let the user enter a number or decimal 
        // into the input textboxes. This works by checking if the char is a digit or decimal point.
        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void lengthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void rateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}