using Exercise1Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        #region userInterface
        #region methodForUserToChooseCinema
        static int ChooseCinema()
        {
            Console.WriteLine("Choose a cinema - (enter 1 for Cineplex or 2 for Milenium)");
            Console.WriteLine("1) Cineplex");
            Console.WriteLine("2) Milenium");
            int cinemNum = int.Parse(Console.ReadLine());
            if (cinemNum < 1|| cinemNum>2)
                {
                    throw new Exception("There are only two cinemas");
                }
            return cinemNum;
        }
        #endregion

        #region methodHowToShowMovies
        static int ChooseAllOrByGenre()
        {
            Console.WriteLine("Would you like to see a list of all movies or movies sorted by Genre - (enter 1 for All  or 2 for Genre)");
            Console.WriteLine("1) All Movies");
            Console.WriteLine("2) Genre");
            int movieNum = int.Parse(Console.ReadLine());
                if(movieNum>2)
                {
                    throw new Exception("Wrong");
                }
                else
                    return movieNum;
        }
        #endregion

        #region methodShowAllMovie
        static int AllMovie(List<Movie> ListOfMovies)
        {
            Console.WriteLine("Select movie you want to watch:(enter the number bfore the movie you want to watch)");
            int i = 0;
            foreach(Movie movie in ListOfMovies)
            {
                i++;
                Console.WriteLine($"{i}) {movie.Title}");
            }
            int numberMovie = int.Parse(Console.ReadLine());
            return numberMovie;
        }
        #endregion

        #region methodShowAllGenre
        static int ChooseGenre() 
        {
            Console.WriteLine("Choose movie genre: (enter the number before the genre you want to watch)");
            int j= 0;
            foreach(Genre type in Enum.GetValues(typeof(Genre)))
            {
                j = j + 1;
                Console.WriteLine($"{j}) {type}");
            }
            int GenreNumber = int.Parse(Console.ReadLine());
            if (GenreNumber < 1 || GenreNumber > 5)
            {
                throw new Exception("There are only 5 types of Genre");
            }
            return GenreNumber;
        }
        #endregion

        #region methodReturnTheMovieFromGenreWhichUserChoose
        static Movie movieA(List<Movie>List)
        {
            int i = 1;
            Console.WriteLine("Enter the number of movie you want to watch");
            foreach (Movie movie in List)
            {
                Console.WriteLine($"{i}) {movie.Title}  ");
                i++;
            }
            int num = int.Parse(Console.ReadLine());
            int j = 1;
            foreach (Movie item in List)
            {
                if (j == num)
                    return item;
                else
                    j++;
            }
            return List[-1];
        }
        #endregion

        #region ShowAllMoviesFromGenreUserChoose
        static List<Movie> MovieGenre(int Num,List<Movie>List)
        {
            List<Movie> resultList=new List<Movie>();
            foreach (Movie movie in List)
            {
                switch (Num)
                {
                    case 1:
                        if (movie.Genre == Genre.Comedy)
                        {       
                            resultList.Add(movie);
                        }
                        break;

                    case 2:
                        if (movie.Genre == Genre.Horror)
                        {
                            resultList.Add(movie);
                        }
                        break;

                    case 3:
                       if (movie.Genre == Genre.Action)
                       {
                            resultList.Add(movie);
                       }
                       break;

                    case 4:
                        if (movie.Genre == Genre.Drama)
                        {
                             resultList.Add(movie);
                        }
                        break;

                    case 5:
                         if (movie.Genre == Genre.SciFi)
                         {
                             resultList.Add(movie);
                         }
                        break;        
                }
            }
           return resultList;
        }
        #endregion
        #endregion

        static void Main(string[] args)
        {
            Cinema cinema1=new Cinema(" ");
            Cinema cinema2=new Cinema(" ");
            
            try
            {
                #region allMovies
                Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4, 2.5);
                Movie movie2 = new Movie("American Pie", Genre.Comedy, 4, 2.5);
                Movie movie3 = new Movie("Saw", Genre.Horror, 4, 2.5);
                Movie movie4 = new Movie("The Shining", Genre.Horror, 4, 2.5);
                Movie movie5 = new Movie("Rambo", Genre.Action, 4, 2.5);
                Movie movie6 = new Movie("The Terminator", Genre.Action, 4, 2.5);
                Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4, 2.5);
                Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4, 2.5);
                Movie movie9 = new Movie("Passengers", Genre.SciFi, 4, 2.5);
                Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4, 2.5);
                List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
                Movie movie11 = new Movie("Airplane", Genre.Comedy, 4, 2.5);
                Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4, 2.5);
                Movie movie13 = new Movie("The Ring", Genre.Horror, 4, 2.5);
                Movie movie14 = new Movie("Sinister", Genre.Horror, 4, 2.5);
                Movie movie15 = new Movie("RoboCop", Genre.Action, 4, 2.5);
                Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4, 2.5);
                Movie movie17 = new Movie("The Social Network", Genre.Drama, 4, 2.5);
                Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4, 2.5);
                Movie movie19 = new Movie("Inception", Genre.SciFi, 4, 2.5);
                Movie movie20 = new Movie("Avatar", Genre.SciFi, 4, 2.5);
                List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };
                #endregion

                cinema1 = new Cinema("Cineplex");
                cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
                cinema1.ListOfMovies = MovieSet1;
                cinema2 = new Cinema("Milenium");
                cinema2.Halls = new List<int>() { 1, 2 };
                cinema2.ListOfMovies = MovieSet2;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                int titleNum=0;
                int cinema = ChooseCinema();
                Console.Clear();
                int allOrGenre = ChooseAllOrByGenre();
                Console.Clear();
                //show the user all movies
                if (allOrGenre == 1)
                {
                    //if the user choose Cineplex
                    if (cinema == 1)
                    {
                        // titleNum is number of movie the user choose to watch
                         titleNum = AllMovie(cinema1.ListOfMovies);
                        Console.Clear();
                        cinema1.MoviePlaying(cinema1.ListOfMovies[titleNum - 1]);
                    }

                    //if the user choose Milenium
                    else
                    {
                        titleNum = AllMovie(cinema2.ListOfMovies);
                        Console.Clear();
                        cinema2.MoviePlaying(cinema2.ListOfMovies[titleNum - 1]);
                    }
                }
                //show movie by genre to the user
                else
                {
                   
                    
                    //if the user choose Cineplex
                    if (cinema == 1)
                    {
                        //in genre is the number of genre the user choose
                        int genre = ChooseGenre();
                        //in move is a Movie the user choose to watch after showing to him list of movies of genre he choose
                        Movie movie = movieA(MovieGenre(genre, cinema1.ListOfMovies));
                        Console.Clear();
                        cinema1.MoviePlaying(movie);
                    }
                    //if the user choose Milenium
                    else
                    {
                        int genre = ChooseGenre();
                        Movie movie=movieA(MovieGenre(genre, cinema2.ListOfMovies));
                        Console.Clear();
                        cinema2.MoviePlaying(movie);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            Console.ReadLine();
        }
    }
}
