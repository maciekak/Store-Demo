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
        //TODO: add lazy loading
        private readonly DepartmentsRepository _departmentsRepository = new DepartmentsRepository();
        private readonly CategoriesRepository _categoriesRepository = new CategoriesRepository();
        private readonly ProductsRepository _productsRepository = new ProductsRepository();

        // GET: Home
        public ActionResult Index()
        {
            return View(_departmentsRepository.GetDepartmentsViewModel());
        }

        public ActionResult Departments()
        {
            return View(new DepartmentsNameIdViewModel
            {
                DepartmentsNames = _departmentsRepository.GetDepartmentsNames(),
                DepartmentNameWithId = _departmentsRepository.GetDepartmentsNamesIds()
            });
        }

        public ActionResult Categories(int id)
        {
            //TODO: Add validation
            var viewModel = new CategoriesNamesWithDepartmentNameViewModel
            {
                DepartmentsNames = _departmentsRepository.GetDepartmentsNames(),
                CategoriesNamesAndIds = _categoriesRepository.GetCategoriesNamesIdsOfDepartmantById(id),
                DepartmentName = _departmentsRepository.GetDepartmentNameById(id)
            };

            return View(viewModel);
        }

        public ActionResult Products(int id)
        {
            //TODO: Add validation
            return View(_productsRepository.GetProductsWithCategoryAndDepartmantsByCategoryId(id));
        }

        public ActionResult ProductDetails(int id)
        {
            return View(_productsRepository.GetProductDetailsViewModel(id));
        }
    }
}