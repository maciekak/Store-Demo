using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreDemo.DataAccessLayer;
using StoreDemo.ViewModels;

namespace StoreDemo.BussinessLogic
{
    public class CartService
    {
        public void AddProductToCart(List<ProductIdWithQuantity> products, int productId)
        {
            var product = products.FirstOrDefault(p => p.ProductId == productId);
            if (product == null)
            {
                products.Add(new ProductIdWithQuantity
                {
                    ProductId = productId,
                    Quantity = 1
                });
            }
            else
            {
                product.Quantity++;
            }
        }

        public void DeleteAllOffSingleProductFromCart(List<ProductIdWithQuantity> cart, int id)
        {
            cart.RemoveAll(c => c.ProductId == id);
        }

        public void DeleteSingleProductFromCart(List<ProductIdWithQuantity> cart, int id)
        {
            var product = cart.FirstOrDefault(c => c.ProductId == id);

            if (product == null)
                return;

            if (product.Quantity == 1)
                cart.Remove(product);
            else
                product.Quantity--;
        }
    }
}