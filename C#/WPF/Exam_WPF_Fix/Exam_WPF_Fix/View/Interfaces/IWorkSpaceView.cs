using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IWorkSpaceView : IView
{
    public event EventHandler<EventArgs> WorkSpaceLoguot;
    public event EventHandler<ClientAddEventArgs> ClientAdd;
    public event EventHandler<ClientLoadEventArgs> ClientLoadEvent;
    public event EventHandler<ProductAddEventArgs> ProductAdd;
    public event EventHandler<EventArgs> ProductLoadEvent;

    public event EventHandler<OrderAddEventArgs> OrderAdd;
    public event EventHandler<OrderLoadEventArgs> OrderLoadEvent;

    public void LoadClient(ICollection<Client> clients);
    public void LoadProduct(ICollection<Product> products);
    public void LoadOrder(ICollection<Order> orders);
}
   
