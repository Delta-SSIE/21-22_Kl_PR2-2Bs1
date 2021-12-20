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

namespace _03_WPF_06_Checkbox
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

        private void ZapniBtn_Click(object sender, RoutedEventArgs e)
        {
            SlevaCB.IsChecked = true;
        }

        private void VypniBtn_Click(object sender, RoutedEventArgs e)
        {
            SlevaCB.IsChecked = false;
        }

        private void SlevaCB_Checked(object sender, RoutedEventArgs e)
        {
            if (SlevaCB.IsChecked == true)
            {
                DisplayRect.Fill = Brushes.Green;
            }
            else
            {
                DisplayRect.Fill = Brushes.Red;
            }
        }
    }
}
