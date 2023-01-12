//As we can see to the diagram to the right, C# has several built-in data types. You don’t need to memorize all of them, but pay specific attention to these common ones that we’ll use throughout our lessons:
/*
int - whole numbers, like: 1, -56, 948
double - decimal numbers, like: 239.43909, -660.01
char - single characters, like: “a”, “&”, “£”
string - string of characters, like: “dog”, “hello world”
bool - boolean values, like: true or false


// also others (on diagram to the right)
long - whole numbers wider range
float - floating point basic (double more precision and wider range)
decimal - 28sf
DateTime - moments in time
*/

//exercise

using System;

namespace Form
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create Variables
      string name = "Shadow";
      string breed = "Golden Retriever";
      int age = 5;
      double weight = 65.22;
      bool spayed = true;
      // Print variables to the console
      Console.WriteLine(name);
      Console.WriteLine(breed);
      Console.WriteLine(age);
      Console.WriteLine(weight);
      Console.WriteLine(spayed);

    }
  }
}

/*

So, what happens if you forget to specify a data type for your variable?:

randomData = "asdf jskdf";
Console.WriteLine(randomData);
C# will give an error, because it doesn’t want you to have random data being used in your application. The error will look something like this:

The name 'randomData' does not exist in the current context [CS0103:] 
If you use the wrong type definition, like an int when it’s supposed to be a double:

int score = 45.39;
You might see an error like this:

Cannot implicitly convert type 'double' to 'int'. An explicit conversion exists (are you missing a cast?)
We also want to watch out for how we name our variables. It’s good practice to use camelCase styling, and they should only contain underscores, letters, and digits.

string iAmAVariable;
string i'mnot; // this will cause errors
*/

//exercise (debugged)

using System;

namespace BugSquasher
{
  class Program
  {
    static void Main(string[] args)
    {
      double number = 38498.3222;

      string dinosaur = "Barney";

      double locks = 293.000;

      bool is_yes = true;

      string band = "The Low Anthem";

    }
  }
}


/*

Converting Data Types
Because variables have to be strictly typed, there may be some circumstances where we want to change the type of data a variable is storing. This strategy is known as data type conversion.

For example, let’s try converting a double to an integer:

double myDouble = 3.2;

// Round myDouble to the nearest whole number
int myInt = myDouble;
But if you tried to run this code, it wouldn’t work. Sorry.

However, if you did the reverse and turned an int into a double:

int myInt = 3;
// Turn it into a decimal
double MyDouble = myInt;
It’s fine! Why is that?

C# checks to make sure that when we convert data types from one to another that we’re not losing any data, because that could cause problems in our code.

Because of that, there are a couple different ways to do data type conversion:

implicit conversion: happens automatically if no data will be lost in the conversion. That’s why it’s possible to convert an int (which can hold less data) to a double (which can hold more), but not the other way around.
explicit conversion: requires a cast operator to convert a data type into another one. So if we do want to convert a double to an int, we could use the operator (int).
So, if we’re to fix the error in our previous code, we’d rewrite it as follows:

double myDouble = 3.2;

// Round myDouble to the nearest whole number
int myInt = (int)myDouble;
It’s also possible to convert data types using built-in methods. For most data types, there is a Convert.ToX() method, like Convert.ToString() and Convert.ToDouble(). For a full list of Convert class built-in methods, check out the Microsoft Documentation.
*/

//exercise

using System;

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");

      // Turn that answer into an int
      //int faveNumber = (int)Console.ReadLine();//always returns string e.g., "7" not 7
      //int faveNumber = (int)7;// casts int but not with readline above that we need
      //builtin
      int faveNumber = Convert.ToInt32(Console.ReadLine()); //this one!
      Console.Write(faveNumber + " nice number!");
    }
  }
}
/*
review

Review
Congratulations! In this lesson, you learned about how data types and variables work in C#. Topics covered include:

C# built-in data types, including int, double, char, string, and bool
How to create, name, and use variables
Common errors you might encounter
Converting data types from one to another
For more information on using types and declaring variables, check out Microsoft’s C# documentation.

Want to keep track of the different data types? Download this handy cheatsheet.

Now that you know a few things about variables and data types, try writing a program that:

Converts a boolean to a string
Changes a string to a list of chars
Converts a data type we didn’t cover to another data type!
*/

//working with numbers

using System;

namespace BusinessSolution
{
  class Program
  {
    static void Main(string[] args)
    {
      // Calculating Net Income 
      double revenue = 853023.45;
      double expenses = 438374.11;
      double netIncome = revenue - expenses;

      Console.WriteLine(netIncome);

      // Calculating a Break-Even Point
      double fixedCosts = 912849.30;
      double salesPrice = 29.99;
      double variableCostPerUnit = 17.65;

      double breakEvenVolume = fixedCosts / (salesPrice - variableCostPerUnit);
      Console.WriteLine(breakEvenVolume);
    }
  }
}

//exercise

using System;

namespace Numbers
{
  class Program
  {
    static void Main(string[] args)
    {
      // Number of pizza shops
      int pizzaShops = 4332;

      // Number of employees
      int totalEmployees = 86928;

      // Revenue
      double revenue = 390819.28;

      // Log the values to the console:
      Console.WriteLine(pizzaShops);
      Console.WriteLine(totalEmployees);
      Console.WriteLine(revenue);
   	}
  }
}

//ages

using System;

namespace PlanetCalculations
{
  class Program
  {
    static void Main(string[] args)
    {  
      // Your Age
      int userAge = 5;

      // Length of years on Jupiter (in Earth years)
      double jupiterYears = 11.86;

      // Age on Jupiter
      double jupiterAge = userAge / jupiterYears;

      // Time to Jupiter
      double journeyToJupiter = 6.142466;

      // New Age on Earth
      double newEarthAge = userAge + journeyToJupiter;

      // New Age on Jupiter
      double newJupiterAge = newEarthAge / jupiterYears;

      // Log calculations to console
      Console.WriteLine(userAge);
      Console.WriteLine(jupiterAge);
      Console.WriteLine(newEarthAge);
      Console.WriteLine(newJupiterAge);

    }
  }
}
//increment/ decrease
using System;

namespace MakingProgress
{
  class Program
  {
    static void Main(string[] args)
    {
      // declare steps variable
      int steps = 0;

      // Two steps forward 
      steps += 2;

      // One step back 
      steps--;

      // Print result to the console
      Console.WriteLine(steps);
    }
  }
}

//modulo

using System;

namespace ClassTeams
{
  class Program
  {
    static void Main(string[] args)
    {
      // Number of students
      int students = 18;

      // Number of students in a group
      int groupSize = 3;

      // Does groupSize go evenly into students?
      Console.WriteLine(students % groupSize);

    }
  }
}


/*
built ins

There are several built-in methods that we can use to manipulate numerical data and perform more complex mathematical calculations. Here are a few:

Math.Abs()—will find the absolute value of a number. Example: Math.Abs(-5) returns 5.
Math.Sqrt()—will find the square root of a number. Example: Math.Sqrt(16) returns 4.
Math.Floor()—will round the given double or decimal down to the nearest whole number. Example: Math.Floor(8.65) returns 8.
Math.Min()—returns the smaller of two numbers. Example: Math.Min(39, 12) returns 12.

*/

//exercise

using System;

namespace LowestNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Starting variables 
      int numberOne = 12932;
      int numberTwo = -2828472;

      // Use built-in methods and save to variable 
      double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

      // Use built-in methods and save to variable 
      double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

      // Print the lowest number
      Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));

    }
  }
}

// 113

//some functions
//Math.Pow()
//Math.Max()
//Math.Ceiling()

using System;

namespace DocumentationHunt
{
  class Program
  {
    static void Main(string[] args)
    {

      double numberOne = 6.5;
      double numberTwo = 4;

      // Raise numberOne to the numberTwo power
      Console.WriteLine(Math.Pow(numberOne, numberTwo));

      // Round numberOne up
      Console.WriteLine(Math.Ceiling(numberOne));

      // Find the larger number between numberOne and numberTwo
      Console.WriteLine(Math.Max(numberOne, numberTwo));

    }
  }
}

/*
WORKING WITH NUMBERS
Review
Great job! You just learned about numerical data types and how to work with numerical data in a few different ways:

Use arithmetic operators to write expressions.
Combine operators together to write more concise programs.
Use the modulo operator (%) to find remainders.
Use built-in methods to do more complex math.
Use documentation to look new things up.
Now that you know a few ways of working with numbers, try writing some small programs that use what you learned in this lesson. Some ideas:

Write a program that calculates compound interest
Write a program that finds your age in dog years
What other program ideas can you come up with?
*/

//working with text

string withoutSlash = "Ifemelu said, "Hello!"";

string withSlash = "Ifemelu said, \"Hello!\"";
//We can use escape character sequences to create a newline. That means that when we print the string to the console, it will print that line below the rest. If printed on its own, it will create an empty line. To create a newline, use the character combination \n.

string newLine = "Ifemelu walked \n to the park.";

using System;

namespace PrideAndPrejudice
{
  class Program
  {
    static void Main(string[] args)
    {
      // First string variable
      string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";
      // Second string variable
      string firstSpeech ="\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

      // Print variable and newline
      Console.WriteLine(firstSentence);
      Console.WriteLine("\n");//1 writeline with + works
      Console.WriteLine(firstSpeech);
    }
  }
}

//story

using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "Light flickered through the blinds,";
      string middle = " from the dying street lamp.";
      string end = " Enough, he jumped up, time to party.\n";
      // Concatenate the string and the variables
      string story = beginning + middle + end;
      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}


//String Interpolation
/*While string concatenation is easy to read, it can get annoying to write. Another option is string interpolation. String interpolation was introduced in C# 6 and it enables us to insert our variable values and expressions in the middle of a string, without having to worry about spaces and punctuation.

string yourFaveMusician = "David Bowie";
string myFaveMusician = "Solange";

Console.WriteLine($"Your favorite musician is {yourFaveMusician} and mine is {myFaveMusician}.")
Notice how we just have one string, which we append with the dollar sign symbol $. Make sure there isn’t a space in between the $ and the starting quotation mark ". Whenever we need to insert a variable, we surround it with braces {}.For more on string interpolation, check out Microsoft’s documentation.
*/

//exercise

using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "Once upon a time,";
      string middle = "The kid climbed a tree";
      string end = "Everyone lived happily ever after.";

      // Interpolate the string and the variables
      string story = $"{beginning} {middle} {end}\n";

      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}

//string interpolation
// use $"{variable1} {variable2}"
//IndexOf and Length

using System;

namespace PasswordCheck
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create password
      string password = "a92301j2add";

      // Get password length
      int passwordLength = password.Length;

      // Check if password uses symbol
      int passwordCheck = password.IndexOf("!");

      // Print results
      Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");

    }
  }
}


//IndexOf Substring

using System;

namespace NameGrab
{
  class Program
  {
    static void Main(string[] args)
    {
      // User Name
      string name = "Farhad Hesam Abbasi";

      // Get first letter
      int first = name.IndexOf("F");
      char firstLetter = name[first];

      // Get last name
      int last = name.IndexOf("A");
      string lastName = name.Substring(last);

      // Print results
      Console.WriteLine($"{firstLetter}. {lastName}");

    }
  }
}

//ToLower ToUpper 

using System;

namespace MovieScript
{
  class Program
  {
    static void Main(string[] args)
    {
      // Script line
      string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

      // Get camera directions
      int charPosition = script.IndexOf("Close");
      int length = "Close on".Length;
      string cameraDirections = script.Substring(charPosition, length);//note length arg

      // Get scene description
      charPosition = script.IndexOf("a portrait");
      string sceneDescription = script.Substring(charPosition);

      // Make camera directions uppercase
      cameraDirections = cameraDirections.ToUpper();

      // Make scene description lowercase
      sceneDescription = sceneDescription.ToLower();

      // Print results
      Console.WriteLine(cameraDirections + " " + sceneDescription);
    }
  }
}

//review
/*
Review
Great job! You just learned about how to work with textual data in a few different ways:

How to save char and string values to a variable.
Use the addition symbol (+) to concatenate strings.
Interpolate strings for easier string construction.
Find information about a string using .Length and .IndexOf().
Grab characters and parts of strings using bracket notation and .Substring().
Use built-in methods such as .ToUpper() and .ToLower() to manipulate strings.
Now use what you’ve learned to write a short program! Some ideas:

Write a program that randomly converts part of a text to uppercase and lowercase to look like randomcase.
Write a program that takes in a series of random words to construct an automated poem, in the style of e.e. cummings.
*/
//MoneyMaker

using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Amount to convert?");
      double amount = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine($"{amount} cents is equal to...");
      int gold = 10;
      int silver = 5;
      double goldCoins = Math.Floor(amount / gold);
      double remainder = amount % (goldCoins * gold);
      double silverCoins = Math.Floor(remainder / silver);
      Console.WriteLine(silverCoins);
      remainder = remainder % (silverCoins * silver);
      Console.WriteLine($"Gold coins: {goldCoins}\nSilver Coins: {silverCoins}\nBronze Coins: {remainder}");

    }
  }
}
//bool
using System;

namespace ComparisonOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      double timeToDinner = 4;
      double distance = 95;
      double rate = 30;
      double tripDuration = distance / rate;
      bool answer = tripDuration <= timeToDinner;
      Console.WriteLine(answer);
    }
  }
}

// && || ! work same as usual && only TRUE and TRUE = TRUE || only FALSE and FALSE = FALSE, not TRUE = FALSE, FALSE = TRUE;

//exercise

using System;

namespace LogicalOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      bool beach = true;
      bool hiking = false;
      bool city = true;

      bool yourNeeds = beach && city;
      bool friendNeeds = beach || hiking;
      bool tripDecision = yourNeeds && friendNeeds;
      Console.WriteLine(tripDecision);
    }
  }
}


/*
UNDERSTANDING LOGIC IN C#
Review
Great job! You just learned about logic and boolean values, including:

How to define variables with a bool data type
How to use comparison operators with different data types to return boolean values
What a truth table is and how to read one
How to use logical operators to compare boolean values and expressions
Now that you know a few things about boolean data types, comparison operators and logical operators, try writing a program that:

Checks a password if it has uppercase letters and doesn’t include symbols
Tells you if you should watch a TV show if it has your favorite actor or is your favorite drama

      BOOL TYPE: bool variableName
      COMPARISON OPERATORS: ==, <, >, <=, >=
      LOGICAL OPERATORS: &&, ||, !

*/

//conditional statements
/*
We’ll look at a couple of different structures that use Boolean logic to control the flow of our programs, including:

If statements
If…Else… statements
Else if statements
Switch statements
Ternary Operators
*/
//exercise
using System;

namespace IfStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      int socks = 6;//3 or less to print
      if (socks <= 3) {
        Console.WriteLine("Time to do laundry!");
      }

    }
  }
}

//exercise

using System;

namespace IfElseStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      int people = 12;
      string weather = "bad";
      if (people <= 10 && weather == "nice") {
        Console.WriteLine("SaladMart");
      } else {
        Console.WriteLine("Soup N Sandwich");
      }

    }
  }
}

//exercise

using System;

namespace ElseIfStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      int guests = 0;
      if (guests >= 4) {
        Console.WriteLine("Catan");
      } else if (guests >= 1) {
        Console.WriteLine("Innovation");
      } else {
        Console.WriteLine("Solitaire");
      }
    }
  }
}

//exercise

using System;

namespace SwitchStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("We have amazing library of 5 films, from 5 genres Drama, Comedy, Adventure, Horror and Science Fiction please pick a genre and enjoy (I'm sure you'll be disappointed).");
      string genre = Console.ReadLine();
      switch (genre) {
        case "Drama":
          Console.WriteLine("Citizen Kane");
          break;
        case "Comedy":
          Console.WriteLine("Duck Soup");
          break;
        case "Adventure":
          Console.WriteLine("King Kong");
          break;
        case "Horror":
          Console.WriteLine("Psycho");
          break;
        case "Science Fiction":
          Console.WriteLine("2001: A Space Odyssey");
          break;
        default:
          Console.WriteLine("No movie found");
          break;
      }

    }
  }
}

//ternary exercise

using System;

namespace TernaryOperator
{
  class Program
  {
    static void Main(string[] args)
    {
      int pepperLength = 4;
      string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";
      Console.WriteLine(message);
    }
  }
}

/*
CONDITIONAL STATEMENTS
Review
Great job! You just learned about how to create programs that use control flow. Here’s a few of the things we covered:

Using if, else if, and else keywords to write conditional statements
Writing switch statements for situations where they are many conditions
Using ternary operators for shorter conditional statements
Now that you know a few things about control flow, try writing a program that:

Has a user guess a random number between 1-10 and lets them know if they got it correct, are too low, or are too high
Asks users to select their favorite fast food and tells them what type of cat they are (or basically, any kind of Buzzfeed style quiz)
Checks if it’s your birthday. If it is, it will print out a celebratory ASCII banner and if not, it will tell you how many days until your birthday.
*/
