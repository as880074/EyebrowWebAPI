using Eyebrow.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eyebrow.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        // GET: api/<CategoriesController>
        [HttpGet]
        public async Task<IActionResult> Price(int categoryId)
        {
            var result = new List<PriceViewModel>()
            {
                new PriceViewModel()
                {
                    Id = 1,
                    Name ="法式霧眉",
                    Mony=800,
                    Order =1,
                    CategoryId =1,
                },
                new PriceViewModel()
                {
                    Id = 2,
                    Name ="韓系霧眉",
                    Mony=   12000,
                    Order =2,
                    CategoryId =1
                },
            };
            return Ok(result);
        }

        // GET api/<CategoriesController>/5
        [HttpGet]
        public async Task<IActionResult> Portfolio(int subcategoryId)
        {
            var result = new List<PortfolioViewModel>()
            {
                new PortfolioViewModel()
                {
                    Id = 1,
                    Name ="作品集A",
                    Before="before/apple.png",
                    After="after/apple.png",
                    Order =1
                },
                new PortfolioViewModel()
                {
                    Id = 2,
                    Name ="作品集B",
                    Before="before/apple.png",
                    After="after/apple.png",
                    Order =2
                },
            };
            return Ok(result);
        }
    }
}
