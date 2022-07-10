using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IWorkSpaceView:IView
{
    public event EventHandler<EventArgs> WorkSpaceLoguot;
    public event EventHandler<ClientAddEventArgs> ClientAdd;
    public event EventHandler<ClientLoadEventArgs> ClientLoadEvent;
}
