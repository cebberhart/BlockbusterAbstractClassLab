using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    //There are 3 things unique to VHS 
    //It's play method which will play the scenes in order 
    //and it will have a property for tracking the current time for the tape 
    //Lastly we'll need a method to rewind the tape, setting current time back to the start 
    class VHS : Movie
    {
        //This is unique to VHS 
        public int CurrentTime { get; set; } = 0; 
        public VHS(string Title, Genre Category, int Runtime, params string[] Scenes) : base(Title, Category, Runtime, Scenes)
        {

        }

        public void Rewind()
        {
            Console.WriteLine($"Rewinding {Title}");
            CurrentTime = 0; 
        }

        //Print the scene at the current time
        //Icrement the current 
        //if the current time is greater the "length" of the movie, rewind it
        public override void Play()
        {
            if (CurrentTime < Scenes.Count)
            {
                string scene = Scenes[CurrentTime];
                CurrentTime++;
                Console.WriteLine(scene);
            }
            else
            {
                Rewind();
            }
        }

        public override void PrintInfo()
        {
            //We want the parents version 
            //but we want also want to print the property unique to VHS 
            base.PrintInfo();
            Console.WriteLine($"Current Time: {CurrentTime}");

        }
    }
}
