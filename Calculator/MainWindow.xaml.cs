using Calculator.Enums;
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
        private double? _firstNumber;
        private double? _secondNumber;
        private Operations? _selectedOperation;
        private CalculatorButtons? _lastButtonClicked;

        public MainWindow()
        {
            //TO DO:
            //1.) Div by 0
            //2.) Length with the decimals - possible weird behaviour
            //3.) Percentage button - better functionality

            InitializeComponent();
            _selectedOperation = null;
            _lastButtonClicked = null;

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
            if (_lastButtonClicked == CalculatorButtons.EqualButton)
                reset();

            var buttonValue = ((Button)sender).Content;

            if (resultLabel.Content.ToString() == "0" || _lastButtonClicked == CalculatorButtons.EqualButton)
                resultLabel.Content = buttonValue;
            else
                resultLabel.Content = resultLabel.Content.ToString() + buttonValue;

            _lastButtonClicked = CalculatorButtons.NumberButton;
        }

        private void operationButton_Click(object sender, RoutedEventArgs e)
        {
            _firstNumber = double.Parse(resultLabel.Content.ToString());
            resultLabel.Content = "0";

            if (sender == plusButton)
                _selectedOperation = Operations.Addition;
            else if (sender == minusButton)
                _selectedOperation = Operations.Substraction;
            else if (sender == multiplyButton)
                _selectedOperation = Operations.Multiplication;
            else if (sender == divideButton)
                _selectedOperation = Operations.Division;

            _lastButtonClicked = CalculatorButtons.OperationButton;
            equationLabel.Content = $"{_firstNumber} {Utility.OperationSymbol(_selectedOperation)}";
        }

        private void acButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            reset();
            _lastButtonClicked = CalculatorButtons.ACButton;
        }

        private void negativeButton_Click(object sender, RoutedEventArgs e)
        {
            if(resultLabel.Content.ToString() != "0")
                resultLabel.Content = double.Parse(resultLabel.Content.ToString()) * (-1);

            _lastButtonClicked = CalculatorButtons.NegativeButton;
        }

        private void percentageButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = double.Parse(resultLabel.Content.ToString()) / 100;
            _lastButtonClicked = CalculatorButtons.PercentageButton;
        }

        private void equalButton_Click(object sender, RoutedEventArgs e)
        {
            if(_lastButtonClicked != CalculatorButtons.EqualButton)
                _secondNumber = double.Parse(resultLabel.Content.ToString());
            
            double? result = _firstNumber;

            switch (_selectedOperation)
            {
                case Operations.Addition:
                    result = _firstNumber + _secondNumber;
                    break;
                case Operations.Substraction:
                    result = _firstNumber - _secondNumber;
                    break;
                case Operations.Multiplication:
                    result = _firstNumber * _secondNumber;
                    break;
                case Operations.Division:
                    result = _firstNumber / _secondNumber;
                    break;
                default:
                    result = _secondNumber;
                    break;
            }

            equationLabel.Content = $"{_firstNumber} {Utility.OperationSymbol(_selectedOperation)} {_secondNumber} =";
            
            if(_firstNumber != null)
                _firstNumber = result;

            resultLabel.Content = result.ToString();
            _lastButtonClicked = CalculatorButtons.EqualButton;
        }

        private void decimalButton_Click(object sender, RoutedEventArgs e)
        {
            if (!resultLabel.Content.ToString().Contains('.'))
                resultLabel.Content = $"{resultLabel.Content}.";

            _lastButtonClicked = CalculatorButtons.DecimalButton;
        }

        private void reset()
        {
            _firstNumber = null;
            _secondNumber = null;
            _selectedOperation = null;
            equationLabel.Content = "";
        }
    }
}
