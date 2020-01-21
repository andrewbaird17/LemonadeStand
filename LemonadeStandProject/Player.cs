using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Player
    {
        //Member Variables (HAS A)
        public string userName;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;

        //Constructor
        public Player()
        {
            wallet = new Wallet();
            recipe = new Recipe();
            inventory = new Inventory();
            pitcher = new Pitcher();
        }
        //Member Methods (CAN DO)
        public bool SellGlassOfLemonaid()
        {
            if (pitcher.cupsLeftInPitcher >= 1)
            {
                pitcher.PourGlassOfLemonaid();
                SubtractCupsFromInventory();
                return true;
            }
            else
            {
                CheckInventory();
                return false;
            }
        }
        public void ChooseYourUserName()
        {
            Console.WriteLine("Enter your Name:");
            userName = Console.ReadLine();
            Console.Clear();
        }
        public void CreateNewPitcher()
        {
            SubtractLemonsFromInventory();
            SubtractSugarCubesFromInventory();
            SubtractIceCubesFromInventory();
            pitcher.FillUpLemonaidInPitcher();
        }
        public bool CheckInventory()
        {
           
            bool enoughLemons = CheckForEnoughLemons();
            bool enoughSugarCubes = CheckForEnoughSugarCubes();
            bool enoughIceCubes = CheckForEnoughIceCubes();
            if ((enoughLemons == true) && (enoughIceCubes == true) && (enoughSugarCubes == true))
            {
                CreateNewPitcher();
                return true;
            }
            else
            {
                Console.WriteLine("You have run out of product!");
                Console.ReadLine();
                return false;
                //ADD end of day operation or not maybe
            }
        }
        public void SubtractCupsFromInventory()
        {
                inventory.cups.RemoveAt(0);
        }
        public void SubtractLemonsFromInventory()
        {
            for (int i = 0; i < recipe.amountOfLemons; i++)
            {
                inventory.lemons.RemoveAt(0);
            }
        }
        public void SubtractSugarCubesFromInventory()
        {
            for (int i = 0; i < recipe.amountOfSugarCubes; i++)
            {
                inventory.sugarCubes.RemoveAt(0);
            }
        }
        public void SubtractIceCubesFromInventory()
        {
            for (int i = 0; i < recipe.amountOfIceCubes; i++)
            {
                inventory.icecubes.RemoveAt(0);
            }
        }
        public bool CheckForEnoughLemons()
        {
            if (inventory.lemons.Count() >= recipe.amountOfLemons)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckForEnoughSugarCubes()
        {
            if (inventory.sugarCubes.Count() >= recipe.amountOfLemons)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckForEnoughIceCubes()
        {
            if (inventory.icecubes.Count() >= recipe.amountOfIceCubes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ChangeRecipe()
        {
            Console.WriteLine("Enter your desired recipe!\n" +
                "Tip: Although you can skimp on ingredients the customers may not like it.\n");
            recipe.ChangePriceOfCup();
            recipe.ChangeAmountOfLemonsInRecipe();
            recipe.ChangeAmountOfSugarCubes();
            recipe.ChangeAmountOfIceCubes();
        }
    }
}
