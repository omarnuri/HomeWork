using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AddUserPresenter
{
    IUserViewAdd View;
    IUserModel Model;

    public AddUserPresenter(IUserModel model, IUserView view)
    {
        View = View;
        Model = model;

    }

}
