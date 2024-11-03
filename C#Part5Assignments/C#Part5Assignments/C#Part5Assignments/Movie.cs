using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignments
{
    public class Movie
    {
        //properties for movie title and movie year
        public string Title { get; set; }
        public int Year { get; set; }


        //constructor
        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }

        //method to display 
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Year: {Year}");
        }
    }

    public class MovieLibrary
    {
        public Movie[] movies; //arrayto store Movie objects
        public int movieCount;

        //constrcutor
        public MovieLibrary(int capacity)
        {
            movies = new Movie[capacity]; //initialzes the array with given capacity
            movieCount = 0; //no movies initially
        }

        //method to add a new movie
        public void AddMovie(Movie movie)
        {
            //check if is space there to add a new movie
            if (movieCount < movies.Length)
            {
                movies[movieCount] = movie; //Add the movie to the array
                movieCount++;
                Console.WriteLine($"Movie: {movie.Title} added");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Movie Library Full");
            }
        }

        //method to display information of all movies
        public void DisplayMovies()
        {
            for (int i = 0; i < movieCount; i++)
            {
                movies[i].DisplayInfo();
            }
        }
    }
}
