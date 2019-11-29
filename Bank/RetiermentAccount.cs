using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class RetiermentAccount : BankAccount
    {
        public override void AccountName( )
        {
            AccountType = "Pensionskonto";
        }

        public override bool IsWithdrawPossible(decimal withdraw)
        // Uttag(returvärde ska vara en bool)
        {
            decimal fee = withdraw/10;

            if (Balance - fee> withdraw)
            {
                Balance = Balance - withdraw - fee;
                return true;
            }

            else return false;
        }

       

    }
}
