using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Store
    {
        //Member Variables (HAS A)       
        Inventory storeInventory;
        string itemPurchased;
        int numberOfItems;
        //Constructor
        public Store()
        {
            storeInventory = new Inventory();
        }
        //Member Methods (CAN DO)
        public double SellLemons(Player player)
        {
            itemPurchased = "lemon";
            numberOfItems = NumberItemsToPurchase();
            double saleCost = storeInventory.lemon.purchasePrice * numberOfItems;
            return saleCost;
        }
        public double SellSugar(Player player)
        {
            itemPurchased = "sugar";
            numberOfItems = NumberItemsToPurchase();
            double saleCost = storeInventory.sugarcube.purchasePrice * numberOfItems;
            return saleCost;
        }
        public double SellIce(Player player)
        {
            itemPurchased = "ice";
            numberOfItems = NumberItemsToPurchase();
            double saleCost = storeInventory.icecube.purchasePrice * numberOfItems;
            return saleCost;
        }
        public double SellCups(Player player)
        {
            itemPurchased = "cup";
            numberOfItems = NumberItemsToPurchase();
            double saleCost = storeInventory.cup.purchasePrice * numberOfItems;
            return saleCost;
        }
        public void ItemAquiredByPlayer(int numberOfItems, Player player, string itemPurchase)
        {
            for (int i = 0; i < numberOfItems; i++)
            {
                if(itemPurchase == "lemon")
                {
                    player.inventory.lemons.Add(new Lemon());
                }
                else if (itemPurchase == "sugar")
                {
                    player.inventory.sugarCubes.Add(new SugarCube());
                }
                else if (itemPurchase == "cup")
                {
                    player.inventory.cups.Add(new Cup());
                }
                else if (itemPurchase == "ice")
                {
                    player.inventory.icecubes.Add(new IceCube());
                }
            }
        }    
        public int NumberItemsToPurchase()
        {
            numberOfItems = UserInterface.GetUserInteger("How many items do you want?");
            return numberOfItems;
        }
        public void CreditCheck(double saleCost, Player player)
        {
            if (saleCost > player.wallet.Money)
            {
                Console.Clear();
                Console.WriteLine("CARD DECLINED!\n" +
                    "This costs $" + saleCost + ", you only have $" + decimal.Round(Convert.ToDecimal(player.wallet.Money), 2) + " remaining.\n\n");              
            }
            else
            {
                StorePurchase(saleCost, player);
            }

        }
        public void StorePurchase(double saleCost, Player player)
        {
            Console.Clear();
            Console.WriteLine("Your total comes to $" + decimal.Round(Convert.ToDecimal(saleCost), 2) + "!\n");
            player.wallet.Money -= saleCost;
            ItemAquiredByPlayer(numberOfItems, player, itemPurchased);
            Console.WriteLine("You have $" + decimal.Round(Convert.ToDecimal(player.wallet.Money), 2) + " remaining.");
        }
    }
}
