using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Cloudy : Weather
    {//Member Variables (HAS A)

        //Constructor
        public Cloudy()
        {
            condition = "Cloudy";
            lowestNumCustomers = 45;
            highestNumCustomers = 85;
        }
        //Member Methods (CAN DO)
  
    }
}
