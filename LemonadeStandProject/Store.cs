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
        public Player player;
        public int numberOfItems;
        public double saleCost;
        //Constructor
        public Store()
        {
            storeInventory = new Inventory();
        }
        //Member Methods (CAN DO)

        public double SellLemons(Player player)
        {
            NumberItemsToPurchase();
            saleCost = storeInventory.lemon.purchasePrice * numberOfItems;
            //AddLemonsToInventory(numberOfItems, player);
            return saleCost;
        }
        public double SellSugar(Player player)
        {
            NumberItemsToPurchase();
            saleCost = storeInventory.sugarcube.purchasePrice * numberOfItems;
            //AddSugarToInventory(numberOfItems, player);
            return saleCost;
        }
        public double SellIce(Player player)
        {
            NumberItemsToPurchase();
            saleCost = storeInventory.icecube.purchasePrice * numberOfItems;
            //AddIceToInventory(numberOfItems, player);
            return saleCost;
        }
        public double SellCups(Player player)
        {
            NumberItemsToPurchase();
            saleCost = storeInventory.cup.purchasePrice * numberOfItems;
            //AddCupToInventory(numberOfItems, player);
            return saleCost;
        }
        public void AddItemsToInventory(int numberOfItems, Player player, string itemPurchase)
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
                else
                {
                    break;
                }
            }
        }
        public void NumberItemsToPurchase()
        {
            Console.WriteLine("How many items do you want?");
            Int32.TryParse(Console.ReadLine(), out numberOfItems);
        }
    }
}
