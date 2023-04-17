using Øvelse8._1.DBFolder;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Øvelse8._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PersonContext personContext = new PersonContext();
        public MainWindow()
        {
            InitializeComponent();
            bool created = personContext.Database.EnsureCreated();
            if (created)
            {
                MessageBox.Show("Database er oprettet");
            }
        }
        Klasse klasse = new Klasse("5", "Taber klassen");
        private void Tilfoej_Click(object sender, RoutedEventArgs e)
        {
            personContext.Personer.Add(new Person("Bent", "30", klasse));
            personContext.SaveChanges();
        }

        private void Vis_Click(object sender, RoutedEventArgs e)
        {
            Liste.Items.Clear();
            foreach(Person person in personContext.Personer.ToList()) {
                Liste.Items.Add(person);

            }
        }

        private void VisKlasser_Click(object sender, RoutedEventArgs e)
        {

            ListeKlasser.Items.Clear();
            foreach (Klasse klasse in personContext.Klasser.ToList())
            {
                ListeKlasser.Items.Add(klasse);

            }

        }

        private void TilfoejKlasse_Click(object sender, RoutedEventArgs e)
        {
            personContext.Klasser.Add(new Klasse("5", "NyKlasse"));
            personContext.SaveChanges();

        }

        private void OpdaterKnap_Click(object sender, RoutedEventArgs e)
        {
            Person p = (Person)Liste.SelectedItem;
            p.Name = PersonNavn.Text;
            p.Age = PersonAlder.Text;
            p.LastName = PersonEfternavn.Text;
            personContext.SaveChanges();
        }

        private void SletKnap_Click(object sender, RoutedEventArgs e)
        {
            Person p = (Person)Liste.SelectedItem;
            personContext.Personer.Remove(p);
            personContext.SaveChanges();
        }
    }
}
