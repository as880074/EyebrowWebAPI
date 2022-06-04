using Eyebrow.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eyebrow.Common.Models
{
    public class CalendarDto
    {
        public string Period { get; set; }
        public DayStatusEnum Status { get; set; }
    }
}
