using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
   
    class AccountManager
    {
        public BankAccount ConsolidateAccountsToChecking(BankAccount account1, BankAccount account2)
        {
            CheckConsolidationCondition(account1, account2);

            BankAccount consolidated = new CheckingAccount(initialBalance: account1.Balance + account2.Balance);
            account1.Close();
            account2.Close();

            return consolidated;
        }

        public BankAccount ConsolidateAccountsToSaving(BankAccount account1, BankAccount account2)
        {
            CheckConsolidationCondition(account1, account2);

            BankAccount consolidated = new SavingAccount(initialBalance: account1.Balance + account2.Balance);
            account1.Close();
            account2.Close();

            return consolidated;
        }

        public void CheckConsolidationCondition(BankAccount account1, BankAccount account2)
        {
            if (!account1.owner.OwnerID.Equals(account2.owner.OwnerID))
                throw new Exception("The owners of both accounts are different. Cannot be consolidated.\n");
            if (account1.AccountNumber.Equals(account2.AccountNumber))
                throw new Exception("The same accounts cannot be consolidated.\n");
        }

    }
}
