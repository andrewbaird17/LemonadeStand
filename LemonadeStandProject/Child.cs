using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Child : Customer
    {
        //Member Variables (HAS A)

        //Constructor
        public Child(Random random, Player player, int temperature)
        {
            this.random = random;
            LikelihoodToBuy();
            CustomerChanceBuyTemp(temperature);
            CustomerChanceBuyRecipe(player);
            CustomerChanceBuyPrice(player);
        }
        //Member Methods (CAN DO)
        public override void CustomerChanceBuyTemp(int temperature)
        {
            if (temperature >= 40 && temperature < 45)
            {
                chanceToBuy -= 20;
            }
            else if (temperature >= 45 && temperature < 80)
            {
                chanceToBuy += 10;
            }
            else if (temperature >= 80)
            {
                chanceToBuy += 30;
            }
        }
        public override void CustomerChanceBuyPrice(Player player)
        {
            if (player.recipe.pricePerCup > 0.30)
            {
                chanceToBuy -= 20;
            }
            else if (player.recipe.pricePerCup > 0.10 && player.recipe.pricePerCup <= 0.30)
            {
                chanceToBuy += 10;
            }
            else if (player.recipe.pricePerCup > 0 && player.recipe.pricePerCup <= 0.10)
            {
                chanceToBuy += 20;
            }
        }
        public override void CustomerChanceBuyRecipe(Player player)
        {
            if (player.recipe.amountOfSugarCubes > 4)
            {
                chanceToBuy += 20;
            }
            else if (player.recipe.amountOfSugarCubes > 2 && player.recipe.amountOfSugarCubes <= 4)
            {
                chanceToBuy += 10;
            }
            else if (player.recipe.amountOfSugarCubes > 0 && player.recipe.amountOfSugarCubes <= 2)
            {
                chanceToBuy -= 20;
            }
        }
    }
}
