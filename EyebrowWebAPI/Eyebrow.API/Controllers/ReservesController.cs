using Eyebrow.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eyebrow.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReservesController : ControllerBase
    {
        // GET: api/<ReservesController>
        [HttpGet]
        public async Task<IActionResult> Calendar()
        {
            var result = new List<CalendarViewModel>() 
            {
                //new CalendarViewModel(){Appointment=DateTime.Now,Period="AM",Status="預約" },
                //new CalendarViewModel(){Appointment=DateTime.Now,Period="PM",Status="預約" },
                //new CalendarViewModel(){Appointment=DateTime.Now.AddDays(1),Period="ALL",Status="休息" },
            };
            return Ok(result);
        }

    }
}
