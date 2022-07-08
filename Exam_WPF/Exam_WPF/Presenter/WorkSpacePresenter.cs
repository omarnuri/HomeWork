using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WorkSpacePresenter
{
    IWorkSpaceView _view;
    IWorkSpaceModel _model;
    public WorkSpacePresenter(IWorkSpaceModel Model, IWorkSpaceView View)
    {
        _view = View;
        _model = Model;
    }
    public void Show()
    {
        _view.Show();
    }
    public void Hide()
    {
        _view?.Hide();
    }
}
