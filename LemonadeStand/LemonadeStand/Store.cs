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
            
        }

        public void BuyCup()
        {

        }

        public void BuyIce()
        {

        }

        public void BuySugar()
        {

        }

        public void SubtractMoney()
        {

        }
    }
}
