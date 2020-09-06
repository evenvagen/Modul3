using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealAndDrinkGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            var h = new Drink("skinke", "angus-burger", "bønne-taco", "Isberg", 90, "Cola", "Voss", "CB");

          Console.WriteLine(h.ValidMealCombinations());  


        }
    }
}
