using ContentNegotiationEx.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContentNegotiationEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        CompanyContext cc;
        public ProductAPIController(CompanyContext cc)
        {
            this.cc = cc;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(this.cc.Products.ToList());
        }
    }
}
