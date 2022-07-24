using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class UserPresenter
{
    IUserView View;
    IUserModel Model;

    public event EventHandler<EventArgs> WorkSpaseCalled;
    public User _user = new();
    public UserPresenter(IUserModel model, IUserView view)
    {
        View = view;
        Model = model;
        View.GetUserCalled += View_ShowUserCalled;
        View.AddUserCalled += View_AddUserCalled;

    }
    private void View_AddUserCalled(object? sender, EventArgs e)
    {
        var presenter = ServiceLocator.Instance.Get<AddUserPresenter>();
        presenter?.ShowDialog();

    }
    private void View_ShowUserCalled(object? sender, UserViewEventArguments e)
    {
        User? User = Model.GetUser(e.user.Login, e.user.Password);
        if (User == null)
        {
            View.ShowMessage("Wrong Login or Password");
        }
        else
        {
            View.dtStop();
            View.Hide();
            View.ShowMessage(string.Empty);
            var presenter = ServiceLocator.Instance.Get<AddUserPresenter>();
            _user = User;
            View_WorkSpaceCalled();

        }
    }
    private void View_WorkSpaceCalled()
    {

        var presenter = ServiceLocator.Instance.Get<WorkSpacePresenter>();
        View.ClearFields();
        presenter?.Show();
    }
    public void Show()
    {
        View.dtStart();
        View.Show();
    }
}
