using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Customer newCustomer;
        List<Customer> listOfCustomers = new List<Customer>();

        public MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Kod för att välja kund i ComboBoxen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void BtnSelectCustomer_Click(object sender, RoutedEventArgs e) 
        {
            Customer selcetedCustomer = (Customer)CboCustomer.SelectedItem;
          

            if (selcetedCustomer != null)
            {
                CboSelectAccount.ItemsSource = null;
                CboSelectAccount.ItemsSource = selcetedCustomer.GetBankAccounts();
                 CboSelectAccount.SelectedIndex = 0;

            }

        }


        /// <summary>
        /// Kod för att välja konto från aktiv kund
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelectAccount_Click(object sender, RoutedEventArgs e) // välj konto
        {

            BankAccount selcetedBankAccount = (BankAccount)CboSelectAccount.SelectedItem;
        
        }

        /// <summary>
        /// Insättningar och uttag från valt bankkonto = en transaktion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveTransaction_Click(object sender, RoutedEventArgs e)
        {
            BankAccount selcetedBankAccount = (BankAccount)CboSelectAccount.SelectedItem;
            decimal amount = decimal.Parse(TxtAmount.Text);


            if (selcetedBankAccount != null)
            {

                if (OptWithdrawal.IsChecked == true)
                {
                    bool possible = selcetedBankAccount.IsWithdrawPossible(amount);

                    if (possible == false)
                    { MessageBox.Show("Du saknar täckning på kontot"); }

                }

                else if (OptDeposit.IsChecked == true)
                {
                    selcetedBankAccount.Deposit(amount);

                }

                TxtAmount.Clear();
             

            }

        }

        /// <summary>
        /// Skapa ny kund
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            newCustomer = new Customer() // Skapar en ny kund
            {
                Firstnamne = TxtFirstname.Text,
                Lastnamne = TxtLastname.Text,
                Cellphone = TxtPhone.Text,
            }; 
            listOfCustomers.Add(newCustomer); // lägger till kunden i min lista av kunder 

            TxtFirstname.Clear(); // rensar alla textboxar
            TxtLastname.Clear();
            TxtPhone.Clear();

            CboCustomer.ItemsSource = null; // lägger in kunden i listan av valbara kunder
            CboCustomer.ItemsSource = listOfCustomers;
            CboCustomer.SelectedIndex = 0;




        } // Skapar ny kund. Jag tog bort adress

        /// <summary>
        /// Skapa nytt bankkonto till aktiv kund
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNewAccount_Click(object sender, RoutedEventArgs e) 
        {

            Customer selcetedCustomer = (Customer)CboCustomer.SelectedItem;

            if (selcetedCustomer != null)
            {
                if (OptChecking.IsChecked == true)
                {
                    BankAccount checkAcc = selcetedCustomer.CreateBankAccount("CheckingAccount");
                    {
                        decimal getCredit = decimal.Parse(TxtCredit.Text); // hämtar Crediten              
                        checkAcc.GetCredit(getCredit);
                        checkAcc.Saldo();
                        
                    }
                    checkAcc.AccountName();


                    selcetedCustomer.BankAccounts.Add(checkAcc);
                }

                else if (OptSavings.IsChecked == true)
                {
                    BankAccount saveAcc = selcetedCustomer.CreateBankAccount("SavingsAccount");
                    saveAcc.AccountName();
                    saveAcc.Saldo();
                    selcetedCustomer.BankAccounts.Add(saveAcc);
                }

                else if (OptRetirement.IsChecked == true)
                {
                    BankAccount retAcc = selcetedCustomer.CreateBankAccount("RetiermentAccount");
                    retAcc.AccountName();
                    retAcc.Saldo();
                    selcetedCustomer.BankAccounts.Add(retAcc);
                }
            }

        }

        }

}
