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

        public void FindThirstLevel()
        {
            if (Weather.temperature >= 40 && Weather.temperature <= 60)
            {
                Weather.weatherConditions = "Cloudy";
            }
            else if (Weather.temperature >= 61 && Weather.temperature <= 70)
            {
                Weather.weatherConditions = "Raining";
            }
            else
            {
                Weather.weatherConditions = "Sunny";
            }
        }
    }
}
