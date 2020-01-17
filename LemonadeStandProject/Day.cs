using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Day
    {
        //Member Variables (HAS A)
        public Weather weather;
        public int temperature;
        public List<Customer> customers;
        Random random;
        public Weather currentWeather;
        

        //Constructor
        public Day()
        {
            weather = new Weather();
        }

        //Member Methods (CAN DO)
        public void ChooseCondition()
        {
            Random random = new Random();
            currentWeather = weather.weatherConditions[random.Next(weather.weatherConditions.Count)];
        }
        public void ChooseNumCustomers()
        {
            Random random = new Random();
            ChooseCondition();
            int randcustomers = random.Next(currentWeather.highestNumCustomers, currentWeather.lowestNumCustomers);
        }
        public void ChooseTemp()
        {
            Random random = new Random();
            temperature = random.Next(40, 115);
        }

    }
}
