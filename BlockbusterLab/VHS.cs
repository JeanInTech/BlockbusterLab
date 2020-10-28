using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;
        public VHS(string Name, Genre Category, int Runtime, List<string> Scenes)
            :base(Name, Category, Runtime, Scenes){ }
        public override void Play()
        {
            Console.Clear();
            bool keepWatching = true;
            while (keepWatching)
            {
                if (CurrentTime < Scenes.Count)
                {
                    string scene = Scenes[CurrentTime];
                    Console.WriteLine($"{CurrentTime} : {scene}");
                    CurrentTime++;
                    Console.Write("Do you want to keep watching? [Y/N] ");
                    string input = Console.ReadLine().Trim().ToLower();
                    if (input == "y")
                    {
                        continue;
                    }
                    else
                    {
                        keepWatching = false;
                    }
                }
                else
                {
                    Console.WriteLine("\nThe end. You need to rewind the movie.");
                    Console.Write("Do you want to rewind? [Y/N] ");
                    string input = Console.ReadLine().Trim().ToLower();
                    if (input == "y")
                    {
                        Console.Clear();
                        Rewind();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        public override void PlayWholeMovie()
        {
            Console.Clear();
            while (true)
            {
                if (CurrentTime < Scenes.Count)
                {
                    string scene = Scenes[CurrentTime];
                    Console.WriteLine($"{CurrentTime} : {scene}");
                    CurrentTime++;
                }
                else
                {
                    Console.WriteLine("\nThe end. You need to rewind the movie.");
                    Console.Write("\nDo you want to rewind? [Y/N] ");
                    string input = Console.ReadLine().Trim().ToLower();
                    if (input == "y")
                    {
                        Console.Clear();
                        Rewind();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}