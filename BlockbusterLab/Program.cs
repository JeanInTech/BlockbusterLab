using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing
            Blockbuster bb = new Blockbuster();

            bb.PrintMovies();

            Movie m = bb.Checkout();
            Console.WriteLine("You selected: ");
            Console.WriteLine(m.Title);
        }
    }
}
