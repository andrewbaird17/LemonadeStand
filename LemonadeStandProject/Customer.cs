using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    abstract public class Customer
    {
        //Member Variables (HAS A)
        public Random random;
        public int chanceToBuy;
        //Constructor
        public Customer()
        {
        }
        //Member Methods (CAN DO)
        public virtual void LikelihoodToBuy()
        {
            chanceToBuy = random.Next(40, 61);
        }
        public virtual void CustomerChanceBuyTemp(int temperature)
        {
            if (temperature >= 40 && temperature <= 60)
            {
                chanceToBuy -= 20;
            }
            else if (temperature > 60 && temperature <= 80)
            {
                chanceToBuy += 10;
            }
            else if (temperature > 80)
            {
                chanceToBuy += 20;
            }
        }
        public virtual void CustomerChanceBuyPrice(Player player)
        {

            if (player.recipe.pricePerCup > 0.50 && player.recipe.pricePerCup <= 0.75)
            {
                chanceToBuy -= 20;
            }
            else if (player.recipe.pricePerCup > 0.20 && player.recipe.pricePerCup <= 0.50)
            {
                chanceToBuy += 10;
            }
            else if (player.recipe.pricePerCup > 0 && player.recipe.pricePerCup <= 0.20)
            {
                chanceToBuy += 20;
            }

        }
        public virtual void CustomerChanceBuyRecipe(Player player)
        {
            if (player.recipe.amountOfLemons > 4 && player.recipe.amountOfLemons <= 10)
            {
                chanceToBuy -= 20;
            }
            else if (player.recipe.amountOfLemons > 2 && player.recipe.amountOfLemons <= 4)
            {
                chanceToBuy += 10;
            }
            else if (player.recipe.amountOfLemons > 0 && player.recipe.amountOfLemons <= 2)
            {
                chanceToBuy += 20;
            }
        }
    }
}

