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
        public void SellGlassOfLemonaid()
        {
            if (pitcher.cupsLeftInPitcher >= 1)
            {
                pitcher.PourGlassOfLemonaid();
            }
            else
            {
                CheckInventory();
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
        public void CheckInventory()
        {
            bool enoughLemons = true;
            bool enoughSugarCubes = true;
            bool enoughIceCubes = true;
            CheckForEnoughLemons(enoughLemons);
            CheckForEnoughSugarCubes(enoughSugarCubes);
            CheckForEnoughIceCubes(enoughIceCubes);
            if ((enoughLemons == true) & (enoughIceCubes == true) & (enoughSugarCubes == true))
            {
                CreateNewPitcher();
            }
            else
            {
                Console.WriteLine("You have run out of product!");
                Console.ReadLine();
                //ADD end of day operation or not maybe
            }
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
        public bool CheckForEnoughLemons(bool enoughLemons)
        {
            if (inventory.lemons.Count() >= recipe.amountOfLemons)
            {
                return enoughLemons = true;
            }
            else
            {
                return enoughLemons = false;
            }

        }
        public bool CheckForEnoughSugarCubes(bool enoughSugarCubes)
        {
            if (inventory.sugarCubes.Count() >= recipe.amountOfLemons)
            {
                return enoughSugarCubes = true;
            }
            else
            {
                return enoughSugarCubes = false;
            }
        }
        public bool CheckForEnoughIceCubes(bool enoughIceCubes)
        {
            if (inventory.icecubes.Count() >= recipe.amountOfIceCubes)
            {
                return enoughIceCubes = true;
            }
            else
            {
                return enoughIceCubes = false;
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
