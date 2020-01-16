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
    }
}
