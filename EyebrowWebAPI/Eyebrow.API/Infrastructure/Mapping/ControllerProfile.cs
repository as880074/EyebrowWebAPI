using AutoMapper;
using Eyebrow.API.Models;
using Eyebrow.Service.Models.Dtos;

namespace Eyebrow.API.Infrastructure.Mapping
{
    public class ControllerProfile : Profile
    {
        public ControllerProfile()
        {
            this.CreateMap<BannerDto, BannerViewModel>()
                .ForMember(d => d.Path, o => o.MapFrom(s => s.ImagePath))
                .ForMember(d => d.Order, o => o.MapFrom(s => s.BannerOrder));
        }
    }
}
