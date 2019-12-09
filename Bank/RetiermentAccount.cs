using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class RetiermentAccount : BankAccount
    {

        public RetiermentAccount()
        {
            AccountType = "Pensionskonto:";

        }

        public override bool IsWithdrawPossible(decimal withdraw) // kollar om uttag är möjligt. Tar hänsyn till avgiften.
       
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
