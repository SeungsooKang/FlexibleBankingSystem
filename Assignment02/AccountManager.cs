using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class AccountManager
    {
        public BankAccount ConsolidateAccounts(BankAccount account1, BankAccount account2)
        {
            if (!account1.owner.OwnerID.Equals(account2.owner.OwnerID))
                throw new Exception("The owners of both accounts are different. Cannot be consolidated.\n");
            if (account1.AccountNumber.Equals(account2.AccountNumber))
                throw new Exception("The same accounts cannot be consolidated.\n");

            BankAccount consolidated = null;

            return consolidated;
        }
    }
}
