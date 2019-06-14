using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class CheckingAccount: BankAccount
    {
        public double OverDraftLimit { get; set; }
        public double OverDraftFee { get; set; }

        public CheckingAccount(double initialBalance = 0, double overDraftFee = 5) : base(initialBalance)
        {
            OverDraftFee = overDraftFee;
        }

        public override void Withdraw(double amt)
        {
            if (Status == AccountStatus.Active)
            {
                if (_balance>=amt)
                    _balance -= amt;
                else if (_balance + OverDraftLimit>=amt + OverDraftFee)
                    _balance -= (amt+ OverDraftFee);
                else
                    throw new Exception("The balance has reached OverDraft Limit. Withdraw failed.\n");
            }
            else
            {
                throw new Exception("The account is not active. Withdraw failed.\n");
            }
        }
    }
}
