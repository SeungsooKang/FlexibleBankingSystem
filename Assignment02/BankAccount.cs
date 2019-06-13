using System;
using System.Collections.Generic;
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
        public string AccountNumber { get; set; }

        protected double _balance;
        public double Balance
        {
            get { return _balance; }
        }

        public Owner owner { get; set; }
        public Status status { get; set; }

        public BankAccount(double initialBalance=0)
        {
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

    }
}
