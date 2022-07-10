using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_WPF.View.Windows;
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
        _model.LoadClient(e._User);
       
    }
}
