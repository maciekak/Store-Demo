using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreDemo.ViewModels
{
    public class ProductsWithClientContactViewModel : ClientContactViewModel
    {
        public ProductsWithClientContactViewModel()
        {
        }

        public ProductsWithClientContactViewModel(ClientContactViewModel baseModel)
        {
            //TODO: Please, refactor this
            QuantityOfProducts = baseModel.QuantityOfProducts;
            PriceForAllProducts = baseModel.PriceForAllProducts;
            FirstName = baseModel.FirstName;
            LastName = baseModel.LastName;
            Address = baseModel.Address;
            AdditionalInformation = baseModel.AdditionalInformation;
            DepartmentsNames = baseModel.DepartmentsNames;
        }
        public List<ProductInCartViewModel> Products { get; set; }
    }
}