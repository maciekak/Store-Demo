using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreDemo.BussinessLogic;
using StoreDemo.DataAccessLayer;
using StoreDemo.ViewModels;

namespace StoreDemo.Controllers
{
    public class CartController : Controller
    {
        private readonly DepartmentsRepository _departmentsRepository = new DepartmentsRepository();
        private readonly ProductsRepository _productsRepository = new ProductsRepository(); 
        private readonly CartService _cartService = new CartService();

        private bool CheckCartIsCreated()
        {
            return Session["Cart"] != null && Session["CartCount"] != null;
        }
        // GET: Cart
        public ActionResult Index()
        {
            if (!CheckCartIsCreated())
            {
                Session["Cart"] = new List<ProductIdWithQuantity>();
                Session["CartCount"] = 0;
            }

            var cart = new CartViewModel
            {
                Products = _productsRepository.GetCartProducts((List<ProductIdWithQuantity>) Session["Cart"])
            };
            Session["Count"] = cart.Products.Sum(p => p.Quantity);

            cart.DepartmentsNames = _departmentsRepository.GetDepartmentsNames();

            return View(cart);
        }

        public ActionResult AddToCart(int id)
        {
            if (!CheckCartIsCreated())
            {
                Session["Cart"] = new List<ProductIdWithQuantity>();
            }

            var cart = (List<ProductIdWithQuantity>) Session["Cart"];
            _cartService.AddProductToCart(cart, id);

            Session["Cart"] = cart;
            Session["CartCount"] = cart.Sum(p => p.Quantity);

            if (Request.UrlReferrer != null)
                return Redirect(Request.UrlReferrer.ToString());

            return RedirectToAction("Index", "Home");
        }

        [ActionName("DeleteSingle")]
        public ActionResult DeleteFromCart(int id)
        {
            if (!CheckCartIsCreated())
                return RedirectToAction("Index");

            var cart = (List<ProductIdWithQuantity>)Session["Cart"];

            _cartService.DeleteSingleProductFromCart(cart, id);

            Session["Cart"] = cart;
            Session["CartCount"] = cart.Sum(p => p.Quantity);

            return RedirectToAction("Index");
        }

        [ActionName("DeleteAll")]
        public ActionResult DeleteAllOffSingleProductFromCart(int id)
        {
            if (!CheckCartIsCreated())
                return RedirectToAction("Index");

            var cart = (List<ProductIdWithQuantity>)Session["Cart"];

            _cartService.DeleteAllOffSingleProductFromCart(cart, id);

            Session["Cart"] = cart;
            Session["CartCount"] = cart.Sum(p => p.Quantity);

            return RedirectToAction("Index");
        }


        [ActionName("Contact")]
        // GET: Purchase
        [HttpGet]
        public ActionResult ClientContact()
        {
            if (!CheckCartIsCreated())
                return RedirectToAction("Index", "Home");

            var cart = (List<ProductIdWithQuantity>)Session["Cart"];
            var model = new ClientContactViewModel
            {
                QuantityOfProducts = cart.Sum(p => p.Quantity),
                PriceForAllProducts = 0.0m
            };

            return View(model);
        }

        [ActionName("Contact")]
        [HttpPost]
        public ActionResult ClientContact(ClientContactViewModel model)
        {
            //TODO: Add validation

            return RedirectToAction("Summary", model);

        }
        //TODO: make it work
        [ChildActionOnly]
        [HttpGet]
        public ActionResult Summary(ClientContactViewModel model)
        {
            if (!CheckCartIsCreated())
                return RedirectToAction("Index", "Home");
            
            var viewModel = (ProductsWithClientContactViewModel) model;
            viewModel.Products = _productsRepository.GetCartProducts((List<ProductIdWithQuantity>)Session["Cart"]);

            return View(viewModel);
        }
    }
}