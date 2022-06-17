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

namespace IT.CSCourse.WPFApplication
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

        private void testButton_Click(object sender, RoutedEventArgs e)
        {
            String InAndOutLine = testinput.Text;

            InAndOutLine = InAndOutLine.Replace(",", "  Y:");
            InAndOutLine = "X:" + InAndOutLine;

            formattedText.Text = InAndOutLine;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            String InAndOutLine;

            while ((InAndOutLine = Console.ReadLine()) != null)
            {

                InAndOutLine = InAndOutLine.Replace(",", "  Y:");
                InAndOutLine = "X:" + InAndOutLine + "\n";

                formattedText.Text += InAndOutLine;
            }
        }
    }
}
