namespace BankProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    abstract class Account
    {
        public enum CustromerType { Individual, Company };

        protected CustromerType _customer;
        protected decimal _balance;
        protected decimal _interestRate;

        public Account()
        {
            _customer = CustromerType.Individual;
            _balance = decimal.MinValue;
            _interestRate = decimal.MinValue;
        }

        public Account(CustromerType customer, decimal balance, decimal interestRate)
        {
            _customer = customer;
            _balance = balance;
            _interestRate = interestRate;
        }

        public abstract CustromerType Custromer
        {
            get;
            set;
        }

        public abstract decimal Balance
        {
            get;
            set;
        }

        public abstract decimal InterestRate
        {
            get;
            set;
        }

        public virtual void DepositMoney(decimal money)
        {
            _balance += money;
        }

        public virtual void WithdrawMoney(decimal money)
        {
            _balance -= money;
        }

        public virtual decimal InterestAmount(int months)
        {
            return (decimal)(months * _interestRate);
        }
    }
}
