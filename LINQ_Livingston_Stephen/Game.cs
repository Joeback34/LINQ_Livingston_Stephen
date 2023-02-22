using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Livingston_Stephen
{
    class Game
    {
       public string Title { get; } // properties with getters that are assigned respective parameters.
       public char ESRB { get; }
       public string Genre { get; }

        public Game(string titleparam, char esrbparam, string genreparam) // constructor that assigns parameters to the previous properties.
        {
            Title = titleparam;
            ESRB = esrbparam;
            Genre = genreparam;

            
        }
        
    }
}
