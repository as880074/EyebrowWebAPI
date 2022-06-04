using System;
using System.Collections.Generic;

namespace Eyebrow.Repository.Models
{
    public partial class SysSetting
    {
        public int Id { get; set; }
        public string? SsKey { get; set; }
        public string? SsType { get; set; }
        public string? SsValue { get; set; }
        public string? SsDese { get; set; }
        public int? SsOrder { get; set; }
    }
}
