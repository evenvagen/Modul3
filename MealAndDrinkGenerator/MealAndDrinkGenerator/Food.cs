using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealAndDrinkGenerator
{
    internal class Food : Price
    {
        internal string _pizza { get; set; }
        internal string _burger;
        internal string _tacos;
        internal string _salad;


        public Food(string pizza, string burger, string tacos, string salad, int price)
        {
            _pizza = pizza;
            _burger = burger;
            _tacos = tacos;
            _salad = salad;
            _pizzaPrice = price;
        }

       

       


    }
}
