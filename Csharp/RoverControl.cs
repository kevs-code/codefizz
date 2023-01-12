//Program.cs

using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957); 
  		Rover[] rovers = {lunokhod, apollo, sojourner};
      DirectAll(rovers);
      Object[] probesT = {sputnik, lunokhod, apollo, sojourner};
      foreach (Object probe in probesT)
      {
        Console.WriteLine($"Tracking a {probe.GetType()}...");
      }
      IDirectable[] probes = {sputnik, lunokhod, apollo, sojourner};
      DirectAll(probes);
    }

    static void DirectAll(IDirectable[] probes) {
      foreach (IDirectable probe in probes)
      {
        Console.WriteLine(probe.GetInfo());
        Console.WriteLine(probe.Explore());
        Console.WriteLine(probe.Collect());
      }
    }
  }
}

//IDirectable

namespace RoverControlCenter
{
  interface IDirectable
  {
    string GetInfo();
    string Explore();
    string Collect();
  }
}

//Rover.cs

namespace RoverControlCenter
{
  class Rover : IDirectable
  {
    public string Alias
    { get; private set; }

    public int YearLanded
    { get; private set; }

    public Rover(string alias, int yearLanded)
    {
      Alias = alias;
      YearLanded = yearLanded;
    }

    public string GetInfo()
    {
      return $"Alias: {Alias}, YearLanded: {YearLanded}";
    }

    public virtual string Explore()
    {
      return "Rover is exploring the surface!";
    }

    public virtual string Collect()
    {
      return "Rover is collecting rocks!";
    }
  }
}

//Satellite.cs

namespace RoverControlCenter
{
  class Satellite : IDirectable
  {
    public string Alias
    { get; private set; }

    public int YearLaunched
    { get; private set; }

    public Satellite(string alias, int yearLaunched)
    {
      Alias = alias;
      YearLaunched = yearLaunched;
    }

    public string GetInfo()
    {
      return $"Alias: {Alias}, YearLaunched: {YearLaunched}";
    }

    public virtual string Explore()
    {
      return "Satellite is exploring the far reaches of space!";
    }

    public virtual string Collect()
    {
      return "Satellite is collecting photographic evidence!";
    }
  }
}
