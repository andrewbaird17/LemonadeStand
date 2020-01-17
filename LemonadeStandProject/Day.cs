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
        public int randcustomers;


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
            randcustomers = random.Next(currentWeather.highestNumCustomers, currentWeather.lowestNumCustomers);
        }
        public void ChooseTemp()
        {
            Random random = new Random();
            temperature = random.Next(40, 115);
        }
        public void CreateCustomers()
        {
            for (int i = 0; i < randcustomers; i++)
            {
                customers = new List<Customer>();
                customers.Add(new Customer());
                customers[i].name = "Customer" + String.Concat(i + 1);
                customers[i].LikelihoodToBuy();
            }
        }
        public void CustomerChanceBuyTemp()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (temperature >= 40 && temperature <= 60)
                {
                    customers[i].chanceToBuy -= 20;
                }
                else if (temperature > 60 && temperature <= 80)
                {
                    customers[i].chanceToBuy += 10;
                }
                else if (temperature > 80)
                {
                    customers[i].chanceToBuy += 20;
                }
            }
        }
        public void CustomerChanceBuyPrice()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (pricePerCup > 0.50 && pricePerCup <= 0.75)
                {
                    customers[i].chanceToBuy -= 20;
                }
                else if (pricePerCup > 0.20 && pricePerCup <= 0.50)
                {
                    customers[i].chanceToBuy += 10;
                }
                else if (pricePerCup > 0 && pricePerCup <= 0.20)
                {
                    customers[i].chanceToBuy += 20;
                }
            }
        }
    }
}
