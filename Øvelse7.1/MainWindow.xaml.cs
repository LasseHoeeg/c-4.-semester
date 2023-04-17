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

namespace Øvelse7._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person("Bob", "27", "100", "99", true);
        public MainWindow()
        {
            InitializeComponent();
            textBoxName.DataContext = person;
            textBoxAge.DataContext = person;
            textBoxWeight.DataContext = person;
            textBoxScore.DataContext = person;
            CheckAccepted.DataContext = person;
            // ChangePerson.Click+= ChangePerson_Click;

            //Person svarer til datacontext ift. eksemplet.

            //Binding Mode=TwoWay skal måske tilføjes i xaml binding path stykket, men det fungerer også uden

        }

        private void ChangePerson_Click(object sender, RoutedEventArgs e)
        {
            person.Name = "Karl";
            person.Age = "20";
            person.Weight = "50";
            person.Score = "40";
            person.Accepted = false;




        }
        private void Change(object sender, RoutedEventArgs e)
        {
            if (person != null)
            {
                person.Name = ((TextBox)sender).Text;

            }

        }


        private void Print_Click(object sender, RoutedEventArgs e)
        {


            MessageBox.Show(person.Name + " " + person.Score);

        }
    }
}
