using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreDemo.BussinessLogic;

namespace StoreDemo.ViewModels
{
    public class DepartmentsNameIdViewModel : BaseSearchDepartmentsViewModel
    {
        public List<NameWithId> DepartmentNameWithId { get; set; }
    }
}