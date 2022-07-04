using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Exam_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //View
            var view = new Login_Window();
            //Model
            var model = new UserBaseModel();
            //Presenter
            var presenter = new UserPresenter(model, view);
            this.MainWindow = view;
            view.Show();
            
            
        }
    }
}
