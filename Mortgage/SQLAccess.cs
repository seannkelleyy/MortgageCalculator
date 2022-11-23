using Dapper;
using Microsoft.Data.Sqlite;
using System.Configuration;
using System.Data;
namespace Mortgage
{
    public class SQLAccess
    {
        // This method selects all of the data from the Mortgage table and puts each PaymentModel into a list
        // and returns it. 
        // This will be used for gathering the data from the Mortgage table to populate the mortgageAmortization dataGridView.
        public static List<PaymentModel> LoadPayment()
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                 var output = cnn.Query<PaymentModel>("select * from Mortgage", new DynamicParameters());
                 return output.ToList();
            }
        }

        // This method saves the data from a payment into the Mortgage table of MortgageDB.db. 
        // Takes in a string in the form of a SQL insert statement as a param and executes 
        public static void SavePayment(string queryStr)
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                cnn.Execute(queryStr);
            }
        }

        // This method will be used for clearing the SQLite table called Mortgage in the 
        // MortgageDB.db file. 
        // This works by deleting all of the rows and values by not specifying which rows
        // in the SQL command.
        public static void ClearTable()
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Mortgage;");
            }
        }

        // This method looks for the connection string named "Default" in the app.config
        // file and returns it. 
        // This will be used for quickly pulling up the connection string from one location.
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

/*        "insert into Mortgage (PaymentNumber, BeginningBalance, PaymentAmount, Principal, Interest, " +
                    "InterestPaid, EndingBalance) values (@PaymentNumber, @BeginningBalance, @PaymentAmount, @Principal, " +
                    "@Interest, @InterestPaid, @EndingBalance)", payment"*/
    }
}
