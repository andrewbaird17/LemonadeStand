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
        Random random;
        public Weather weather;
        public int temperature;
        public int randomNumberOfCustomers;
        public List<Customer> customers;
        List<Weather> listOfWeather;
        //Constructor
        public Day(Random random)
        {
            customers = new List<Customer>();
            this.random = random;
            listOfWeather = new List<Weather> { new Foggy(), new Cloudy(), new Hazy(), new Overcast(), new Rainy(), new Sunny(), new Windy()}; 
        }
        //Member Methods (CAN DO)
        public void ChooseNumberOfCustomers(Weather weather)
        {           
            randomNumberOfCustomers = random.Next(weather.lowestNumCustomers, weather.highestNumCustomers);
        }
        public Weather ChooseCondition()
        {           
            weather = listOfWeather[random.Next(listOfWeather.Count)];
            return weather;
        }  
        public void ChooseTemp()
        {           
            temperature = random.Next(40, 115);
        }
        public void CreateCustomers(Player player)
        {
            for (int i = 0; i < randomNumberOfCustomers; i++)
            {
                //customers = new List<Customer>();
                customers.Add(new Customer(random));
                customers[i].name = "Customer" + String.Concat(i + 1);
                customers[i].LikelihoodToBuy();
            }

            CustomerChanceBuyTemp();
            CustomerChanceBuyPrice(player);
            CustomerChanceBuyRecipe(player);
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
        public void CustomerChanceBuyPrice(Player player)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (player.recipe.pricePerCup > 0.50 && player.recipe.pricePerCup <= 0.75)
                {
                    customers[i].chanceToBuy -= 20;
                }
                else if (player.recipe.pricePerCup > 0.20 && player.recipe.pricePerCup <= 0.50)
                {
                    customers[i].chanceToBuy += 10;
                }
                else if (player.recipe.pricePerCup > 0 && player.recipe.pricePerCup <= 0.20)
                {
                    customers[i].chanceToBuy += 20;
                }
            }
        }
        public void CustomerChanceBuyRecipe(Player player)
        {
            for(int i = 0; i < customers.Count; i++)
            {
                if (player.recipe.amountOfLemons > 4 && player.recipe.amountOfLemons <= 10)
                {
                    customers[i].chanceToBuy -= 20;
                }
                else if (player.recipe.amountOfLemons > 2 && player.recipe.amountOfLemons <= 4)
                {
                    customers[i].chanceToBuy += 10;
                }
                else if (player.recipe.amountOfLemons > 0 && player.recipe.amountOfLemons <= 2)
                {
                    customers[i].chanceToBuy += 20;
                }
            }
        }
    }
}
