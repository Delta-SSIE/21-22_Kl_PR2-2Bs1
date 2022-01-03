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

using Microsoft.Win32;

namespace _03_WPF_09_Fotoprohlizec
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

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a file";
            ofd.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|"
                + "PNG (*.png)|*.png|"
                + "JPEG (*.jpg; *.jpeg)|*.jpg;*.jpeg";


            if (ofd.ShowDialog() == true)
            {
                try { 
                    PhotoImg.Source = new BitmapImage(new Uri(ofd.FileName));
                } catch
                {
                    MessageBox.Show(
                        "Error", 
                        "Invalid file format", 
                        MessageBoxButton.OK, 
                        MessageBoxImage.Error
                    );
                }
            }
        }
    }
}
