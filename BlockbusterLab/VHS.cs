using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("\nThe end. You need to rewind the movie.");
                    Rewind();
                    Console.WriteLine($"Do you want to watch {Title} again?");
                    string input = Console.ReadLine().Trim().ToLower();

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
        public void Rewind()
        {
            Console.Write("\nDo you want to rewind? [Y/N] ");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "y")
            {
                Console.WriteLine("Rewinding.....");
                Thread.Sleep(2000);
                Console.WriteLine("....");
                Thread.Sleep(2000);
                Console.WriteLine("Almost halfway there");
                Thread.Sleep(2000);
                Console.WriteLine("wrrrrrrr");
                Thread.Sleep(2000);
                Console.WriteLine("....");
                Thread.Sleep(2000);
                Console.WriteLine("okay okay okay");
                Thread.Sleep(2000);
                Console.WriteLine(":)");
                Thread.Sleep(2000);
                Console.WriteLine("Rewinding complete.");
                Thread.Sleep(2000);
                CurrentTime = 0;
            }
            else
            {
                Console.WriteLine("You've been reported to the FBI.");
            }

        }
    }
}