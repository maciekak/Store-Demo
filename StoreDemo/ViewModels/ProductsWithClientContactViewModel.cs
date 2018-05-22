using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreDemo.ViewModels
{
    public class ProductsWithClientContactViewModel : ClientContactViewModel
    {
        public List<ProductInCartViewModel> Products { get; set; }
    }
}