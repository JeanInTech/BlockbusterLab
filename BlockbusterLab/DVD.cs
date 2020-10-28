using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD(string Name, Genre Category, int Runtime, List<string> Scenes)
            :base(Name, Category, Runtime, Scenes){ }
        public override void Play()
        {
            Console.Clear();
            bool keepWatching = true;
            while (keepWatching)
            {
                Console.WriteLine($"What scene would you like to watch? [0 - {Scenes.Count - 1}]");
                if (Int32.TryParse(Console.ReadLine().Trim(), out int input))
                {
                    try
                    {
                        Console.WriteLine($"Scene {input}: {Scenes[input]}");

                        Console.Write("Do you want to keep watching? [Y/N] ");
                        string userContinue = Console.ReadLine().Trim().ToLower();
                        if (userContinue == "y")
                        {
                            continue;
                        }
                        else
                        {
                            keepWatching = false;
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Invalid input, try again");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                    continue;
                }
            }
        }

        public override void PlayWholeMovie()
        {
            Console.Clear();
            bool keepWatching = true;
            while (keepWatching)
            {
                PrintScenes();
                Console.WriteLine("\nDo you want to watch it again? [Y/N] ");
                string input = Console.ReadLine().ToLower().Trim();
                if (input == "y")
                {
                    Console.Clear();
                    continue;
                }
                else
                    break;
            }
        }
    }
}
