using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class UserViewAddEventArgs:EventArgs
{
    public User User { get;}
    public UserViewAddEventArgs(User user)
    {
        User = user;
    }
}
