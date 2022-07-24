using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class UserViewEventArguments:EventArgs
{
    public User user { get; }
    public UserViewEventArguments(User _user)
    {
        user = _user;
    }

}
