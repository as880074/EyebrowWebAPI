using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eyebrow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly IMapper mapper;

        public NewsController(IMapper mapper) 
        {
            this.mapper = mapper;
        }
        //// GET: api/<NewsController>
        //[HttpGet]
        //public IEnumerable<Announcement> Get()
        //{
        //    return _announcement.GetAnnouncements();
        //}

        //// GET api/<NewsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<NewsController>
        //[HttpPost]
        //public void Post([FromBody] Announcement value)
        //{
        //    _announcement.CreateAnnouncements(value);
        //}

        //// PUT api/<NewsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<NewsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
