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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //numbers
            // !!! I could have also tagged these in the XAML and just loop based on the tag but it creates more lines of code actually in total
            // Without MVVM
            zeroButton.Click += numberButton_Click;
            oneButton.Click += numberButton_Click;
            twoButton.Click += numberButton_Click;
            threeButton.Click += numberButton_Click;
            fourButton.Click += numberButton_Click;
            fiveButton.Click += numberButton_Click;
            sixButton.Click += numberButton_Click;
            sevenButton.Click += numberButton_Click;
            eightButton.Click += numberButton_Click;
            nineButton.Click += numberButton_Click;
        }

        private void numberButton_Click(object sender, RoutedEventArgs e)
        {
            var buttonValue = ((Button)sender).Content;

            if (resultLabel.Content.ToString() == "0")
                resultLabel.Content = buttonValue;
            else
                resultLabel.Content = resultLabel.Content.ToString() + buttonValue;
        }

        private void acButton_Click(object sender, RoutedEventArgs e) => resultLabel.Content = "0";

        private void negativeButton_Click(object sender, RoutedEventArgs e) 
        {
            if(resultLabel.Content.ToString() != "0")
                resultLabel.Content = double.Parse(resultLabel.Content.ToString()) * (-1);
        }

        private void percentageButton_Click(object sender, RoutedEventArgs e) => resultLabel.Content = double.Parse(resultLabel.Content.ToString()) / 100;

        private void equalButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
