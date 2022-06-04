using System;
using System.Collections.Generic;

namespace Eyebrow.Repository.Models
{
    public partial class Banner
    {
        public int Id { get; set; }
        public string? ImagePath { get; set; }
        public string? Url { get; set; }
        public bool? Statu { get; set; }
        public int? BannerOrder { get; set; }
    }
}
