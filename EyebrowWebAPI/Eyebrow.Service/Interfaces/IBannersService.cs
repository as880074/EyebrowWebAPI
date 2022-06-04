using Eyebrow.Service.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eyebrow.Service.Interfaces
{
    public interface IBannersService
    {
        public IEnumerable<BannerDto> GetList();
        public bool Create(BannerDto bannerDto);
        public bool Update(BannerDto bannerDto);
        public bool Delete(int id);
    }
}
