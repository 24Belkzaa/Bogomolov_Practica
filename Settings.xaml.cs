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
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Window
        
    {
        char[] SpecialChars = "!@#$%^&*()".ToCharArray();

        public static Settings Default;

        User user;
        public Settings(User user)
        {
            InitializeComponent();

            Default = this;
            this.user = user;
        }
        private void OnEmailChange(object sender, EventArgs e)
        {
            if (sender is TextBox box)
            {
                if (string.IsNullOrEmpty(box.Text))
                    box.Background = (ImageBrush)FindResource("email");
                else
                    box.Background = Brushes.White;
            }
        }
        private void OnPasswordChange(object sender, EventArgs e)
        {
            if (sender is TextBox box)
            {
                if (string.IsNullOrEmpty(box.Text))
                    box.Background = (ImageBrush)FindResource("password");
                else
                    box.Background = Brushes.White;
            }
            if (sender is PasswordBox box1)
            {
                if (string.IsNullOrEmpty(box1.Password))
                    box1.Background = (ImageBrush)FindResource("password");
                else
                    box1.Background = Brushes.White;
            }
        }
        private void OnOldPasswordChange(object sender, EventArgs e)
        {
            if (sender is TextBox box)
            {
                if (string.IsNullOrEmpty(box.Text))

                    box.Background = (ImageBrush)FindResource("old_password");
                else
                    box.Background = Brushes.White;
            }
            if (sender is PasswordBox box1)
            {
                if (string.IsNullOrEmpty(box1.Password))

                    box1.Background = (ImageBrush)FindResource("old_password");
                else
                    box1.Background = Brushes.White;
            }
        }
        private bool check1 = true;

        private void Hide_Click1(object sender, RoutedEventArgs e)
        {
            if (check1)
            {
                pass1.Visibility = Visibility.Collapsed;
                Show1.Visibility = Visibility.Visible;
                Show1.Text = pass1.Password;
                check1 = false;
                Hide1.Visibility = Visibility.Collapsed;
                Showpass1.Visibility = Visibility.Visible;
            }
            else
            {
                pass1.Visibility = Visibility.Visible;
                Show1.Visibility = Visibility.Collapsed;
                pass1.Password = Show1.Text;
                check1 = true;
                Hide1.Visibility = Visibility.Visible;
                Showpass1.Visibility = Visibility.Collapsed;
            }
        }
        private bool check2 = true;

        private void Hide_Click2(object sender, RoutedEventArgs e)
        {
            if (check2)
            {
                pass2.Visibility = Visibility.Collapsed;
                Show2.Visibility = Visibility.Visible;
                Show2.Text = pass2.Password;
                check2 = false;
                Hide2.Visibility = Visibility.Collapsed;
                Showpass2.Visibility = Visibility.Visible;
            }
            else
            {
                pass2.Visibility = Visibility.Visible;
                Show2.Visibility = Visibility.Collapsed;
                pass2.Password = Show2.Text;
                check2 = true;
                Hide2.Visibility = Visibility.Visible;
                Showpass2.Visibility = Visibility.Collapsed;
            }
        }
        private bool check3 = true;

        private void Hide_Click3(object sender, RoutedEventArgs e)
        {
            if (check3)
            {
                pass3.Visibility = Visibility.Collapsed;
                Show3.Visibility = Visibility.Visible;
                Show3.Text = pass3.Password;
                check3 = false;
                Hide3.Visibility = Visibility.Collapsed;
                Showpass3.Visibility = Visibility.Visible;
            }
            else
            {
                pass3.Visibility = Visibility.Visible;
                Show3.Visibility = Visibility.Collapsed;
                pass3.Password = Show3.Text;
                check3 = true;
                Hide3.Visibility = Visibility.Visible;
                Showpass3.Visibility = Visibility.Collapsed;
            }
        }
        private bool check4 = true;

        private void Hide_Click4(object sender, RoutedEventArgs e)
        {
            if (check4)
            {
                pass4.Visibility = Visibility.Collapsed;
                Show4.Visibility = Visibility.Visible;
                Show4.Text = pass4.Password;
                check4 = false;
                Hide4.Visibility = Visibility.Collapsed;
                Showpass4.Visibility = Visibility.Visible;
            }
            else
            {
                pass4.Visibility = Visibility.Visible;
                Show4.Visibility = Visibility.Collapsed;
                pass4.Password = Show4.Text;
                check4 = true;
                Hide4.Visibility = Visibility.Visible;
                Showpass4.Visibility = Visibility.Collapsed;
            }
        }

        private void Password_Click(object sender, RoutedEventArgs e)
        {
            Error.Content = "";

            email.BorderBrush = new SolidColorBrush(Colors.White);

            pass1.BorderBrush = new SolidColorBrush(Colors.White);

            pass2.BorderBrush = new SolidColorBrush(Colors.White);

            pass3.BorderBrush = new SolidColorBrush(Colors.White);

            pass4.BorderBrush = new SolidColorBrush(Colors.White);

            Show1.BorderBrush = new SolidColorBrush(Colors.White);

            Show2.BorderBrush = new SolidColorBrush(Colors.White);

            Show3.BorderBrush = new SolidColorBrush(Colors.White);

            Show4.BorderBrush = new SolidColorBrush(Colors.White);

            if (!check2)
            {
                Hide_Click2(null, null);
            }

            if (!check3)
            {
                Hide_Click3(null, null);
            }

            if (!check4)
            {
                Hide_Click4(null, null);
            }

            var old_password = pass2.Password;

            if (old_password != user.Password)
            {
                Error.Content = "Неправильный пароль";

                pass2.BorderBrush = new SolidColorBrush(Colors.Red);

                Show2.BorderBrush = new SolidColorBrush(Colors.Red);

                return;
            }

            var pas1 = pass3.Password;

            var pas2 = pass4.Password;

            if (pas1 != pas2)
            {
                Error.Content = "Пароли должны быть одинаковыми";

                pass4.BorderBrush = new SolidColorBrush(Colors.Red);

                Show4.BorderBrush = new SolidColorBrush(Colors.Red);
                return;
            }
            if (pas1.Length < 8)
            {
                Error.Content = "Пароль должен быть не менее восьми символов";

                pass3.BorderBrush = new SolidColorBrush(Colors.Red);

                Show3.BorderBrush = new SolidColorBrush(Colors.Red);

                return;
            }
            bool small = false;

            bool big = false;

            bool numbers = false;

            bool special = false;

            foreach (char c in pas1)
            {
                if (SpecialChars.Contains(c))
                {
                    special = true;
                }
                else

                if (Char.IsDigit(c))
                {
                    numbers = true;
                }
                else
                if (Char.IsLetter(c))
                {
                    if (Char.IsUpper(c))
                    {
                        big = true;
                    }
                    else
                    {
                        small = true;

                    }
                }
            }
            if (!small)
            {
                Error.Content = "В пароле должны быть маленькие буквы";

                pass3.BorderBrush = new SolidColorBrush(Colors.Red);

                Show3.BorderBrush = new SolidColorBrush(Colors.Red);

                return;
            }

            if (!big)
            {
                Error.Content = "В пароле должны быть большие буквы";

                pass3.BorderBrush = new SolidColorBrush(Colors.Red);

                Show3.BorderBrush = new SolidColorBrush(Colors.Red);

                return;
            }

            if (!numbers)
            {
                Error.Content = "В пароле должны быть цифры";

                pass3.BorderBrush = new SolidColorBrush(Colors.Red);

                Show3.BorderBrush = new SolidColorBrush(Colors.Red);

                return;
            }

            if (!special)
            {
                Error.Content = "В пароле должны быть специальные символы";

                pass3.BorderBrush = new SolidColorBrush(Colors.Red);

                Show3.BorderBrush = new SolidColorBrush(Colors.Red);

                return;
            }

            user.Password = pas1;

            var context = new AppDbContext();

            context.Users.Update(user);

            context.SaveChanges();

            pass2.Password = "";

            pass3.Password = "";

            pass4.Password = "";

            Show2.Text = "";

            Show3.Text = "";

            Show4.Text = "";

            MessageBox.Show("Пароль обновлён");
        }

        private void Email_Click(object sender, RoutedEventArgs e)
        {
           
            Error.Content = "";

            email.BorderBrush = new SolidColorBrush(Colors.White);

            pass1.BorderBrush = new SolidColorBrush(Colors.White);

            pass2.BorderBrush = new SolidColorBrush(Colors.White);

            pass3.BorderBrush = new SolidColorBrush(Colors.White);

            pass4.BorderBrush = new SolidColorBrush(Colors.White);

            Show1.BorderBrush = new SolidColorBrush(Colors.White);

            Show2.BorderBrush = new SolidColorBrush(Colors.White);

            Show3.BorderBrush = new SolidColorBrush(Colors.White);

            Show4.BorderBrush = new SolidColorBrush(Colors.White);

            var Email = email.Text;

            if (!Email.Contains('@') || !Email.Split("@")[1].Contains('.'))
            {
                Error.Content = "Данная почта некорректна";

                email.BorderBrush = new SolidColorBrush(Colors.Red);
                return;
            }
            if (!check1)
            {
                Hide_Click1(null, null);
            }

            var password = pass1.Password;

            if(password != user.Password)
            {
                Error.Content = "Неправильный пароль";

                pass1.BorderBrush = new SolidColorBrush(Colors.Red);

                Show1.BorderBrush = new SolidColorBrush(Colors.Red);

                return;
            }

            user.e_mail = Email;

            var context = new AppDbContext();

            context.Users.Update(user);

            context.SaveChanges();

            email.Text = "";

            pass1.Password = "";

            Show1.Text = "";

            MessageBox.Show("Почта обновлена");
            
        }
    }
}
