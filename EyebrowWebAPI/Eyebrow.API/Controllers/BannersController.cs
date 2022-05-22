using Eyebrow.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eyebrow.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
        // GET: api/<BannersController>
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = new List<BannerViewModel>()
            {
                new BannerViewModel() { },
                new BannerViewModel() { },
            };
            return Ok(result);
        }

    }
}
