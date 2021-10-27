using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blockbuster
{
    //I mentioned the 1 class 1 file rule. 
    //Enums are kinda an exception 
    //If a class uses the enum heavily oftentimes it will be lumped into that
    abstract class Movie
    {
        public string Title { get; set; }
        
        //We'll put an enum here later 
        public Genre Category { get; set; }
        public int Runtime { get; set; }

        //1) Make sure with lists you have using system.collections.generic 
        //2) You must create/initialize before doing anything else
        public List<string> Scenes { get; set; } = new List<string>();

        //So what does the params keyword do? 
        //Params allows us to fill in our method calls with as many inputs as we wish. 
        //Params must be set on the last parameter in your method
        //Params is useable on any method
        //Params is useable only once per method 
        //For params you may feed in comma separated values or an array 
        //Handy for when you don't know the number of inputs you need 
        //or for filling in a list or array. 

        //This constructor you may pass in scenes as an array or comma separated inputs 
        public Movie(string Title, Genre Category, int Runtime, params string[] Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.Runtime = Runtime;
            this.Scenes = Scenes.ToList();
        }

        //Overloading is the same method, but the set of parameter is different 
        //Overloading is used to create alternate version of the same method 
        //In this course, we won't use overloading often, it mostly shows up with built in methods
        //For this constructor you MUST make the list of scenes outside the object and pass them in 
        public Movie(string Title, Genre Category, int Runtime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.Runtime = Runtime;
            this.Scenes = Scenes;
        }

        //Print everything save for the scenes 
        //Virtual methods and properties mean that the child has the option 
        //to override them. BUT if the child does not override the method/property 
        //they are passed the method/property as is 
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Run Time: {Runtime}");
        }

        //in toString you want to place all the info into a single string 
        //and then return it 
        //ToString lets me print the object directly 
        //Otherwise it fills the same job as print info, they are mostly interchangeable
        public override string ToString()
        {
            string output = $"Title: {Title}\n";
            output += $"Category: {Category}\n";
            output += $"Run Time: {Runtime}\n";
            return output;
        }

        //Print scenes does not need to change 
        //All children should be good with it as is 
        public void PrintScenes()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{i} : {Scenes[i]}");
            }
        }

        public abstract void Play();
      
    };
}
