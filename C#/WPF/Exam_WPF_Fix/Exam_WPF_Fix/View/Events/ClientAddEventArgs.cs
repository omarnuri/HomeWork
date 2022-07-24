using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class ClientAddEventArgs
    {
        public User _user;
        public Client _client;
    public ClientAddEventArgs(User user, Client client)
    {
        _user = user;
        _client = client;
    }
   }
