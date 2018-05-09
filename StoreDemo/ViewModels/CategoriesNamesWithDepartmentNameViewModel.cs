using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreDemo.BussinessLogic;

namespace StoreDemo.ViewModels
{
    public class CategoriesNamesWithDepartmentNameViewModel : BaseSearchDepartmentsViewModel
    {
        public List<NameWithId> CategoriesNamesAndIds { get; set; }
        public string DepartmentName { get; set; }
    }
}