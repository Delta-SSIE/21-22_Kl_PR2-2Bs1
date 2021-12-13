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

namespace _03_WPF_01_Hello_World
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _writeHello = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_writeHello)
                HelloLbl.Content = "Hello World!";
            else
                HelloLbl.Content = "Goodbye World!";

            _writeHello = !_writeHello;
        }

        private void ColorBtn_Click(object sender, RoutedEventArgs e)
        {
            HelloLbl.Foreground = Brushes.Red;
        }

        private void ColorBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            HelloLbl.Foreground = Brushes.Blue;
        }

        private void ColorBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            HelloLbl.Foreground = Brushes.Black;
        }

        private void ZapisBtn_Click(object sender, RoutedEventArgs e)
        {
            HelloLbl.Content = InputTB.Text;
        }
    }
}
