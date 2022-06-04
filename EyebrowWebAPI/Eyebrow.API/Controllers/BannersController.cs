using AutoMapper;
using Eyebrow.API.Models;
using Eyebrow.Service.Interfaces;
using Eyebrow.Service.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eyebrow.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IBannersService bannersService;

        public BannersController(IMapper mapper, IBannersService bannersService)
        {
            this.mapper = mapper;
            this.bannersService = bannersService;
        }
        // GET: api/<BannersController>
        [HttpGet]
        public IActionResult Get()
        {
            var data = bannersService.GetList();
            var result = data.Select(x => mapper.Map<BannerViewModel>(x));
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] BannerViewModel param)
        {
            var data = mapper.Map<BannerDto>(param);
            var result = bannersService.Update(data);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Create(BannerViewModel param)
        {
            var data = mapper.Map<BannerDto>(param);
            var result = bannersService.Create(data);           
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var data = bannersService.Delete(id);
            return Ok(data);
        }
    }
}
