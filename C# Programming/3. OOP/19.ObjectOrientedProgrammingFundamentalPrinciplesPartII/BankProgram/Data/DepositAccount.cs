namespace BankProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class DepositAccount : Account
    {
        public DepositAccount()
            : base()
        { }

        public DepositAccount(CustromerType customer, decimal balance, decimal interestRate)
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
                    throw new ArgumentException("Minimal deposit is 1 cent!");
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
                    throw new ArgumentException("Interest rate can't be under 0% !");
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
            if (Balance > money)
            {
                base.WithdrawMoney(money);
                Console.WriteLine("Successfully withdraw money: $" + money);
                Console.WriteLine("Your balance is: $" + Balance);
            }
            else
            {
                Console.WriteLine("You can't withdraw ${0}, because your balance is: ${1}", money, Balance);
            }
        }

        public override decimal InterestAmount(int months)
        {
            if (Balance > 0m && Balance < 1000m)
            {
                return 0m;
            }
            return base.InterestAmount(months);
        }
    }
}
