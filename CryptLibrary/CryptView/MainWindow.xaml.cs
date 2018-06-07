﻿using MahApps.Metro.Controls;
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
using CryptLibrary;

namespace CryptView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            List<String> NamesCrypts = new List<string>
            {
                "Caesar","XOR"
            };
            Combo.ItemsSource = NamesCrypts;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ICryptService src = new Caesar();
            crtext.Text = src.Crypt(text.Text, key.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ICryptService src = new Caesar();
            text.Text = src.Decrypt(crtext.Text, key.Text);
        }
    }
}
