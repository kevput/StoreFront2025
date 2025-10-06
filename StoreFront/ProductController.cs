using Microsoft.AspNetCore.Mvc;
using StoreFront.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StoreFront
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static Dictionary<int, Product> _products = new() { { 1, new("Xbox","a nice toy for men",550.50m,18,1) } };
        
        // GET: api/<ProductController>
        [HttpGet]
        public List<Product>GetProducts()
        {
            return _products.Values.ToList();
        }



    }
}
