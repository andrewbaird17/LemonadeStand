using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Weather
    {
        //Member Variables (HAS A)

        public string condition;
        public int temperature;
        private List<string> weatherConditions;
        private List<string> conditionlist;
        private List<int> templist;
        public string predictedForecast;

        //Constructor
        public Weather()
        {
            conditionlist = new List<string>() { "Sunny", "Cloudy", "Rainy", "Overcast", "Windy", "Scattered Showers", "Hazy", "Foggy" };
        }
        //Member Methods (CAN DO)
        public void ChooseCondition()
        {
            Random random = new Random();
            condition = conditionlist[random.Next((conditionlist.Count + 1))];
        }

        public void ChooseTemp()
        {
            Random random = new Random();
            temperature = random.Next(45, 105);
        }
    }
}

