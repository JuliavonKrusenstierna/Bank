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
            BankAccount saveAcc = customer.CreateBankAccount("SavingsAccount");
            customer.BankAccounts.Add(saveAcc);

            BankAccount checkAcc = customer.CreateBankAccount("CheckingAccount");
            customer.BankAccounts.Add(checkAcc);

            BankAccount retAcc= customer.CreateBankAccount("RetiermentAccount");
            customer.BankAccounts.Add(retAcc);

            
            saveAcc.Deposit(500);
            checkAcc.Deposit(400);
            retAcc.Deposit(300);

            saveAcc.IsWithdrawPossible(200);
            checkAcc.IsWithdrawPossible(200);
            retAcc.IsWithdrawPossible(200);
 
   
        }
    }



}

