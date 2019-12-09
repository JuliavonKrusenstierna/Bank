using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class CheckingAccount : BankAccount // ärver klass BankAccout
    {

        public CheckingAccount()
        {
            AccountType = "Lönekonto:";
        }


        public override decimal Saldo() // metod som räkna ut tillgängligt saldo 
                                       // Tillgängligt saldo = kontots saldo + eventuell kredit
        {
            Balance += Credit;
            return Balance;
        }

    }
}
