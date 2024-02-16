using OnlineShop.Models;
public class StoreIndexViewModel
{
    public StoreIndexViewModel(List<Product> Product, List<Category> Category)
    {
        Products = Product;
        Categories = Category;
    }
    public List<Product> Products;
    public List<Category> Categories;
}