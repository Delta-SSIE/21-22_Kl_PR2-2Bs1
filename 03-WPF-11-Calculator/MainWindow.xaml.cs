﻿using System;
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

namespace _03_WPF_11_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string currentText = "0";
        public MainWindow()
        {
            InitializeComponent();
            RenderDisplay();
        }

        private void RenderDisplay()
        {
            DisplayTB.Text = currentText;
        }

        private void NumberBtn_Click(object sender, RoutedEventArgs e)
        {
            Button pressedBtn = (Button)sender;
            string digit = pressedBtn.Content.ToString();

            if (currentText == "0")
                currentText = "";

            currentText += digit;
            RenderDisplay();
        }
    }
}
