using System.Collections.Generic;

namespace Blockbuster.Models
{

  class Movie
  {
    public string Title { get; set; }
    public string Plot { get; set; }
    public int ReleaseYear { get; set; }
    public List<Actor> Actors { get; set; }

    public void addActor(Actor actor)
    {
      Actors.Add(actor);
    }
    public Movie(string title, string plot, int year)
    {
      Title = title;
      Plot = plot;
      ReleaseYear = year;
      Actors = new List<Actor>();
    }
  }
}