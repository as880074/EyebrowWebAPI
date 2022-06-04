using AutoMapper;
using Eyebrow.Repository.Models;
using Eyebrow.Service.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eyebrow.Service.Infrastructure.Mapping
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            this.CreateMap<Banner, BannerDto>();
        }
    }
}
