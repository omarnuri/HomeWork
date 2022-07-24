using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class OrderLoadEventArgs
{
   public User _User;
    public OrderLoadEventArgs(User user)
    {
        _User = user;
    }
}
