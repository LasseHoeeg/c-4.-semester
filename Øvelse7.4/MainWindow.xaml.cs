using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Øvelse7._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private ObservableCollection<Person> data;
    
        public MainWindow()
        {
            InitializeComponent();
            textBoxName.DataContext = data;
            textBoxAge.DataContext = data;
            textBoxWeight.DataContext = data;
            textBoxScore.DataContext = data;
            CheckAccepted.DataContext = data;
          //  gridOuter.DataContext = data;

            data = new ObservableCollection<Person>() {
             new Person("Kaj", "30", "133", "2", true),
            new Person("Bent", "40", "190", "5", false),
            new Person("Bob", "27", "100", "99", true),

        };
            
            listBox.ItemsSource = data;
            
        }

        private void Tilfoej_Click(object sender, RoutedEventArgs e)
        {
            data.Add(new Person("Ib", "10", "30", "20", true));
        }
        private void VisPerson_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text =  ((Person)listBox.SelectedItem).Name;
            textBoxAge.Text = ((Person)listBox.SelectedItem).Age;
            textBoxWeight.Text = ((Person)listBox.SelectedItem).Weight;
            textBoxScore.Text = ((Person)listBox.SelectedItem).Score;
            CheckAccepted.IsChecked = ((Person)listBox.SelectedItem).Accepted;

        }

        private void Aendre_Click(object sender, RoutedEventArgs e)
        {
            EditWindow p = new EditWindow(((Person)listBox.SelectedItem));
            p.Closed += Edit_Dialog_Closed;

            p.ShowDialog();
            listBox.Items.Refresh();
        }

        private void Edit_Dialog_Closed(object sender, EventArgs e)
        {
            listBox.Items.Refresh();
        }

    }
}
