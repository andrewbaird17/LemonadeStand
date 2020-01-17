using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public abstract class WeatherCondition
    {
        //Member Variables (HAS A)
        public string condition;
        public int highestNumCustomers;
        public int lowestNumCustomers;
        

        //Constructor
        public WeatherCondition()
        {

        }
        //Member Methods (CAN DO)

        public abstract void NumberCustomers();

    }
}
