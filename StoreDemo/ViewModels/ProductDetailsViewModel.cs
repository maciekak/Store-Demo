using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreDemo.ViewModels
{
    public class ProductDetailsViewModel : BaseSearchDepartmentsViewModel
    {
        public string DepartmentName { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}