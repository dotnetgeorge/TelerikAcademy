namespace BankProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class LoanAccount : Account
    {
        public LoanAccount()
            : base()
        { }

        public LoanAccount(CustromerType customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public override Account.CustromerType Custromer
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
            Console.WriteLine("Your account is Loan.\nYou can't withdraw money only deposit!");
        }

        public override decimal InterestAmount(int months)
        {
            decimal amount = InterestRate;
            if (Custromer == CustromerType.Individual)
            {
                if (months - 3 < 0)
                {
                    amount = 0;
                }
                else
                {
                    amount = base.InterestAmount(months - 3);
                }
            }
            else if (Custromer == CustromerType.Company)
            {
                if (months - 2 < 0)
                {
                    amount = 0;
                }
                else
                {
                    amount = base.InterestAmount(months - 2);
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
