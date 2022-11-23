namespace Mortgage
{
    public class MortgageModel
    {
        // Properties for mortgage, they are used for calculating payments by altering
        // certain values for the mortgage.
        public decimal LoanAmount { get; set; }
        public int LoanLength { get; set; }
        public double InterestRate { get; set; }
        public decimal PaidInterest { get; set; }

        // calculates the monthly payment amount based off of information about 
        // the loan provided by the user. 
        // P = loan amount
        // R = interest rate
        // N = number of loan payments
        // returns the monthly payment amount
        public decimal CalculatePaymentAmount(decimal P, double R, int N)
        {
            return P * (decimal) (R * Math.Pow((1 + R), (double)N) / (Math.Pow((1 + R), (double)N) - 1));
        }

    }

}
