using StackBuilder_Test.Models;
using StackBuilder_Test.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBuilder_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculations = new Calculations(Prompt());
                GetAnswer(calculations.ExistsRestrictions());

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static Request Prompt()
        {
            Request request = new Request();

            Console.WriteLine("Welcome to the Pico y Placa Calculator\n\n");

            Console.WriteLine("Enter the plate of your vehicle");
            request.Plate = Console.ReadLine();

            Console.WriteLine("Enter the date you want to check, in this format: yyyy-MM-dd, Ex: 2022-12-31");
            request.DateInStringFormat = Console.ReadLine();

            Console.WriteLine("Enter the hour you want to check, For Example: 7 (7am) or 19 (19pm)");
            request.Hour24Format = int.Parse(Console.ReadLine());

            return request;
        }

        private static void GetAnswer(bool hasRestrictions)
        {
            Console.WriteLine(hasRestrictions ?  
                    "\n\nWarning: You can not run in your vehicle in this date" :
                    "\n\nYou can run in your vehicle without problems");
            Console.ReadLine();
        }

    }
}
