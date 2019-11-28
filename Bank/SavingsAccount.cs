using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class SavingsAccount : BankAccount
    {
        public static decimal Balance { get; protected set; } // låt denna använda en metod. Det är ingen variabel.

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

        public static bool IsWithdrawPossible(decimal Balance, decimal withdraw)
        // Uttag(returvärde ska vara en bool)

        {
            if (Balance < withdraw)
            {
                return false;
            }
            else return true;
        }

        public static decimal MakeWithdraw (decimal Balance, decimal withdraw,bool makeWithdraw)
        {
            if (makeWithdraw.Equals(true))
            {
                Balance = Balance - withdraw;

                return Balance;
            }

            return Balance;

        }

    }
}
