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
        public string name;
        public int chanceToBuy;
        Random random;
        //Constructor
        public Customer()
        {
           
        }
        //Member Methods (CAN DO)
        public void LikelihoodToBuy()
        {
            // temperature determines the likelihood of those customers buying
            random = new Random();
            chanceToBuy = random.Next(40, 60);
        }

    }
}
