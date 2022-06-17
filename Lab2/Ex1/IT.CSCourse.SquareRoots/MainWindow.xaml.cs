using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IT.CSCourse.SquareRoots
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double numberDouble;

            if (!Double.TryParse(inputTextBox.Text, out numberDouble) ) 
            {
                MessageBox.Show("Введите double.");
                return;
            }
 
            numberDouble = Convert.ToDouble(inputTextBox.Text);

            if ( numberDouble < 0) 
            {
                MessageBox.Show("Введите неотрицательное число.");
            } 

            double squareRoot = Math.Sqrt(numberDouble);
            frameworkLabel.Content = string.Format("{0} (Using the .NET Framework)", squareRoot);

            decimal numberDecimal, guess, result,
                delta = Convert.ToDecimal(Math.Pow(10, -28));

            if (!Decimal.TryParse(inputTextBox.Text, out numberDecimal))
            {
                MessageBox.Show("Введите Decimal.");
                return;
            }

            numberDecimal = Convert.ToDecimal(inputTextBox.Text);
            guess = numberDecimal / 2;
            result = ((numberDecimal / guess) + guess) / 2;

            while (Math.Abs(result - guess) > delta) 
            {
                guess = result;
                result = ((numberDecimal / guess) + guess) / 2;
            }

            newtonLabel.Content = string.Format("{0} (Using Newton)", result);
        }
    }
}
