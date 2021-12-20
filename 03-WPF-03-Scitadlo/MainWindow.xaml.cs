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

namespace wpf_02_Scitadlo
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

        private void SectiBtn_Click(object sender, RoutedEventArgs e)
        {


            if (!double.TryParse(Input1TB.Text, out double cislo1) )
            {
                Input1TB.Background = Brushes.Red;
            }
            else
            {
                Input1TB.Background = Brushes.White;
            }

            if (!double.TryParse(Input2TB.Text, out double cislo2))
            {
                Input2TB.Background = Brushes.Red;
            }
            else
            {
                Input2TB.Background = Brushes.White;
            }
          

            double vysledek = cislo1 + cislo2;
            OutputTB.Text = vysledek.ToString();

        }
    }
}
