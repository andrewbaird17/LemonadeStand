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
        Player player;
        List<Day> days;
        Store store;
        //Constructor
        public Game()
        {
            days = new List<Day>();
            player = new Player();
            store = new Store();
        }
        //Member Methods (CAN DO)
        public void Run()
        {
            UserInterface.StartScreen();
            MainMenu();
        }
        public void MainMenu()

        {
            Console.Clear();
            Console.WriteLine("Please select from the following  options:\n1:Start Game\n2:Instructionsn");
            switch (Console.ReadLine())
            {
                case "1":
                case "start":
                case "start game":
                case "game":
                    CreateLengthOfGame();
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
        public void CreateLengthOfGame()
        {
            int numberOfDays = SelectNumberDays();
            for (int i = 0; i < numberOfDays; i++)
            {
                days.Add(new Day());
                days[i].ChooseCondition();
                days[i].ChooseTemp();
                days[i].ChooseNumCustomers();
                Console.Clear();
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
        public void GoToTheStore()
        {

        }

        public void StorePurchase()
        {
            player.wallet.Money -= store.SellLemons();
        }

    }
}

