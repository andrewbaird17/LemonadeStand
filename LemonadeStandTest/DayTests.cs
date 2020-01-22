using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStandProject;

namespace LemonadeStandTest
{
    [TestClass]
    public class DayTests
    {
        [TestMethod]
        public void ChoooseConition_RandomNumberIsZero_WeatherIsFoggy()
        {
            //Arrange
            Random random = new Random();
            Day day = new Day(random);
            Weather weather2 = new Foggy();
            
            string expected = weather2.condition;
            
            //Act
            

            //Assert
            

        }

        [TestMethod]
        public void ChoooseConition_RandomNumberIsSix_WeatherIsWindy()
        {
            //Arrange
            Random random = new Random();
            Day day = new Day(random);
            Weather weather = new Windy();
            string expected = weather.condition;
            string actual;
            //Act
            day.ChooseCondition();
            actual = weather.condition;

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
