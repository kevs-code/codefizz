using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program interpolates a paragraph text with word variables
      Author: monkey types
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Welcome to MadLib, let's write a story ...\n");

      // Give the Mad Lib a title:
      string title = "Mad Lib";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.WriteLine("Give are main character a name please and press enter.");
      String name = Console.ReadLine();
      Console.WriteLine("Next, we need 3 adjectives, please enter one at a time and press enter.  Reminder an adjective is a word that describes a noun, like a color (‘blue’), or feeling (‘silly’), texture (‘soft’).");
      String adj1 = Console.ReadLine();
      String adj2 = Console.ReadLine();
      String adj3 = Console.ReadLine();
      Console.WriteLine("Great!, now we need 3 more adjectives, no just kidding! To progress the story we need a verb and then two nouns please.");
      String verb = Console.ReadLine();
      String noun1 = Console.ReadLine();
      String noun2 = Console.ReadLine();
      Console.WriteLine("Okay, if your still with me (why), finally I will need as single inputs an animal, a food, a fruit, a superhero, a country, a dessert, a year and we're done.  I hope you enjoy the story after all this work, thank you for your 14 inputs and this colossal waste of your time have fun\n");
      String animal = Console.ReadLine();
      String food = Console.ReadLine();
      String fruit = Console.ReadLine();
      String superhero = Console.ReadLine();
      String country = Console.ReadLine();
      String dessert = Console.ReadLine();
      String year = Console.ReadLine();
      // The template for the story:

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}

