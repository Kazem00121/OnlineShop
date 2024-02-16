using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public List<Category> GetCategory()
        {
            var CategoryList = new List<Category>
            {
                new Category{CategoryID=1,CategoryName="Computers"},
                new Category{CategoryID=2,CategoryName="Phons"},
                new Category{CategoryID=3,CategoryName="Tablets"},
            };

            return CategoryList;
        }
    }
}
