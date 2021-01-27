using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    interface IProductService
    {
        List<Product> GetProducts();
        Product GetProductById(string ProductId);
    }
}
