using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Begginers_Mod01.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Begginers_Mod01.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    //[Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        static List<Product> _products = new List<Product>()
        {
            new Product(){ProductId = 1, ProductName = "Laptop", ProductPrice = "80000"},
            new Product(){ProductId = 2, ProductName = "Smart Watch", ProductPrice = "25000"},
            new Product(){ProductId = 3, ProductName = "Smart Phone", ProductPrice = "50000"},
        };

        //[HttpGet]
        public IActionResult GetProduct()
        {
            return Ok(_products);
        }

        [HttpGet("welcome")]
        public IActionResult Welcome()
        {
            return Ok("Welcome to our website");
        }
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            _products.Add(product);
            return StatusCode(StatusCodes.Status201Created);
        }
        
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product product)
        {
            _products[id] = product;
            //return $"Successfully Modified: {product.ProductId}";
            return StatusCode(StatusCodes.Status204NoContent);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _products.RemoveAt(id);
            return StatusCode(StatusCodes.Status205ResetContent);
        }

    }
}
