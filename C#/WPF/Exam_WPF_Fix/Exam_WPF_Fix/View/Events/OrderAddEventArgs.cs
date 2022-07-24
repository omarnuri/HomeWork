using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class OrderAddEventArgs
    {
        public User _user;
        public Order _order;
    public OrderAddEventArgs(User user, Order order)
    {
        _user = user;
        _order = order;
    }
   }
