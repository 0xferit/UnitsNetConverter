using System;
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


        private void ToValue_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            FromValue.Text = (Double.Parse(ToValue.Text) + 5).ToString();
        }

        private void FromValue_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            ToValue.Text = (Double.Parse(FromValue.Text) - 3).ToString();
        }

        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
            return !regex.IsMatch(text);
        }

        private void ToValue_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private void FromValue_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }
    }
}
