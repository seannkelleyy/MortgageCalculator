using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mortgage;
using Xunit;

namespace Mortgage.Tests
{
    public class MortgageModelTests
    {
        // Testing various loan amounts in the CalculatePaymentAmount method of MortgageModel, expecting a payment amount.
        [Theory]
        [InlineData("$0.00" , 0)]
        [InlineData("$71.95", 12000)]
        [InlineData("$13,160.13", 2195000)]
        public void CalculatePaymentAmount_TypicalValues_ShouldReturnMonthlyPayment(String expected, decimal loanAmount)
        {
            MortgageModel mortgage = new MortgageModel();

            double rate =  6.0 / 1200;
            decimal payment = mortgage.CalculatePaymentAmount(loanAmount, rate, 360);
            String actual = payment.ToString("C2");

            Assert.Equal(expected, actual);
        }
    }
}
