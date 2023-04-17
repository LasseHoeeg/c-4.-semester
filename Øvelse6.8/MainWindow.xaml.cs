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

namespace Øvelse6._8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Hva.Checked += CheckBox_Checked;
            Saa.Checked += CheckBox_Checked;
            Der.Checked += CheckBox_Checked;
            Taber.Checked += CheckBox_Checked;

            Hva.Unchecked += CheckBox_Unchecked;
            Saa.Unchecked += CheckBox_Unchecked;
            Der.Unchecked += CheckBox_Unchecked;
            Taber.Unchecked += CheckBox_Unchecked;

            North.Checked += RadioButton_Checked;
            South.Checked += RadioButton_Checked;
            East.Checked += RadioButton_Checked;
            West.Checked += RadioButton_Checked;
        }


        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            check.Text += ((CheckBox)sender).Content.ToString() + " ";

        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            string[] textArray = check.Text.Split(' ');
            string text = "";
            string thisText = ((CheckBox)sender).Content.ToString() + " ";
          
            foreach (string s in textArray)
            {
                if (s.ToLower().Trim().Equals(thisText.ToLower().Trim()))
                {

                }
                else
                {
                    text += s + " ";
                }
            }
            check.Text = text;

        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            radio.Text = ((RadioButton)sender).Content.ToString();
        }
     

    }
}
