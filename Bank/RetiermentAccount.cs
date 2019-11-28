using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class RetiermentAccount : BankAccount
    {


        public static decimal Deposit(decimal inPut)
        // Insättning
        {
            Balance += inPut;
            return Balance;
        }
             

        public static decimal Saldo(decimal Balance) // metod som räkna ut tillgängligt saldo 
                                                     // Tillgängligt saldo = kontots saldo + eventuell kredit
        {
            return Balance;
        }

        public static bool IsWithdrawPossible(decimal Credit, decimal Balance, decimal withdraw)
        // Uttag(returvärde ska vara en bool)

        {
            decimal fee = withdraw/10;
            Balance = Balance + Credit - fee;

            if (Balance < withdraw)
            {
                return false;
            }
            else return true;
        }

        public static decimal MakeWithdraw(decimal Balance, decimal Credit, decimal withdraw, bool makeWithdraw)
        {
            decimal fee = withdraw / 10;

            Balance += Credit;
            if (makeWithdraw.Equals(true))
            {
                Balance = Balance - withdraw - fee;

                return Balance;
            }
            return Balance;

        }

    }
}
