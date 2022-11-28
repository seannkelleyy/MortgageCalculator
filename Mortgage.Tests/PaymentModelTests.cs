using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Mortgage;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mortgage.Tests
{
    public class PaymentModelTests
    {

        // First 3 tests check the first payment of a mortgage, while the last 3 check the second

        [Fact]
        public void CalculatePayment_TypicalValues_ShouldReturnEndingBalance1()
        {
            MortgageModel mortgage = new MortgageModel();
            mortgage.LoanAmount = (decimal)12000;
            mortgage.InterestRate = .00416667;
            mortgage.PaidInterest = 50;

            decimal paymentAmount = (decimal)127.28;

            PaymentModel expected = new PaymentModel
            {
                PaymentNumber = 2,
                BeginningBalance = (decimal)12000,
                PaymentAmount = (decimal)127.28,
                Interest = (decimal)50,
                Principal = (decimal)77.28,
                InterestPaid = 50,
                EndingBalance = (decimal)11922.72
            };

            PaymentModel actual = PaymentModel.CalculatePayment(mortgage.LoanAmount, mortgage.InterestRate, 2, mortgage.PaidInterest, paymentAmount);

            Assert.Equal(expected.EndingBalance.ToString("C2"), actual.EndingBalance.ToString("C2"));
        }


        [Fact]
        public void CalculatePayment_TypicalValues_ShouldReturnInterest1()
        {
            MortgageModel mortgage = new MortgageModel();
            mortgage.LoanAmount = (decimal)12000;
            mortgage.InterestRate = .00416667;
            mortgage.PaidInterest = 50;

            decimal paymentAmount = (decimal)127.28;

            PaymentModel expected = new PaymentModel
            {
                PaymentNumber = 2,
                BeginningBalance = (decimal)12000,
                PaymentAmount = (decimal)127.28,
                Interest = (decimal)50,
                Principal = (decimal)77.28,
                InterestPaid = 50,
                EndingBalance = (decimal)11922.72
            };

            PaymentModel actual = PaymentModel.CalculatePayment(mortgage.LoanAmount, mortgage.InterestRate, 2, mortgage.PaidInterest, paymentAmount);

            Assert.Equal(expected.Interest.ToString("C2"), actual.Interest.ToString("C2"));
        }


        [Fact]
        public void CalculatePayment_TypicalValues_ShouldReturnPrincipal1()
        {
            MortgageModel mortgage = new MortgageModel();
            mortgage.LoanAmount = (decimal)12000;
            mortgage.InterestRate = .00416667;
            mortgage.PaidInterest = 50;

            decimal paymentAmount = (decimal)127.28;

            PaymentModel expected = new PaymentModel
            {
                PaymentNumber = 2,
                BeginningBalance = (decimal)12000,
                PaymentAmount = (decimal)127.28,
                Interest = (decimal)50,
                Principal = (decimal)77.28,
                InterestPaid = 50,
                EndingBalance = (decimal)11922.72
            };

            PaymentModel actual = PaymentModel.CalculatePayment(mortgage.LoanAmount, mortgage.InterestRate, 2, mortgage.PaidInterest, paymentAmount);

            Assert.Equal(expected.Principal.ToString("C2"), actual.Principal.ToString("C2"));
        }

        // Second payment test

        [Fact]
        public void CalculatePayment_TypicalValues_ShouldReturnEndingBalance2()
        {
            MortgageModel mortgage = new MortgageModel();
            mortgage.LoanAmount= (decimal)11922.72;
            mortgage.InterestRate = .00416667;
            mortgage.PaidInterest = 50;

            decimal paymentAmount = (decimal) 127.28;

            PaymentModel expected = new PaymentModel
            {
                PaymentNumber = 2,
                BeginningBalance = (decimal)11922.72,
                PaymentAmount = (decimal)127.28,
                Interest = (decimal)49.68,
                Principal = (decimal)77.60,
                InterestPaid = 50,
                EndingBalance = (decimal)11845.12
            };

            PaymentModel actual = PaymentModel.CalculatePayment(mortgage.LoanAmount, mortgage.InterestRate, 2, mortgage.PaidInterest, paymentAmount);

            Assert.Equal(expected.EndingBalance.ToString("C2"), actual.EndingBalance.ToString("C2"));
        }

        [Fact]
        public void CalculatePayment_TypicalValues_ShouldReturnInterest2()
        {
            MortgageModel mortgage = new MortgageModel();
            mortgage.LoanAmount = (decimal)11922.72;
            mortgage.InterestRate = .00416667;
            mortgage.PaidInterest = 50;

            decimal paymentAmount = (decimal)127.28;

            PaymentModel expected = new PaymentModel
            {
                PaymentNumber = 2,
                BeginningBalance = (decimal)11922.72,
                PaymentAmount = (decimal)127.28,
                Interest = (decimal)49.68,
                Principal = (decimal)77.60,
                InterestPaid = 50,
                EndingBalance = (decimal)11845.12
            };

            PaymentModel actual = PaymentModel.CalculatePayment(mortgage.LoanAmount, mortgage.InterestRate, 2, mortgage.PaidInterest, paymentAmount);

            Assert.Equal(expected.Interest.ToString("C2"), actual.Interest.ToString("C2"));
        }

        [Fact]
        public void CalculatePayment_TypicalValues_ShouldReturnPrincipal2()
        {
            MortgageModel mortgage = new MortgageModel();
            mortgage.LoanAmount = (decimal)11922.72;
            mortgage.InterestRate = .00416667;
            mortgage.PaidInterest = 50;

            decimal paymentAmount = (decimal)127.28;

            PaymentModel expected = new PaymentModel
            {
                PaymentNumber = 2,
                BeginningBalance = (decimal)11922.72,
                PaymentAmount = (decimal)127.28,
                Interest = (decimal)49.68,
                Principal = (decimal)77.60,
                InterestPaid = 50,
                EndingBalance = (decimal)11845.12
            };

            PaymentModel actual = PaymentModel.CalculatePayment(mortgage.LoanAmount, mortgage.InterestRate, 2, mortgage.PaidInterest, paymentAmount);

            Assert.Equal(expected.Principal.ToString("C2"), actual.Principal.ToString("C2"));
        }

    }
}
