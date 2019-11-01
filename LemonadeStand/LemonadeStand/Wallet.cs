using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {

        private double money;
        public double Money;
        public Wallet()
        {

        }

        public void BuyItems()
        {
            cash -= cost;
            Inventory.addItem();
        }
    }
}
