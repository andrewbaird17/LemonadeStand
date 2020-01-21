using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class OldWoman : Customer
    {
        //Member Variables (HAS A)

        //Constructor
        public OldWoman(Random random, Player player, int temperature)
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
            if (temperature >= 40 && temperature < 50)
            {
                chanceToBuy -= 10;
            }
            else if (temperature >= 50 && temperature < 65)
            {
                chanceToBuy += 20;
            }
            else if (temperature >= 65 && temperature < 85)
            {
                chanceToBuy += 10;
            }
            else if (temperature >= 85)
            {
                chanceToBuy -= 20;
            }
        }
        public override void CustomerChanceBuyPrice(Player player)
        {
            if (player.recipe.pricePerCup > 0.40)
            {
                chanceToBuy -= 10;
            }
            else if (player.recipe.pricePerCup > 0.25 && player.recipe.pricePerCup <= 0.40)
            {
                chanceToBuy += 10;
            }
            else if (player.recipe.pricePerCup > 0 && player.recipe.pricePerCup <= 0.25)
            {
                chanceToBuy += 20;
            }
        }
        public override void CustomerChanceBuyRecipe(Player player)
        {
            if (player.recipe.amountOfLemons > 4)
            {
                chanceToBuy += 30;
            }
            else if (player.recipe.amountOfLemons > 2 && player.recipe.amountOfLemons <= 4)
            {
                chanceToBuy += 15;
            }
            else if (player.recipe.amountOfLemons > 0 && player.recipe.amountOfLemons <= 2)
            {
                chanceToBuy -= 15;
            }
        }
    }
}
