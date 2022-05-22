using Eyebrow.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eyebrow.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Detail()
        {
            var result = new AboutViewModel() 
            {
                ImageUrl = "about/img.png",
                Content = "<h1>您好我是...</h1>"
            };
            return Ok(result);
        }

    }
}
