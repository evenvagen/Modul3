using System;
using System.Net.Sockets;

namespace StaticToNotStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Place.ShowPlace("Karmøy", "Rogaland");
            Place.ShowPlace("Skien", "Telemark");
            Place.ShowPlace("Oslo", "Oslo");
        }

       
        
    }
}
