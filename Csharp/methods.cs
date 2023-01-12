using System;

namespace CallAMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      string msg = "Yabba dabba doo!";
      Math.Min(2, 3);
      Console.WriteLine(msg);
      Console.WriteLine(msg.Substring(0, 1));
    }
  }
}
//
using System;

namespace CaptureOutput
{
  class Program
  {
    static void Main(string[] args)
    {
      string designer = "Anders Hejlsberg";
      int indexOfSpace = designer.IndexOf(" ");
      string secondName = designer.Substring(indexOfSpace+1);
      Console.WriteLine(secondName);
    }
  }
}
//
using System;

namespace DefineAMethod
{
  class Program
  {
    static void VisitPlanets()
    {
      Console.WriteLine("Using are ship of the imagination we visit many new planets... Thus perhaps ostensibly giving new facets to our understanding of the phrase pale blue dot, or even the phrase there is no place like home.");
    }
    static void Main(string[] args)
    {
      VisitPlanets();
    }
  }
}
//
using System;

namespace DefineParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(0);
      VisitPlanets(2);
      VisitPlanets(7);
    }
    
    static void VisitPlanets(int numberOfPlanets)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }
  }
}
//
using System;

namespace OptionalParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(3);
      VisitPlanets(4);
      VisitPlanets(5);
      VisitPlanets();
    }
    
    static void VisitPlanets(int numberOfPlanets = 0)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }
  }
}
//new specifying parameters
/*
static void YourMethodName(int a = 0, int b = 0, int c = 0, int d = 0, int e = 0) {...}
YourMethodName(4);//just changes a = 4 behaviour usual if (4, 2) b = 2
YourMethodName(d: 4, b: 1, a: 2);//multiple 
YourMethodName(d: 4);//single
*/
using System;

namespace NamedArguments
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets();
      VisitPlanets(numberOfPlanets: 2);
      VisitPlanets(numberOfPlanets: 2, name: "Monkey");
    }
    
    static void VisitPlanets(
      string adjective = "brave",
      string name = "Cosmonaut", 
      int numberOfPlanets = 0,
      double gForce = 4.2)
    {
      Console.WriteLine($"Welcome back, {adjective} {name}.");
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }
  }
}

/*
Method Overloading
Say you want to use Math.Round(), a built-in method. You go to the Microsoft documentation to learn how to use it, and find at least 8 different versions! They all have the same name: Math.Round().

What’s happening here is called method overloading, and each “version” is called an overload. Though they have the same name, the overloads are different because they have either (i) different parameter types or (ii) different number of parameters. This is useful if you want the same method to have different behavior based on its inputs.

Let’s examine this concept with these two overloads: Math.Round(Double, Int32) and Math.Round(Double).

The first overload, Math.Round(Double, Int32), rounds the double to the int‘s number of decimal points

Math.Round(3.14159, 2); // returns 3.14
The second, Math.Round(Double), rounds the double to the nearest integer.

Math.Round(3.14159); // returns 3
*/
using System;

namespace MethodOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      NamePets();
      NamePets("Pongo", "Perdita");
      NamePets("Huey", "Lewy", "Dewey");
    }
    static void NamePets(string pet1, string pet2)
    {
      Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
    }
    static void NamePets(string pet1, string pet2, string pet3)
    {
      Console.WriteLine($"Your pets {pet1}, {pet2}, and {pet3} will be joining your voyage across space!");
    }
    static void NamePets()
    {
      Console.WriteLine("Aw, you have no spacefaring pets :(");
    }
  }
}
/*
Review
You learned a lot this lesson: congrats on finishing! Here’s what you’ve covered:

Call a method with its name and parentheses:
VisitPlanets();
Store a method’s returned value in a variable:
double result = Math.Round(3.14159, 2);
Define a basic method with the following syntax:
static void VisitPlanets()
{
}
Every time an application is started, the Main() method is called.
Values passed to a method are called arguments. When defined in the method, they are parameters.
Method parameters can only be used within the method body.
Method parameters can be optional if given a default value using equals = syntax:
static void VisitPlanets(int numberOfPlanets = 0)
When calling a method, pass arguments by position or by name. If using names, use the colon (:) syntax:
VisitPlanets(numberOfPlanets: 9);
In method overloading, multiple methods can have the same name, as long as they have different method signatures.
A method signature is a method’s name and parameter types in order.
*/
//review code
using System;

namespace ReviewMethodCallsAndInput
{
  class Program
  {
    static void Main(string[] args)
    {
      NamePets("Pinky", "Perky");
      VisitPlanets(numberOfPlanets: 7);
    }
    
    static void NamePets()
    {
      Console.WriteLine("Aw, you have no spacefaring pets :(");
    }
    
    static void NamePets(string pet1, string pet2)
    {
      Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
    }  
    
    static void NamePets(string pet1, string pet2, string pet3)
    {
      Console.WriteLine($"Your pets {pet1}, {pet2}, and {pet3} will be joining your voyage across space!");
    }  
    
    static void VisitPlanets(
      string adjective = "brave",
      string name = "Cosmonaut", 
      int numberOfPlanets = 0,
      double gForce = 4.2)
    {
      Console.WriteLine($"Welcome back, {adjective} {name}.");
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }
    
  }
}
//part2 output

using System;

namespace Return
{
  class Program
  {
    static void Main(string[] args)
    {
      DecoratePlanet("Mars");
      Console.WriteLine(DecoratePlanet("Jupiter"));
    }
    static string DecoratePlanet(string planetName)
    {
      return $"*.*.* Welcome to {planetName} *.*.*";
    }
	}
}
//
using System;

namespace ReturnErrors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(DecoratePlanet("Mars")); 
      Console.WriteLine("Is Pluto really a dwarf...?");
      Console.WriteLine(IsPlutoADwarf());
      Console.WriteLine("Then how many planets are there in the galaxy...?");
      Console.WriteLine(CountThePlanets());
    }
    
    static string DecoratePlanet(string planet)
    {
       return $"*..*..* Welcome to {planet} *..*..*";
    }
    
    static bool IsPlutoADwarf()
    {
      bool answer = true;
      return answer;
    }
    
    static string CountThePlanets()
    {
      return "8 planets, usually";
    }
	}
}

//out
/*Out
A method can only return one value, but sometimes you need to output two pieces of information.

For example the Int32.TryParse() method tries to parse its input as an integer. If it can, it returns true and sets a specific variable to the new value. If it cannot it returns false and sets a specific variable to null. This is what the method’s signature looks like:
*/
public static bool TryParse (string s, out int result);

//The method returns a boolean and accepts a string and int variable as input.

//Here’s how Int32.TryParse() and the out parameter are used:

int number;
bool success = Int32.TryParse("10602", out number); 
// number is 10602 and success is true
int number2;
bool success2 = Int32.TryParse(" !!! ", out number2);
// number2 is null and success2 is false

//
using System;

namespace OutParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      string ageAsString = "102";
      string nameAsString = "Granny";
      int ageAsInt;//better syntax below perhaps 
      bool outcome;//but remember define first rule perhaps
      outcome = Int32.TryParse(ageAsString, out ageAsInt);
      Console.WriteLine(outcome);
      Console.WriteLine(ageAsInt);
      //trying below correct syntax wrong input so False 0 returned
      bool outcome2 = Int32.TryParse(nameAsString, out int nameAsInt);
      Console.Write($"{outcome2}\n{nameAsInt}\n");
    }    
	}
}
//Using Out

//We can use out parameters in our own methods as well. In this example, Yell() converts phrase to uppercase and sets a boolean variable to true:

static string Yell(string phrase, out bool wasYellCalled)
{
  wasYellCalled = true;
  return phrase.ToUpper();
}
//The out parameter must have the out keyword and its expected type
//The out parameter must be set to a value before the method ends
//When calling the method, don’t forget to use the out keyword as well:

string message = "garrrr";
Yell(message, out bool flag);
// returns "GARRRR" and flag is true

//
using System;

namespace UsingOut
{
  class Program
  {
    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
      wasWhisperCalled = true;
      return phrase.ToLower();
    }
    
    static void Main(string[] args)
    {
      string statement = "GARRRR";//pirate steve
      string whisper = Whisper(statement, out bool marker);
      // should return  "garrrr" and set marker to true;
      Console.WriteLine(whisper);// + " " + marker);
    }    
	}
}
/*
Out Errors
As with return, out is a very useful keyword, but it can lead to errors if used incorrectly. Here are two common ones:

This error means that the out parameter needs to be assigned a value within the method:

error CS0177: The out parameter 'success' must be assigned to before control leaves the current method
This error means you called a method that expects an ‘out’ parameter but you didn’t use the out keyword when calling it:

error CS1620: Argument 2 must be passed with the 'out' keyword
*/
//
using System;

namespace OutErrors
{
  class Program
  {
    static void Main(string[] args)
    {
      string statement = "GARRRR";
      bool marker;
			string murmur = Whisper(statement, out marker);
      Console.WriteLine(murmur);
    }  
    
    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
      wasWhisperCalled = true;
      return phrase.ToLower();
    }
	} 
}

/*
Review
Congrats on finishing! You can now use and define methods with output.

Here’s what else you’ve learned in this lesson:

Methods return values with the return keyword.
Every method has a return type, designated in its method signature. That type must match the type of the value actually returned.
If a method returns no type, its return type is void.
out parameters can be used to return multiple values from a method.
You can always review this material on the Microsoft documentation.
*/
//review code

using System;

namespace ReviewMethodOutput
{
  class Program
  {
    static void Main(string[] args)
    {
      // Define variables
      string destination = "Neptune";
      string galaxyString = "8";
      int galaxyInt;
      string welcomeMessage;
      bool outcome;
      
      // Call DecoratePlanet() and TryParse() here
      welcomeMessage = DecoratePlanet(destination);
      outcome = Int32.TryParse(galaxyString, out galaxyInt);
      // Print results
      Console.WriteLine(welcomeMessage);
      Console.WriteLine($"Parsed to int? {outcome}: {galaxyInt}");
      
    }
    
    // Define a method that returns a string
  	static string DecoratePlanet(string planet)
    {
       return $"*..*..* Welcome to {planet} *..*..*";
    }
    
    // Define a method with out
    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
      wasWhisperCalled = true;
      return phrase.ToLower();
    }
	}
}

//public static void HideMessage(out string message) {} using out without return

//alternate expressions

//Expression-bodied Definitions
//Expression-bodied definitions are the first “shortcut” for writing methods. They’re great for writing one-line methods, like this one:

bool IsEven(int num)
{
  return num % 2 == 0;
}
//We can rewrite this definition as an expression-bodied definition by:

//removing the curly braces and return keyword, and
//adding the “fat arrow”, or =>, which is composed of the equal sign, =, and greater than, >, symbols
bool isEven(int num) => num % 2 == 0;
//This also works for methods that return nothing, aka void:

void Shout(string x) => Console.WriteLine(x.ToUpper());
//This type of definition can only be used when a method contains one expression. This helps us remember the name: expression-bodied definitions are method definitions with one expression.

//Fun fact: some developers also call the fat arrow notation, =>, a squid! 🦑
//
using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      Welcome("Earth");
      double days = 500;
      double rotations = DaysToRotations(days);
      Console.WriteLine($"In {days} days, the Earth has rotated {rotations} time(s).");
    } 
    
    static double DaysToRotations(double days) => days / 365;
    
    static void Welcome(string planet) => Console.WriteLine($"Welcome to {planet}!");
  }
}

/*
Methods as Arguments
Before we get into the next shortcut, we need to understand how methods are passed to other methods as arguments. This is possible and sometimes necessary in C#.

For example, say we need to check if there are even values in an array (you don’t need to know much about arrays here, except that they are lists of values).

First you need an array of values and the IsEven() method that returns true if its argument is even:

int[] numbers = {1, 3, 5, 6, 7, 8};

public static bool IsEven(int num)
{
  return num % 2 == 0;
}
Pass both of these as arguments to the method Array.Exists(), which returns a boolean value:

bool hasEvenNumber = Array.Exists(numbers, IsEven);
You can see that IsEven, a method, is passed as the second argument to Array.Exists().

In the background, this is what Array.Exists() does:

The IsEven() method is called with each value in the array. We can imagine each of these being called:
IsEven(1);
IsEven(3);
IsEven(5);
IsEven(6);
If any of these return true, Array.Exists() returns true.
By the end, Array.Exists() returns true because isEven(6) returns true.

There are other methods that accept methods as arguments, which you will encounter later on. For now, you need to understand that we can use a method’s name like a variable, e.g. IsEven is a variable representing the method IsEven(). We pass this variable to another method, like Array.Exists(), which will probably invoke that method-argument at least once within its own body.

1.
Array.Find() is another method that takes an array and a method as arguments. Array.Find() calls the method on each element of the array and returns the first element for which the method returns true.

An array adjectives and method IsLong() are defined for you. Call Array.Find() with these two arguments to find the first element in adjectives that is “long”.

Store the returned string in a variable named firstLongAdjective.
*/
//
using System;

namespace AlternateExpressions
{
  class Program
  {
  	// Method to be used as second argument
   	public static bool IsLong(string word)
    {
      return word.Length > 8;
    }
      
    static void Main(string[] args)
    {
      // Array to be used as first argument
      string[] adjectives = {"rocky", "mountainous", "cosmic", "extraterrestrial"};
     
      // Call Array.Find() and 
      // Pass in the array and method as arguments
      string firstLongAdjective = Array.Find(adjectives, IsLong);
      
      Console.WriteLine($"The first long word is: {firstLongAdjective}.");
    }
  }
}
//The first long word is: mountainous.
/*
Lambda Expressions
The next shortcut, lambda expressions, are great for situations when you need to pass a method as an argument.

In the past exercise, we used IsEven() to check that an even value exists in the array numbers:

int[] numbers = {1, 3, 5, 6, 7, 8};

public static bool IsEven(int num)
{
  return num % 2 == 0;
}

bool hasEvenNumber = Array.Exists(numbers, IsEven);
When using the original definition (with curly braces and return), it takes multiple lines to define the IsEven() method and other developers will need to jump around our code to find the definition. With a lambda expression, we can define IsEven() directly in the method call. We don’t even need to give it a name:

bool hasEvenNumber = Array.Exists(numbers, (int num) => num % 2 == 0 );
This might look similar to an expression-bodied definition. It sort of is! What makes a lambda expression unique is that it is an anonymous method: it has no name.

Generally lambda expressions with one expression (like the above example) take this form. They use the fat arrow, no curly braces, and no semicolon (;):

(input-parameters) => expression
Lambda expressions with more than one expression use curly braces and semicolon:

(input-parameters) => { statement; }
Here’s an example of the second structure, which checks if any element in numbers is a multiple of 12 and greater than 20:

bool hasBigDozen = Array.Exists(numbers, (int num) => {
  bool isDozenMultiple = num % 12 == 0;
  bool greaterThan20 = num > 20;
  return isDozenMultiple && greaterThan20;
});
Since this lambda expression includes multiple expressions (3 in this case), then we must use curly braces and semicolons.
*/
//
using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
      
      bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite");
      
      if (makesContact)
      {
        Console.WriteLine("At least one space rock has reached the Earth's surface!");
      } 
    } 
    /*bool makesContact = Array.Exists(spaceRocks, HitGround);
    //replaced with lamda above
    static bool HitGround(string s)
    {
      return s == "meteorite";
    }
    */
  }
}
/*
make our lambda expression even shorter. Here’s what we have to start:

bool hasEvenNumbers = Array.Exists(numbers, (int num) => num % 2 == 0 );
The type of num is int. It’s great to be explicit like this to avoid errors, but some developers wouldn’t include int. To them, it’s obvious! Here’s their reasoning:

The modulo operator (%) is only used with numbers, so num must be a number
The result of the operation num % 2 is compared to the integer 0. We can only compare similar types, so num must also be an integer!
Therefore, we can remove int without causing any errors:

bool hasEvenNumbers = Array.Exists(numbers, (num) => num % 2 == 0 );
When there is just one parameter in a lambda expression, we don’t need the parentheses around the parameter either:

bool hasEvenNumbers = Array.Exists(numbers, num => num % 2 == 0 );
We just learned two new shortcuts “within” the lambda expression shortcut. Though we don’t need to use them all the time, we do need to recognize them in other developers’ code:

We can remove the parameter type if can be inferred
We can remove the parentheses if there is one parameter
*/
//
using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
      
      bool makesContact = Array.Exists(spaceRocks, s => s == "meteorite");
      
      if (makesContact)
      {
        Console.WriteLine("At least one space rock has reached the Earth's surface!");
      } 
    } 
  }
}


/*
Review
Well done! We learned two shortcuts for defining methods:

Expression-bodied definitions can be used for one-line method bodies.

bool isEven(int num) => num % 2 == 0;
Lambda expressions can be used to create an anonymous method:

bool hasEvenNumbers = Array.Exists(numbers, (int num) => num % 2 == 0 );
You learned two “sub-shortcuts” within lambda expressions:

You can remove the parameter type if it can be inferred:

bool hasEvenNumbers = Array.Exists(numbers, (num) => num % 2 == 0 );
You can remove the parentheses if there is one parameter:

bool hasEvenNumbers = Array.Exists(numbers, num => num % 2 == 0 );
*/
//review code
using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = {0, 555, 252, 3, 9, 101};
      
      bool hasBigNum = Array.Exists(nums, isBig);
      
      bool hasSmallNum = Array.Exists(nums, isSmall);
      
      bool hasMediumNum = Array.Exists(nums, (n) => n >= 10 && n <= 100);
      
      Console.WriteLine($"Any big #s? {hasBigNum}");
      Console.WriteLine($"Any small #s? {hasSmallNum}");
      Console.WriteLine($"Any medium #s? {hasMediumNum}");
      
    }
    
    static bool isBig(int n) => n > 100;
    
    static bool isSmall(int n) => n < 10;
    
  }
}

