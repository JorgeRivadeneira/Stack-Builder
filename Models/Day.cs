using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBuilder_Test.Models
{
    public class Day
    {
        public Guid Id { get; set; }
        public DayOfWeek DayOfWeek { get; set; }

        public int[] NumbersWithRestrictions { get; set; }
        public bool ApplyPicoyPlaca { get; set; }
    }
}
