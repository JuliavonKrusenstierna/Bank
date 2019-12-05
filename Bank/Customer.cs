using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Customer
    {
        public string Firstnamne { get; set; }
        public string Lastnamne { get; set; }
        public string Cellphone { get; set; }

        public List<BankAccount> BankAccounts { get; set; } //Association till BankAccount
        public Customer() // Konstruktor som körs när ett nytt objekt skapas
        {
            BankAccounts = new List<BankAccount>(); // nytt objekt
        }

        public BankAccount CreateBankAccount(string newAccount) // Lägger upp ett konto åt kund
        {
            BankAccount createBankAccount;


            if (newAccount.Equals("CheckingAccount"))
            {
                createBankAccount = new CheckingAccount(); 
             
            }

            else if (newAccount.Equals("RetiermentAccount"))

            {

                createBankAccount = new RetiermentAccount();

            }

            else
           
                createBankAccount = new SavingsAccount();
          
            return createBankAccount;

        }

        public override string ToString()
        {
            return $"{Firstnamne} {Lastnamne}";
        }

        public List<BankAccount> GetBankAccounts()
        {

            return BankAccounts; 
        }

    }



}


