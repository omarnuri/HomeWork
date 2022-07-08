using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Storage
{
    public List<Product>products = new();
    public void Sell(string Name)
    {
        for (int i = 0; i < products.Count; i++)
        {
            if (products[i].name == Name)
            {
                products[i].count--;
                if (products[i].count == 0)
                {
                    products.RemoveAt(i);
                }
            }
        }
    }
    public void AddProduct(Product product)
    {
        products.Add(product);
    }


}

