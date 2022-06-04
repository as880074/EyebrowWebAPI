using System;
using System.Collections.Generic;

namespace Eyebrow.Repository.Models
{
    public partial class SubCategory
    {
        public int Id { get; set; }
        public string? CategoryId { get; set; }
        public string? SubCategoryName { get; set; }
        public int? Price { get; set; }
        public int? SubCategoryOrder { get; set; }
    }
}
