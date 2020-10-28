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
            Console.WriteLine($"What scene would you like to watch?");
            PrintScenes();
            int input = Int32.Parse(Console.ReadLine().Trim());
            Console.WriteLine($"Scene {input}: {Scenes[input]}");
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
