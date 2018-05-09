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
            Database.SetInitializer<StoreDbContext>(new DropCreateDatabaseIfModelChanges<StoreDbContext>());
        }

        public DbSet<CategoryModel> Categories { get; set; }
    }
}