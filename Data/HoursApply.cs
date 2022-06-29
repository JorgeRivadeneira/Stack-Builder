using StackBuilder_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBuilder_Test.Data
{
    public class HoursApply : Hour
    {
        public HoursApply()
        {

        }

        public List<Hour> GetScheduleHours()
        {
            List<Hour> schedule = new List<Hour>();

            schedule.Add(new Hour() { Id = Guid.NewGuid(), HourSince = 7.0f, HourTo = 9.3f, isAM = true});
            schedule.Add(new Hour() { Id = Guid.NewGuid(), HourSince = 16.0f, HourTo = 19.3f, isAM = false });

            return schedule;
        }

        
    }
}
