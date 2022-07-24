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
using System.Windows.Threading;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Exam_WPF;

namespace Exam_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login_Window : Window, IUserView, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private float _Angle;
        public float Angle
        {
            get { return _Angle; }
            set
            {
                if (_Angle != value)
                {
                    _Angle = value;
                    this.OnPropertChanged();
                }
            }
        }
        DispatcherTimer dt = new();

        private void OnPropertChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Login_Window()
        {
            DataContext = this;
            InitializeComponent();


        }
        public void ShowMessage(string message)
        {
            Error_Field.Text = message;
        }
        private void WindowLoaded(object sender, RoutedEventArgs e)
        {

            dt.Interval = TimeSpan.FromMilliseconds(1);
            dt.Tick += dtTicker;
            dt.Start();

        }
        public void dtStop()
        {
            dt.Stop();
        }
        public void dtStart()
        {
            dt.Start();
        }
        private void dtTicker(object sender, EventArgs e)
        {
            Angle += 0.10f;

        }


        private void Registration_Button_Click(object sender, RoutedEventArgs e)
        {
            AddUserCalled?.Invoke(this, EventArgs.Empty);

        }
        public event EventHandler<UserViewEventArguments> GetUserCalled;
        public event EventHandler<EventArgs> AddUserCalled;

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
        public void ClearFields()
        {
            Password_Field_Text.Clear();
            Password_Field.Clear();
            Login_Field.Clear();
        }
        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
