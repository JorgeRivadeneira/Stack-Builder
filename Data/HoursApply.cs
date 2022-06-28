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

            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 0, ApplyPicoyPlaca = false });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 1, ApplyPicoyPlaca = false });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 2, ApplyPicoyPlaca = false });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 3, ApplyPicoyPlaca = false });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 4, ApplyPicoyPlaca = false });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 5, ApplyPicoyPlaca = true });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 6, ApplyPicoyPlaca = true });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 7, ApplyPicoyPlaca = true });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 8, ApplyPicoyPlaca = true });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 9, ApplyPicoyPlaca = false });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 10, ApplyPicoyPlaca = false });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 11, ApplyPicoyPlaca = false });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 12, ApplyPicoyPlaca = false });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 13, ApplyPicoyPlaca = false });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 14, ApplyPicoyPlaca = false });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 15, ApplyPicoyPlaca = false });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 16, ApplyPicoyPlaca = true });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 17, ApplyPicoyPlaca = true });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 18, ApplyPicoyPlaca = true });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 19, ApplyPicoyPlaca = true });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 20, ApplyPicoyPlaca = false });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 21, ApplyPicoyPlaca = false });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 22, ApplyPicoyPlaca = false });
            schedule.Add(new Hour() { Id = Guid.NewGuid(), Hour24Format = 23, ApplyPicoyPlaca = false });

            return schedule;
        }

        
    }
}
