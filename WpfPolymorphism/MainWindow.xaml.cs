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

namespace WpfPolymorphism
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
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string username = textBox.Text;
            string password = passwordBox.Password;

            string errorMessage = String.Empty;
            if (!User.IsValidPassword(password, out errorMessage))
            {
                label.Content = errorMessage;
            }
            else
            {
                User userToLogin = new User(username, password);
                // and then log the user in.
            }
        }
    }
}
