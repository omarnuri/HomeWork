using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<Animal> Animals { get; set; }

    public AppDbContext() : base("data source=as;initial catalog=Zoo;trusted_connection=true")
    {
        
    }
}

