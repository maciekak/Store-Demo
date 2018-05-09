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
        private readonly ProductsRepository _productsRepository = new ProductsRepository(); 
        private readonly CartService _cartService = new CartService();
        // GET: Cart
        public ActionResult Index()
        {
            if (Session["Cart"] == null || Session["CartCount"] == null)
            {
                Session["Cart"] = new List<ProductIdWithQuantity>();
                Session["CartCount"] = 0;
            }

            var cart = new CartViewModel
            {
                Products = _productsRepository.GetCartProducts((List<ProductIdWithQuantity>) Session["Cart"])
            };
            Session["Count"] = cart.Products.Count;
            
            return View(cart);
        }

        public ActionResult AddToCart(int id)
        {
            if (Session["Cart"] == null || Session["CartCount"] == null)
            {
                Session["Cart"] = new List<ProductIdWithQuantity>();
            }

            var cart = (List<ProductIdWithQuantity>) Session["Cart"];
            _cartService.AddProductToCart(cart, id);

            Session["Cart"] = cart;
            Session["CartCount"] = cart.Count;

            if (Request.UrlReferrer != null)
                return Redirect(Request.UrlReferrer.ToString());

            return RedirectToAction("Index", "Home");
        }

        [ActionName("DeleteSingle")]
        public ActionResult DeleteFromCart(int id)
        {
            if (Session["Cart"] == null || Session["CartCount"] == null)
                return RedirectToAction("Index");

            var cart = (List<ProductIdWithQuantity>)Session["Cart"];

            _cartService.DeleteSingleProductFromCart(cart, id);

            Session["Cart"] = cart;
            Session["CartCount"] = cart.Count;

            return RedirectToAction("Index");
        }

        [ActionName("DeleteAll")]
        public ActionResult DeleteAllOffSingleProductFromCart(int id)
        {
            if (Session["Cart"] == null || Session["CartCount"] == null)
                return RedirectToAction("Index");

            var cart = (List<ProductIdWithQuantity>)Session["Cart"];

            _cartService.DeleteAllOffSingleProductFromCart(cart, id);

            Session["Cart"] = cart;
            Session["CartCount"] = cart.Count;

            return RedirectToAction("Index");
        }
    }
}