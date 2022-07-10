using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ClientLoadEventArgs
{
   public User _User;
    public ClientLoadEventArgs(User user)
    {
        _User = user;
    }
}
