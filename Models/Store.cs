using System.Collections.Generic;

namespace Blockbuster.Models
{

  class Store
  {
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Movie> AvailableMovies { get; set; }
    public List<Movie> RentedMovies { get; set; }

    public void addMovie(Movie movieToAdd)
    {
      AvailableMovies.Add(movieToAdd);
    }
    public void PrintAvailableMovies()
    {
      System.Console.Clear();
      System.Console.WriteLine("Movies available to rent:");
      foreach (var movie in AvailableMovies)
      {
        System.Console.WriteLine();
        System.Console.WriteLine($"{movie.Title} -- {movie.ReleaseYear}");
        System.Console.WriteLine($"{movie.Plot}");
        foreach (var actor in movie.Actors)
        {
          System.Console.Write($"{actor.Name}     ");
        }
        System.Console.WriteLine();
      }
      System.Console.Write("Enter the movie you'd like to rent. ");
    }

    public void PrintRentedMovies()
    {
      System.Console.Clear();
      System.Console.WriteLine("Movies available to return:");
      foreach (var movie in RentedMovies)
      {
        System.Console.WriteLine();
        System.Console.WriteLine($"{movie.Title} -- {movie.ReleaseYear}");
        System.Console.WriteLine($"{movie.Plot}");
        foreach (var actor in movie.Actors)
        {
          System.Console.Write($"{actor.Name}   ");
        }
        System.Console.WriteLine();
      }
      System.Console.Write("Enter the movie you'd like to return. ");
    }

    public void RentMovie(string movieTitle)
    {
      Movie movie = ValidateMovie(movieTitle, AvailableMovies);
      if (movie != null)
      {
        AvailableMovies.Remove(movie);
        RentedMovies.Add(movie);
        System.Console.WriteLine($"Thank you. Enjoy {movie.Title}");
      }

      else
      {
        System.Console.WriteLine("Not a valid title. Please enter a movie to rent. ");
      }
    }

    public void ReturnMovie(string movieTitle)
    {

    }

    public Movie ValidateMovie(string movieTitle, List<Movie> movies)
    {
      foreach (var m in movies)
      {
        if (m.Title.ToLower() == movieTitle.ToLower())
        {
          return m;
        }
      }
      return null;
    }

    public Store(string name, string address)
    {
      Name = name;
      Address = address;
      AvailableMovies = new List<Movie>();
      RentedMovies = new List<Movie>();
    }
  }
}