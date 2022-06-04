using System;
using System.Collections.Generic;

namespace Eyebrow.Repository.Models
{
    public partial class Announcement
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public bool? Statu { get; set; }
        public DateOnly? ShelfTime { get; set; }
        public DateOnly? CreateTime { get; set; }
        public bool? IsTop { get; set; }
    }
}
