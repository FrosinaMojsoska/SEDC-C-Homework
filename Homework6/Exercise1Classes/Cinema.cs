using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1Classes
{
    public class Cinema
    {
        //properies
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }

        //constructor
        public Cinema(string name)
        {
            Name = name;
        }

        //method
        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"Whtching {movie.Title}");
        }
    }
}
