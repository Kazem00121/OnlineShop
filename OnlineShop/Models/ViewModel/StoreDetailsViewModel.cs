
using OnlineShop.Models;
    public class StoreDetailsViewModel
    {
            public StoreDetailsViewModel(Product product, List<Category> Category)
            {
                Product = product;
                Categories = Category;
            }

            public Product Product { get; set; }
            public List<Category> Categories { get; set; }
        }

