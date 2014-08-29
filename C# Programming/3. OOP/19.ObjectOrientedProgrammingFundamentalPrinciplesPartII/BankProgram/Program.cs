using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankProgram.Data;

namespace BankProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Accounts = Accounts();

            foreach (var account in bank.Accounts)
            {
                account.DepositMoney(500m);
                account.WithdrawMoney(400m);
                Console.WriteLine("Interest amount is: " + account.InterestAmount(3));
                Console.Write("Press any key to continue: ");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static List<Account> Accounts()
        {
            List<Account> accounts = new List<Account>();
            Account.CustromerType customer = new Account.CustromerType();
            DepositAccount depositAccount = new DepositAccount();
            LoanAccount loanAccount = new LoanAccount();

            Console.Write("Number of accounts to add: ");
            int numberOfAccounts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfAccounts; i++)
            {
                int customerType = 0;
                int accountType = 0;

                Console.WriteLine("[{0}] Account", i);
                do
                {
                    Console.WriteLine("Custromer types");
                    Console.WriteLine("1. Individual");
                    Console.WriteLine("2. Company");
                    Console.Write("Custromer: ");
                    customerType = int.Parse(Console.ReadLine());
                } while (customerType < 1 || customerType > 2);

                do
	            {
	                Console.WriteLine("Account types");
                    Console.WriteLine("1. Deposit account");
                    Console.WriteLine("2. Loan account");
                    Console.WriteLine("3. Mortgage account");
                    Console.Write("Account: ");
                    accountType = int.Parse(Console.ReadLine());
	            } while (accountType < 1 || accountType > 3);

                Console.Write("Balance: ");
                decimal balance = decimal.Parse(Console.ReadLine());
                Console.Write("Interest rate: ");
                decimal interestRate = decimal.Parse(Console.ReadLine());

                switch (customerType)
                {
                    case 1:
                        customer = Account.CustromerType.Individual;
                        break;
                    case 2:
                        customer = Account.CustromerType.Company;
                        break;
                }

                switch (accountType)
                {
                    case 1:
                        accounts.Add(new DepositAccount(customer, balance, interestRate));
                        break;
                    case 2:
                        accounts.Add(new LoanAccount(customer, balance, interestRate));
                        break;
                    case 3:
                        accounts.Add(new MortgageAccount(customer, balance, interestRate));
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }

            return accounts;
        }
    }
}
