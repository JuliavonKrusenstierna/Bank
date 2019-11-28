using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Customer
    {
        BankAccount activeBankAccount;

        public string Firstnamne { get; set; }
        public string Lastnamne { get; set; }
        public string Address { get; set; }
        public string Cellphone { get; set; }
        public List<BankAccount> BankAccounts { get; set; } //Association till BankAccount
        public Customer() // Konstruktor som körs när ett nytt objekt skapas
        {
            BankAccounts = new List<BankAccount>(); // nytt objekt
        }

        public BankAccount CreateBankAccount(string vilketKonto) // Lägger upp ett konto åt kund
        {
            BankAccount createBankAccount;

            if (vilketKonto.Equals("CheckingAccount"))
            {
                createBankAccount = new CheckingAccount();
            }

            else if (vilketKonto.Equals("RetiermentAccount"))

            {

                createBankAccount = new RetiermentAccount();
            }

            else
           
                createBankAccount = new SavingsAccount();
          
            return createBankAccount;

        }

    }



}


