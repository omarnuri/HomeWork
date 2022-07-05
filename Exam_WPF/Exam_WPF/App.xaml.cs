using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Exam_WPF.View.Windows;
using Exam_WPF.View;

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
            var userView = new Login_Window();
         
            //Model
            var userModel = new UserBaseModel();
            //Presenter
            var userPresenter = new UserPresenter(userModel, userView);
           
            
            this.MainWindow = userView;
            this.MainWindow.Show();
            ServiceLocator.Instance.Add(
                    () => { 
                        return userPresenter; 
                    }
                    );
            ServiceLocator.Instance.Add(
                    () => {
                        var addUserView = new Registration_Windows();
                        var addUserPresenter = new AddUserPresenter(userModel, addUserView);
                        return addUserPresenter;

                       
                    }
                    );
            





        }
    }
}
