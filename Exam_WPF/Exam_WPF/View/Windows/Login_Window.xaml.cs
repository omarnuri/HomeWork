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
    }
}
