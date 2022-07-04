using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class User
{
    List<Product> products { get; set; }
    List<Client> clients { get; set; }
    public string Name { get; set; } 
    public string Login { get; set; }
    public string Password { get; set; }
    public string Surename { get; set; }
 
    
}
