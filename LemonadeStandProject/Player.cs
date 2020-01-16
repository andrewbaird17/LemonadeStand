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
        public void AddBoughtItemsToInventory()
        {

        }
        public void CheckInventory()
        {

        }
        public void CreateNewPitcher()
        {
            for()
            inventory.lemons
        }
    }
}
