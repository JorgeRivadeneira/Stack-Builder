using StackBuilder_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBuilder_Test.Data
{
    class DaysApply : Day
    {
        public DaysApply() { }

        public List<Day> GetDaysWithPicoyPlaca()
        {
            List<Day> days = new List<Day>();
            
            days.Add(new Day() { Id = Guid.NewGuid(), DayOfWeek = DayOfWeek.Monday, NumbersWithRestrictions = new int[]{1, 2}, ApplyPicoyPlaca = true });
            days.Add(new Day() { Id = Guid.NewGuid(), DayOfWeek = DayOfWeek.Tuesday, NumbersWithRestrictions = new int[] { 3, 4 }, ApplyPicoyPlaca = true });
            days.Add(new Day() { Id = Guid.NewGuid(), DayOfWeek = DayOfWeek.Wednesday, NumbersWithRestrictions = new int[] { 5, 6 }, ApplyPicoyPlaca = true });
            days.Add(new Day() { Id = Guid.NewGuid(), DayOfWeek = DayOfWeek.Thursday, NumbersWithRestrictions = new int[] { 7, 8 }, ApplyPicoyPlaca = true });
            days.Add(new Day() { Id = Guid.NewGuid(), DayOfWeek = DayOfWeek.Friday, NumbersWithRestrictions = new int[] { 9, 0 }, ApplyPicoyPlaca = true });
            days.Add(new Day() { Id = Guid.NewGuid(), DayOfWeek = DayOfWeek.Saturday, NumbersWithRestrictions = new int[] { }, ApplyPicoyPlaca = false });
            days.Add(new Day() { Id = Guid.NewGuid(), DayOfWeek = DayOfWeek.Sunday, NumbersWithRestrictions = new int[] {  }, ApplyPicoyPlaca = false });

            return days;
        }
    }
}
