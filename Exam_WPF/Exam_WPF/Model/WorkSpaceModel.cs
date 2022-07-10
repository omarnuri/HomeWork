using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

internal class WorkSpaceModel:IWorkSpaceModel
{
    public Dictionary<string, List<Client>> clients { get; set; } = new();
    public List<Product> products { get; set; } = new();

    public WorkSpaceModel()
    {
        if (File.ReadAllText(@"C:\HomeWork\Exam_WPF\Exam_WPF\Recources\Clients.json") != String.Empty)
        {
            
            if (JsonSerializer.Deserialize<Dictionary<string, List<Client>>>(File.ReadAllText(@"C:\HomeWork\Exam_WPF\Exam_WPF\Recources\Clients.json")) != null)
            {
                clients = GetClient();
            }
            //if (JsonSerializer.Deserialize<List<Product>>(File.ReadAllText(@"C:\HomeWork\Exam_WPF\Exam_WPF\Recources\Products.json")) != null)
            //{
            //    products = LoadProduct();
            //}
        }
    }
    public void AddClient(User user, Client client)
    {
        if (clients.ContainsKey(user.Login))
            {
                clients[user.Login].Add(client);
            }
            else
            {
                clients.Add(user.Login, new List<Client>());
                clients[user.Login].Add(client);
            }
        SaveClient();
    }
    public List<Client> LoadClient(User user)
    {
        if (clients.ContainsKey(user.Login))
        {

        return clients[user.Login];
        }
        return null;
    }

    //public void AddProduct(Product product)
    //{
    //   products.Add(product);
    //   SaveProduct();
      
    //}
    //public List<Product> LoadProduct()
    //{
    //    return JsonSerializer.Deserialize<List<Product>>(File.ReadAllText(@"C:\HomeWork\Exam_WPF\Exam_WPF\Recources\Products.json"));
    //}
    private void SaveProduct()
    {
        File.WriteAllText(@"C:\HomeWork\Exam_WPF\Exam_WPF\Recources\Products.json", JsonSerializer.Serialize(clients));
    }
    private void SaveClient()
    {
        File.WriteAllText(@"C:\HomeWork\Exam_WPF\Exam_WPF\Recources\Clients.json", JsonSerializer.Serialize(clients));
    }
    private Dictionary<string, List<Client>> GetClient()
    {
       return JsonSerializer.Deserialize<Dictionary<string, List<Client>>>(File.ReadAllText(@"C:\HomeWork\Exam_WPF\Exam_WPF\Recources\Clients.json"));
    }
}
