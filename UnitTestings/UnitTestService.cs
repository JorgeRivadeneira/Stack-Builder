using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackBuilder_Test.Services;
using StackBuilder_Test.Models;
using System;

namespace UnitTestings
{
    [TestClass]
    public class UnitTestService
    {
        [TestMethod]
        [ExpectedException(typeof(System.Exception),
            "The Plate is Null or Empty")]
        public void CheckIfPlateIsEmpty()
        {
            Request request = new Request() {Plate = "", DateInStringFormat = "2022-06-28", Hour24Format=15 };
            var service = new Calculations(request).GetLastNumberOfPlate();
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception),
        "The last digit is not a valid number")]
        public void CheckIfLastDigitOfPlateIsNumber()
        {
            Request request = new Request() { Plate = "PHM0AAA", DateInStringFormat = "2022-06-28", Hour24Format = 15 };
            var service = new Calculations(request).GetLastNumberOfPlate();
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception),
        "The date you entered is incorrect")]
        public void CheckIfDateIsInCorrectFormat()
        {
            Request request = new Request() { Plate = "PHM0AA3", DateInStringFormat = "2022-06", Hour24Format = 15 };
            var service = new Calculations(request).CalculateDayOfTheWeek();
            Assert.Fail();
        }

        /// <summary>
        /// This method should return True
        /// </summary>
        [TestMethod]
        public void CheckIfExistsRestrictionsMethodIsCorrect()
        {
            Request request = new Request() { Plate = "PHM323", DateInStringFormat = "2022-06-28", Hour24Format = 16 };
            var service = new Calculations(request).ExistsRestrictions();
            Assert.AreEqual(true, service);
        }
    }
}