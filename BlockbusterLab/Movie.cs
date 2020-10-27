using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    abstract class Movie
    {
        //need to change category from string to enum
        public string Title { get; set; }
        public string Category { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }
        public Movie() { }
        public Movie(string Title, string Category, int Runtime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.Runtime = Runtime;
            this.Scenes = Scenes;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Runtime: {Runtime} minutes");
            PrintScenes();
        }
        public virtual void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{i}. {Scenes[i]}");
            }
        }
        public abstract void Play();
    }
}
