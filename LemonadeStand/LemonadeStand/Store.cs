using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {

        private double pricePerLemon;
        private double pricePerSugarCube;
        private double pricePerIceCube;
        private double pricePerCup;

        public Store()
        {
            
        }

        public void DisplayStoreOptions()
        {
            Console.WriteLine("Welcome to the store, you can buy all your necessary ingredients for a lemonade stand here. Type 'lemon', 'cup', 'sugar', or 'ice' to view options and pricing.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "lemon":
                    BuyLemons();
                    break;
                case "cup":
                    BuyCup();
                    break;
                case "sugar":
                    BuySugar();
                    break;
                case "ice":
                    BuyIce();
                    break;
                default:
                    Console.WriteLine("Your input was not valid.");
                    DisplayStoreOptions();
                    break;
            }
        }

        public void BuyLemons()
        {
            //create prompt for welcome to store
            //display prices for lemons
            //buy lemons
            //take money from wallet
            //add lemons to inventory
            Console.WriteLine("Here are the different prices for Lemons.");
            Console.WriteLine("Lemons are sold in 3 bundles. 25 Lemons for 1$, 50 lemons for 2$, and 75 lemons for 3$. Type '25', '50', or '75'.");
            string Input = Console.ReadLine();
            switch (Input)
            {
                case "25":
                    break;
                case "50":
                    break;
                case "75":
                    break;
                default:
                    Console.WriteLine("Your input was not valid.");
                    BuyLemons();
                    break;
            }
        }

        public void BuyCup()
        {
            Console.WriteLine("Here are the different prices for Cups.");
            Console.WriteLine("Cups are sold in 3 bundles. 25 Cups for 1$, 50 Cups for 2$, and 75 Cups for 3$. Type '25', '50', or '75'.");
            string Input = Console.ReadLine();
            switch (Input)
            {
                case "25":
                    break;
                case "50":
                    break;
                case "75":
                    break;
                default:
                    Console.WriteLine("Your input was not valid.");
                    BuyCup();
                    break;
            }
        }

        public void BuyIce()
        {
            Console.WriteLine("Here are the different prices for Ice.");
            Console.WriteLine("Ice are sold in 3 bundles. 50 Ice for 1$, 150 Ice for 2$, and 250 Ice for 3$. Type '50', '150', or '250'.");
            string Input = Console.ReadLine();
            switch (Input)
            {
                case "50":
                    break;
                case "150":
                    break;
                case "250":
                    break;
                default:
                    Console.WriteLine("Your input was not valid.");
                    BuyIce();
                    break;
            }
        }

        public void BuySugar()
        {
            Console.WriteLine("Here are the different prices for Sugar.");
            Console.WriteLine("Sugar are sold in 3 bundles. 25 Sugar for 1$, 50 Sugar for 2$, and 75 Sugar for 3$. Type '25', '50', or '75'.");
            string Input = Console.ReadLine();
            switch (Input)
            {
                case "25":
                    break;
                case "50":
                    break;
                case "75":
                    break;
                default:
                    Console.WriteLine("Your input was not valid.");
                    BuySugar();
                    break;
            }
        }

        public void SubtractMoney()
        {

        }
    }
}
