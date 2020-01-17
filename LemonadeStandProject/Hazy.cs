using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Hazy : Weather
    {//Member Variables (HAS A)

        //Constructor
        public Hazy()
        {
            condition = "Hazy";
            lowestNumCustomers = 50;
            highestNumCustomers = 85;
        }
        //Member Methods (CAN DO)
    
    }
}
