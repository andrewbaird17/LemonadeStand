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
        public int numItems;
        public double saleCost;

        //Constructor
        public Store()
        {
            storeInventory = new Inventory();   
        }
        //Member Methods (CAN DO)

        public void RunStore()
        {
            NumberItemsToPurchase();
        }
        public double SellLemons()
        {
           NumberItemsToPurchase();
           saleCost = storeInventory.lemon.purchasePrice*numItems;
           return saleCost;
        }

        public double SellSugar()
        {
            NumberItemsToPurchase();
            saleCost = storeInventory.sugarcube.purchasePrice * numItems;
            return saleCost;
        }

        public double SellIce()
        {
            NumberItemsToPurchase();
            saleCost = storeInventory.icecube.purchasePrice * numItems;
            return saleCost;
        }
        public double SellCups()
        {
            NumberItemsToPurchase();
            saleCost = storeInventory.cup.purchasePrice * numItems;
            return saleCost;
        }
        public void NumberItemsToPurchase()
        {
            Console.WriteLine("How many items do you want?");
            string setnumItems = Console.ReadLine();
            Int32.TryParse(setnumItems, out int numItems);
            
        }
    }
}
