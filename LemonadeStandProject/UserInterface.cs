using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public static class UserInterface
    {
        //Member Variables (HAS A)
        
        //Constructor

        //Member Methods (CAN DO)
        public static void StartScreen()
        {
            Console.WriteLine("Welcome your Lemonade Stand!\n\nPlease press enter to continue!");
            Console.ReadLine();
        }
        public static void Instructions()
        {
            Console.Clear();
            Console.WriteLine("Ahhhh... Its a hot lazy summer in your little subarb of the world and you are eleven years old again.\n" +
                "You have five dollars left over from your birthday money, and your mom even gives you fifteen more. You're done\n" +
                "exploring the neighborhood with your friends and are excited by the prospect of earning some money! You decide\n" +
                "to open a lemonade stand!\n\n" +
                "Lemonade Stand is played over a minimum of seven days, your day will be as follows:\n" +
                "You will start each day seeing your inventory, then you will decide if you want to make a trip to the store.\n" +
                "Once you have returned from the store, You will decide if you want to change your reciepe and prices for the day.\n" +
                "When you have open the stand for the day, customers will begin to decide if they would like to purchase from you.\n" +
                "\n" +
                "Keep in mind that the weather, your prices, and recipe all greatly affect the customers choice to buy.\n" +
                "Keep in mind the forecast given at the begining of each day, when making your purchases and changing your recipe!\n\n" +
                "Press enter to set up you game.");
            Console.ReadLine();
        }
        public static void UserDisplay(Player player, Day days)
        {
            Console.WriteLine(player.userName + "'s Lemonade Stand\n" +
                "Today's Forcast: High Temperature of " + days.temperature + " and " + days.weather.condition);
        }
        public static int GetRandomInteger(int min, int max, Random random)
        {
            int randInteger = random.Next(min, max);
            return randInteger;
        }
        public static int GetUserInteger(string output)
        {
            Console.WriteLine(output);
            Int32.TryParse(Console.ReadLine(), out int result);
            return result;
        }
        public static void InventoryDisplay(Player player)
        {
            //Console.WriteLine($"hello this is a variable {player.recipe}");
            Console.WriteLine(
            "You currently have: $" + player.wallet.Money + "\n\n" +
            "Your Inventory: \n" + 
            "Lemons: " + player.inventory.lemons.Count() + "\n" +
            "Sugar Cubes: " + player.inventory.sugarCubes.Count() + "\n" +
            "Ice Cubes: " + player.inventory.icecubes.Count() + "\n" +
            "Cups: " + player.inventory.cups.Count() + "\n");
        }
        public static void RecipeDisplay(Player player)
        {
            Console.WriteLine("Current Recipe:\n" +
            "Lemons: " + player.recipe.amountOfLemons + "\n" +
            "Sugar Cubes: " + player.recipe.amountOfSugarCubes + "\n" +
            "Ice Cubes: " + player.recipe.amountOfIceCubes + "\n");
        }
        public static void CostDisplay(Player player)
        {
            Console.WriteLine("Current Cost per Cup: $" + Convert.ToDecimal(player.recipe.pricePerCup));
        }
        public static void BeginningDayDisplay(Player player, Day days)
        {
            UserDisplay(player, days);
            Console.WriteLine();
            CostDisplay(player);
            InventoryDisplay(player);
            RecipeDisplay(player);
        }
        public static void EndOfDayDisplay(Player player, Day day, int servedCustomers, double begindaysMoney, double enddaysMoney)
        {
            Console.WriteLine("End of day Results:\n" +
               "Todays Profit/Loss: " + decimal.Round(Convert.ToDecimal(enddaysMoney - begindaysMoney), 2)+"\n" +
               "Total Profit/Loss: " + decimal.Round((Convert.ToDecimal(player.wallet.Money - 20)),2) +"\n" +
               "Customers: "+ servedCustomers + " out of " + day.customers.Count+ "\n\n " +
               "Press Enter to continue to next day");
            Console.ReadLine();
            Console.Clear();
        }
        public static void EndOfGameDisplay(Player player)
        {
            Console.WriteLine("Congratulations you have made it the the end of running your lemonade stand!\n" +
                "Let's find out how you did:\n" +
                "Total Profit/Loss: " + (decimal.Round((Convert.ToDecimal(player.wallet.Money - 20)), 2)) + "\n" +
                "Press Enter to exit the Game");
            Console.ReadLine();
        }
    }
}




