using catalog.api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catalog.api.Context
{
  public class AppDbContext:DbContext
  {

    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {

    }

    public DbSet<Product> Product { get; set; }
  }
}
