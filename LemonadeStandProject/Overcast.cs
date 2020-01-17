using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Overcast : Weather
    {//Member Variables (HAS A)

        //Constructor
        public Overcast()
        {
            condition = "Overcast";
            lowestNumCustomers = 35;
            highestNumCustomers = 55;
        }
        //Member Methods (CAN DO)
        
    }
}
