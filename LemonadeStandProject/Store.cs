using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Store
    {
        //Member Variables (HAS A)
        double pricePerLemon;
        double pricePerSugarCube;
        double procePerIceCube;
        double pricePerCup;
        //Constructor
        public Store()
        {
            pricePerLemon = 0.25;
            pricePerSugarCube = 0.01;
            procePerIceCube = 0.01;
            pricePerCup = 0.05;
        }
        //Member Methods (CAN DO)

        public void RunStore()
        {
            MakePurchases();
        }
        public void MakePurchases()
        {
            Console.WriteLine("Welcome to The Store! What do you want to do?\n" +
                                "1) Lemon\n2) SugarCube\n3) IceCube\n4) Cup\n5)Exit");
            string selection = Console.ReadLine().ToLower();
            do
            {
                switch (selection)
                {
                    case "1":
                    case "lemon":
                        break;
                    case "2":
                    case "sugarcube":
                    case "sugar cube":
                        break;
                    case "3":
                    case "icecube":
                    case "ice cube":
                        break;
                    case "4":
                    case "cup":
                        break;
                    case "5":
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Please enter a valid selection.");
                        MakePurchases();
                        break;
                }
            } while (selection != "exit");

        }

    }
}
