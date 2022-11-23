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
            // Instantiates a StringBuilder object called query with the beginning of a SQLite insert statement.
            StringBuilder query = new StringBuilder("insert into Mortgage (PaymentNumber, BeginningBalance, " +
                "PaymentAmount, Principal, Interest, InterestPaid, EndingBalance) values ");

            // Clears the Mortgage table in the MortgageDB.db database for each new mortgage calculation.
            SQLAccess.ClearTable();
            // Clears the rows in the mortgageAmortization dataGridView for each new mortgage calculation.
            mortgageAmortization.Rows.Clear();


            if (amountTextBox.Text.Length > 0 && lengthTextBox.Text.Length > 0 && rateTextBox.Text.Length > 0)
            {
                // Adds values to the properties for the mortgage object, values come from text boxes.
                mortgage.LoanAmount = Convert.ToDecimal(amountTextBox.Text);
                // This is divided by 1200 because interest rate is expected as a percent and the value needs to be in months
                mortgage.InterestRate = Convert.ToDouble(rateTextBox.Text) / 1200;
                // This value is multiplied by 12 because the input is expected to be years
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
                    PaymentModel newPayment = PaymentModel.CalculatePayment(mortgage.LoanAmount, mortgage.LoanLength, mortgage.InterestRate,
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

        // This button resets the dataGridView as well as the SQLite database.
        private void resetButton_Click(object sender, EventArgs e)
        {
            SQLAccess.ClearTable();
            mortgageAmortization.Rows.Clear();
        }
    }
}