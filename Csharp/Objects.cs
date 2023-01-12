/*
THE OBJECT CLASS
Introduction to Object
In C# there is one type of reference that can be used for all objects. It’s aptly called Object.

Every class is derived from Object. Whether it’s the class’ superclass or the superclass’ superclass’ superclass, Object is at the top of the class’ inheritance hierarchy.

Since references can be upcast to any type in its inheritance hierarchy, then all types can by referenced as Objects:

Object o1 = new Dissertation();
Object o2 = new Diary();
Object o3 = new Random();
Object o4 = new Forest("Amazon");
If that’s so, why not use Object references for everything? Because the functionality of an object is limited by its reference type. We lose all of a specific type’s specific functionality when we reference it as an Object type. We would also lose the automatic type-checking that saves us from type errors.

When we do use them, Object references can be very useful! For example, if we’re not sure what type a variable is, we can safely store it as an Object. We can also assume that any object has access to the standard Object members for basic manipulation.

In this lesson, you’ll learn:

How every type inherits from Object
The useful members in Object
*/

/*

The Object Type
Every class is derived from Object — even classes that we define ourselves!

When you create a class, C# implicitly makes it inherit Object. So when we write this code:

class Book
{}
C# assumes we mean:

class Book : Object
{}
Even if we already declared a superclass, like…

class Book : Media
{}
…Object will be at the top of the family tree. Maybe Media directly inherits from Object, or its base class inherits from Object, etc.

We can prove this to ourselves by attempting to convert any reference to an Object. None of this code will throw an error because each type — at some point — inherits from Object:

Object o1 = new Dissertation();
Object o2 = new Diary();
Object o3 = new Random();
Object o4 = new Forest("Amazon");
Value types and strings also inherit from Object:

Object o5 = 21;
Object o6 = false;
Object o7 = "Hello you!";
*/

//
using System;

namespace TheObjectClass
{
  class Program
  {
    static void Main(string[] args)
    {
      Book bk = new Book();
      
      Diary dy = new Diary(38);
      
      int i = 9;

      Object bk2 = bk;
      
      Object dy2 = dy;
      
      Object i2 = i;
      

    }
  }
}


/*

Object Members
Object has a few useful members and they’re accessible by every type. Here are some important ones:

Equals(Object) — returns true if the current instance and the argument are equal (using value equality for value types and referential equality for reference types)
GetType() — returns the type of the object
ToString() — returns a string describing the object
You can see each method in action here:

Object o1 = new Object();
// t is System.Object
Type t = o1.GetType();

string s = o1.ToString();
// Prints "System.Object"
Console.WriteLine(s);

Object o2 = o1;
// Equals true
bool b = o1.Equals(o2);
Remember that we can access inherited members from a derived class. In this case, every type inherits from Object, so every type can access these members!

For the full list of Object members read the Microsoft documentation.

1.
Create an array of type Object[] that contains b, d, r, and i.

Checkpoint 2 Passed
￼
Stuck? Get a hint
2.
Make an empty foreach loop that loops through each element in the array.

Checkpoint 3 Passed
￼
Stuck? Get a hint
3.
In the body of the loop, call the GetType() method of each element and print out the result.
*/

using System;

namespace TheObjectClass
{
  class Program
  {
    static void Main(string[] args)
    {
      Book b = new Book();      
      Diary d = new Diary(38);
      Random r = new Random();
      int i = 9;
      Object[] arr = {b, d, r, i};
      foreach (Object a in arr)
      {
        Console.WriteLine(a.GetType());
      }
    }
  }
}



//Overriding Object Members
//The Equals() and ToString() methods in Object are virtual, so they can be overridden.

//For example, we can override ToString() in the Diary class:

class Diary
{
  /* other members omitted */

  public override string ToString()
  {
    return $"This Diary is currently on page {CurrentPage}."; 
  }
}
//Now any Diary instance will use this version of the method:

Diary dy = new Diary(7);
Console.WriteLine(dy.ToString());
// Output: "This Diary is currently on page 7."


//Program.cs

using System;

namespace TheObjectClass
{
  class Program
  {
    static void Main(string[] args)
    {
      Book bk = new Book("Ta-Nehisi Coates", "Between the World and Me");
      Console.WriteLine(bk.ToString());
      
    }
  }
}


//Book.cs

namespace TheObjectClass
{
  class Book
  {
    public string Author
    { get; private set; }
    
    public string Title
    { get; private set; }

    public Book(string author = "Unknown", string title = "Untitled")
    {
      Author = author;
      Title = title;
    }

    public virtual string Stringify()
    {
      return "This is a Book object!";
    }

    public override string ToString()
    {
      return $"Author: {Author}\nTitle: {Title}\n";
      
    }
  }
}
/*
Object in Plain Sight
At the very beginning of your C# journey, you learned about Console.WriteLine(). You used this tool with nearly every type, from int and bool to Dissertation and Diary:

bool b = true;
Diary d = new Diary();
Console.WriteLine(b);
Console.WriteLine(d);
We can use this same tool with every type because every type inherits from Object!

Under the hood, Console.WriteLine() uses ToString(), which is defined in Object. Every object needs some kind of string representation to be printed in text. These two lines are equivalent:

Console.WriteLine(b);
Console.WriteLine(b.ToString());
Instructions
1.
Let’s prove to ourselves that ToString() is used when printing to the console.

First, override the ToString() method in the Diary class. Have the method return the string "Surprise!".

￼
Stuck? Get a hint
2.
Back in Program.cs, construct a Diary object and pass it directly to Console.WriteLine().

You should see your surprise printed!Object in Plain Sight
At the very beginning of your C# journey, you learned about Console.WriteLine(). You used this tool with nearly every type, from int and bool to Dissertation and Diary:

bool b = true;
Diary d = new Diary();
Console.WriteLine(b);
Console.WriteLine(d);
We can use this same tool with every type because every type inherits from Object!

Under the hood, Console.WriteLine() uses ToString(), which is defined in Object. Every object needs some kind of string representation to be printed in text. These two lines are equivalent:

Console.WriteLine(b);
Console.WriteLine(b.ToString());
Instructions
1.
Let’s prove to ourselves that ToString() is used when printing to the console.

First, override the ToString() method in the Diary class. Have the method return the string "Surprise!".

￼
Stuck? Get a hint
2.
Back in Program.cs, construct a Diary object and pass it directly to Console.WriteLine().

You should see your surprise printed!
*/
//Diary.cs

namespace TheObjectClass
{
  class Diary : Book, IFlippable
  {
    public int CurrentPage
    { get; set; }

    public Diary(int page = 0) : base()
    {
      CurrentPage = page;
    }
    
    public Diary(int page, string author, string title) : base(author, title)
    {
      CurrentPage = page;
    }

    public void Flip()
    {
      CurrentPage++;
    }

    public string SpillSecret()
    {
      return "OMG kerry loves kris <3";
    }

    public override string ToString()
    {
      return "Surprise!";
    }

    public override string Stringify() 
    {
      return "This is a Diary object!";
    }
  }
}

//Program.cs

using System;

namespace TheObjectClass
{
  class Program
  {
    static void Main(string[] args)
    {
      Diary d = new Diary();
      Console.WriteLine(d);
    }
  }
}
//Surprise!
//as ...
//Console.WriteLine(d);
//Console.WriteLine(d.ToString());
/*
Review
Good job! In this lesson you learned that:

Every type, eventually, inherits from Object
Object members include Equals(), ToString(), and GetType()
The ToString() method allows Console.WriteLine() to work for all types

Try reading the “Remarks” section of the Object class documentation. It’s a good way to check your understanding.

The last section, “Performance Considerations”, talks about strategies to avoid unnecessary “unboxing” and “boxing”, which you probably know as casting.

You can see the first strategy in action with Console.WriteLine(). In the documentation, you can see that there are multiple versions of the method with different parameter types: some of the more common types like int and string and of course Object.

If you have any trouble finding those three versions, here are direct links:

For int arguments
For string arguments
For Object arguments
Don’t worry too much about the other strategy that uses generics: you aren’t expected to understand it because we haven’t yet covered the concept!

*/

//Review code
//Program.cs

using System;

namespace TheObjectClass
{
  class Program
  {
    static void Main(string[] args)
    {
      Book bk = new Book("Ta-Nehisi Coates", "Between the World and Me");
      Diary dy = new Diary(38);
      Random rand = new Random();
      int i = 9;

      Object[] objects = {bk, dy, rand, i};

      foreach (Object obj in objects)
      {
        Console.WriteLine(obj.GetType());
        Console.WriteLine(obj);
      }

      bool b = true;
      Console.WriteLine(b);
      Console.WriteLine(b.ToString());
    }
  }
}


//Diary.cs

namespace TheObjectClass
{
  class Diary : Book, IFlippable
  {
    public int CurrentPage
    { get; set; }

    public Diary(int page = 0) : base()
    {
      CurrentPage = page;
    }
    
    public Diary(int page, string author, string title) : base(author, title)
    {
      CurrentPage = page;
    }

    public void Flip()
    {
      CurrentPage++;
    }

    public string SpillSecret()
    {
      return "OMG kerry loves kris <3";
    }

    public override string Stringify() 
    {
      return "This is a Diary object!";
    }
    
    public override string ToString()
    {
    	return "Surprise!";
    }
  }
}

//Book.cs

namespace TheObjectClass
{
  class Book
  {
    public string Author
    { get; private set; }
    
    public string Title
    { get; private set; }

    public Book(string author = "Unknown", string title = "Untitled")
    {
      Author = author;
      Title = title;
    }

    public virtual string Stringify()
    {
      return "This is a Book object!";
    }
  	
    public override string ToString()
    {
      return $"This Book is {Title}, by {Author}.";
    }
  }
}

//PART 2 or 3 including reference
//String the exception

/*

Re-introduction to Strings
Previous lessons have stated that all classes are reference types and all “primitive” values are value types.

// Reference type
Object o = new Object();
// Value type
bool b = true;
Do we consider string a reference type or a value type?

Spoiler! Strings are technically reference types. But in action, it’s a bit more complicated. Nearly every C# program uses some strings, so you’ll need to know how it works. This lesson will explain the unique behavior of string references.

By the way: in C#, String and string are equivalent. This just gives us more options when we are coding. It’s convenient for beginners because they usually see string introduced with other primitive value types like int and bool.

Instructions
Look at Program.cs. Can you explain all of this code in terms of references and values?

*/
//A string reference will always point to the original object, so “modifying” one reference to a string will not affect other references
//Comparing strings with the equality operator (==) performs a value, not referential, comparison
using System;

namespace StringTheException
{
  class Program
  {
    static void Main(string[] args)
    {
      // Example 1
      string dog = "chihuahua";
      string tinyDog = dog;
      dog = "dalmation";
      Console.WriteLine(dog);
      // Output: "dalmation"
      Console.WriteLine(tinyDog);
      // Output: "chihuahua"

      // Example 2
      string s1 = "Hello ";
      string s2 = s1;
      s1 += "World";
      System.Console.WriteLine(s1);
      // Output: "Hello World"
      System.Console.WriteLine(s2);
      // Output: "Hello"
    }
  }
}


/*

Strings Can Look Like Values
String, or string, is a class that represents text. Technically its value is stored as a collection of char objects.

Since it is a class, it is a reference type. In some cases its behavior looks like a value type:

A string reference will always point to the original object, so “modifying” one reference to a string will not affect other references
Comparing strings with the equality operator (==) performs a value, not referential, comparison
Here’s are two examples of the first behavior (modifying one reference doesn’t affect the others):

// Example 1
string dog = "chihuahua";
string tinyDog = dog;
dog = "dalmation";
Console.WriteLine(dog);
// Output: "dalmation"
Console.WriteLine(tinyDog);
// Output: "chihuahua"

// Example 2
string s1 = "Hello ";
string s2 = s1;
s1 += "World";
System.Console.WriteLine(s1);
// Output: "Hello World"
System.Console.WriteLine(s2);
// Output: "Hello"
The can be explained by the fact that strings are immutable: they cannot be changed after they are created. Anything that appears to modify a string actually returns a new string object.

Here’s an example of the second behavior (value-like comparisons):

string s = "hello";
string t = "hello";
// b is true
bool b = (s == t);
Typically we want to compare strings by value, so this makes it easier to write in code and it also gives the C# compiler flexibility in how it implements the program (it doesn’t have to worry about where the actual string value is stored).
1.
Create two string variables with the same value: "immutable".

2.
Compare the two variables using == and print the result.

Why does this return true?

3.
Now repeat the process with two Object variables:

Construct two new Object instances and store them in two new variables
Compare them with ==
Make sure to call new Object() twice. Why are the results different?
*/

//
using System;

namespace StringTheException
{
  class Program
  {
    static void Main(string[] args)
    {
      string a = "immutable";
      string b = "immutable";
      Console.WriteLine(a == b);
      //True as value comparision
      Object c = new Object();
      Object d = new Object();
      Console.WriteLine(c == d);
      //False as reference comparison;
    }
  }
}

/*
Strings can be Null or Empty or Unassigned
Like other reference types, string references can be null or unassigned. They can also have a third value: empty.

// Unassigned
string s;
// Null
string s2 = null;
// Empty string
string s3 = "";
// Also empty string
string s4 = String.Empty;
// This prints true
Console.WriteLine(s3 == s4);
All of these signify a lack of text, but they each mean something slightly different:

unassigned means that the programmer did not give the variable any value
null means that the programmer intentionally made the variable refer to no object
an empty string signifies a piece of text with zero characters. This is often used to represent a blank text field. It can be represented by "" or String.Empty
The Microsoft Programming Guide suggests using String.Empty or "" instead of null to avoid NullReferenceException errors.

We can check for null OR empty strings using the static String method IsNullOrEmpty(). It’s explained in more detail in the documentation.

1.
Using Console.Write() and Console.ReadLine(), ask the user for input and capture it in a variable.

2.
Write an if-else statement that checks for a null or empty string. If it is null, print out the message:

"You didn't enter anything!"
Otherwise, print out the message:

"Thank you for your submission!"

3.
Run the program using dotnet run.

What happens when you enter no text and hit Enter?
*/

using System;

namespace StringTheException
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please, squire give us some input?");
      string input = Console.ReadLine();
      if (!String.IsNullOrEmpty(input))
      {
        Console.WriteLine("Thank you for your submission!");
      } else {
        Console.WriteLine("You didn't enter anything!");
      }
    }
  }
}

// You didn't enter anything!

/*

String as Class
We can prove that String is a class by looking up the String class documentation and trying some of the methods and properties listed there.

This example uses Length and Contains().

string s = "Hello World";
Console.WriteLine(s.Length);
Console.WriteLine(s.Contains("o"));
We’ve already seen one static property Empty and one static method, IsNullOrEmpty():

string s = String.Empty;
bool isEmpty = String.IsNullOrEmpty(s);

1.
Let’s practice using Replace(String, String), which returns a new string with every instance of the first argument replaced by the second.

Replace all instances of "ollie" with "ana".

If you’re unfamiliar with Replace(), the documentation is your best friend.

*/

//
using System;

namespace StringTheException
{
  class Program
  {
    static void Main(string[] args)
    {
      string lyrics = 
        "Dollie, Dollie, bo-bollie,\n" +
        "Banana-fana fo-follie\n" +
        "Fee-fi-mo-mollie\n" +
        "Dollie!";
      
      // Call `Replace()` here
      lyrics = lyrics.Replace("ollie", "ana");
      
      Console.WriteLine(lyrics);
    }
  }
}

/*
Review
Well done, you’re a reference master now!

The concept of references, especially the nuances of the string type, can be difficult to understand when they aren’t clearly visible in the code. Let the information sink in and play with some code to check your understanding. Once you get it, this concept will save you dozens of hours of debugging.

Here’s what was covered in this lesson:

The String or string type is a reference type
Strings are immutable, which means they cannot be changed after they are created
Being immutable also means that a string reference will always point to the original object, so “modifying” one reference to a string will not affect other references to it
With the equality operator (==), strings are checked for value, not referential, equality
A string variable can be unassigned, null, or empty. Empty strings can be represented by String.Empty or "" — they’re equivalent
Instructions
If you’d like to read more about the String operations and methods, the documentation has you covered. We don’t expect you to know anymore than what was covered in this lesson, but it’s here if you’re interested!
*/
