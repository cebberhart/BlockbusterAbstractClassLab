using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blockbuster
{

    //This stores and allows us to checkout our movies 
    //This is what I like to call a runner class since its main job 
    //is to manage and delegate to other classes
    class Blockbuster
    {
        List<Movie> Movies { get; set; } = new List<Movie>();

        //We'll use the constructor to fill our movie list
        public Blockbuster()
        {
            
            Movies.Add(new DVD("28 Days Later", Genre.Horror, 130, "Infected attack", "He Wakes up from a coma"));
            Movies.Add(new DVD("Forest Gump", Genre.Drama, 150, "Running Scene", "Life is like a box of chocolates"));
            Movies.Add(new DVD("Dawn of the Dead", Genre.Horror, 135, "Fortifying the mall", "Mall is overrun by bandits", "Running to the helicopter"));


            Movies.Add(new VHS("Alladin", Genre.Action, 90, "Opening Song", "Alladin steals bread for the kids", "A whole new world"));
            Movies.Add(new VHS("Billy Madison", Genre.Comedy, 110, "Billy goes back to school", "Field trip scene", "Academic Decathalon"));
            Movies.Add(new VHS("Apacolypse Now", Genre.Drama, 180, "Never get off the boat", "Beach Scene", "Marlin Brando"));

        }

        public Movie GetMovie(int index)
        {
            Movie m = Movies[index];
            //m.Rewind will never work since it does not exist in the movie class, only in VHS
            //m.Rewind();

            //while (true)
            //{
            //    //When I call m.Play C# see that m is a VHS and tries to find Play in VHS first 
            //    //Then if Play is not found it goes up to Movie 
            //    m.Play();
            //}

            return m;
        }

        public List<Movie> SearchByGenres(params Genre[] searchTypes)
        {
            //Make an output list 
            //Loop through movies 
            //if movie type == searchType, add it to output 
            //return output

            List<Movie> outputs = new List<Movie>();
            for(int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];

                //This is for single type search
                //if(m.Category == searchType)

                //We need to be using system.Linq to use contains 
                if(searchTypes.Contains(m.Category))
                {
                    outputs.Add(m);
                }
            }

            return outputs;
        }
      
    }
}
