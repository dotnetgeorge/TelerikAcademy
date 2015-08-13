namespace ATM.Client
{
    using System;
    using System.Data.SqlClient;
    using ATM.Data;
    using System.Transactions;

    class TestATM
    {
        static void Main(string[] args)
        {
            Transaction();
        }

        public static void Transaction()
        {
            SqlConnection connection = new SqlConnection("Server=.;Database=ATM;Integrated Security=true");
            SqlCommand query = new SqlCommand("SELECT * FROM CardAccounts WHERE CardNumber = @CardNumber AND CardPIN = @CardPIN", connection);

            connection.Open();

            using (var transaction = new TransactionScope(TransactionScopeOption.Required))
            {
                try
                {
                    decimal cash = 0.00m;
                    Console.Write("Card Number: ");
                    string cardNumber = Console.ReadLine();
                    Console.Write("Card PIN: ");
                    string cardPin = Console.ReadLine();

                    query.Parameters.AddWithValue("@CardNumber", cardNumber);
                    query.Parameters.AddWithValue("@CardPIN", cardPin);

                    SqlDataReader reader = query.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            cash = (decimal)reader["CardCash"];
                            break;
                        }
                    }

                    Console.WriteLine("You have '${0:F2}' in your bank account!", cash);
                    Console.Write("Select ammount to withdraw: ");
                    decimal withdraw = decimal.Parse(Console.ReadLine());

                    if(cash >= withdraw)
                    {
                        cash -= withdraw;
                    }
                    else
                    {
                        string error = String.Format("You can't withdraw more money than you have.!\n You're try to withdraw '${0:F2}' from '${1:F2}'", withdraw, cash);
                        throw new Exception(error);
                    }

                    query.CommandText = "UPDATE CardAccounts SET CardCash = @CardCash WHERE CardNumber = @Number AND CardPIN = @PIN";
                    query.Parameters.AddWithValue("@CardCash", cash);
                    query.Parameters.AddWithValue("@Number", cardNumber);
                    query.Parameters.AddWithValue("@PIN", cardPin);
                    query.ExecuteNonQuery();

                    transaction.Complete();
                    Console.WriteLine("Successfully withdraw money!");
                    Console.WriteLine("Your account now have '${0:F2}'", cash);

                    query.CommandText = "INSERT INTO TransactionsHistory VALUES(@CN, @TranDate, @Ammount)";
                    query.Parameters.AddWithValue("@CN", cardNumber);
                    query.Parameters.AddWithValue("@TranDate", DateTime.Now);
                    query.Parameters.AddWithValue("@Ammount", withdraw);

                    query.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    Console.Error.WriteLine("Error occured: " + se.Message);
                }
            }
            connection.Close();
        }
    }
}