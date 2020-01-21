using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Man : Customer
    {
        //Member Variables (HAS A)

        //Constructor
        public Man(Random random, Player player, int temperature)
        {
            this.random = random;
            LikelihoodToBuy();
            CustomerChanceBuyTemp(temperature);
            CustomerChanceBuyRecipe(player);
            CustomerChanceBuyPrice(player);
        }
        //Member Methods (CAN DO)
    }
}
