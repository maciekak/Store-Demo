using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using StoreDemo.Models;

namespace StoreDemo.DataAccessLayer
{
    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<StoreDbContext>
    {
        protected override void Seed(StoreDbContext context)
        {
            //TODO: add start data
            var departments = new List<DepartmentModel>
            {
                new DepartmentModel {Id = 1, Name = "Elektronika"},
                new DepartmentModel {Id = 2, Name = "Moda"},
                new DepartmentModel {Id = 3, Name = "Dom i ogród"},
                new DepartmentModel {Id = 4, Name = "Motoryzacja"},
                new DepartmentModel {Id = 5, Name = "Dziecko"}
            };

            context.Departments.AddRange(departments);

            base.Seed(context);
        }
    }
}