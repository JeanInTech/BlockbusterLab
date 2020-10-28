using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userContinue = true;

            while (userContinue)
            {
                Console.Clear();
                Console.WriteLine("Welcome to GC Blockbuster!");

                Blockbuster bb = new Blockbuster();
                Movie m = bb.Checkout();

                Console.Clear();
                Console.WriteLine("You've selected: \n");
                m.PrintInfo();

                WatchingMovie(m);

                Console.Clear();
                userContinue = UserContinue("Would you like to checkout another movie? [Y/N] ");
            }
            Console.WriteLine("\nBye!");

        }
        public static string GetUserInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine().Trim();
            return input;
        }
        public static bool UserContinue(string message)
        {
            Console.WriteLine(message);
            string proceed = Console.ReadLine().Trim().ToLower();

            while (proceed != "n" && proceed != "y")
            {
                Console.WriteLine("Invalid input. Please enter [Y] to continue or [N] to exit.");
                proceed = Console.ReadLine().Trim().ToLower();
            }

            if (proceed == "y")
            {
                return true;
            }
            else
                return false;
        }
        public static void WatchingMovie(Movie m)
        {
            bool watch = true;
            while (watch)
            {
                string input = GetUserInput("\nDo you want to watch the movie? [Y/N]: ");
                if (input == "y")
                {
                    input = GetUserInput("Would you like to watch the whole movie? [Y/N] ");
                    {
                        if(input == "y")
                        {
                            m.PlayWholeMovie();
                            break;
                        }
                        else
                        {
                            m.Play();
                            break;
                        }
                    }
                }
                else if (input == "n")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Write("Invalid input. Do you want to watch the movie? [Y / N]: ");
                    continue;
                }
            }
        }
        public static int ParseInput(string input, Movie m)
        {

            while (true)
            {
                if (Int32.TryParse(input, out int index))
                {
                    if (index < 1 || index > m.Scenes.Count)
                    {
                        input = GetUserInput($"Invalid input. [Select 1 - {m.Scenes.Count}] ");
                        continue;
                    }
                    else
                        return index;
                }
                else
                {
                    input = GetUserInput($"Invalid input. [Select 1 - {m.Scenes.Count}] ");
                }
            }
        }
    }
}
