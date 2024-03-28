using System;
using System.Collections.Generic;
using System.IO;
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
using WpfApp3.Classes;
using WpfApp3.Windows;

namespace WpfApp3
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

        private void reg_Click(object sender, RoutedEventArgs e)

        {
            
            Window1 reg = new Window1();

            reg.Show();
            this.Hide();
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var login = log.Text;
            var password = pas.Text;
            var context = new AppDbContext();
            var user = context.users.SingleOrDefault(x => x.Login == login && x.Password == password);
            if (user is null)
            {
                MessageBox.Show("Неправильный логин или пароль!");
                return;
            }

            if (login is not null)
            {
                Window2 zach = new Window2();
                zach.Show();
                this.Hide();
            }
            if (login is ErrorEventArgs)
            {
                //l/*og = Background = red;*/
            }

            //public void Button_Click_1(object sender, RoutedEventArgs e)
            //{
            //    passbox = Visibility;
            //    Visibility = Visibility.Visible;
            //}
        }
    }
}
