namespace BankProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Bank
    {
        private List<Account> accounts;
        private int accountsCount;

        public Bank()
        {
            this.accounts = new List<Account>();
            this.accountsCount = 0;
        }

        public Bank(List<Account> accounts)
        {
            this.accounts = accounts;
            this.accountsCount = accounts.Count;
        }

        public List<Account> Accounts
        {
            get { return this.accounts; }
            set
            {
                if (value.Count < 1)
                {
                    throw new ArgumentException("Accounts must be at leats one!");
                }
                this.accounts = value;
            }
        }

        public int AccountsCount
        {
            get { return this.accountsCount; }
        }

        public void AddAccount(Account account)
        {
            this.accounts.Add(account);
            this.accountsCount++;
        }

        public void RemoveAccount(Account account)
        {
            this.accounts.Remove(account);
            this.accountsCount--;
        }
    }
}
