//Profile.cs
using System;

namespace DatingProfile
{ 
  class Profile
  {
    //all members in class default private but ... explicit clearer here
    //FIELDS
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;
    
    //CONSTRUCTORS
    public Profile (string name, int age, string city, string country, string pronouns = "they/them")
    {
      //haven't capitalized
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      //string[] hobbies = {};
    }
    //PROPERTIES

    //METHODS
    public string ViewProfile()
    {
      string details = $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}\nHobbies:\n";
      foreach (string hobby in this.hobbies) {
        details = details + $"{hobby}\n";
      }
      return details;
    }

    public void SetHobbies(string[] hobbies) 
    {
      this.hobbies = hobbies;
    }
  }
}
//Program.cs
using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
      sam.SetHobbies(new string[] {"listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns"});
      Console.WriteLine(sam.ViewProfile());
      
    }
  }
}

