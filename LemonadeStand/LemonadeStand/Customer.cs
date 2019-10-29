using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {

        private List<string> names;
        public string name;
        public string thirstLevel;

        public Customer()
        {
            names = new List<string>();;
        }

        public void FindThirstLevel(Weather weather)
        {
            if (weather.temperature >= 40 && weather.temperature <= 60)
            {
                weather.condition = "Cloudy";
            }
            else if (weather.temperature >= 61 && weather.temperature <= 70)
            {
                weather.condition = "Raining";
            }
            else
            {
                weather.condition = "Sunny";
            }
        }
    }
}
