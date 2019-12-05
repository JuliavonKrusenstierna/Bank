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


namespace Godiskalkylatorn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CandyCalculator candyCalculator; 

        public MainWindow()
        {
            InitializeComponent();

        }



        private void SaveCandy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            string name = InputNamne.Text;
            int age = int.Parse(InPutAge.Text); 

            Person person = new Person();
            CandyCalculator candyCalculator = new CandyCalculator();
            
            candyCalculator.AddPerson(person);


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            int du = 10;


            candyCalculator.DivideCandy(du);

            ListBox.ItemsSource = null; // lägger in kunden i listan av valbara kunder
            ListBox.ItemsSource = candyCalculator.GetPeople(); 
            ListBox.SelectedIndex = 0;
        }
    }






}

