using System;
using System.Collections.Generic;
using System.Threading;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<TwoValues>();
            var random = new Random();
            var count = 0; 
            while (true)
            {
                var xy = new TwoValues(random.Next(0, 10), random.Next(0,10));
                list.Add(xy);
                count++;
                if(random.Next(0, 10) == 5) break;
            }

            foreach (var xy in list)
            {
                Console.Write(xy + " ");
            }
            Console.WriteLine();
        }
    }
}
