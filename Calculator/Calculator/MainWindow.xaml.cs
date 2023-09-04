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
using Engine;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        double answer;

        public MainWindow()
        {
            InitializeComponent();            
        }

        private void ButNum1_Click(object sender, RoutedEventArgs e)
        {
            CalculatorDisplay.Content += "1";
        }
        private void ButNum2_Click(object sender, RoutedEventArgs e)
        {
            CalculatorDisplay.Content += "2";
        }
        private void ButNum3_Click(object sender, RoutedEventArgs e)
        {
            CalculatorDisplay.Content += "3";
        }
        private void ButNum4_Click(object sender, RoutedEventArgs e)
        {
            CalculatorDisplay.Content += "4";
        }
        private void ButNum5_Click(object sender, RoutedEventArgs e)
        {
            CalculatorDisplay.Content += "5";
        }
        private void ButNum6_Click(object sender, RoutedEventArgs e)
        {
            CalculatorDisplay.Content += "6";
        }
        private void ButNum7_Click(object sender, RoutedEventArgs e)
        {
            CalculatorDisplay.Content += "7";
        }
        private void ButNum8_Click(object sender, RoutedEventArgs e)
        {
            CalculatorDisplay.Content += "8";
        }
        private void ButNum9_Click(object sender, RoutedEventArgs e)
        {
            CalculatorDisplay.Content += "9";
        }
        private void ButNum0_Click(object sender, RoutedEventArgs e)
        {
            CalculatorDisplay.Content += "0";
        }

        private void ButNumDec_Click(object sender, RoutedEventArgs e)
        {
            string x = (string)CalculatorDisplay.Content;
            string y = ".";
            bool z = x.Contains(y);
            if (z != true)
                CalculatorDisplay.Content += ".";
        }

        private void ButClear_Click(object sender, RoutedEventArgs e)
        {
            CalculatorDisplay.Content = "";
        }
        private void ButClearEv_Click(object sender, RoutedEventArgs e)
        {
            CalculatorDisplay.Content = "";
            EquationDisplay.Content = "";
            CalculatorDisplayFunc.Content = "";
        }

        private void ButEquals_Click(object sender, RoutedEventArgs e)
        {
            if ((string)CalculatorDisplayFunc.Content == "+")
                answer = Convert.ToDouble(EquationDisplay.Content) + Convert.ToDouble(CalculatorDisplay.Content);

            if ((string)CalculatorDisplayFunc.Content == "-")
                answer = Convert.ToDouble(EquationDisplay.Content) - Convert.ToDouble(CalculatorDisplay.Content);
            
            if ((string)CalculatorDisplayFunc.Content == "X")
                answer = Convert.ToDouble(EquationDisplay.Content) * Convert.ToDouble(CalculatorDisplay.Content);

            if ((string)CalculatorDisplayFunc.Content == "/")
                answer = Convert.ToDouble(EquationDisplay.Content) / Convert.ToDouble(CalculatorDisplay.Content);

            EquationDisplay.Content = CalculatorDisplay.Content;
            CalculatorDisplay.Content = answer;
        }

        public void ButAdd_Click(object sender, RoutedEventArgs e)
        {
            funcButPress("+");
        }
        public void ButSub_Click(object sender, RoutedEventArgs e)
        {
            funcButPress("-");
        }
        public void ButMult_Click(object sender, RoutedEventArgs e)
        {
            funcButPress("X");
        }
        public void ButDiv_Click(object sender, RoutedEventArgs e)
        {
            funcButPress("/");
        }

        public void funcButPress(string i)
        {
            Double da = Convert.ToDouble(CalculatorDisplay.Content);
            CalculatorDisplayFunc.Content = i;
            EquationDisplay.Content = $"{da}";
            CalculatorDisplay.Content = "";
            return;
        }

        private void ButPow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButPi_Click(object sender, RoutedEventArgs e)
        {
            CalculatorDisplay.Content = Math.PI;
        }

        private void ButLog_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButRoute_Click(object sender, RoutedEventArgs e)
        {
            EquationDisplay.Content = CalculatorDisplay.Content;
            CalculatorDisplayFunc.Content = "√";
            var r = Convert.ToDouble(EquationDisplay.Content);
            CalculatorDisplay.Content = Convert.ToDouble(Math.Sqrt(r));
        }

        private void ButSqrd_Click(object sender, RoutedEventArgs e)
        {
            double sq = Convert.ToDouble(CalculatorDisplay.Content) * Convert.ToDouble(CalculatorDisplay.Content);
            CalculatorDisplay.Content = sq;
        }
    }
}
