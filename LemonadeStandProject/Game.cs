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
        int currentDay;
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
            CreateLengthOfGame();    
        }
        public void CreateLengthOfGame()
        {
            Day initday = new Day();
            int numDays = initday.SelectNumberDays();
            for (int i = 0; i < numDays; i++)
            {
                days.Add(new Day());
                days[i].weather.ChooseCondition();
                days[i].weather.ChooseTemp();
                Console.WriteLine("Day " + (i + 1) + " is: " + (days[i].weather.condition) + " and has a high of " + (days[i].weather.temperature));
            }
            
        }
        public void StorePurchase()
        {
            player.wallet.Money -= store.SellLemons(); 
        }
    }
}
