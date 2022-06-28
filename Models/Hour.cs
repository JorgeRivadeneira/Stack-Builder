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
        public int Hour24Format { get; set; }
        public bool ApplyPicoyPlaca { get; set; }
    }
}
