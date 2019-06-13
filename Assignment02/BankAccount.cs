using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    enum Status
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
        public Status status { get; set; }

        static BankAccount()
        {
            _numOfOpenedAccounts = 0;
        }

        public BankAccount(double initialBalance=0)
        {
            _numOfOpenedAccounts++;
            status = Status.Active;
            _balance = initialBalance;
        }

        public virtual void Deposit(double amt)
        {
            if (status==Status.Active)
                _balance += amt;
            else
                throw new Exception("The account is not active. Deposit failed.\n");
        }

        public abstract void Withdraw(double amt);

        public void Close()
        {
            status = Status.Closed;
            _balance = 0;
            _numOfOpenedAccounts--;
        }

    }
}
