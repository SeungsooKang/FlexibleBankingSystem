using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class SavingAccount: BankAccount
    {
        public double AnnualInterestRate { get; set; }
        public InterestMode Mode { get; set; }

        public override void Withdraw(double amt)
        {
            if (status == Status.Active)
            {
                if (_balance >= amt)
                    _balance -= amt;
                else
                    throw new Exception("There isn't enough balance. Withdraw failed.\n");
            }
            else
            {
                throw new Exception("The account is not active. Withdraw failed.\n");
            }
        }

        public double GetAnnualInterestAmount()
        {
            return Interest.CalculateInterest(_balance, AnnualInterestRate, Mode);
        }

    }
}
