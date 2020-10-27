using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;
        public VHS(string Name, string Category, int Runtime, List<string> Scenes)
            :base(Name, Category, Runtime, Scenes){ }
        public override void Play()
        {
            if (CurrentTime < Scenes.Count) 
            {
                string scene = Scenes[CurrentTime];
                Console.WriteLine($"{CurrentTime} : {scene}");
                CurrentTime++;
            }
            else
            {
                Console.WriteLine("The end. You need to rewind the movie.");
            }
        }
        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}