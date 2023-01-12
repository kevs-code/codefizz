using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      Console.Write("Type YES or NO: ");//no line return;
      string noiseChoice = Console.ReadLine();
      noiseChoice = noiseChoice.ToUpper();
      if (noiseChoice == "NO") {
        Console.WriteLine("Not much of an adventure if we don't leave our room!\nTHE END.");
      } else if (noiseChoice == "YES") {
        Console.Write("You walk into the hallway and see a light coming from under a door down the hall.\nYou walk towards it. Do you open it or knock?\nType OPEN or KNOCK:");
        string doorChoice = Console.ReadLine();
        doorChoice = doorChoice.ToUpper();
        if (doorChoice == "KNOCK") {
          Console.Write("A voice behind the door speaks. It says, \"Answer this riddle: \"Poor people have it. Rich people need it. If you eat it you die. What is it?\"\nType your answer: ");
          string riddleAnswer = Console.ReadLine();
          riddleAnswer = riddleAnswer.ToUpper();
          if (riddleAnswer == "NOTHING") {
            Console.Write("The door opens and NOTHING is there.\nYou turn off the light and run back to your room and lock the door.\nTHE END.\n");
          } else {
            Console.Write("You answered incorrectly. The door doesn't open.\nTHE END.\n");
          }
        } else if (doorChoice == "OPEN") {
          Console.Write("The door is locked! See if one of your three keys will open it.\nEnter a number (1-3): ");
          string keyChoice = Console.ReadLine();
          switch (keyChoice) {
            case "1":
              Console.Write("You choose the first key. Lucky choice!\nThe door opens and NOTHING is there. Strange...\nTHE END.\n");
              break;
            case "2":
              Console.Write("You choose the second key. The door doesn't open.\nTHE END.\n");
              break;
            case "3":
              Console.Write("You choose the third key. The door doesn't open.\nTHE END.\n");
              break;
          }
        }
      } // no else for inputs as practicing using nested if then else switch! 
    }
  }
}




