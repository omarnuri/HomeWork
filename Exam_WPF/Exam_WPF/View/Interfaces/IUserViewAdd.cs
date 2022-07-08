using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IUserViewAdd:IView
{
    public event EventHandler<UserViewAddEventArgs> UserViewAdd;
    public void IsUserExist(bool user);
    public void ShowMessage(string message);
    public void ShowDialog();
}
