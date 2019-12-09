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
       
        {
            Balance += inPut;
        }



        public decimal GetCredit(decimal input) // hämtar kretiden till lönekonto
        {
            Credit += input;
            return Credit; 
        }

        public virtual bool IsWithdrawPossible( decimal withdraw) // Kollar om uttag är möjligt. Ej egen metod för lönekontot.
 
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
                               
        {
            return Balance; 
        }


        public override string ToString()
        {
            return $"{AccountType} {Balance:C}";
        }

    }
}
