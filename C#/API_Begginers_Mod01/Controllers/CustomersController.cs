using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Begginers_Mod01.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Begginers_Mod01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Produces("application/json")]
    public class CustomersController : ControllerBase
    {
        static List<Customer> _customers = new List<Customer>()
        {
            new Customer(){Id=0,Name="Papa",Email="sreenarayanrathore@gmail.com",Phone="9474239908"},
            new Customer(){Id=1,Name="Mummy",Email="sunita.rathore70@gmail.com",Phone="9933297965"},
            new Customer(){Id=2,Name="Bhaiya",Email="amit.rathore@gmail.com",Phone="7532322321"},
            new Customer(){Id=3,Name="Me",Email="rathoddharmendra.nit@gmail.com",Phone="9591322676"},
        };

        public IActionResult Get()
        {
            return Ok(_customers);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            _customers.Add(customer);
            return StatusCode(StatusCodes.Status201Created);
        }


    }
}
