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
        List<Weather> possibleWeather;
        public Weather currentWeather;
        public int randcustomers;


        //Constructor
        public Day()
        {
            weather = new Weather();
            possibleWeather = new List<Weather> { new Foggy(), new Cloudy(), new Hazy(), new Overcast(), new Rainy(), new Sunny(), new Windy()}; 
        }
        //Member Methods (CAN DO)
        public void ChooseCondition()
        {
            Random random = new Random();
            currentWeather = possibleWeather[random.Next(possibleWeather.Count)];
        }
        public void ChooseNumCustomers()
        {
            Random random = new Random();
            ChooseCondition();
            randcustomers = random.Next(currentWeather.lowestNumCustomers, currentWeather.highestNumCustomers);
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

        // USE GET/SET?? to access pricePerCup as readonly 
        //public void CustomerChanceBuyPrice()
        //{
        //    for (int i = 0; i < customers.Count; i++)
        //    {
        //        if (player.recipe.pricePerCup > 0.50 && pricePerCup <= 0.75)
        //        {
        //            customers[i].chanceToBuy -= 20;
        //        }
        //        else if (pricePerCup > 0.20 && pricePerCup <= 0.50)
        //        {
        //            customers[i].chanceToBuy += 10;
        //        }
        //        else if (pricePerCup > 0 && pricePerCup <= 0.20)
        //        {
        //            customers[i].chanceToBuy += 20;
        //        }
        //    }
        //}
    }
}
