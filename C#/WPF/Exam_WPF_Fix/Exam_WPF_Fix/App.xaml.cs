using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Exam_WPF.View;
using Exam_WPF.View.Windows;

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
            ServiceLocator.Instance.Add(
              () => {
                  var WorkSpaceModel = new WorkSpaceModel();
                  var WorkSpaceView = new WorkSpace_Window(userPresenter._user);
                  var WorkSpacePresenter = new WorkSpacePresenter(WorkSpaceModel, WorkSpaceView);
                  return WorkSpacePresenter;

              }
              );

            this.MainWindow = userView;
            this.MainWindow.Show();





        }
    }
}
