using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class BankAccount
    {
        public string AccountType { get; set; } // ska kunna vara Savings, Retierment, Checking
        public static decimal Balance { get; protected set; } // låt denna använda en metod. Det är ingen variabel.
        public static decimal Credit { get; protected set; } //krediten kan inte ändras, alla kunder har samma



        //        Programfunktioner som måste hamna i olika metoder
        // Insättning - behöver kopplas till kontot samt kunden 
        // Uttag(returvärde ska vara en bool)
        ////// Lägg upp konto för en kund
        // Tillgängligt saldo = kontots saldo + eventuell kredit

        public static decimal Deposit (decimal inPut)
        // Insättning
        {
            Balance += inPut;
            return Balance; 
          }

        public virtual bool IsWithdrawPossible (decimal withdraw)
        // Uttag(returvärde ska vara en bool)

        {
            if (Balance < withdraw)
            {
                return false;

            }
            else return true; 
        }


        public static decimal Saldo() // metod som räkna ut tillgängligt saldo 
                               // Tillgängligt saldo = kontots saldo + eventuell kredit
        {

        return Balance; 
        }

    }
}
