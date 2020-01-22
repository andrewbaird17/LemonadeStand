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
        public Store distributor;
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
            distributor = new Store();
        }
        //Member Methods (CAN DO)
        public bool SellGlassOfLemonaid()
        {
            if ((pitcher.cupsLeftInPitcher >= 1) && (inventory.cups.Count >= 1))
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
            bool enoughCups = CheckForEnoughCups();
            if ((enoughLemons == true) && (enoughIceCubes == true) && (enoughSugarCubes == true) && (enoughCups == true))
            {
                CreateNewPitcher();
                return true;
            }
            else
            {
                Console.WriteLine("You have run out of product!");
                Console.ReadLine();
                return false;
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
        public bool CheckForEnoughCups()
        {
            if (inventory.cups.Count() >= 1)
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
        public void GoToTheStore(Player player)
        {
            Console.Clear();
            bool continueShopping = true;
            do
            {
                Console.Clear();
                UserInterface.InventoryDisplay(player);
                Shopping(player);
                continueShopping = ContinueShopping();
            }
            while (continueShopping == true);
        }
        public bool ContinueShopping()
        {
            Console.WriteLine("Would you like to continue Shopping?\n1. Yes\n2. No");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "y":
                case "yes":
                    return true;
                default:
                    return false;
                    
            }
        }
        public void Shopping(Player player)
        {
            double saleCost;
            Console.WriteLine("What would you like to buy:\n" +
                "1. Lemon - Cost 0.25 per lemon\n" +
                "2. Sugar Cube - Cost 0.10 per Sugar Cube\n" +
                "3. Ice Cube - Cost 0.01 per Ice Cube \n" +
                "4. Cup - Cost 0.05 per Cup \n" +
                "5. Exit back to Main Menu");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "lemons":
                case "lemon":
                    Console.Clear();
                    UserInterface.InventoryDisplay(player);
                    saleCost = distributor.SellLemons(player);
                    distributor.CreditCheck(saleCost, player);
                    break;
                case "2":
                case "sugar":
                case "sugar cubes":
                    Console.Clear();
                    UserInterface.InventoryDisplay(player);
                    saleCost = distributor.SellSugar(player);
                    distributor.CreditCheck(saleCost, player);
                    break;
                case "3":
                case "cups":
                case "cup":
                    Console.Clear();
                    UserInterface.InventoryDisplay(player);
                    saleCost = distributor.SellCups(player);
                    distributor.CreditCheck(saleCost, player);
                    break;
                case "4":
                case "ice":
                    Console.Clear();
                    UserInterface.InventoryDisplay(player);
                    saleCost = distributor.SellIce(player);
                    distributor.CreditCheck(saleCost, player);
                    break;
                default:
                    break;
            }
        }
    }
}
