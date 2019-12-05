using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class BankAccount
    {
        public string AccountType { get; protected set; }
        public decimal Balance { get; protected set; }
        public decimal Credit { get; set; }

        public virtual string AccountName()
        {
            return AccountType;
        }

        public void Deposit(decimal inPut)
        // Insättning
        {
            Balance += inPut;
        }


        public decimal GetCredit(decimal input) 
        {

            Credit += input;
        return Credit; 
    } 




        public virtual bool IsWithdrawPossible( decimal withdraw)
        // Uttag(returvärde ska vara en bool)

        {
            if (Balance > withdraw)
            {
                Balance = Balance - withdraw;
                return true;
            }

            else
               
            return false;
        }

        public virtual decimal Saldo() // metod som räkna ut tillgängligt saldo 
                               // Tillgängligt saldo = kontots saldo + eventuell kredit
        {        
            return Balance; 
        }


        public override string ToString()
        {
            return $"{AccountType} {Balance:C}";
        }

    }
}
