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

namespace Exam_WPF.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для WorkSpace_Window.xaml
    /// </summary>
    public partial class WorkSpace_Window : Window
    {
        public User User { get; set; }
        public WorkSpace_Window(User user)
        {
            InitializeComponent();
            User = user;
            User_Name.Text = user.Name;
            
        }
    }
}
