using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using StoreDemo.Models;

namespace StoreDemo.DataAccessLayer
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext() : base()
        {
            Database.SetInitializer(new StoreDbInitializer());
        }

        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<ClientModel> Clients { get; set; }
    }
}