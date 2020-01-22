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
        Day day;
        List<Day> days;
        Store store;
        int servedCustomers;
        double begindaysMoney;
        double enddaysMoney;
        //Constructor
        public Game()
        {
            random = new Random();
            player = new Player();
            day = new Day(random, player);
            days = new List<Day>();
            store = new Store();
            servedCustomers = 0;
        }
        //Member Methods (CAN DO)
        public void StartGame()
        {
            UserInterface.StartScreen();
            UserInterface.Instructions();
            GameSetUp();
        }
        public void GameSetUp()
        {
            Console.Clear();
            player.ChooseYourUserName();
            CreateLengthOfGame();
            RunGame();
        }
        public void RunGame()
        {
            foreach (Day today in days)
            {
                bool continueUserChoices = true;
                UserInterface.BeginningDayDisplay(player, today);
                do
                {
                    continueUserChoices = UserChoices();
                }
                while (continueUserChoices == true);

                begindaysMoney = player.wallet.Money;
                RunDaySimulation();
                enddaysMoney = player.wallet.Money;
                UserInterface.EndOfDayDisplay(player, today, servedCustomers, begindaysMoney, enddaysMoney);
                servedCustomers = 0;
            }
            Console.Clear();
            UserInterface.EndOfGameDisplay(player);
        }
        public void CreateLengthOfGame()
        {
            int numberOfDays = day.SelectNumberDays();
            for (int i = 0; i < numberOfDays; i++)
            {
                days.Add(new Day(random, player));
            }
        }
        public bool UserChoices()
        {
            
            Console.WriteLine("What would you like to do?\n1: Go to Store\n2: See Week's Forecast\n3: Change Recipe\n4: Open Lemonade Stand");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "go to store":
                case "store":
                case "go":
                    player.GoToTheStore(player);
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
            bool continueUserChoices = ContinueUserChoices();
            return continueUserChoices;
        }
        public bool ContinueUserChoices()
        {
            Console.WriteLine("Would you like to start your day?\n1) Yes\n2) No\n\nOnce you start your day you can no longer change receipe, aquire more products, or change your price!");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "y":
                case "yes":
                    return false;
                default:
                    return true;
            }
        }
        public void RunDaySimulation()
        {
            foreach (Customer customer in day.customers)
            {
                if (customer.chanceToBuy > 70)
                {
                    Console.Clear();
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

