using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MealAndDrinkGenerator
{
    internal class Drink : Food
    {
        public string _coke;
        public string _water;
        public string _beer;
        public Drink(string pizza, string burger, string tacos, string salad, int price, string coke, string water, string beer)
            : base(pizza, burger, tacos, salad, price)
        {
            _beer = beer;
            _water = water;
            _coke = coke; 
        }



        public string ValidMealCombinations()
        {
            return "Random dinner generator!\n" + "Dagens middag er *drumroll* \n" + $"{_pizza}, og {_coke}";
        }
    }
}
