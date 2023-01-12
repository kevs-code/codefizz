/*
Narrative
Learn
ARRAYS
Building Arrays
In C#, arrays are a collection of values that all share the same data type. You could have an array of type string that contains a list of your favorite songs, or an array of type int that stores a collection of user ids.

Similar to defining a variable for one piece of data, when we define a variable to hold an array we also have to specify the type:

// These arrays store ints, strings, and doubles, respectively
int[] x; 
string[] s; 
double[] d; 
To declare a variable that holds an array, we first write the type of data that will be stored in an array, then add the square brackets [] to signify that it is holding an array (rather than a single value), followed by the name of the array.

Like a variable, we can define and initialize an array at the same time, by specifying the values we want to store in it:
*/
int[] plantHeights = { 3, 4, 6 };
//To declare and initialize an array at the same time, after the array declaration we use the equal sign to denote we’re storing a value to the array, then write out the numbers we’re putting in the array, separated by commas , and enclosed in curly braces {}.

//You may also see arrays defined and initialized using a new keyword:

int[] plantHeights = new int[] { 3, 4, 6 };
//The new keyword signifies that we are instantiating a new array from the array class. We’ll cover classes and instantiation in another lesson, but for now you can just think of it as another way to create an array.

//In fact, if you decide to define an array and then initialize it later (rather in one line like above) you must use the new keyword:

// Initial declaration
int[] plantHeights;

// This works
plantHeights = new int[] { 3, 4, 6 };   

// This will cause an error
//plantHeights = { 3, 4, 6 }; 

using System;

namespace BuildingArrays
{
  class Program
  {
    static void Main(string[] args)
    {
        // Initial declaration
        string[] summerStrut;
        // Initialize
        summerStrut = new string[] { "Barracuda", "American Pie", "Tamborine Man", "Bridge over troubled water", "Winds of Change", "Maggie May", "Sound of Silence", "Sweet Caroline"};
        // declare and initialize ratings
        int[] ratings =  {5, 5, 5, 5, 5, 5, 5, 5};
      
    }
  }
}
// array.Length

using System;

namespace ArrayLength
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] summerStrut;

      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito"};

      int arrayLength = summerStrut.Length;
      if (arrayLength == 8) {
        Console.WriteLine("summerStrut Playlist is ready to go!");
      } else if (arrayLength > 8) {
        Console.WriteLine("Too many songs!");
      } else {
        Console.WriteLine("Add some songs!");
      }
    }
  }
}
//accessing through index

using System;

namespace AccessingArrays
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars.");
    }
  }
}

//edit arrays

// plantHeights will be equal to [0, 0, 0]
int[] plantHeights = new int[3]; 

// plantHeights will now be [0, 0, 8]
plantHeights[2] = 8; 

int[] plantHeights = { 3, 4, 6 };

// plantHeights will be [3, 5, 6]
plantHeights[1] = 5; 

//
using System;

namespace EditingArrays
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      
      summerStrut[7] = "I Like It";
      ratings[7] = 3;
    }
  }
}

//built ins

//SORT

int[] plantHeights = { 3, 6, 4, 1 };

// plantHeights will be { 1, 3, 4, 6 }
Array.Sort(plantHeights); 
//Sort() takes an array as a parameter and edits the array so its values are sorted. If it is an array of integer values, it will sort them into ascending values (lowest to highest). If it’s an array of string values, they would be sorted alphabetically.

//INDEX OF
//The Array method Array.IndexOf()(documentation) takes a value and returns its index. IndexOf() works best when you have a specific value and need to know where it’s located in the array (or if it even exists!).

int[] plantHeights = { 3, 6, 4, 1, 6, 8 };

 // returns 1
Array.IndexOf(plantHeights, 6);
//IndexOf() typically takes two parameters: the first is the array and the second is the value whose index we’re locating. IndexOf() also has several overloads that allow you to search for a specific range of the array. If the value appears more than once in an array, it returns only the first occurrence within the specified range. If it cannot find the value, it returns the lower bound of the array, minus 1 (since most arrays start at 0, it’s usually -1).

//FIND
//The Array method Array.Find()(documentation) searches a one-dimensional array for a specific value or set of values that match a certain condition and returns the first occurrence in the array.

int[] plantHeights = { 3, 6, 4, 1, 6, 8 };

// Find the first occurence of a plant height that is greater than 5 inches
int firstHeight = Array.Find(plantHeights, height => height > 5);

//

using System;

namespace BuiltInMethods
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      
      //int firstThreeStar = Array.Find(ratings, r => r == 3);
      //Find returns value not index so wrong
      Console.WriteLine($"Song number {Array.IndexOf(ratings, 3) + 1} is rated three stars.");
      //Song number 3 is rated three stars.
      //index 3 and song 4 actually so add 1.
      string firstGreaterLengthTen = Array.Find(summerStrut, l => l.Length > 10);
      Console.WriteLine($"The first song that has more than 10 characters in the title is {firstGreaterLengthTen}");
      Array.Sort(summerStrut);
      Console.Write($"{summerStrut[0]}\n{summerStrut[7]}\n");
      //-1 indexing does not work could use
      Console.Write($"{summerStrut[0]}\n{summerStrut[summerStrut.Length - 1]}\n");
    }
  }
}

using System;

namespace DocumentationHunt
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      Console.WriteLine(summerStrut);
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

      string[] summerStrutCopy = new string[8];
      Array.Copy(summerStrut, summerStrutCopy, 8);
      Console.WriteLine(summerStrutCopy);//Prints System.String[]
      Array.Reverse(summerStrut);
      Console.WriteLine(summerStrut);//Prints System.String[]
      Array.Clear(ratings, 0, ratings.Length);
      Console.WriteLine(ratings);//Prints System.Int32[]
    }
  }
}
/*
Review
Congratulations, we covered a lot in this lesson! We learned about:

Data structures and how we can use them to better organize our data
How to build, access, and edit values in arrays
How to use Array class built-in methods, including Sort(), IndexOf(), and Find()
If you get stuck or would like to learn more, check out the official Microsoft site:

For general conceptual information, read the programming guide on Arrays
For specific information on methods like Find(), read the Array class documentation
*/
//review code

using System;

namespace ArraysReview
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program! 
      Here's what you learned:

      Building Arrays
      .Length Property
      Accessing and Editing Arrays using bracketNotation[]
      Built-in-Methods: Sort(), IndexOf(), Find()

      Good luck! */
    }
  }
}

//loops

//while do ..while for foreach

//while
using System;

namespace WhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      int emails = 20;  
      while (emails > 0) {
        emails--;
        Console.WriteLine($"Deleting an email there are {emails} left");
      }
        Console.WriteLine("INBOX ZERO ACHIEVED!");
    }
  }
}
//do while ... runs at least once

using System;

namespace DoWhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = true;
      do {
        Console.WriteLine("BLARRRRRRRRR");
      } while (!buttonClick);
      Console.WriteLine("Time for a five minute break.");
    }
  }
}
/*for loop

For Loop
What if we want our code to execute a specific number of times? We can use a for loop to do that.

for (initialization; stopping condition; iteration statement)
{
  statement;
}
The for loop tells the computer how many times to repeat the instructions using the for keyword and three expressions inside of parentheses. Each of these expressions use what’s known as an iterator variable, which is a variable that keeps track of how many times the program goes through the loop.

These expressions are:

Initialization: where the loop begins
Stopping condition: the condition that the iterator variable is evaluated against
Iteration statement: used to update the iterator variable on each loop
The for loop is good to use when you know the number of times you’d like to perform a task before you begin, like printing three copies of a document or inserting eight rows into a table.

In our video game, we want ten flags to appear at the start of each level:

for (int i = 0; i < 10; i++)
{
  DisplayFlag();
}
*/

//for loop

using System;

namespace ForLoop
{
  class Program
  {
    static void Main(string[] args)
    { 
      for(int i = 1; i < 17; i++)
      {
        CreateTemplate(i);
      }

    }
    
    static void CreateTemplate(int week)
    {
      Console.WriteLine($"Week {week}");
      Console.WriteLine("Announcements: \n \n \n ");
      Console.WriteLine("Report Backs: \n \n \n");
      Console.WriteLine("Discussion Items: \n \n \n");
    }
    
    
  }
}

//foreach

string[] melody = { "a", "b", "c", "c", "b" };
//and the loop would look like:

foreach (string note in melody)
{
  PlayMusic(note);
}
//
using System;

namespace ForEachLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };
      foreach (string item in todo)
      {
        CreateTodoItem(item);
      }

    }
    
    static void CreateTodoItem(string item)
    {
      Console.WriteLine($"[] {item}");
    }
  }
}

/*
In general,

while loops are good when you know your stopping condition, but not when you know how many times you want a program to loop or if you have a specific collection to loop through.
do...while loops are only necessary if you definitely want something to run once, but then stop if a condition is met.
for loops are best if you want something to run a specific number of times, rather than given a certain condition.
foreach loops are the best way to loop over an array, or any other collection.
*/

//
using System;

namespace ComparingLoops
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] websites = { "twitter", "facebook", "gmail" };
      foreach(string site in websites)
      {
        Console.WriteLine(site); 
      }
    }
  }
}

//jump statements -- continue, break, return
//continue breaks out of loop iteration
//break breaks out of loop
//return breaks out of whole function and returns to call point with value
using System;

namespace JumpStatements
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = true;
      int counter = 0;
      do
      {
        Console.WriteLine("BLARRRRR");
        counter++;
        if (counter == 3) {
          break;
        }
      } while(buttonClick);//or just counter != 3
    }
  }
}

/*
Review
Well done! In C#, loops are commonly used because they save time, reduce errors, and are easy to read. Being comfortable with each type of loop will make you a better programmer. In review:

A loop is a structure in programming where the instructions are written once, but a computer can execute them multiple times
Each execution of those instructions is called an iteration
while loops repeat until a condition changes
do...while loops execute once, and then repeat until a condition changes
for loops repeat for a specified number of times
foreach loops repeat for each item in a collection
jump statements, like break, continue, and return are used to add additional control flow to loops
Now that you know a few things about loops, try writing a program that:

Loops through a piece of text and only prints words that start with the letter “a” to the console to create a poem.
Loops through a list of numbers and if it is even, print even and if it’s odd, print odd.
A Choose Your Own Adventure game that uses a while loop to make sure a user chooses a correct option.
*/
//review code
using System;

namespace LoopsReview
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program! 
      Here's what you learned:

      while loop: while(){..} 
      do...while loop: do{...}while();
      for loop: for(int i=0; i<x; i++){}
      foreach loop: foreach(int item in list){}
      jump statements: break, continue, return

      Good luck! */
    }
  }
}
