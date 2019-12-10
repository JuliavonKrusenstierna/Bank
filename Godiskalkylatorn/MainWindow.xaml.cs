using System;
using System.Collections.Generic;
using System.IO;
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


namespace Godiskalkylatorn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       const string fileName = "savedList.bin";

        CandyCalculator candyCalculator;
        Person person; 
        public MainWindow() // startläget, kollar om jag har någon startad fil om ja, visas dessa, annars skapas nya objekt
        {
            InitializeComponent();

            if (File.Exists(fileName))
            {
                candyCalculator = (CandyCalculator)FileOperations.Deserialize(fileName);
            }

            else

            {
                candyCalculator = new CandyCalculator();
                person = new Person();
            }
            ListBox.ItemsSource = null;
            ListBox.ItemsSource = candyCalculator.GetPeople();

        }


        private void SaveCandy_Click(object sender, RoutedEventArgs e)
        {           
            FileOperations.Serialize(candyCalculator, "savedList.bin");
        }  // spar mitt program
       
        private void BtnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            string name = InputNamne.Text;
            int age = int.Parse(InPutAge.Text);

            candyCalculator.AddPerson(name, age);
            ListBox.ItemsSource = null;
            ListBox.ItemsSource = candyCalculator.GetPeople();
        } // lägger till nya personer

        private void Button_Click_1(object sender, RoutedEventArgs e) // knapp som fördelar godisar efter önskad sortering
        {
            int input = int.Parse(InNumOfC.Text); 

            if (BtnAge.IsChecked == true)
            {
                candyCalculator.DivideCandyByAge(input);
                ListBox.ItemsSource = null;
                ListBox.ItemsSource = candyCalculator.GetPeopleByAge();
            }

            if (BtnLetter.IsChecked == true)
            {
                candyCalculator.DivideCandyByName(input);
                ListBox.ItemsSource = null;
                ListBox.ItemsSource = candyCalculator.GetPeopleByName();
            }

            if (BtnOriginal.IsChecked == true)
            {
                candyCalculator.DivideCandy(input);
                ListBox.ItemsSource = null;
                ListBox.ItemsSource = candyCalculator.GetPeople();
            }



        }


    }






}

