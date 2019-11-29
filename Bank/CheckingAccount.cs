using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class CheckingAccount : BankAccount
    {


        public override void AccountName()
        {
            AccountType = "Lönekonto";
           
        }

        public void Deposit(decimal inPut)
        // Insättning
        {
            Balance += inPut;

        }

        public override bool IsWithdrawPossible(decimal withdraw)
        // Uttag(returvärde ska vara en bool)
        {
             
            if (Balance + Credit > withdraw)
            {
                Balance -= withdraw;
                
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
