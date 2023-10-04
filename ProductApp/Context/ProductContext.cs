using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductApp.Models;
using System.Data.Entity;

namespace ProductApp.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set;}
    }
}