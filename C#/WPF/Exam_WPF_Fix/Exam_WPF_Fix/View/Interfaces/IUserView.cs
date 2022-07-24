using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IUserView:IView
{
   
    public event EventHandler<EventArgs> AddUserCalled;
    public event EventHandler<UserViewEventArguments> GetUserCalled;
    public void ShowMessage(string message);
    public void ClearFields();
    public void dtStop();
    public void dtStart();
    
}
