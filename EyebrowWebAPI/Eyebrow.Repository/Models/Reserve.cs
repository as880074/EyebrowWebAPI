using System;
using System.Collections.Generic;

namespace Eyebrow.Repository.Models
{
    public partial class Reserve
    {
        public int Id { get; set; }
        public string? ReserveName { get; set; }
        public string? Phone { get; set; }
        public string? CategoryId { get; set; }
        public string? SubCategoryId { get; set; }
        public DateOnly? Appointment { get; set; }
        public ulong? Period { get; set; }
    }
}
