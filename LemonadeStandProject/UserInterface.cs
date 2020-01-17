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
            Console.WriteLine("Welcome your Lemonaid Stand!\n\nPlease press enter to continue to the main menu!");
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
                "Press enter to go back to main menu.");
            Console.ReadLine();
        }
        public static void UserDisplay(string name,)
        {
            Console.WriteLine("Welcome" + string name)
        }

    }
}


    

