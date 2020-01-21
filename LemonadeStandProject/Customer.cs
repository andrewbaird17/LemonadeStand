using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Customer
    {
        //Member Variables (HAS A)
        Random random;
        public string name;
        public int chanceToBuy;
        //Constructor
        public Customer(Random random)
        {
            this.random = random;
        }
        //Member Methods (CAN DO)
        public void LikelihoodToBuy()
        {
            chanceToBuy = random.Next(40, 60);
        }

    }
}
