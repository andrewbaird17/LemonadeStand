using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Windy : Weather
    {//Member Variables (HAS A)

        //Constructor
        public Windy()
        {
            condition = "Windy";
            lowestNumCustomers = 25;
            highestNumCustomers = 45;
        }
        //Member Methods (CAN DO)
 
    }
}
