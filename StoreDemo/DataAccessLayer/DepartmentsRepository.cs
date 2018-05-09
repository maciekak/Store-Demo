using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreDemo.ViewModels;

namespace StoreDemo.DataAccessLayer
{
    public class DepartmentsRepository
    {
        private readonly StoreDbContext _storeDb = new StoreDbContext();

        public BaseSearchDepartmentsViewModel GetDepartmentsViewModel()
        {
            return new BaseSearchDepartmentsViewModel
            {
                DepartmentsNames = _storeDb.Departments.Select(d => d.Name).ToList()
            };
        }
    }
}