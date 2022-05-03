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

namespace Accounting
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

        private void TextBox1_GotFocus(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "UserName")
            {
                textBox1.Text = null;
            }
        }

        private void TextBox1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "UserName";
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "Password";
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "Password")
            {
                textBox.Text = null;
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                new Loading().Show();
                Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Home().Show();
            Close();
        }
    }
}
