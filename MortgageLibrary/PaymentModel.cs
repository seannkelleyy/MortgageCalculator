using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mortgage
{
    public class PaymentModel

    {
        // These are the properties that are used to save the information about a payment.
        public int PaymentNumber { get; set; }
        public decimal BeginningBalance { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal Principal { get; set; }
        public decimal Interest { get; set; }
        public decimal InterestPaid { get; set; }
        public decimal EndingBalance { get; set; }

        // This method calculates a payment using some of the properties from the MortageModel class. 
        // Returns a PaymentModel object named payment, which will be added to the MortgageDB.db database,
        public static PaymentModel CalculatePayment(decimal balance, int length, double rate, int count, decimal interestPaid, decimal paymentAmount)
        {
            
            PaymentModel payment = new PaymentModel();
            payment.PaymentNumber = count;
            payment.BeginningBalance = balance;
            payment.PaymentAmount = paymentAmount;
            payment.Interest = (balance * (decimal)(rate * 12)) / 12;
            payment.Principal = paymentAmount - payment.Interest;
            payment.InterestPaid = interestPaid;
            payment.EndingBalance = payment.BeginningBalance - payment.Principal;

            return payment;
        }
    }
}
