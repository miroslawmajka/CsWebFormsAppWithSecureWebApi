using CsWebFormsAppWithSecureWebApi.Helpers;
using CsWebFormsAppWithSecureWebApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CsWebFormsAppWithSecureWebApi.Controllers.Api
{
    public class ProductsController : ApiController
    {
        [Authorize]
        [Route("api/allproducts")]
        [ActionName("GetAllProducts")]
        public IEnumerable<Product> GetAllProducts()
        {
            return ProductHelper.GetAllPRoducts();
        }

        [Authorize]
        [Route("api/oneproduct/{id}")]
        [ActionName("GetProduct")]
        public IHttpActionResult GetProduct(int id)
        {
            var product = ProductHelper.GetAllPRoducts().FirstOrDefault(p => p.Id == id);

            if (product == null) return NotFound();

            return Ok(product);
        }

        [Route("api/firstproduct")]
        [ActionName("GetFirstProduct")]
        public Product GetFirstProduct()
        {
            return ProductHelper.GetAllPRoducts().First();
        }
    }
}