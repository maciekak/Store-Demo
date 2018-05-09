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
            return _storeDb
                .Categories
                .Where(c => c.Department.Id == departmentId)
                .Select(c => new NameWithId{
                    Name = c.Name,
                    Id = c.Id
                }).ToList();
        }
    }
}