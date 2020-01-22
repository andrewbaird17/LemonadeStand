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
            day = new Day(random);
            days = new List<Day>();
            player = new Player();
            store = new Store();
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
        public void RunGame()
        {
            int i = 0;
            Console.Clear();
            player.ChooseYourUserName();
            int numberOfDays = CreateLengthOfGame();
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
            Console.Clear();
            UserInterface.EndOfGameDisplay(player);
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
        public void UserChoices()
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

