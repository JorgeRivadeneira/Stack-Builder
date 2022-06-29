using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBuilder_Test.Models
{
    public class Hour
    {
        public Guid Id { get; set; }
        public float HourSince { get; set; }
        public float HourTo { get; set; }
        public bool isAM { get; set; }
    }
}
