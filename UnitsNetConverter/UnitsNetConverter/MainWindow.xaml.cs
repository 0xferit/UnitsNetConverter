﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using UnitsNet;

namespace UnitsNetConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // http://jsfiddle.net/du09jhpd/

        public MainWindow()
        {
            InitializeComponent();
        }

        private void FromValue_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            ToValue.Text = FromValue.
        }

        private void ToValue_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            FromValue.Text = ToValue.Text + "cnm";
        }
    }
}
