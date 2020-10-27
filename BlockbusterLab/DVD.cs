using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD(string Name, string Category, int Runtime, List<string> Scenes)
            :base(Name, Category, Runtime, Scenes){ }
        public override void Play()
        {
            Console.WriteLine($"What scene would you like to watch?");
            PrintScenes();
            int input = Int32.Parse(Console.ReadLine().Trim());
            Console.WriteLine($"Scene {input}: {Scenes[input]}");
        }
    }
}
