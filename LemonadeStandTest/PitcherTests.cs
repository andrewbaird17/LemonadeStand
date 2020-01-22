using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStandProject;

namespace LemonadeStandTest
{
    [TestClass]
    public class PitcherTests
    {
        [TestMethod]
        public void FillUpLemonadeInPitcher_InputZero_Return14()
        {
            //Arrange
            Pitcher pitcher = new Pitcher();     
            int expected = 14;

            //Act
            pitcher.FillUpLemonaidInPitcher();
            int actual = pitcher.cupsLeftInPitcher;

            //Assert
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void PourGlassOfLemonade_InputInt_ReturnOneLess()
        {
            //Arrange
            Pitcher pitcher = new Pitcher();
            int expected = 13;

            //Act
            pitcher.cupsLeftInPitcher = 14;
            pitcher.PourGlassOfLemonaid();
            int actual = pitcher.cupsLeftInPitcher;

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
