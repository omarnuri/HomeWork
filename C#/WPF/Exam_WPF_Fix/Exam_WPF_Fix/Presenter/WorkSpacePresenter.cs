using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_WPF.View.Windows;
using System.Linq;
public class WorkSpacePresenter
{
    IWorkSpaceView _view;
    IWorkSpaceModel _model;

    public WorkSpacePresenter(IWorkSpaceModel Model, IWorkSpaceView View)
    {
        _view = View;
        _model = Model;
        _view.WorkSpaceLoguot += WorkSpaceLogOut;
        _view.ClientAdd += ClientAdd;
        _view.ClientLoadEvent += ClientLoad;
        _view.ProductAdd += ProductAdd;
        _view.ProductLoadEvent += ProductLoad;
        _view.OrderAdd += OrderAdd;
        _view.OrderLoadEvent += OrderLoad;
    }

    private void WorkSpaceLogOut(object? sender, EventArgs eventArgs)
    {
        var presenter = ServiceLocator.Instance.Get<UserPresenter>();
        _view.Hide();
        presenter.Show();
        
    }
    public void Show()
    {
        _view.Show();
    }
    private void ClientAdd(object? sender, ClientAddEventArgs e)
    {
        _model.AddClient(e._user, e._client);
    }
    private void ClientLoad(object? sender, ClientLoadEventArgs e)
    {
        var client = _model.LoadClient(e._User);

        _view.LoadClient(client);
    }
    private void ProductAdd(object? sender, ProductAddEventArgs e)
    {
        _model.AddProduct(e.product);
    }
    private void ProductLoad(object? sender, EventArgs e)
    {
        var product = _model.LoadProduct();
        _view.LoadProduct(product);
    }

    private void OrderAdd(object? sender, OrderAddEventArgs e)
    {
        _model.AddOrder(e._user, e._order);
    }
    private void OrderLoad(object? sender, OrderLoadEventArgs e)
    {
        var order = _model.LoadOrder(e._User);

        _view.LoadOrder(order);
    }

}
