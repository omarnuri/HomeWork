using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class UserPresenter
{
    IUserView View;
    IUserModel Model;
    public UserPresenter(IUserModel model, IUserView view)
    {
        View = view;
        Model = model;
        View.GetUserCalled += View_ShowUserCalled;
        view.AddUserCalled += View_AddUserCalled;
    }
    private void View_AddUserCalled(object? sender, EventArgs e)
    {
        var presenter = ServiceLocator.Instance.Get<AddUserPresenter>();
       
    }
     private void View_ShowUserCalled(object? sender, UserViewEventArguments e)
        {
            User? User = Model.GetUser(e.user.Login, e.user.Password);
            View.ViewUser(User);
        }
}
