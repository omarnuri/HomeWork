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
namespace Exam_WPF.View
{
    /// <summary>
    /// Логика взаимодействия для Registration_Windows.xaml
    /// </summary>
    public partial class Registration_Windows : Window,IUserViewAdd 
    {
        public Registration_Windows()
        {
            InitializeComponent();

        }
        public event EventHandler<UserViewAddEventArgs> ShowRegUserCalled;
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            User user = new();
            user.Name = Reg_Name.Text;
            user.Surename = Reg_SureName.Text;
            user.Password = Reg_Password.Text;
            user.Login = Reg_Login.Text;
            ShowRegUserCalled?.Invoke(this, new UserViewAddEventArgs(user));
        }
        //bool IUserViewAdd(User user)
        //{

        //}

    
    }
}
