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
        public int numberOfItems;
        public double saleCost;
        //Constructor
        public Store()
        {
            storeInventory = new Inventory();
        }
        //Member Methods (CAN DO)

        public double SellLemons()
        {
            NumberItemsToPurchase();
            saleCost = storeInventory.lemon.purchasePrice * numberOfItems;
            return saleCost;
        }
        public double SellSugar()
        {
            NumberItemsToPurchase();
            saleCost = storeInventory.sugarcube.purchasePrice * numberOfItems;
            return saleCost;
        }
        public double SellIce()
        {
            NumberItemsToPurchase();
            saleCost = storeInventory.icecube.purchasePrice * numberOfItems;
            return saleCost;
        }
        public double SellCups()
        {
            NumberItemsToPurchase();
            saleCost = storeInventory.cup.purchasePrice * numberOfItems;
            return saleCost;
        }
        public void NumberItemsToPurchase()
        {
            Console.WriteLine("How many items do you want?");
            Int32.TryParse(Console.ReadLine(), out numberOfItems);
        }
    }
}
