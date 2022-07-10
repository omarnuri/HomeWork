using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IWorkSpaceModel
{
    public void AddClient(User user, Client client);
    public List<Client> LoadClient(User user);
    //public void AddProduct(Product product);
    //public List<Product> LoadProduct();
}
