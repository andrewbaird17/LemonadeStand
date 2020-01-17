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
        public List<Customer> customers;
        Random random;

        //Constructor
        public Day()
        {
            weather = new Weather();
        }

        //Member Methods (CAN DO)
        public int SelectNumberDays()
        {
            int numDays;
            Console.WriteLine("How many days would you like to run your Lemonade Stand for?");
            string days = Console.ReadLine();
            Int32.TryParse(days, out numDays);
            if (numDays < 7)
            {
                Console.WriteLine("Please try again. Your input is not a valid option. Minimum game length is 7 days.");
                Console.ReadLine();
                Console.Clear();
                SelectNumberDays();
            }
            Console.Clear();
            return numDays;
        }

        public void NumberCustomersCurrentDay()
        {
            //Number of customers depends on weather condition for that day
            // create a new list of customers for each new day
            int numcustomers;
            random = new Random();
            if (weather.condition == "Sunny" || weather.condition == "Hazy")
            {
                numcustomers = random.Next(60, 110);
            }
            else
            {
                numcustomers = random.Next(40, 70);
            }
            customers = new List<Customer>();
            for (int i = 0; i < numcustomers; i++)
            {
                customers.Add(new Customer());
            }
        }
        public void ChooseTemp()
        {
            Random random = new Random();
            temperature = random.Next(40, 115);
        }
    }
}
