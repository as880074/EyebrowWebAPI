using System;
using System.Collections.Generic;

namespace Eyebrow.Repository.Models
{
    public partial class Portfolio
    {
        public int Id { get; set; }
        public string? PortfolioName { get; set; }
        public string? BeforePath { get; set; }
        public string? AfterPath { get; set; }
        public int? SubCategoryId { get; set; }
        public int? PortfolioOrder { get; set; }
        public bool? Statu { get; set; }
    }
}
