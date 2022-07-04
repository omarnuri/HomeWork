using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IUserView
{
    public event EventHandler<UserViewEventArguments> GetUserCalled;
    public void ViewUser(User user);
}
