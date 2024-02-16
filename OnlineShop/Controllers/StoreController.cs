using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class StoreController : Controller
    {

        public IActionResult Index(int? id)
        {
            List<Product> Products;
            Product product = new Product();
            Category category = new Category();
            var Categories = category.GetCategory();
            if (id != null)
            {
                Products = product.GetProducts().Where(p => p.ProductCategoryID == id).ToList();
            }
            else
            {
                Products = product.GetProducts();
            }

            StoreIndexViewModel ViewModel = new StoreIndexViewModel(Products, Categories);
            return View(ViewModel);
        }

        public IActionResult Details(int id)
        {
            Product product = new Product();
            Category category = new Category();
            var Categories = category.GetCategory();
            var Product = product.GetProducts().Where(p => p.ProductID == id).First();

            StoreDetailsViewModel ViewModel = new StoreDetailsViewModel(Product, Categories);
            return View(ViewModel);
        }
    }
}
