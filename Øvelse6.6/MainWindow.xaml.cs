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

namespace Øvelse6._6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            West.Click += Button_Click;
            East.Click += Button_Click;
            North.Click += Button_Click;
            South.Click += Button_Click;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += ((Button)sender).Content + "\n";

        }
    }
}
