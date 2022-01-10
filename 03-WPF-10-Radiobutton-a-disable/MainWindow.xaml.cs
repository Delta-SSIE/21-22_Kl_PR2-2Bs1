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

namespace _03_WPF_10_Radiobutton_a_disable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SlevaCB.IsChecked = true;
        }

        private void SlevaCB_Checked(object sender, RoutedEventArgs e)
        {
            TypSlevyContainer.IsEnabled = true;
        }

        private void SlevaCB_Unchecked(object sender, RoutedEventArgs e)
        {
            TypSlevyContainer.IsEnabled = false;
        }
    }
}
