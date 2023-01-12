/*
Introduction to Lists
At this point, we assume that you’re familiar with arrays: they’re useful tools for managing large amounts of sequential data.

But arrays have their drawbacks:

They have a limited length
You have to keep track of the number of elements in the array using a separate index
You can only edit one element at a time
Lists resolve all of these issues! Like arrays, they are a sequential collection of values and they can hold references to any type. Unlike arrays, they have (effectively) unlimited length, they automatically track the number of actual elements in the list, and they have have handy methods to work with multiple elements at a time.

In this lesson we’ll cover list basics and some common list methods.

This code creates and edits a lists of cities. How does this look different from arrays?

Run the code to see it in action.
*/


//
using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };
      
      citiesList.Add("New York City");
      
      citiesList.Remove("Dubai");
      
      citiesList.AddRange(new string[] {"Cairo", "Johannesburg"});
      
      bool hasNewDelhi = citiesList.Contains("New Delhi");
      
      foreach (string city in citiesList)
      {
        Console.WriteLine(city);
      }
    }
  }
}

/*

Creating and Adding
A list is a sequential data structure that can hold any type. Like arrays, you can use them to store any sequential information, like the letters of the alphabet, comments on a blogpost, the finishing times for a horse race, or items on a restaurant menu.

You create a list using the new keyword, like you would create any other class. You specify the type of element inside angle brackets: < >. In this example, the list is named citiesList and it holds instances of the type string.

List<string> citiesList = new List<string>();
You can add elements to the list using the Add() method:

citiesList.Add("Delhi");
You can access elements using indices and square brackets:

string city = citiesList[0];
You can also re-assign elements using bracket notation:

citiesList[0] = "New Delhi";
In order to use lists, you’ll need to add this to the top of your file. We’ll explain this in detail later:

using System.Collections.Generic;
Instructions
1.
Create a list to hold the top women’s marathon times in hours. Create an empty list of type double and stored it in a variable marathons.

￼
Stuck? Get a hint
2.
Jemima Sumgong won the 2016 marathon in Rio de Janeiro with a time of 144.07 minutes and Tiki Gelana won the 2012 marathon in London with a time of 143.12 minutes. (That’s just two hours and 23 seconds!)

Use two Add() statements to add those values to the list.

￼
Stuck? Get a hint
3.
Print the second value in the list to the console.

*/

using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<double> marathons = new List<double>();
      marathons.Add(144.07);
      marathons.Add(143.12);
      Console.WriteLine(marathons[1]);
    }
  }
}
//143.12

/*
Object Initialization
Our first way to create lists and add items took multiple lines:

List<string> citiesList = new List<string>();
citiesList.Add("Delhi");
citiesList.Add("Los Angeles");
We can do it all in one line using object initialization:

List<string> citiesList2 = new List<string> { "Delhi", "Los Angeles" };
We won’t cover everything about object initialization in this lesson, but you do need to recognize and use it.

Basic construction uses parentheses ( ) and no values.
Object initialization uses curly braces { } and the actual values go in-between.
If we need to later add elements later to that second list, we can still use Add():

citiesList2.Add("Kiev");
Instructions
1.
The current code creates an empty list and uses Add() to add elements.

Delete those lines and make the same list with an object initialization.
*/

using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<double> marathons = new List<double> {144.07, 143.12, 146.73, 146.33};
      // Do not delete the below code
      double time = marathons[1];
      
      Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");

    }
  }
}
/*
better than ...
List<double> marathons = new List<double>();
      marathons.Add(144.07);
      marathons.Add(143.12);
      marathons.Add(146.73);
      marathons.Add(146.33);
*/
/*

Count and Contains
We can check on the status of our list in two ways.

We can find the number of elements in the list using the Count property:

List<string> citiesList = new List<string> { "Delhi", "Los Angeles" };
int numberCities = citiesList.Count;
// numberCities is 2
We can check if an element exists in a list using the Contains() method:

bool hasDelhi = citiesList.Contains("Delhi");
bool hasDubai = citiesList.Contains("Dubai");
// hasDelhi is true, hasDubai is false
Instructions
1.
The list marathons has been initialized for you. Print the Count to the console.

￼
Stuck? Get a hint
2.
In the 2000 Sydney Olympic Games, Naoko Takahashi won the marathon with a time of 143.23 minutes (the Olympic record until 2012 in London).

Use Add() to add that value to the list.

￼
Stuck? Get a hint
3.
Make sure that 143.23 was added to the list. Call the Contains() method and print the returned value to the console.

4.
Print Count again. Make sure it increased to 5!
*/

using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<double> marathons = new List<double>
      {
        144.07,
        143.12,
        146.73,
        146.33
      };
      
      Console.WriteLine(marathons.Count);
      marathons.Add(143.23);
      Console.WriteLine(marathons.Contains(143.23));
      Console.WriteLine(marathons.Count);
    }
  }
}

/*
4
True
5
*/

/*
Removing
To remove a specific item from a list we use the Remove() method. It expects the specific item as an argument and it returns true if it was successfully removed. This code removes "Delhi" from the list and returns true:

List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Kiev" };
bool success = citiesList.Remove("Delhi");
// success is true
If the specific item does NOT exist in the list, the method call returns false. Since "Dubai" isn’t in the list, success will be false:

success = citiesList.Remove("Dubai");
// success is false
If you remove an element in the middle of the list, all of the elements will be “shifted” down one index. In the first example, the list was originally:

[ "Delhi", "Los Angeles", "Kiev" ]
After the call to Remove("Delhi"), the list becomes

[ "Los Angeles", "Kiev" ]
Instructions
1.
The list marathons has been initialized for you. Print the second element in the list.

￼
Stuck? Get a hint
2.
Remove the item 143.12 (which is currently the second item in the list) and store the result in a bool variable named removed.

￼
Stuck? Get a hint
3.
Print the second element again and the value of removed. The second element should be different and removed should be true.
*/

using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<double> marathons = new List<double>
      {
        144.07,
        143.12,
        146.73,
        146.33
      };
      Console.WriteLine(marathons[1]);
      bool removed = marathons.Remove(143.12);
      Console.WriteLine(marathons[1]);
      Console.WriteLine(removed);
    }
  }
}

/*
143.12
146.73
True
*/

/*
Clearing
If we need to remove all of the elements from a list, we could iterate through the entire list and call Remove(). The easier way is to use the Clear() method.

List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Kiev" };
citiesList.Clear();

Console.WriteLine(citiesList.Count);
// Output: 0
*/

using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<double> marathons = new List<double>
      {
        148.22,
        156.10,
        153.88,
        155.34,
        160.89
      };
      
      // Clear the list here
      marathons.Clear();
      
      Console.WriteLine($"Count: {marathons.Count}");
    }
  }
}

//Count: 0
ing System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<double> marathons = new List<double>
      {
        144.07,
        143.12,
        146.73,
        146.33
      };
      
      double futureWinner = marathons[marathons.Count-1];
      //this is a bit of a nonsense one
      marathons[3] = 143.23;
      
      Console.WriteLine("If you reached this point, there are no errors!");
    }
  }
}

/*
Working with Ranges
So far we have added, accessed, and removed single elements in a list. What if we wanted to add, access, or remove multiple elements at once?

In the world of lists we call a subsequence of elements a range. For example, this list has 5 elements:

[ "first", "second", "third", "fourth", "fifth" ]
We can say the range of elements from index 1 to 3 is:

[ "second", "third", "fourth" ]
Here are four common range-related methods:

AddRange() — takes an array or list as an argument. Adds the values to the end of the list. Returns nothing.
InsertRange() — takes an int and array or list as an argument. Adds the values at the int index. Returns nothing.
RemoveRange() — takes two int values. The first int is the index at which to begin removing and the second int is the number of elements to remove. Returns nothing.
GetRange() — takes two int values. The first int is the index of the first desired element and the second int is the number of elements in the desired range. Returns a list of the same type.
Here is each one in action:

List<string> places = new List<string> { "first", "second" };

places.AddRange(new string[] { "fifth", "sixth" });
// List is  "first", "second", "fifth", "sixth" ]
places.InsertRange(2, new string[] { "third", "fourth"});
// List is [ "first", "second", "third", "fourth", "fifth", "sixth" ]
places.RemoveRange(4, 2);
// List is [ "first", "second", "third", "fourth" ]
List<string> newPlaces = places.GetRange(0, 3);
// New list is [ "first", "second", "third" ]
You don’t need to memorize these methods, but you should be familiar with the concept of ranges! You can always look up the methods again in the Microsoft documentation.

Instructions
1.
Use GetRange() to get the first three elements in the marathons list.

Store the result in a new list variable called topMarathons.

￼
Stuck? Get a hint
2.
Loop through the topMarathons list and print each value to the console.
*/

using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<double> marathons = new List<double>
      {
        144.07,
        143.12,
        146.73,
        146.33
      };
      List<double> topMarathons = marathons.GetRange(0, 3);
      foreach(double marathon in topMarathons)
      {
        Console.WriteLine(marathon);
      }
    }
  }
}

/*

Looping through Lists
Like arrays, we can perform an operation for every element in the list using for and foreach loops.

With for loops, make sure to use Count to stay within the bounds of the list.

for (int i  = 0; i < numbers.Count; i++)
{
   Console.WriteLine(number);
}
With a foreach loop, the counting is handled for you:

foreach (int number in numbers)
{
   Console.WriteLine(number);
}
Generally, we prefer foreach loops because they require less typing and thus less chance for typos.

If the index is used in the operation — like printing out each index and element together — then we’ll use for loops.

Instructions
1.
The second for loop in the code is used to print out a bib for each runner. Replace it with a foreach loop that achieves the same objective.
*/


using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    { 
      List<string> runners = new List<string> { "Jemima Sumgong", "Tiki Gelana", "Constantina Tomescu", "Mizuki Noguchi" };
      Random rand = new Random();
      
      Console.WriteLine("In reverse chronological order, the gold medalists are...");
      
      // First loop
      for (int i = 0; i < runners.Count; i++)
      {
        Console.WriteLine($"{i+1}: {runners[i]}");
      }
      
      Console.WriteLine("\nPrinting runner bibs...");
      
      // Second loop
      foreach (string runner in runners) {
        string name = runner.ToUpper();
        int id = rand.Next(100, 1000);
        Console.WriteLine($"{id} - {name}");
      }

    }
  }
}

/*
Generic Collections
You’ve done great with lists so far! It’s time to take a look at the bigger picture.

Remember the one line we mentioned at the beginning of this lesson?

using System.Collections.Generic;
The list class is in a group of classes called generic collections. They don’t exist in the default set of System classes, so we need to make a reference to them with this line.

Generic collections are data structures that are defined with a generic type. Each class is defined generally without a specific type in mind. When we make an actual instance, we define the specific type:

List<string> citiesList = new List<string>();
List<Object> objects = new List<Object>();
Imagine it like a set of general instructions: in a toy store, we can tell the employees how to add and remove items from a shelf without specifying the type of toy. In the same way, we can use Add() and Remove() without knowing a lists’s data type.

For this reason, the formal class name of lists is List<T>. That T is a type parameter: it represents some type that we can specify later. The general instructions, however are neatly contained in the generic List<T> class.

Let’s see why this is useful by imagining the other, more difficult ways we could create “generic” collections:

Use type-specific classes, like StringList, IntList, etc. — We would have to make a list class for EVERY type, defining the same properties and methods for each list class.
Use a list containing Object types, List<Object> — Using Object means we can’t use any of the unique functionality of each type and it takes a lot of computing power to convert references to and from the Object type.
As you continue coding, you’ll see for yourself how useful generic collections are!

Instructions
1.
Make a reference to the System.Collections.Generic namespace.

￼
Stuck? Get a hint
2.
Declare three empty lists:

one should hold bool types
one should hold Random types
one should hold IServiceProvider types
That’s right, interfaces work here too!
*/

using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<bool> bools = new List<bool>();
      List<Random> randoms = new List<Random>();
      List<IServiceProvider> services = new List<IServiceProvider>();
    }
  }
}

/*
Review
Well done! You’ve learned a lot of useful information in this lesson:

A list, or List<T>, is a generic, sequential data structure. The specific type that it contains is specified upon instantiation.
Lists are effectively unlimited. They “grow” and “shrink” as the number of elements rises and falls.
List values can be accessed by index using square brackets: [ ].
To create an empty list, use a basic constructor. To create a list with values, use object initialization.
Add() is used to add an element to a list.
Remove() is used to remove an element from the list. It returns true if it is successful, false otherwise.
Count is the number of elements in the array.
Contains() returns true if the argument exists in the list, false otherwise.
A sequence within a list is called a range. There are specific methods for working with ranges, including GetRange(), AddRange(), InsertRange(), and RemoveRange().
Lists are a type of generic collection, which are defined with generic type parameters. The type parameters are specified when instantiating any generic class.
Use lists and dictionaries in your code by including this line at the top of your file:
using System.Collections.Generic;
If you ever forget the constructors, properties, and methods taught here, you can find them in the Microsoft documentation for List<T>.

Finally, you may be wondering: if lists have so many great features, why did we bother with arrays at all?

The answer is (this an optional part of the lesson): under the hood, lists actually use arrays! When we construct a list, the C# compiler constructs an array and stores the elements there. If the list gets longer than the array’s length, the compiler copies the list elements to a new, longer array. To the developer, it just looks like the list is infinitely long.

Thus arrays are faster to use when you have a pre-determined number of elements, and lists are better to use when the number is unknown or you’d like the extra features. If you’d like to dive deeper into this concept, start with the Capacity property.
*/

using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };
      citiesList.Add("Prague");
      foreach(string city in citiesList)
      {
        Console.WriteLine(city);
      }
    }
  }
}

//LINQ
/* Thoughts ... Looks like an sql type language interface
Introduction to LINQ
Imagine you’re building a new game in C#, with dozens of characters to manage in your database. How would you access them all? What if you need to apply a filter? What if you needed to format each character name?

You might think of storing characters in a list and running through each element with a foreach loop. You’d have to write nested if statements, re-format each element, and store each result in a new list.

The result isn’t pretty.

Suppose that we want to find all the names in a list which are longer than 6 letters and return them in all uppercase letters. You can see what it would look like in Program.cs in the code editor.

And remember that this only works in a running C# file. What if the database was stored in a separate server somewhere and it was implemented with SQL instead of C#?

The solution is LINQ. It works for complex selections and transformations, and it works on local and remote data sources. Each selection/transformation is called a query, and LINQ gives us new syntax and methods to write them.

Imagine LINQ like an add-on to C# and .NET. Once you import the LINQ features, you can write new syntax, like:

string[] names = { "Tiana", "Dwayne", "Helena" };
var filteredNames = from n in names
  where n.Contains("a")
  select n;
And you can use new methods on collections, like Where():

var shortNames = names.Where(n => n.Length < 4);
In this lesson you’ll learn :

How to import the LINQ features to C#
How to run LINQ queries on datasets
How to identify method and query syntax
Basic operators, such as Select, Where, and from
Instructions
1.
In Program.cs, compare the two approaches for querying data:

Without LINQ, we use a foreach loop and nested if statement.
With LINQ, we write a three-line query.
Run the code to see them in action!
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
      
      // Approach 1: without LINQ
      List<string> longLoudHeroes = new List<string>();
      
      foreach (string hero in heroes)
      {
        if (hero.Length > 6)
        {
          string formatted = hero.ToUpper();
          longLoudHeroes.Add(formatted);
        }
      }
      
      // Approach 2: with LINQ nice.
      var longLoudHeroes2 = from h in heroes
            where h.Length > 6
            select h.ToUpper();
      
      // Printing...
      Console.WriteLine("Your long loud heroes are...");
      
      foreach (string hero in longLoudHeroes2)
      {
        Console.WriteLine(hero);
      }
    }
  }
}
/*

Importing LINQ
Before we jump into the syntax and methods, let’s import the features into our code. To use LINQ in a file, add this line to the top:

using System.Linq;
Often times we use LINQ with generic collections (like lists), so you may see both namespaces imported into a file:

using System.Collections.Generic;
using System.Linq;
Instructions
1.
This code is throwing errors! Run the code to see the error details.

You should have seen an error message like this:

error CS0246: The type or namespace name 'List<>' could not be found (are you missing a using directive or an assembly reference?) 
or

error CS1935: Could not find an implementation of the query pattern for source type 'List<string>'.  'Where' not found.  Are you missing a reference to 'System.Core.dll' or a using directive for 'System.Linq'? 
2.
Fix the errors by adding references to both the System.Collections.Generic and System.Linq namespaces.

*/

//

using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
  
      var shortHeroes = from h in heroes
                        where h.Length < 8
                        select h;

      // Printing...
      Console.WriteLine("Your short heroes are...");
      
      foreach (string hero in shortHeroes)
      {
        Console.WriteLine(hero);
      }
    }
  }
}

/*

LINQ
Var
Every LINQ query returns either a single value or an object of type IEnumerable<T>. For now, all you need to know about that second type is that:

It works with foreach loops, just like arrays and lists
You can check its length with Count()
Since the single value type and/or the parameter type T is not always known, it’s common to store a query’s returned value in a variable of type var.

var is just an implicitly typed variable — we let the C# compiler determine the actual type for us. Here’s one example:

string[] names = { "Tiana", "Dwayne", "Helena" };
var shortNames = names.Where(n => n.Length < 4);
In this case shortNames is actually of type IEnumerable<string>, but we don’t need to worry ourselves about that as long as we have var!

Instructions
1.
Let’s practice using var with LINQ.

Create a variable of type var named shortHeroes and set it equal to this LINQ query:

from h in heroes
where h.Length < 8
select h;
￼
Stuck? Get a hint
2.
Use a foreach loop to print out each element in shortHeroes.

3.
Create another variable of type var named longHeroes and set it equal to this LINQ query:

heroes.Where(n => n.Length > 8);
￼
Stuck? Get a hint
4.
Use Count() to print the number of elements in longHeroes.

*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
      
      var shortHeroes = from h in heroes
            where h.Length < 8
            select h;
      foreach (var h in shortHeroes)
      {
        Console.WriteLine(h);
      }

      var longHeroes = heroes.Where(n => n.Length > 8);

      Console.WriteLine(longHeroes.Count());
    }
  }
}

/*
D. Va
Lucio
Mercy
Pharah
2
*/

/*
Method and Query Syntax
In LINQ, you can write queries in two ways: in query syntax and method syntax.

Query syntax looks like a multi-line sentence. If you’ve used SQL, you might see some similarities:

var longLoudHeroes = from h in heroes
  where h.Length > 6
  select h.ToUpper();
Method syntax looks like plain old C#. We make method calls on the collection we are querying:

var longHeroes = heroes.Where(h => h.Length > 6);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());
In LINQ, we see where/Where() and select/Select() show up as both keywords and method calls. To cover both cases, they’re generally called operators.

Every developer has a personal preference between syntaxes, but you should be able to read both. In this lesson we’ll start with query syntax then move on to method.

Instructions
1.
Read the two queries in Program.cs. Each one returns a sequence of phrases, one for each hero name that contains an ‘a’. Run the code to see the output.

The queries return the same output, but they are written with different syntax. Which seems easier to read to you?
*/

//

using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

      // Query syntax
      var queryResult = from x in heroes
                        where x.Contains("a")
                        select $"{x} contains an 'a'";
      
      // Method syntax
      var methodResult = heroes
        .Where(x => x.Contains("a"))
        .Select(x => $"{x} contains an 'a'");
     
      // Printing...
      Console.WriteLine("queryResult:");
      foreach (string s in queryResult)
      {
        Console.WriteLine(s);
      }
      
      Console.WriteLine("\nmethodResult:");
      foreach (string s in methodResult)
      {
        Console.WriteLine(s);
      }
    }
  }
}

/*

Basic Query Syntax
A basic LINQ query, in query syntax, has three parts:

string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

var shortHeroes = from h in heroes
  where h.Length < 8
  select h;
The from operator declares a variable to iterate through the sequence. In this case, h is used to iterate through heroes.
The where operator picks elements from the sequence if they satisfy the given condition. The condition is normally written like the conditional expressions you would find in an if statement. In this case, the condition is h.Length < 8.
The select operator determines what is returned for each element in the sequence. In this case, it’s just the element itself.
The from and select operators are required, where is optional. In this next example, select is used to make a new string starting with “Hero: “ for each element:

var heroTitles = from hero in heroes
  select $"HERO: {hero.ToUpper()};
Each element in heroTitles would look like "HERO: D. VA", "HERO: LUCIO", etc.

Instructions
1.
Write a from - where - select query that selects all of the elements in heroes that contain the character "i". Store the result in a variable named heroesWithI.

￼
Stuck? Get a hint
2.
Write a from - select query that returns the same array as heroes, but every space is replaced with an underscore (_). Store the result in a variable named underscored.

*/

//
using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
      var heroesWithI = from hero in heroes
        where hero.Contains("i")
        select hero;
      
      var underscored = from hero in heroes
        select hero.Replace(" ", "_");
    }
  }
}

/*

Basic Method Syntax: Where
In method syntax, each query operator is written as a regular method call.

In the last exercise we selected every element with a length under 8. Here it is in method syntax:

string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
var shortHeroes = heroes.Where(h => h.Length < 8);
The where operator is written as the method Where(), which takes a lambda expression as an argument. Remember that lambda expressions are a quick way to write a method. In this case, the method returns true if h is less than 8 characters long.

Where() calls this lambda expression for every element in heroes. If it returns true, then the element is added to the resulting collection.

For example, the shortHeroes sequence from above would be:

[ D. Va, Lucio, Mercy, Pharah ]
Instructions
1.
Write a method-syntax query that selects all of the elements in heroes containing the character "i". Store the result in a variable named heroesWithI.

￼
Stuck? Get a hint
2.
Print out all of the elements in heroesWithI to check your work.

*/

//
using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
      var heroesWithI = heroes.Where(h => h.Contains("i"));
      foreach (var hero in heroesWithI)
      {
        Console.WriteLine(hero);
      }
    }
  }
}

/*
LINQ
Basic Method Syntax: Select
To transform each element in a sequence — like writing them in uppercase — we can use the select operator. In method syntax it’s written as the method Select(), which takes a lambda expression:

string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
var loudHeroes = heroes.Select(h => h.ToUpper());
We can combine Select() with Where() in two ways:

Use separate statements:
var longHeroes = heroes.Where(h => h.Length > 6);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());
Chain the expressions:
var longLoudHeroes = heroes
.Where(h => h.Length > 6)
.Select(h => h.ToUpper());
As with most of LINQ, the choice is up to you!

In the first option, we use two variable names and two statements. You can tell there are two separate statements by counting the semi-colons.

In the second option, we use one variable name and one statement.

If we must use method-syntax, we prefer the second option (chaining) because it is easier to read and write. You can imagine each line like a step in a conveyor belt, filtering and transforming the sequence as it goes.
*/


//
using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
      var heroesWithC = heroes.Where(h => h.Contains("c"));
      var lowerHeroesWithC = heroesWithC.Select(h => h.ToLower());
      
      var sameResult = heroes
        .Where(h => h.Contains("c"))
        .Select(h => h.ToLower());

      foreach (var h in sameResult)
      {
        Console.WriteLine(h);
      }
    }
  }
}

/*

When To Use Each Syntax
So far you’ve seen query syntax and two flavors of method syntax.

// Query syntax
var longLoudheroes = from h in heroes
  where h.Length > 6
  select h.ToUpper();

// Method syntax - separate statements
var longHeroes = heroes.Where(h => h.Length > 6);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());

// Method syntax - chained expressions
var longLoudHeroes2 = heroes
  .Where(h => h.Length > 6)
  .Select(h => h.ToUpper());
As you get into more advanced LINQ queries and learn new operators, you’ll get a feel for what works best in each situation. For now, we generally follow these rules:

For single operator queries, use method syntax.
For everything else, use query syntax.
Instructions
1.
Write a method-syntax query that transforms each element in heroes to this format:

Introducing...[HERO NAME]!
￼
Stuck? Get a hint
2.
Write a query-syntax query that selects elements containing a space and returns the index of the space in each element. For example, instead of "D. Va", the result should contain 2.

￼
Stuck? Get a hint
3.
Print out all of the elements of both query results to check your work.

*/

//
using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
      var helloHeroes = heroes.Select(h => $"Introducing...{h}!");
      var spaceIndexedHeroes = from h in heroes
        where h.Contains(" ")
        select h.IndexOf(" ");
      
      foreach(var h in helloHeroes)
      {
        Console.WriteLine(h);
      }
      
      foreach(var h in spaceIndexedHeroes)
      {
        Console.WriteLine(h);
      }
    }
  }
}

/*
Introducing...D. Va!
Introducing...Lucio!
Introducing...Mercy!
Introducing...Soldier 76!
Introducing...Pharah!
Introducing...Reinhardt!
2
7
*/

/*
LINQ with Other Collections
You’ve mostly seen LINQ used with arrays, but it can be used for lists as well! The syntax is the same:

List<string> heroesList = new List<string> { "D. Va", "Lucio", "Soldier 76" };

var longLoudheroes = from h in heroesList
  where h.Length > 6
  select h.ToUpper();

// longLoudHeroes is [ "SOLDIER 76" ]
Technically, LINQ can be used with any type that supports foreach loops, but we won’t cover all of those here.

Instructions
1.
Query heroesList to find all hero names that contain either a . or 7 (a period or the number 7).
*/

//
using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      List<string> heroesList = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
      var newHeroes = heroesList.Where(h => h.Contains("7") || h.Contains("."));

    }
  }
}

/*
Review
Great job — we just covered a lot of LINQ! Here’s a recap:

LINQ is a set of language and framework features for writing structured, type-safe queries over local object collections and remote data sources.
Use LINQ by referencing the System.Linq namespace in your file.
When a LINQ query returns a sequence of elements its type is IEnumerable<T>. That means it works with foreach loops and its length is accessible with Count().
Store a query’s result in a variable of type var. var is an implicit type, meaning it gets all of the benefits of type-checking without our specifying the actual type.
LINQ queries can be written in method syntax or query syntax.
We prefer method syntax for single operations and query syntax for most everything else.
The Where operator is used to select certain elements from a sequence.
The Select operator determines what is returned for each element in the sequence.
The from operator declares a range variable that is used to traverse the sequence.
LINQ can be used on arrays and lists, among other datatypes.
If you’re curious or want more practice, here are some additional resources:

Learn more by reading Microsoft’s guide to LINQ.
Find a list of keywords for query syntax here.
Find a list of common methods for method syntax here.
Find a complete list of methods for IEnumerable<T> here.
1.
There are a few bugs in this code! Fix each one before moving on.
*/

//
using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      List<string> heroesList = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
      
      // Query syntax
      var queryResult = from h in heroesList
        where h.Contains("a")
        select $"{h} contains an 'a'";
     
      // Printing...
      Console.WriteLine($"queryResult has {queryResult.Count()} elements");
      
      foreach (string s in queryResult)
      {
        Console.WriteLine(s);
      }

      
    }
  }
}

/*
// Method syntax
var smallAnimals = savannah.Where(x => x.Length < 5);

// Query syntax
var smallAnimals2 = ￼from x in savannah
  ￼where x.Length < 5
  ￼select x;
*/
