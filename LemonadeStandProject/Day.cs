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
        public int numberOfDays;
        public List<Customer> customers;
        public Day(Random random)
        {
            this.random = random; 
            customers = new List<Customer>();
            ChooseCondition();
            ChooseTemp();
            ChooseNumberOfCustomers();
        }
        //Member Methods (CAN DO)
        public int SelectNumberDays()
        {
            Console.WriteLine("How many days would you like to run your Lemonade Stand for?");
            Int32.TryParse(Console.ReadLine(), out int numberOfDays);
            if (numberOfDays < 7)
            {
                Console.Clear();
                Console.WriteLine("Please try again. Your input is not a valid option. Minimum game length is 7 days.\n\n");

                return SelectNumberDays();
            }
            Console.Clear();
            return numberOfDays;
        }
        public void ChooseNumberOfCustomers()
        {           
            randomNumberOfCustomers = random.Next(weather.lowestNumCustomers, weather.highestNumCustomers);
        }
        public void ChooseCondition()
        {           
           int randCondition = random.Next(0,7);
            switch (randCondition)
            {
                case 0:
                    weather = new Foggy();
                    break;
                case 1:
                    weather = new Cloudy();
                    break;
                case 2:
                    weather = new Hazy();
                    break;
                case 3:
                    weather = new Overcast();
                    break;
                case 4:
                    weather = new Rainy();
                    break;
                case 5:
                    weather = new Sunny();
                    break;
                case 6:
                    weather = new Windy();
                    break;
            }
        }  
        public void ChooseTemp()
        {           
            temperature = random.Next(40, 115);
        }
        public void WeatherForecast(List <Day>days)
        {
            Console.Clear();
            for (int i = 0; i < numberOfDays; i++)
            {
                Console.WriteLine("Day " + (i + 1) + ": High Temperature of " + days[i].temperature + " and " + days[i].weather.condition + "\n\n");
            }
            Console.WriteLine("Press enter to go back to the main screen.");
            Console.ReadLine();
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
