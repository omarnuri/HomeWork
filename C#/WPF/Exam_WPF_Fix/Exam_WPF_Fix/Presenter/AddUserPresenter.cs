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
        var user = e.User;
        if (Model.AddUser(user))
        {
            View.ShowMessage(string.Empty);
            View.Close();
        }
        else
        {
            View.ShowMessage("Sorry, this login's already exists. Please, try another one");
        }
        
    }
    public void Show()
    {
        View.Show();

    }
    public void ShowDialog()
    {
        View.ShowDialog();
    }

}
