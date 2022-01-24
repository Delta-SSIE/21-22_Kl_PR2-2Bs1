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
using System.Windows.Threading;

namespace _03_WPF_12_Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer clockTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            clockTimer.Interval = TimeSpan.FromMilliseconds(100);
            clockTimer.Start();
            clockTimer.Tick += ClockTimer_Tick;
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            Clock.Text = $"{now.Hour:00}:{now.Minute:00}:{now.Second:00}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //System.Threading.Thread.Sleep(5000); // tak ne
            // MessageBox.Show("Už je čas!");
            
            timer.Interval = TimeSpan.FromMilliseconds(1500);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            MessageBox.Show("Už je čas!");
        }
    }
}
