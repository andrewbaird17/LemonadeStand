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
        public Customer customer;
        public Weather weather;
        public int temperature;
        public int randomNumberOfCustomers;
        public int numberOfDays;
        public List<Customer> customers;
        public Day(Random random, Player player)
        {
            this.random = random;
            customers = new List<Customer>();
            ChooseCondition();
            ChooseTemp();
            ChooseNumberOfCustomers();
            CreateCustomers(player);
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
            int randCondition = UserInterface.GetRandomInteger(0, 7, random);
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
        public void WeatherForecast(List<Day> days)
        {
            Console.Clear();
            for (int i = 0; i < days.Count; i++)
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
                switch (UserInterface.GetRandomInteger(0,3,random))
                {
                    case 0:
                        customer = new Child(random, player, temperature);
                        customers.Add(customer);
                        break;
                    case 1:
                        customer = new OldWoman(random, player, temperature);
                        customers.Add(customer);
                        break;
                    case 2:
                        customer = new Man(random, player, temperature);
                        customers.Add(customer);
                        break;
                }
            }
        }
    }
}
