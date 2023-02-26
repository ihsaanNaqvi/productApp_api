using productApp_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace productApp_api.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { id = 1, Name = "Tomato Soup", Category = "Groceries", price = 1 },
            new Product { id = 2, Name = "Yo-yo", Category = "Toys", price = 3.75M },
            new Product { id = 3, Name = "Hammer", Category = "Hardware", price = 16.99M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
