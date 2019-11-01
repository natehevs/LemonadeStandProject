using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        /*
         * 1. Start Up Game
         * 2. Notify them of Rules/Instructions
         *      display the objective of the game
         *      Notify them that their recipe affects sales and so does weather
         * 3. Show them current Inventory
         *      List current cups, lemons, ice, sugar, and money
         *      Ice Melts if there is any left
         * 4. Display weather for current day
         *      Hot
         *      Cold
         *      Raining
         * 5. Go to shop to buy items
         *      each item has 3 bundles for different prices
         *      after each item bought subtract money from wallet and keep asking to buy something until they type 'done'
         * 6. Create Recipe for the day
         *      Recipe consists of amount of Lemons, ice, sugar, and price per cup
         *      all of these will affect sales
         * 7. Run day of sales
         *       Have total recipe be held in pitcher, when a pitcher runs out stop day of sales
         * 8. Display Results
         *      total new money
         * 9. Loop through step 3 until 7 days are finished.
         * 10. When all 7 days are done Display Profit/Loss
         * 11. Ask if they want to play again
         */

        //Has A
        private Customer customer;
        private Player player;
        private List<Day> days;
        private int currentDay;
        public Game()
        {
            //Builder

            customer = new Customer();
            player = new Player();
            days = new List<Day>();

        }

        //Can do

        public void RunGame()
        {
            DisplayName();
            DisplayRules();
            player.inventory.DisplayInventory();
            day.weather;
            customer.FindThirstLevel();

        }

        public void DisplayName()
        {
            Console.WriteLine("Welcome to the Lemonade Stand Game! What is your name?");
            Console.ReadLine();
        }

        public void DisplayRules()
        {
            Console.WriteLine("In this game you will be running your own lemonade stand. You will need to buy items from the shop and create a recipe to sell from. Keep in mind the weather can have an affect on your sales along with the recipe.");

        }

        public void DisplayProfits()
        {

        }
    }
}
