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

namespace TheSomething
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
        int counter = 0;
        private void AboutBtn_Click(object sender, RoutedEventArgs e)
        {
            string egg = "Potatoes";
            TxtBlk.Text = ($"Egg + {egg}");
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            //int VariNum1 = 1;
            //int VariNum2 = 2;
            //TxtBlk.Text = ($"{VariNum1} + {VariNum2} = {VariNum1 + VariNum2}");
            
        }

        private void MysteryBtn_Click(object sender, RoutedEventArgs e)
        {
            counter += 1;
            TxtBlk.Text = ($"{counter}");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
