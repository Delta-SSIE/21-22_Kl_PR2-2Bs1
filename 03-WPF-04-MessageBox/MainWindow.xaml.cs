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

namespace _03_WPF_04_MessageBox
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                "Došlo k neznámé chybě\n\nVypněte počítač a jděte spát.",
                "Chyba",
                MessageBoxButton.YesNoCancel,
                MessageBoxImage.Information
            );

            if (result == MessageBoxResult.Yes)
            {
                ResultLbl.Content = "Jo";
            }
            else if (result == MessageBoxResult.No)
            {
                ResultLbl.Content = "Ne";
            }
            else if (result == MessageBoxResult.Cancel)
            {
                ResultLbl.Content = "Nic";
            }
        }
    }
}
