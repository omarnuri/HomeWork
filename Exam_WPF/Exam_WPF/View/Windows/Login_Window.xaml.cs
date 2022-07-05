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
using Exam_WPF.View;
using Exam_WPF.View.Windows;
using Exam_WPF;

namespace Exam_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login_Window : Window, IUserView
    {
        public Login_Window()
        {
            InitializeComponent();
            
        }
        public void ViewUser(User user)
        {
            if (user == null)
            {
                Error_Field.Text = "Пароль или Логин введены не правильно!";
            }
            else
            {
                
                WorkSpace_Window window = new(user);
                window.Show();
                this.Close();
            }
        }
        private void Registration_Button_Click(object sender, RoutedEventArgs e)
        {
            var registration_Windows = new Registration_Windows();
            registration_Windows.ShowDialog();
        }
        public event EventHandler<UserViewEventArguments> GetUserCalled;
        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new();
            user.Login = Login_Field.Text;
            user.Password = Password_Field.Password;
            GetUserCalled?.Invoke(this, new UserViewEventArguments(user));
        }
        private void Password_Field_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (Login_Field.Text != null && Password_Field.Password != null && Login_Field.Text != string.Empty && Password_Field.Password != string.Empty)
            {
                Login_Button.IsEnabled = true;
            }
            else
            {
                Login_Button.IsEnabled = false;
            }
            Password_Field_Text.Text = Password_Field.Password;
            
        }
        private void Login_Field_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Login_Field.Text != null && Password_Field.Password != null && Login_Field.Text != string.Empty && Password_Field.Password != string.Empty)
            {
                Login_Button.IsEnabled = true;
            }
            else
            {
                Login_Button.IsEnabled = false;
            }
        }
        private void ShowButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (Password_Field.Visibility == Visibility.Hidden)
            {
                Password_Field.Visibility = Visibility.Visible;
                Password_Field_Text.Visibility = Visibility.Hidden;
                Show_Button.Content = "Show";
            }
            else
            {
                Password_Field.Visibility = Visibility.Hidden;
                Password_Field_Text.Visibility = Visibility.Visible;
                Show_Button.Content = "Hide";
            }
            
        }
    }
}
