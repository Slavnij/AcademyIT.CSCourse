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

namespace IT.CSCourse.IntegerToBinary
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

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            int i, remainder;
            StringBuilder binary = new StringBuilder();

            if (!Int32.TryParse(inputTextBox.Text, out i)) 
            {
                MessageBox.Show("Поле для текста не содержит числа типа integer.");
                return;
            }

            if (i < 0) 
            {
                MessageBox.Show("Введите неотрицательное число.");
            }

            do 
            {
                remainder = i % 2;
                i = i / 2;
                binary.Insert(0, remainder);
            }
            while (i > 0);

            binaryLabel.Content = binary;
        }
    }
}
