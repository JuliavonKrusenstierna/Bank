using System;
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
        BankAccount activeBankAccount;
        Customer bank;
        Customer customer;

        public MainWindow()
        {
            InitializeComponent();                   
            
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            bank = new Customer();
            List<Customer> customers;
            customers = new List<Customer>();
            customer = new Customer()
            {
                Firstnamne = "Kalle",
                Lastnamne = "Rik",
                Cellphone = "070 999 99 99",
                Address = "Guldgruvan 1"
            };
            customers.Add(customer);

            BankAccount bankAccount = customer.CreateBankAccount("SavingsAccount");
            customer.BankAccounts.Add(bankAccount);
            bankAccount = customer.CreateBankAccount("CheckingAccount");
            customer.BankAccounts.Add(bankAccount);
            bankAccount = customer.CreateBankAccount("RetiermentAccount");
            customer.BankAccounts.Add(bankAccount);

            //activeBankAccount = bank.GetActivBankAccount();


            SavingsAccount hej = new SavingsAccount();
            decimal inPut = 200, Balance = 100, Credit = 100, withdraw = 100;
            Balance = SavingsAccount.Deposit(inPut);
            RetiermentAccount old = new RetiermentAccount();
            Balance = 300;
            Balance = RetiermentAccount.Saldo(Balance);


            CheckingAccount olnud = new CheckingAccount();
            Credit = 400;
            Balance = CheckingAccount.Saldo(Credit);

            RetiermentAccount isEnoughMoney = new RetiermentAccount();
            bool makeWithdraw = RetiermentAccount.IsWithdrawPossible(Credit, Balance, withdraw);
            Balance = RetiermentAccount.MakeWithdraw(Balance, Credit, withdraw, makeWithdraw);



        }
    }



}



////            Customer Customers = new Customer();
//BankAccount bankAccount = Customers.CreateBankAccount("Triangel");


//SavingsAccount savingsAccount = new SavingsAccount()
//{

//};
//customer.BankAccounts.Add(savingsAccount);


//            RetiermentAccount retiermentAccount = new RetiermentAccount()
//            {

//            };
//customer.BankAccounts.Add(retiermentAccount);


//            CheckingAccount checkingAccount = new CheckingAccount()
//            {
//                Credit = 100M,

//            };

//customer.BankAccounts.Add(checkingAccount);