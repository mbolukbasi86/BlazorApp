using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class ProductService : IProductService
    {

        public List<Product> Products { get; set; }
        public ProductService()
        {
            Products = new List<Product>();

            //Products.Add(new Product("1", "Iphone Pro Max", 12.000M));
            //Products.Add(new Product("1", "Iphone Pro Max", 12.000M));
            //Products.Add(new Product("1", "Iphone Pro Max", 12.000M));
        }

        public List<Product> GetProducts();
        {
            return Products;
        }



    public Product GetProductById(string productId)
    {
        return Products.Where(x => x.ProductId == productId).FirstOrDefault();
    }
}
}
}
