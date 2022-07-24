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
    public Dictionary<string, List<Order>> orders { get; set; } = new();
    public List<Product> products { get; set; } = new();
    string ClinetPath = @"Resources\Clients.json";
    string ProductPath = @"Resources\Products.json";
    string OrderPath = @"Resources\Orders.json";


    public WorkSpaceModel()
    {

        if (File.ReadAllText(ClinetPath).Length != 0)
        {
            if (JsonSerializer.Deserialize<Dictionary<string, List<Client>>>(File.ReadAllText(ClinetPath)) != null)
            {
                clients = GetClient();
            }

        }
        if (File.ReadAllText(OrderPath).Length != 0)
        {
            if (JsonSerializer.Deserialize<Dictionary<string, List<Order>>>(File.ReadAllText(OrderPath)) != null)
            {
                orders = GetOrder();
            }

        }

        if (File.ReadAllText(ProductPath).Length != 0)
        {

            if (JsonSerializer.Deserialize<List<Product>>(File.ReadAllText(ProductPath)) != null)
            {
                products = LoadProduct();
            }
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

    public void AddProduct(Product product)
    {
        products.Add(product);
        SaveProduct();

    }
    public List<Product> LoadProduct()
    {
        if (File.ReadAllText(ProductPath).Length != 0)
        {
            return JsonSerializer.Deserialize<List<Product>>(File.ReadAllText(ProductPath));
        }
        else
        {
            return new List<Product>();
        }
    }
    private void SaveProduct()
    {
        File.WriteAllText(ProductPath, JsonSerializer.Serialize(products));
    }
    
    private void SaveClient()
    {
        File.WriteAllText(ClinetPath, JsonSerializer.Serialize(clients));
    }
    private Dictionary<string, List<Client>> GetClient()
    {
       return JsonSerializer.Deserialize<Dictionary<string, List<Client>>>(File.ReadAllText(ClinetPath));
    }
    public List<Client> LoadClient(User user)
    {
        if (clients.ContainsKey(user.Login))
        {

        return clients[user.Login];
        }
        return null;
    }

    private void SaveOrder()
    {
        File.WriteAllText(OrderPath, JsonSerializer.Serialize(orders));
    }
    private Dictionary<string, List<Order>> GetOrder()
    {
        return JsonSerializer.Deserialize<Dictionary<string, List<Order>>>(File.ReadAllText(OrderPath));
    }
    public List<Order> LoadOrder(User user)
    {
        if (orders.ContainsKey(user.Login))
        {

            return orders[user.Login];
        }
        return null;
    }
    public void AddOrder(User user, Order order)
    {
        if (orders.ContainsKey(user.Login))
        {
            orders[user.Login].Add(order);
        }
        else
        {
            orders.Add(user.Login, new List<Order>());
            orders[user.Login].Add(order);
        }
        SaveOrder();
    }
}
