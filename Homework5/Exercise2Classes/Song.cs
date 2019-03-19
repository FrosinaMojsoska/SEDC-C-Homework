using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Classes
{
    public class Song
    {
        //properties
        public string Title { get; set; }
        public int Length { get; set; }
        public Genre Genre { get; set; }

        //constructor
        public Song( string title,int length,Genre genre)
        {
            Title = title;
            Length = length;
            Genre = genre;
        }


    }
}
