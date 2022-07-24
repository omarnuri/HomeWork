using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProductAddEventArgs
{
    public Product product { get; set; }
    public ProductAddEventArgs(Product _product)
    {
        product = _product;
    }

}
