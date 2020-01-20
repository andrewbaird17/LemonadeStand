using System;
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
        List<Day> days;
        Store store;
        int numberOfDays;
        //Constructor
        public Game()
        {
            days = new List<Day>();
            player = new Player();
            store = new Store();
            random = new Random();
        }
        //Member Methods (CAN DO)
        public void StartUp()
        {
            UserInterface.StartScreen();
            MainMenu();
        }
        public void MainMenu()

        {
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
        public void RunGame()
        {
            Console.Clear();
            int i = 0;
            player.ChooseYourUserName();
            CreateLengthOfGame();
            do
            {
                UserInterface.UserDisplay(player, days[i]);
                Console.ReadLine();
                UserInterface.InventoryDisplay(player);
                Console.ReadLine();
                UserChoices();
                i++;
            } while (i < numberOfDays);
        }
        public void CreateLengthOfGame()
        {
            numberOfDays = SelectNumberDays();
            for (int i = 0; i < numberOfDays; i++)
            {
                days.Add(new Day(random));
                days[i].ChooseCondition();
                days[i].ChooseTemp();
                days[i].ChooseNumberOfCustomers(days[i].weather);
            }
        }
        public int SelectNumberDays()
        {

            Console.WriteLine("How many days would you like to run your Lemonade Stand for?");
            Int32.TryParse(Console.ReadLine(), out int numberOfDays);
            if (numberOfDays < 7)
            {
                Console.Clear();
                Console.WriteLine("Please try again. Your input is not a valid option. Minimum game length is 7 days.\n\n");
                SelectNumberDays();
            }
            Console.Clear();
            return numberOfDays;
        }
        public void GoToTheStore(bool playerWantsToShop)
        {
            Console.Clear();
            double saleCost;
            UserInterface.InventoryDisplay(player);
            do
            {
                saleCost = Shopping();
                CreditCheck(saleCost);
                StorePurchase(saleCost);
            } while (playerWantsToShop == true);
        }
        public double Shopping()
        {
            double saleCost;
            Console.WriteLine("What would you like to buy:\n" +
                "1. Lemons - Cost 0.25 per lemon\n" +
                "2. Sugar Cube - Cost 0.10 per Sugar Cube\n" +
                "3. Cups - Cost 0.05 per Cup \n" +
                "4. Ice Cube - Cost 0.01 per Ice Cube \n" +
                "5. Exit back to ");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "lemons":
                case "lemon":
                    saleCost = store.SellLemons();
                    return saleCost;
                case "2":
                case "sugar":
                case "sugar cubes":
                    saleCost = store.SellSugar();
                    return saleCost;

                case "3":
                case "cups":
                case "cup":
                    saleCost = store.SellCups();
                    return saleCost;

                case "4":
                case "ice":
                    saleCost = store.SellIce();
                    return saleCost;
                //case "5":
                //case "exit":
                //    UserChoices();
                //    return saleCost;
                //    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Try using just the number associated with the choice!");
                    GoToTheStore(true);
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
                    "This costs $" + saleCost + ", you only have $" + player.wallet.Money + "remaining.\n\n");
                ContinueShopping();
            }

        }
        public void StorePurchase(double saleCost)
        {
            Console.WriteLine("Your total comes to $" + saleCost + "!\n" +
               "$" + player.wallet.Money + " - $" + saleCost);
            player.wallet.Money -= saleCost;
            Console.WriteLine("You have $" + player.wallet.Money + " remaining.");
            ContinueShopping();
        }
        public void ContinueShopping()
        {
            bool playerWantsToShop;
            Console.WriteLine("Would you like to continue Shopping?\n1. Yes\n2. No");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "yes":
                    playerWantsToShop = true;
                    Console.Clear();
                    GoToTheStore(playerWantsToShop);
                    break;
                case "2":
                case "no":
                    playerWantsToShop = false;
                    Console.Clear();
                    GoToTheStore(playerWantsToShop);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please try enetering only the number associated with your choice.");
                    ContinueShopping();
                    break;
            }
        }
        public void UserChoices()
        {
            Console.WriteLine("What would you like to do?\n1: Go to Store\n2: See Week's Forecast\n3: Open Lemonade Stand");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "go to store":
                    GoToTheStore(true);
                    break;
                case "2":
                case "forecast":
                    WeatherForecast();
                    Console.Clear();
                    UserChoices();
                    break;
                case "3":
                case "open":
                    break;
                default:
                    break;
            }
        }
        public void WeatherForecast()
        {
            for (int i = 0; i < numberOfDays; i++)
            {
                Console.WriteLine("Day "+(i+1)+ ": High Temperature of " + days[i].temperature + " and " + days[i].weather.condition + "\n");
            }
            Console.ReadLine();    
        }
    }
}

