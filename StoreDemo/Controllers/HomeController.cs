using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreDemo.DataAccessLayer;
using StoreDemo.ViewModels;

namespace StoreDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var departmentsRepository = new DepartmentsRepository();
            
            return View(departmentsRepository.GetDepartmentsViewModel());
        }

        public ActionResult Departments()
        {
            var departmentsRepository = new DepartmentsRepository();

            return View(departmentsRepository.GetDepartmentsViewModel());
        }
    }
}