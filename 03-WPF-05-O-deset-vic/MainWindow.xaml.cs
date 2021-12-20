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

namespace _03_WPF_05_O_deset_vic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //InputTB_TextChanged(null, null);
            InputTB.Text = "100";
        }

        private void InputTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OutputTB == null)
                return;

            try
            {
                double cislo = InputTB.Text == "" ? 0 : double.Parse(InputTB.Text);
                OutputTB.Text = (cislo + 10).ToString();

                InputTB.Background = Brushes.White;
            }
            catch
            {
                OutputTB.Text = "N/A";
                InputTB.Background = Brushes.Red;
            }
        }
    }
}
