using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBuilder_Test.Models
{
    /// <summary>
    /// Represents the three parameters to handle all the calclations
    /// </summary>
    public class Request
    {
        public string Plate { get; set; }
        public string DateInStringFormat { get; set; }
        public string Hour24Format { get; set; }
    }
}
