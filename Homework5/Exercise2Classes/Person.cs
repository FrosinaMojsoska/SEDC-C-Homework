using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Classes
{
    public class Person
    {
        //properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        //constructor 
        public Person(string first,string last,int age,Genre genre)
        {
            FirstName = first;
            LastName = last;
            Age = age;
            FavoriteMusicType =genre;
        }
        //method
        public void GetFavSongs()
        {
            if(FavoriteSongs.Count>0)
            {
                foreach (Song song in FavoriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
            else
            {
                Console.WriteLine("This person hates music!");
            }
        }

    }

}