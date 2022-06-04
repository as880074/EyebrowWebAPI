using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eyebrow.Service.Models.Dtos
{
    public class BannerDto
    {
        public int Id { get; set; }
        public string? ImagePath { get; set; }
        public string? Url { get; set; }
        public bool? Statu { get; set; }
        public int? BannerOrder { get; set; }
    }
}
