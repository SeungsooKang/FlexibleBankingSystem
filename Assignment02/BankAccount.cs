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
    class BankAccount
    {
        public string AccountNumber { get; set; }

        private double _balance;
        public double Balance
        {
            get { return _balance; }
        }

        public Owner owner { get; set; }
        public Status status { get; set; }

        public BankAccount(double initialBalance)
        {
            
        }



    }
}
