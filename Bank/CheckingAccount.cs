using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class CheckingAccount : BankAccount
    {

        public static decimal Deposit(decimal inPut)
        // Insättning
        {
            Balance += inPut;
            return Balance;
        }

        public static decimal Saldo(decimal Credit) // metod som räkna ut tillgängligt saldo 
                                       // Tillgängligt saldo = kontots saldo + eventuell kredit
        {
            Balance = Balance + Credit;
            return Balance;
        }


        public static bool IsWithdrawPossible(decimal Credit, decimal Balance, decimal withdraw)
        // Uttag(returvärde ska vara en bool)

        {         
            Balance += Credit; 

            if (Balance < withdraw)
            {
                return false;
            }
            else return true;
        }

        public static decimal MakeWithdraw(decimal Balance, decimal Credit, decimal withdraw, bool makeWithdraw)
        {
            Balance += Credit;
            if (makeWithdraw.Equals(true))
            {
                Balance = Balance - withdraw;

                return Balance;
            }

            return Balance;

        }




    }
}
