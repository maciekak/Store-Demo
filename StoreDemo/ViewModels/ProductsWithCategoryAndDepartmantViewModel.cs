using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreDemo.BussinessLogic;

namespace StoreDemo.ViewModels
{
    public class ProductsWithCategoryAndDepartmantViewModel : BaseSearchDepartmentsViewModel
    {
        public string DepartmentName { get; set; }
        public string CategoryName { get; set; }
        public List<NameWithId> ProductsWithIds { get; set; }
    }
}