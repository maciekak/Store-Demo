using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreDemo.BussinessLogic;
using StoreDemo.ViewModels;

namespace StoreDemo.DataAccessLayer
{
    public class ProductsRepository
    {
        private readonly StoreDbContext _storeDb = new StoreDbContext();

        public ProductsWithCategoryAndDepartmantViewModel GetProductsWithCategoryAndDepartmantsByCategoryId(int categoryId)
        {
            var category = _storeDb.Categories.First(c => c.Id == categoryId);

            return new ProductsWithCategoryAndDepartmantViewModel
            {
                ProductsWithIds = category
                    .Products
                    .Select(p => new NameWithId
                    {
                        Id = p.Id,
                        Name = p.Name
                    }).ToList(),

                CategoryName = category.Name,
                DepartmentName = category.Department.Name,
                DepartmentsNames = _storeDb.Departments.Select(d => d.Name).ToList()
            };
        }

        public ProductDetailsViewModel GetProductDetailsViewModel(int productId)
        {
            var product = _storeDb.Products.First(p => p.Id == productId);
            return new ProductDetailsViewModel
            {
                ProductId = product.Id,
                CategoryName = product.Category.Name,
                DepartmentName = product.Category.Department.Name,
                Description = product.Description,
                Price = product.Price,
                ProductName = product.Name,
                DepartmentsNames = _storeDb.Departments.Select(d => d.Name).ToList()
            };
        }

        public List<ProductInCartViewModel> GetCartProducts(List<ProductIdWithQuantity> list)
        {
            var resultList = new List<ProductInCartViewModel>();
            foreach (var product in _storeDb.Products)
            {
                foreach (var item in list)
                {
                    if (product.Id == item.ProductId)
                    {
                        resultList.Add(new ProductInCartViewModel
                        {
                            Price = product.Price,
                            ProductId = product.Id,
                            ProductName = product.Name,
                            Quantity = item.Quantity
                        });
                        break;
                    }
                }
            }
            return resultList;

            //TODO: make it great again
//            return _storeDb
//                .Products
//                .Where(p => list.Any(x => x.ProductId == p.Id))
//                .Select(p => new ProductInCartViewModel
//                {
//                    ProductId = p.Id,
//                    ProductName = p.Name,
//                    Price = p.Price,
//                    Quantity = list.First(c => c.ProductId == p.Id).Quantity
//                }).ToList();
        }

        public ProductInCartViewModel GetSingleCartProductById(int id)
        {
            var product = _storeDb.Products.First(p => p.Id == id);
            return new ProductInCartViewModel
            {
                Price = product.Price,
                ProductId = product.Id,
                ProductName = product.Name,
                Quantity = 1
            };
        }
    }
}