using CsWebFormsAppWithSecureWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CsWebFormsAppWithSecureWebApi.Controllers
{
    public class ProductsController : ApiController
    {
        private List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Tomato Soup",
                Category = "Groceries",
                Price = 1,
                UpdateTime = DateTime.Now
            },
            new Product
            {
                Id = 2,
                Name = "Yo-yo",
                Category = "Toys",
                Price = 3.7,
                UpdateTime = DateTime.Now
            },
            new Product
            {
                Id = 3,
                Name = "Hammer",
                Category = "Hardware",
                Price = 16.99,
                UpdateTime = DateTime.Now
            }
        };

        [Route("api/allproducts")]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        [Route("api/oneproduct/{id}")]
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null) return NotFound();

            return Ok(product);
        }
    }
}