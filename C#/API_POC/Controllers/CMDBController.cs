using API_POC.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_POC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CMDBController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            var repo = new CatalogueRepository();
            var c = repo.GetAllCatalogues();
            return Ok(c);
        }
        //[Authorize]
        [HttpGet("filter")]
        public IActionResult Filter(string n)
        {
            var repo = new CatalogueRepository();
            var c = repo.GetCatalogueByName(n);
            return Ok(c);
        }

    }
}
