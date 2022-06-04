using AutoMapper;
using Eyebrow.Repository.Models;
using Eyebrow.Service.Interfaces;
using Eyebrow.Service.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eyebrow.Service.Implements
{
    public class BannersService: IBannersService
    {
        private readonly IMapper mapper;

        public BannersService(IMapper mapper) 
        {
            this.mapper = mapper;
        }
        public IEnumerable<BannerDto> GetList() 
        {
            var context = new EyeborwContext();
            var data =context.Banners.ToList();
            var result = data.Select(x => mapper.Map<BannerDto>(x));
            return result;
        }
        public bool Create(BannerDto bannerDto)
        {
            using (var context = new EyeborwContext())
            {              
                var data = mapper.Map<Banner>(bannerDto);
                context.Banners.Add(data);
                context.SaveChanges();
            }   
            return true;
        }
        public bool Update(BannerDto bannerDto)
        {
            using (var context = new EyeborwContext())
            {
                var data = mapper.Map<Banner>(bannerDto);
                context.Update(data);
                context.SaveChanges();
            }
            return true;
        }
        public bool Delete(int id)
        {
            using (var context = new EyeborwContext()) 
            {
                var data = context.Banners.Find(id);
                context.Banners.Remove(data);
                context.SaveChanges();
            }
            return true;    
        }
    }
}
