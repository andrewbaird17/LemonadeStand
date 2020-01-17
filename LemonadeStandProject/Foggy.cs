using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Foggy : Weather
    {
        //Member Variables (HAS A)

        //Constructor
        public Foggy()
        {
            condition = "Foggy";
            lowestNumCustomers = 20;
            highestNumCustomers = 45;
        }
        //Member Methods (CAN DO)

    }
}
