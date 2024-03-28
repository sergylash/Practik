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
using System.Windows.Shapes;
using WpfApp3.Classes;

namespace WpfApp3.Windows
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void vhod_Click(object sender, RoutedEventArgs e)

        {
            
            MainWindow  vhod = new MainWindow();
            vhod.Show();
            this.Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Login = LoginTextBox.Text;
            var pass = passwordBox.Text;
            var email = EmailTextBox.Text;
            var context = new AppDbContext();
            var user_exists = context.users.FirstOrDefault(x => x.Login == Login);
            if (user_exists is not null)
            {
                MessageBox.Show("Пользователь зарегистрирован");
                return;
            }
            var user = new User { Login = Login, Password = pass, Email = email };
            context.users.Add(user);
            context.SaveChanges();
            MessageBox.Show("Welcome to the club buddy!!!");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
