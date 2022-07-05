using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AddUserPresenter
{
    IUserViewAdd View;
    IUserModel Model;

    public AddUserPresenter(IUserModel model, IUserViewAdd view)
    {
        View = view;
        Model = model;
        View.UserViewAdd += View_AddUserCalled;

    }
    public void View_AddUserCalled(object? sender, UserViewAddEventArgs e)
    {
        View.IsUserExist(Model.AddUser(e.User));
    }

}
