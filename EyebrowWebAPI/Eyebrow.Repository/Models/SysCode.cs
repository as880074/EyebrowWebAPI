using System;
using System.Collections.Generic;

namespace Eyebrow.Repository.Models
{
    public partial class SysCode
    {
        public int Id { get; set; }
        public string? ScType { get; set; }
        public string? ScCode { get; set; }
        public string? ScDesc { get; set; }
        public int? ScOrder { get; set; }
    }
}
