using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BlockbusterLab
{
    abstract class Movie
    {
        //need to change category from string to enum
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }
        public Movie() { }
        public Movie(string Title, Genre Category, int Runtime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.Runtime = Runtime;
            this.Scenes = Scenes;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"\tTitle: {Title}");
            Console.WriteLine($"\tCategory: {Category}");
            Console.WriteLine($"\tRuntime: {Runtime} minutes");
        }
        public virtual void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{i}. {Scenes[i]}");
                Thread.Sleep(2000);
            }
        }
        public abstract void Play();
        public abstract void PlayWholeMovie();
    }
}
