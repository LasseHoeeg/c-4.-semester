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

namespace Øvelse6._7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Open.Click += Button_Click;
            Save.Click += Button_Click;
            Exit.Click += Button_Click;
            About.Click += Button_Click;

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuValgt.Text = ((MenuItem)sender).Header.ToString();

        }

    }
}
