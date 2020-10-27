using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BlockbusterLab
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public Blockbuster()
        {
            List<string> scenes1 = new List<string>
            {
                "Frollo adopts Quasimodo", 
                "Festival of Fools",
                "Frollo falls to his death"
            };
            VHS v1 = new VHS("The Hunchback of Notre Dame", "Comedy", 91, scenes1);
            Movies.Add(v1);

            List<string> scenes2 = new List<string> 
            {
                "Ogre stuff",
                "Dragon chase scene",
                "Donkey talks a lot"

            };
            VHS v2 = new VHS("Shrek", "Comedy", 90, scenes2);
            Movies.Add(v2);

            List<string> scenes3 = new List<string>
            { 
                "Brainard creates sentient gloop, christened Flubber", 
                "Flubber shenanigans",
                "Brainard and Sara save Flubber"
            };
            VHS v3 = new VHS("Flubber", "Comedy", 93, scenes3);
            Movies.Add(v3);

            List<string> scenes4 = new List<string> 
            {
                "Bedridden Roy meets young Alexandria",
                "Roy promises to Alexandria the end of a story for a favor",
                "Roy finishes the story"
            };
            DVD d1 = new DVD("The Fall", "Fantasy", 117, scenes4);
            Movies.Add(d1);

            List<string> scenes5 = new List<string>
            {
                "Ofelia meets a faun, who gives her 3 tasks",
                "Ofelia completes the first two tasks and is asked to bring her brother",
                "Ofelia refuses to hurt her brother for the final ritual"
            };
            DVD d2 = new DVD("Pan's Labyrinth", "Horror", 119, scenes5);
            Movies.Add(d2);

            List<string> scenes6 = new List<string>
            {
                "Tim meets an amnesiac Pikachu",
                "Tim and Pikachu investigate Harry's disappearance",
                "Mewtwo is freed from being controlled by bad guy"
            };
            DVD d3 = new DVD("Detective Pikachu", "Mystery", 104, scenes6);
            Movies.Add(d3);
        }
        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                Console.WriteLine($"{i}: {m.Title}");
            }
        }
        public Movie Checkout()
        {
            Console.WriteLine($"Please select a movie from the following list [Enter 0 - {Movies.Count - 1}]: ");
            PrintMovies();
            string input = Console.ReadLine().Trim();
            int index = int.Parse(input);

            Movie output = Movies[index];
            return output;
        }
    }
}
