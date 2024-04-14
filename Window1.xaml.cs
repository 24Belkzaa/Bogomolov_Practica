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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        User user;
        public Window1(string Login, User user)
        {
            InitializeComponent();

            Hello.Content = "Добро пожаловать, " + Login;

            this.user = user;
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void gdfgdf_Click(object sender, RoutedEventArgs e)
        {
            if(Settings.Default == null)
            {
                new Settings(user);
            }

            Settings.Default.Show();
        }
    }
}
