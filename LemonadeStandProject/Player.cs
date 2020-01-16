using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Player
    {
        //Member Variables (HAS A)
        string userName;
        Inventory inventory;
        Wallet wallet;
        Recipe recipe;
        Pitcher pitcher;

        //Constructor
        Player()
        {
            wallet = new Wallet();
            recipe = new Recipe();
            inventory = new Inventory();
            pitcher = new Pitcher();
        }
        //Member Methods (CAN DO)
        public void ChooseYourUserName()
        {
            Console.WriteLine("Enter your Name.");
            userName = Console.ReadLine();
        }
        //interact wallet/and store to add to items to inventory
        public void AddBoughtItemsToInventory()
        {

        }
        public void CheckInventory()
        {
            bool enoughLemons = new bool();
            bool enoughSugarCubes = new bool();
            bool enoughIceCubes = new bool();
            CheckForEnoughLemons();
            CheckForEnoughSugarCubes();
            CheckForEnoughIceCubes();
            if ((enoughLemons == true) & (enoughIceCubes == true) & (enoughSugarCubes == true))
                    {
                CreateNewPitcher();
                    }
            else
            {
                Console.WriteLine("You have run out of product!");
                Console.ReadLine();
            }
        }
        public void CreateNewPitcher()
        {
<<<<<<< HEAD
            SubtractLemonsFromInventory();
            SubtractSugarCubesFromInventory();
            SubtractIceCubesFromInventory();
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
            bool enoughLemons;
            if (inventory.lemons.Count() == recipe.amountOfLemons)
            {
                return enoughLemons = true;
            }
            else
            {
                return enoughLemons = false;
            }

        }
        public bool CheckForEnoughSugarCubes()
        {
            bool enoughSugarCubes;
            
            if (inventory.sugarCubes.Count() >= recipe.amountOfLemons)
            {
                return enoughSugarCubes = true;
            }
            else
            {
                return enoughSugarCubes = false;
            }
        }
        public bool CheckForEnoughIceCubes()
        {
            bool enoughIceCubes;

            if (inventory.icecubes.Count() >= recipe.amountOfIceCubes)
            {
                return enoughIceCubes = true;
            }
            else
            {
                return enoughIceCubes = false;
            }
=======
            
>>>>>>> 8a82d3356dd8530188aa3ee6bf621076d7b31ec7
        }
    }
}
