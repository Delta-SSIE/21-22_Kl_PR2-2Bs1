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

namespace _03_WPF_11_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string currentText = "0";


        private double lastValue;
        private SimpleMath.Operation operation;


        public MainWindow()
        {
            InitializeComponent();
            RenderDisplay();
        }

        private void RenderDisplay()
        {
            DisplayTB.Text = currentText;
        }

        private void NumberBtn_Click(object sender, RoutedEventArgs e)
        {
            Button pressedBtn = (Button)sender;
            string digit = pressedBtn.Content.ToString();

            if (currentText == "0")
                currentText = "";

            currentText += digit;
            RenderDisplay();
        }

        private void DotBtn_Click(object sender, RoutedEventArgs e)
        {
            string decimalSeparator = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (currentText.Contains(decimalSeparator))
                return;

            currentText += decimalSeparator;
            RenderDisplay();
        }

        private void ACBtn_Click(object sender, RoutedEventArgs e)
        {
            currentText = "0";
            RenderDisplay();
        }

        private void PlusMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (currentText == "0")
                return;

            currentText = (double.Parse(currentText) * -1).ToString();
            RenderDisplay();
        }

        private void PercentBtn_Click(object sender, RoutedEventArgs e)
        {
            double currentValue = double.Parse(currentText);
            double percentValue = currentValue / 100;
            currentText = percentValue.ToString();
            RenderDisplay();
        }

        private void OperationBtn_Click(object sender, RoutedEventArgs e)
        {
            lastValue = double.Parse(currentText);
            currentText = "0";
            RenderDisplay();

            string symbol = ((Button)sender).Content.ToString();

            switch (symbol)
            {
                case "+":
                    operation = SimpleMath.Operation.Addition;
                    break;
                case "-":
                    operation = SimpleMath.Operation.Subtraction;
                    break;
                case "*":
                    operation = SimpleMath.Operation.Multiplication;
                    break;
                case "/":
                    operation = SimpleMath.Operation.Division;
                    break;

            }

            //if (sender == AdditionBtn)
            //{
            //    operation = SimpleMath.Operation.Addition;
            //}
            //else if (sender == SubtractionBtn)
            //{
            //    operation = SimpleMath.Operation.Subtraction;
            //}
            //else if (sender == MultiplicationBtn)
            //{
            //    operation = SimpleMath.Operation.Multiplication;
            //}
            //else if (sender == DivisionBtn)
            //{
            //    operation = SimpleMath.Operation.Division;
            //}
            
        }

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            double currentValue = double.Parse(currentText);
            double result;

            switch (operation)
            {
                case SimpleMath.Operation.Addition:
                    result = SimpleMath.Add(lastValue, currentValue);
                    break;
                case SimpleMath.Operation.Subtraction:
                    result = SimpleMath.Subtract(lastValue, currentValue);
                    break;
                case SimpleMath.Operation.Multiplication:
                    result = SimpleMath.Multiply(lastValue, currentValue);
                    break;
                case SimpleMath.Operation.Division:
                    result = SimpleMath.Divide(lastValue, currentValue);
                    break;
                default:
                    result = 0; //impossible case
                    break;
            }

            currentText = result.ToString();
            RenderDisplay();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.NumPad0:
                    NumberBtn_Click(ZeroBtn, null);
                    break;
                    //... další číselné klávesy

                case Key.Add:
                    OperationBtn_Click(AdditionBtn, null);
                    break;
                    //... další operační klávesy
            }
        }
    }
}
