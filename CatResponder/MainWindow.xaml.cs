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

namespace CatResponder
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

        private void buttonCat_Click(object sender, RoutedEventArgs e)
        {
            if (MediaButton.Content == FindResource("ON"))
            {
                MediaButton.Content = FindResource("OFF");
            }
            else
            {
                MediaButton.Content = FindResource("ON");
            }
        }

        private void buttonCat_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}
