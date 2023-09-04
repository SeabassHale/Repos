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

namespace Names
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

        //Try to find a way to trim the input before checking and sending to/from the list as currently whitespace is enabling multiple same names to be added.
        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !FstNames.Items.Contains(txtName.Text))
            {
                FstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }

            //below pop-up needs more thorough testing
            if (FstNames.Items.Contains(txtName.Text))
            {
                MessageBox.Show($"Error. {txtName.Text} is already in the list");
            }
        }


        //This is probably a bit hacky. Check. Pop-up seems to happen on 
        private void ButtonRemName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && FstNames.Items.Contains(txtName.Text))
            {
                FstNames.Items.Remove(txtName.Text);
                txtName.Clear();
            }

            else //(!FstNames.Items.Contains(txtName.Text))
            {
                MessageBox.Show($"Error. {txtName.Text} not found in list");
            }
        }
    }
}
