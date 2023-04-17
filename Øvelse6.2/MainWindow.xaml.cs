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

namespace Øvelse6._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void KnapTop_Click(object sender, RoutedEventArgs e)
        {
            var temp = TopRight.Content;
                        
            TopRight.Content = TopLeft.Content;
            TopLeft.Content = temp;
        }

        private void KnapBot_Click(object sender, RoutedEventArgs e)
        {
            var temp = BottomRight.Content;
                        
            BottomRight.Content = BottomLeft.Content;
            BottomLeft.Content = temp;
        }
    }
}
