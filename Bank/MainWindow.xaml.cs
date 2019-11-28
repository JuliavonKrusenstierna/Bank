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
        Customer customer;
        public MainWindow()
        {
            InitializeComponent();                           
        }
  
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // kund skapas och ska läggas i en lista, vi får skapa kunden här och spara listan här tillsvidare
            List<Customer> customers;
            customers = new List<Customer>(); 
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


            // startscenario, Kalle rik är dock fattig för han har 0 kr på alla konton från början men vinner 2000kr. 
            // Han sätter in pegnarna enligt nedan.

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


            // insättningarna görs framgångsrikt. Allt är nästan frid och fröjd, dock syns inte insättningen under respektive konto i customer.BankAccounts.Add(bankAccount);
            // Ska det uppdateras där? Hur får jag det att uppdateras där?
            //när jag kollar om det hamnat i "customer.BankAccounts.Add(bankAccount);" på rad 53, 56, 59, ligger det inget där.



            //Kalle Rik är dock en slösaktig man och sätter genast på sig spenderarbyxorna och tar ut pengar enligt följande.

            decimal withdrawal = 0;

          
            withdrawal = 600;
            retiermentAccount.IsWithdrawPossible(withdrawal); // Se upp, det är 10% i uttagningsavgift baserat på utagsbeloppet     

            withdrawal = 200;
            savingsAccount.IsWithdrawPossible(withdrawal);

            withdrawal = 500; 
            checkingAccount.IsWithdrawPossible(withdrawal); // (han ska ha 500 kr i credit)
            // I metoden för checkingAccount har jag använt Balance = Balance + creditToUse för att få reda på hur mycket pengar han kan ta ut, det som finns i pengar från insättningen + krediten
            // för att krediten inte ska räknas med om han vill göra ett nytt utdrag skrev jag Balance = Balance - creditToUse 
            // finns det något lättare sätt att göra detta på?

            // Sammanfattning av frågor
            // Hur gör jag göra så att Balance förändras i respektive bankkontot under/i Customer-listan? 
            // Finns det något lättare sätt att använda lösa krediten?
  
        }
    }



}

