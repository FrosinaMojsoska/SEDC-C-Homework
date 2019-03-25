using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1Classes
{
    public class Movie
    {
        //properties
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice  { get; set; }

        //constructor
        public Movie(string title,Genre genre,int rating,double ticketPrice)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = 5 * ticketPrice;

            if(Rating<0 || Rating>6)
            {
                throw new Exception("Rating must be between[1, 5]");
            }
        }

    }
}
