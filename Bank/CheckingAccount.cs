using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class CheckingAccount : BankAccount
    {
        public void Deposit(decimal inPut)
        // Insättning
        {
            Balance += inPut;

        }

        public override bool IsWithdrawPossible(decimal withdraw)
        // Uttag(returvärde ska vara en bool)
        {
            decimal creditToUse = 1000; 
            Balance = Balance + creditToUse;

            if (Balance > withdraw)
            {
                Balance = Balance - withdraw;
                Balance = Balance - creditToUse;
                return true;
            }

            else return false;
        }


        public override decimal Saldo(decimal Credit) // metod som räkna ut tillgängligt saldo 
                                       // Tillgängligt saldo = kontots saldo + eventuell kredit
        {  
            Balance = Balance + Credit;
            return Balance;
        }

    }
}
