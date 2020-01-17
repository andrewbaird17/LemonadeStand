using System;
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
        public List<Weather> weatherConditions = new List<Weather>();
        public int highestNumCustomers;
        public int lowestNumCustomers;


        //Constructor
        public Weather()
        {
            weatherConditions.Add(new Foggy());
            weatherConditions.Add(new Hazy());
            weatherConditions.Add(new Windy());
            weatherConditions.Add(new Cloudy());
            weatherConditions.Add(new Rainy());
            weatherConditions.Add(new Overcast());
            weatherConditions.Add(new Sunny());
        }
        //Member Methods (CAN DO)
    }
}

