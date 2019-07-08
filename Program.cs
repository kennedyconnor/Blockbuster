using System;
using Blockbuster.Models;

namespace Blockbuster
{
  class Program
  {
    static void Main(string[] args)
    {
      #region Create Data

      Store blockbuster = new Store("Blockbuster", "1000 Ya not a drawl Lane");
      Actor arnold = new Actor("Arnold Swchwarzenegger");
      Actor russell = new Actor("Russell Crowe");
      Actor paul = new Actor("Paul Bettany");
      Actor joaquin = new Actor("Joaquin Phoenix");
      Actor psh = new Actor("Phillip Seymour Hoffman");
      Movie master = new Movie("The Master", "Blah blah scientology with good acting, it's actually about how and by what people are controlled in life.", 2012);
      Movie conan = new Movie("Conan The Barbarian", "Orphaned barbarian seeks revenge on the man who killed his people and stole his father's sword, the enigmatic Thulsa Doom.", 1982);
      Movie mc = new Movie("Master and Commander: Far Side of The World", "British warship tracks elusive French vessel across the Atlantic.", 2003);

      mc.addActor(russell);
      mc.addActor(paul);
      conan.addActor(arnold);
      master.addActor(joaquin);
      master.addActor(psh);
      blockbuster.addMovie(mc);
      blockbuster.addMovie(conan);
      blockbuster.addMovie(master);

      #endregion
      Console.Clear();
      Console.WriteLine("Welcome to Blockbuster, B!");

      bool inStore = true;
      string menu = "rent";

      while (inStore)
      {
        System.Console.Write("Enter anything to see all available movies. Enter 'return' to return a film. ");

        string selection = Console.ReadLine();
        if (selection == "return")
        {
          menu = "return";
        }

        switch (menu)
        {
          case "rent":
            blockbuster.PrintAvailableMovies();
            break;
          case "return":
            blockbuster.PrintRentedMovies();
            break;
        }

        //assign the movie to rent/return
        string m = Console.ReadLine();

        switch (menu)
        {
          case "rent":
            blockbuster.RentMovie(m);
            break;
          case "return":
            blockbuster.ReturnMovie(m);
            break;
        }

      }
    }
  }
}
