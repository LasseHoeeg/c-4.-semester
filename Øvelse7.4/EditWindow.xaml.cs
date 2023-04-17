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
using System.Windows.Shapes;

namespace Øvelse7._4
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private Person p = null;
        public EditWindow(Person person)
        {
            InitializeComponent();

            p = person;
            textBoxName.DataContext = p;
            textBoxAge.DataContext = p;
            textBoxWeight.DataContext = p;
            textBoxScore.DataContext = p;
            CheckAccepted.DataContext = p;
        }

        private void Aendre_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
