using Eyebrow.Common.Models;

namespace Eyebrow.API.Models
{
    public class CalendarViewModel
    {
        public DateTime Appointment { get; set; }
        public IEnumerable<CalendarDto> Calendars { get; set; }
    }
}
