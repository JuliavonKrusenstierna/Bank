using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class CheckingAccount : BankAccount
    {

        public CheckingAccount()
        {
            AccountType = "Lönekonto:";

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


        public override decimal Saldo() // metod som räkna ut tillgängligt saldo 
                                       // Tillgängligt saldo = kontots saldo + eventuell kredit
        {
            Credit = 0; 
            Balance = Balance + Credit;
            return Balance;
        }

    }
}
