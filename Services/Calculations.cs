using StackBuilder_Test.Data;
using StackBuilder_Test.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StackBuilder_Test.Services
{
    /// <summary>
    /// Class to make some calculations of the plate, day and time
    /// </summary>
    public class Calculations
    {
        private string _plate;
        private string _date;
        private string _hour;
        public Calculations(Request request)
        {
            this._plate = request.Plate;
            this._date = request.DateInStringFormat;
            this._hour = request.Hour24Format;
        }

        /// <summary>
        /// Function to calculate if a vehicle can run without restrictions
        /// </summary>
        /// <returns>FALSE if these vehicle can run; TRUE if the vehicle can't run</returns>
        public bool ExistsRestrictions()
        {
            bool result = false;
            
            List<Day> daysApply = new DaysApply().GetDaysWithPicoyPlaca();

            //Fetch all the Data to find the data corresponding to the day entered
            var day = daysApply.Find(d => d.DayOfWeek == CalculateDayOfTheWeek());

            float hour = float.Parse(_hour, CultureInfo.InvariantCulture.NumberFormat);
            Hour hours = new Hour();

            if (day.ApplyPicoyPlaca)
            {
                //if apply plico y placa, find with the plate and hour if the vehicle can run                        
                if (day.NumbersWithRestrictions.Contains(GetLastNumberOfPlate()))
                {
                    //if the last digit of the plate match with the restrictions, find the hour
                    var hoursapply = new HoursApply().GetScheduleHours();
                    if(hour <= 12)
                    {
                        hours = hoursapply.Find(h => h.isAM == true);
                    }
                    else
                    {
                        hours = hoursapply.Find(h => h.isAM == false);
                    }


                    if(hours.HourSince <= hour && hours.HourTo >= hour)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                        
                }

            }
            else
            {
                return false;
            }
            


            return result;
        }

        public int GetLastNumberOfPlate()
        {
            int result = -1;
            try
            {
                if (!String.IsNullOrEmpty(_plate))
                {
                    string lastDigit = _plate.Substring(_plate.Length - 1, 1);
                    if(Regex.IsMatch(lastDigit, @"\d"))
                    {
                        result = int.Parse(lastDigit);
                    }
                    else
                    {
                        throw new Exception("The last digit is not a valid number");
                    }
                    
                }
                else
                {
                    throw new Exception("The Plate is Null or Empty");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public DayOfWeek CalculateDayOfTheWeek()
        {
            DayOfWeek dayOfWeek;

            try
            {
                if(string.IsNullOrEmpty(_date) || _date.Length != 10)
                {
                    throw new Exception("The date you entered is incorrect");
                }
                DateTime oDate = DateTime.Parse(_date);
                dayOfWeek = oDate.DayOfWeek;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dayOfWeek;
        }
    }
}
