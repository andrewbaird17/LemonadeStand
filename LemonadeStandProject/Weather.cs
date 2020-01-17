﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Weather
    {
        //Member Variables (HAS A)

        public string condition;
        public int temperature;
        private List<string> weatherConditions;
        public string predictedForecast;

        //Constructor
        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Cloudy", "Rainy", "Overcast", "Windy", "Scattered Showers", "Hazy", "Foggy"};
        }
        //Member Methods (CAN DO)
        public void RunWeatherSelection()
        {
            ChooseCondition();
            ChooseTemp();
        }
        public void ChooseCondition()
        {
            Random random = new Random();
            condition = weatherConditions[random.Next(weatherConditions.Count)];
        }
        public void ChooseTemp()
        {
            Random random = new Random();
            temperature = random.Next(40, 115);
        }

    }
}

