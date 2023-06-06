
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.Entity;
namespace EF_Code_First_HW.Context;

public class ShopDBContext:DbContext
{

    public ShopDBContext():base("Data Source=localhost;Initial Catalog=Shop;Integrated Security=True")
    {
        
    }
    public DbSet<Item> Items { get; set; }
}