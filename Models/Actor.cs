namespace Blockbuster.Models
{

  class Actor
  {
    public string Name { get; private set; }

    public Actor(string name)
    {
      Name = name;
    }
  }
}