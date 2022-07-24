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
using System.Collections.ObjectModel;
namespace Exam_WPF.View
{
    /// <summary>
    /// Логика взаимодействия для Registration_Windows.xaml
    /// </summary>
    public partial class Registration_Windows : Window, IUserViewAdd
    {
      

        public Registration_Windows()
        {
            InitializeComponent();

        }
        public void IsUserExist(bool isUserExis)
        {
            if (isUserExis)
            {
                Error_Message_Text.Text = "This login's already exists, please try another one!";
            }

        }

        public event EventHandler<UserViewAddEventArgs> UserViewAdd;
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            User user = new();
            user.Name = Reg_Name.Text;
            user.Surename = Reg_SureName.Text;
            user.Password = Reg_Password.Text;
            user.Login = Reg_Login.Text;
            UserViewAdd?.Invoke(this, new UserViewAddEventArgs(user));
        }
        public void ShowMessage(string message)
        {
            Error_Message_Text.Text = message;
        }
        
        void IUserViewAdd.ShowDialog()
        {
            ShowDialog();
        }

        private void TextBoxChecker(object sender, TextChangedEventArgs e)
        {
            
            foreach (var pb in Blocks.Children)
            {
                if (pb is TextBox && (pb as TextBox).Text == "")
                {
                   Reg_Button.IsEnabled = false;
                   return;

                }
                Reg_Button.IsEnabled = true;

            }
        }

        private void HideShowButton_Click(object sender, RoutedEventArgs e)
        {
            if (Reg_Password_hidden.Visibility == Visibility.Hidden)
            {
                Reg_Password_hidden.Visibility = Visibility.Visible;
                Reg_Password.Visibility = Visibility.Hidden;
                (sender as Button).Content = "Show";
            }
            else
            {
                Reg_Password_hidden.Visibility = Visibility.Hidden;
                Reg_Password.Visibility = Visibility.Visible;
                (sender as Button).Content = "Hide";
            }
        }

        private void Reg_Password_hidden_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Reg_Password.Text = (sender as PasswordBox).Password;
            
        }
    }
}
