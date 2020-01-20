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
            pitcher.PourGlassOfLemonaid();
        }
        public void ChooseYourUserName()
        {
            Console.WriteLine("Enter your Name.");
            userName = Console.ReadLine();
            Console.Clear();
        }
        public void CreateNewPitcher()
        {
            inventory.SubtractLemonsFromInventory();
            inventory.SubtractSugarCubesFromInventory();
            inventory.SubtractIceCubesFromInventory();
            pitcher.FillUpLemonaidInPitcher();
        }
        public void CheckInventory()
        {
            bool enoughLemons = new bool();
            bool enoughSugarCubes = new bool();
            bool enoughIceCubes = new bool();
            inventory.CheckForEnoughLemons(enoughLemons);
            inventory.CheckForEnoughSugarCubes(enoughSugarCubes);
            inventory.CheckForEnoughIceCubes(enoughIceCubes);
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
    }
}
