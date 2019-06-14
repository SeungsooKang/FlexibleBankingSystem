using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    enum AccountStatus
    {
        Active,
        Closed
    }
    abstract class BankAccount
    {
        private static int _numOfOpenedAccounts;
        public static int NumOfOpenedAccounts
        {
            get { return _numOfOpenedAccounts; }
        }

        public string AccountNumber { get; set; }
        protected double _balance;
        public double Balance
        {
            get { return _balance; }
        }

        public Owner owner { get; set; }
        public AccountStatus Status { get; set; }

        static BankAccount()
        {
            _numOfOpenedAccounts = 0;
        }

        public BankAccount(double initialBalance=0)
        {
            _numOfOpenedAccounts++;
            Status = AccountStatus.Active;
            _balance = initialBalance;
        }

        public virtual void Deposit(double amt)
        {
            if (Status==AccountStatus.Active)
                _balance += amt;
            else
                throw new Exception("The account is not active. Deposit failed.\n");
        }

        public abstract void Withdraw(double amt);

        public void Close()
        {
            Status = AccountStatus.Closed;
            _balance = 0;
            _numOfOpenedAccounts--;
        }

        public void TransferTo(BankAccount destination, double amt)
        {
            if (Status == AccountStatus.Closed)
                throw new Exception("Current account is closed. Cannot send money.\n");
            if (destination.Status == AccountStatus.Closed)
                throw new Exception("Destination account is closed. Cannot send money.\n");

            Withdraw(amt);
            destination.Deposit(amt);
        }

    }
}
