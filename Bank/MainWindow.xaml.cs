﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bank
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Customer customer;
        List<Customer> customers = new List<Customer>();

        public MainWindow()
        {
            InitializeComponent();                           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            customer = new Customer()
            {
                Firstnamne = "Kalle",
                Lastnamne = "Rik",
                Cellphone = "999 999 99 99",
                Address = "Guldgruvan 1"
            };
            customers.Add(customer);


            // bankkonton skapas åt Kalle rik, han får tre konton
            BankAccount bankAccount = customer.CreateBankAccount("SavingsAccount");
            customer.BankAccounts.Add(bankAccount);

            bankAccount = customer.CreateBankAccount("CheckingAccount");
            customer.BankAccounts.Add(bankAccount);

            bankAccount = customer.CreateBankAccount("RetiermentAccount");
            customer.BankAccounts.Add(bankAccount);


           

            decimal inPut = 0;

            RetiermentAccount retiermentAccount = new RetiermentAccount();
            inPut = 1100;
            retiermentAccount.Deposit(inPut);

            SavingsAccount savingsAccount = new SavingsAccount();
            inPut = 400;
            savingsAccount.Deposit(inPut);


            CheckingAccount checkingAccount = new CheckingAccount();
            inPut = 500;
            checkingAccount.Deposit(inPut);



            decimal withdrawal = 0;


            withdrawal = 600;
            retiermentAccount.IsWithdrawPossible(withdrawal);

            withdrawal = 200;
            savingsAccount.IsWithdrawPossible(withdrawal);

            withdrawal = 500;
            checkingAccount.IsWithdrawPossible(withdrawal);
        }
    }



}

