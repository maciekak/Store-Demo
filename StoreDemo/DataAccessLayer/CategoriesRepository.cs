using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreDemo.BussinessLogic;

namespace StoreDemo.DataAccessLayer
{
    public class CategoriesRepository
    {
        private readonly StoreDbContext _storeDb = new StoreDbContext();

        public List<NameWithId> GetCategoriesNamesIdsOfDepartmantById(int departmentId)
        {
            var a = _storeDb
                .Categories.ToList();
            var b = a
                .Where(c => c.Department.Id == departmentId).ToList();
            var d = b
                .Select(c => new NameWithId{
                    Name = c.Name,
                    Id = c.Id
                }).ToList();
            return d;
        }
    }
}