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

namespace Calculator
{
    public partial class MainWindow : Window
    {
        private double _currentValue = 0;
        private double _lastValue = 0;
        private string _currentOperator = " ";
        private bool _isNewEntry = true;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Number_Click(object sender, RoutedEventArgs e)
        {
            var button = (System.Windows.Controls.Button)sender;
            string number = button.Content.ToString();

            if (_isNewEntry)
            {
                ResultBox.Text = number;
                _isNewEntry = false;
            }
            else
            {
                ResultBox.Text += number;
            }

        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
