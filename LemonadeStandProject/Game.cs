﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Game
    {
        //Member Variables (HAS A)
        Random random;
        Player player;
        Day day;
        List<Day> days;
        Store store;
        int servedCustomers;
        double begindaysMoney;
        double enddaysMoney;
        string itemPurchase;

        //Constructor
        public Game()
        {
            day = new Day(random);
            days = new List<Day>();
            player = new Player();
            store = new Store();
            random = new Random();
            servedCustomers = 0;
        }
        //Member Methods (CAN DO)
        public void MainMenu()
        {
            UserInterface.StartScreen();
            Console.Clear();
            Console.WriteLine("Please select from the following options:\n1:Start Game\n2:Instructions");
            switch (Console.ReadLine())
            {
                case "1":
                case "start":
                case "start game":
                case "game":
                    RunGame();
                    break;
                case "2":
                case "instructions":
                case "instruct":
                    UserInterface.Instructions();
                    MainMenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("That is not a valid choice.\n\n");
                    MainMenu();
                    break;
            }
        }
        public void RunGame(int numberOfDays = 0)
        {
            Console.Clear();
            int i = 0;
            player.ChooseYourUserName();
            CreateLengthOfGame();
            do
            {
                UserInterface.BeginningDayDisplay(player, days[i], i);
                UserChoices();
                StartDay();
                days[i].CreateCustomers(player);
                begindaysMoney = player.wallet.Money;
                RunDaySimulation(i);
                enddaysMoney = player.wallet.Money;
                UserInterface.EndOfDayDisplay(player, days[i], servedCustomers, begindaysMoney, enddaysMoney);
                i++;
                servedCustomers = 0;
            } while (i < numberOfDays);
            // End of Game Results
        }
        public int CreateLengthOfGame()
        {
            int numberOfDays = day.SelectNumberDays();
            for (int i = 0; i < numberOfDays; i++)
            {
                days.Add(new Day(random));
            }
            return numberOfDays;
        }
        public void GoToTheStore()
        {
            Console.Clear();
            double saleCost;
            UserInterface.InventoryDisplay(player);
            saleCost = Shopping();
            CreditCheck(saleCost);

        }
        public double Shopping()
        {
            double saleCost;
            Console.WriteLine("What would you like to buy:\n" +
                "1. Lemons - Cost 0.25 per lemon\n" +
                "2. Sugar Cube - Cost 0.10 per Sugar Cube\n" +
                "3. Cups - Cost 0.05 per Cup \n" +
                "4. Ice Cube - Cost 0.01 per Ice Cube \n" +
                "5. Exit back to Main Menu");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "lemons":
                case "lemon":
                    Console.Clear();
                    UserInterface.InventoryDisplay(player);
                    saleCost = store.SellLemons(player);
                    itemPurchase = "lemon";
                    return saleCost;
                case "2":
                case "sugar":
                case "sugar cubes":
                    Console.Clear();
                    UserInterface.InventoryDisplay(player);
                    saleCost = store.SellSugar(player);
                    itemPurchase = "sugar";
                    return saleCost;

                case "3":
                case "cups":
                case "cup":
                    Console.Clear();
                    UserInterface.InventoryDisplay(player);
                    saleCost = store.SellCups(player);
                    itemPurchase = "cup";
                    return saleCost;

                case "4":
                case "ice":
                    Console.Clear();
                    UserInterface.InventoryDisplay(player);
                    saleCost = store.SellIce(player);
                    itemPurchase = "ice";
                    return saleCost;
                case "5":
                case "exit":
                    saleCost = 0;
                    itemPurchase = "";
                    return saleCost;
                default:
                    Console.Clear();
                    Console.WriteLine("Try using just the number associated with the choice!");
                    GoToTheStore();
                    saleCost = 0;
                    return saleCost;
            }
        }
        public void CreditCheck(double saleCost)
        {
            if (saleCost > player.wallet.Money)
            {
                Console.Clear();
                Console.WriteLine("CARD DECLINED!\n" +
                    "This costs $" + saleCost + ", you only have $" + player.wallet.Money + " remaining.\n\n");
                ContinueShopping();
            }
            else
            {
                StorePurchase(saleCost);
            }

        }
        public void StorePurchase(double saleCost)
        {
            Console.Clear();
            Console.WriteLine("Your total comes to $" + saleCost + "!\n");
            player.wallet.Money -= saleCost;
            store.AddItemsToInventory(store.numberOfItems, player, itemPurchase);
            Console.WriteLine("You have $" + player.wallet.Money + " remaining.");
            ContinueShopping();
        }
        public void ContinueShopping()
        {
            Console.WriteLine("Would you like to continue Shopping?\n1. Yes\n2. No");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "yes":
                    Console.Clear();
                    GoToTheStore();
                    break;
                case "2":
                case "no":
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please try entering only the number associated with your choice.");
                    ContinueShopping();
                    break;
            }
        }
        public void UserChoices()
        {
            //while()
            //{ }
            Console.WriteLine("What would you like to do?\n1: Go to Store\n2: See Week's Forecast\n3: Change Recipe\n4: Open Lemonade Stand");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "go to store":
                case "store":
                case "go":
                    GoToTheStore();
                    break;
                case "2":
                case "week":
                case "see week":
                case "see week's":
                case "forecast":
                case "see weeks forecast":
                case "see week's forecast":
                    day.WeatherForecast(days);
                    Console.Clear();
                    break;
                case "3":
                case "change recipe":
                case "change":
                case "recipe":
                    Console.Clear();
                    UserInterface.CostDisplay(player);
                    UserInterface.RecipeDisplay(player);
                    player.ChangeRecipe();
                    break;
                case "4":
                case "open":
                case "open lemonade":
                case "open lemonade stand":
                case "lemonade":
                case "lemonade stand":
                case "stand":
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please Try Entering the number associated with the option you would like to do.");
                    break;
            }
        }
        public void StartDay()
        {
            Console.WriteLine("Would you like to start selling?\n1) Yes\n2) No");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "yes":
                    break;
                case "2":
                case "no":
                    Console.Clear();
                    UserChoices();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please try entering only the number associated with your choice.");
                    StartDay();
                    break;
            }
        }
        public void RunDaySimulation(int i)
        {
            for (int j = 0; j < days[i].randomNumberOfCustomers; j++)
            {
                if (days[i].customers[j].chanceToBuy > 70)
                {
                    Console.Clear();
                    //player.SellGlassOfLemonaid();
                    if (player.SellGlassOfLemonaid() == true)
                    {
                        player.wallet.Money += player.recipe.pricePerCup;
                        servedCustomers += 1;
                    }
                }
            }
        }
    }
}

