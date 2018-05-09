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
                CategoryName = product.Category.Name,
                DepartmentName = product.Category.Department.Name,
                Description = product.Description,
                Price = product.Price,
                ProductName = product.Name,
                DepartmentsNames = _storeDb.Departments.Select(d => d.Name).ToList()
            };
        }
    }
}