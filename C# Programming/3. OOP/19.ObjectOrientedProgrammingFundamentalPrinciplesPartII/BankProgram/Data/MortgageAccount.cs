namespace BankProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MortgageAccount : Account
    {
        public MortgageAccount()
            : base()
        { }

        public MortgageAccount(CustromerType customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public override CustromerType Custromer
        {
            get
            {
                return _customer;
            }
            set
            {
                _customer = value;
            }
        }

        public override decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < 0.01m)
                {
                    throw new ArgumentException("Your balance can't be under 1 cent!");
                }
                _balance = value;
            }
        }

        public override decimal InterestRate
        {
            get
            {
                return _interestRate;
            }
            set
            {
                if (value < 0.00m)
                {
                    throw new ArgumentException("Interest rate can't be under 0%");
                }
                _interestRate = value;
            }
        }

        public override void DepositMoney(decimal money)
        {
            base.DepositMoney(money);
            Console.WriteLine("Successfully deposit: " + money);
            Console.WriteLine("Your balance is: " + Balance);
        }

        public override void WithdrawMoney(decimal money)
        {
            Console.WriteLine("Your account is Mortagage.\nYou can't withdraw money only deposit!");
        }

        public override decimal InterestAmount(int months)
        {
            decimal amount = 0m;
            if (Custromer == CustromerType.Individual)
            {
                if (months - 6 < 0)
                {
                    return 0m;
                }
                else
                {
                    amount = base.InterestAmount(months - 6);
                }
            }
            else if (Custromer == CustromerType.Company)
            {
                if (months > 12)
                {
                    decimal firstYear = base.InterestAmount(12) / 2;
                    amount = firstYear + base.InterestAmount(months - 12);
                }
                else
                {
                    amount = base.InterestAmount(months) / 2;
                }
            }
            else
            {
                return 0;
            }

            return amount;
        }
    }
}
