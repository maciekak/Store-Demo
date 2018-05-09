using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreDemo.ViewModels;

namespace StoreDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new BaseSearchDepartmentsViewModel
            {
                DepartmentsNames = new List<string>()
                {
                    "First",
                    "Second",
                    "Third",
                    "Fourth"
                }
            };
            
            return View(model);
        }
    }
}