/*
What do you think will be printed by this code?

Dissertation diss1 = new Dissertation();
Dissertation diss2 = diss1;
diss1.CurrentPage = 0;
diss2.CurrentPage = 16;
Console.WriteLine(diss1.CurrentPage);
Console.WriteLine(diss2.CurrentPage);
Did you guess 0 and 16? The answer is 16 and 16!

To understand what’s happening here, we need to understand references. They might not be obvious in this code, but learning how to use them unlocks a whole new set of superpowers in C#. This lesson explains:

How references work in C#
Why references are useful
How to upcast a reference
How to create a null reference
Instructions
This lesson uses the Book, Dissertation, and Diary classes and the IFlippable interface. Look through each file to get acquainted.

IFlippable is the interface
Book is the base class
Dissertation and Diary are classes that extend the base class and implement the interface
￼

If you need to refresh yourself with interfaces and inheritance, take the C# Interfaces and Inheritance lessons.
*/

/*
References of the Same Type
Classes are reference types. That means that when we create a new instance of a class and store it in a variable, the variable is a reference to the object.

Let’s see what’s happening behind the scenes. When this code is run:

Dissertation diss1 = new Dissertation();
A new Dissertation instance is constructed and stored in the computer’s memory. You can imagine a slot in your computer holding the instance’s type, property values, etc. diss1 is a reference to that location in memory.

￼

diss1 is not the actual object, it is a reference to the object. Thus an object can have multiple references:

Dissertation diss1 = new Dissertation();
Dissertation diss2 = diss1;
￼

Now there are two references to the same location in memory: we can say that diss1 and diss2 refer to the same object. If changes are made to that object, then they will be reflected in both references to it:

Dissertation diss1 = new Dissertation();
Dissertation diss2 = diss1;
diss1.CurrentPage = 0;
diss2.CurrentPage = 16;
Console.WriteLine(diss1.CurrentPage);
Console.WriteLine(diss2.CurrentPage);
The middle two lines of this code are setting the CurrentPage property of the same object (first setting it to 0, then 16)
The last two lines will print the same value, 16
You can imagine references like directions to a house: they tell you where to find the house, but they are not the house itself!
*/

using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      Diary dy1 = new Diary(5);
      Diary dy2 = dy1;
      dy2.Flip();//++ to parameter above
      Console.Write($"{dy1.CurrentPage}\n{dy2.CurrentPage}\n");
    }
  }
}

//6
//6

/*

References vs. Values
To better grasp the idea of reference types, let’s look at the other kind of type: value types. While reference-type variables refer to a place in memory, value-type variables hold the actual data.

int is a value type, so the variable num holds the value 6:

int num = 6;
Reference types, on the other hand, refer to a location in memory. Every class is a reference type, so the variable diss refers to a location in memory that has the Dissertation object:

Dissertation diss = new Dissertation(50);
Every “primitive” data type is a value type, including:

int
double
bool
char
Revisiting our metaphor: a reference is like directions to a house, which “points” to a house. It isn’t the actual house. A value type is the house itself!

You might have noticed that string is missing here. It works a bit differently, so it will be covered in a later lesson.
*/

//

using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      Book bookLocation = new Book();//reference
      Book sameBookLocation = bookLocation;//same reference
      bool falseValue = false;//value
      bool anotherFalseValue = falseValue;//reference to value
    }
  }
}
/*

Narrative
Learn
REFERENCE FUNDAMENTALS
Reference vs. Value Comparison
When we compare value types with ==, the C# compiler performs a value comparison. For example, this prints true because the value 6 is equal to the value 6:

int int1 = 6;
int int2 = 6;
Console.WriteLine(int1 == int2);
// Output: true
int1 and int2 are the actual value 6. When we compare the value 6 with 6, they’re the same!

When we compare reference types with ==, the C# compiler performs a referential comparison, which means it checks if two variables refer to the same memory location. For example, this prints false because d1 and d2 refer to two different locations in memory (even though they contain objects with the same values):

Dissertation d1 = new Dissertation(50);
Dissertation d2 = new Dissertation(50);
Console.WriteLine(d1 == d2);
// Output: false
We constructed two different Dissertation objects which happened to have the same values. Each reference (d1 and d2) point to different objects, so they are not equal.

*/

/*

Reference vs. Value Comparison
When we compare value types with ==, the C# compiler performs a value comparison. For example, this prints true because the value 6 is equal to the value 6:

int int1 = 6;
int int2 = 6;
Console.WriteLine(int1 == int2);
// Output: true
int1 and int2 are the actual value 6. When we compare the value 6 with 6, they’re the same!

When we compare reference types with ==, the C# compiler performs a referential comparison, which means it checks if two variables refer to the same memory location. For example, this prints false because d1 and d2 refer to two different locations in memory (even though they contain objects with the same values):

Dissertation d1 = new Dissertation(50);
Dissertation d2 = new Dissertation(50);
Console.WriteLine(d1 == d2);
// Output: false
We constructed two different Dissertation objects which happened to have the same values. Each reference (d1 and d2) point to different objects, so they are not equal.

*/

//However
using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      Book b1 = new Book();
      Book b2 = b1;
      Console.WriteLine(b1 == b2);
    }
  }
}
//True as same references to where object value is stored

/*
References of Different Types
Before going any further, let’s remind ourselves that Dissertation implements IFlippable, which has the CurrentPage property and Flip() method. You’ll need this info in a minute.

In our previous example both references to the Dissertation object were of type Dissertation:

Dissertation diss1 = new Dissertation();
Dissertation diss2 = diss1;
Whenever we use diss1 and diss2 we can handle the Dissertation object as if it were a Dissertation type. Since Dissertation also implements the IFlippable interface, we can reference it that way too:

Dissertation diss = new Dissertation(50);
IFlippable fdiss = diss;
Now diss and fdiss refer to the same object, but fdiss is an IFlippable reference, so it can ONLY use IFlippable functionality:

diss.Flip();
fdiss.Flip();
Console.WriteLine(diss.Define());
// This causes an error!
Console.WriteLine(fdiss.Define());
This last line causes an error because Define() is not a method in the IFlippable interface. The other lines do NOT cause errors because they use members that both IFlippable and Dissertation have.

This rule also applies to base classes too, so we can refer to a Dissertation object as Book.

Dissertation diss = new Dissertation(50);
Book bdiss = diss;
Console.WriteLine(diss.Title);
Console.WriteLine(bdiss.Title);
diss.Define();
// This causes an error!
bdiss.Define();
Title is defined for Book, so no error is thrown there. Define(), however, is not defined for the Book class, so we can’t use it with Book references.
*/

//Program.cs

using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      Dissertation diss = new Dissertation();
			IFlippable fdiss = diss;
      Book bdiss = diss;
			fdiss.CurrentPage = 42;
      //bdiss.CurrentPage = 43;
      //fdiss.Stringify();
      bdiss.Stringify();
      Console.WriteLine(fdiss == bdiss);
    }
  }
}


//Book.cs

namespace LearnReferences
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
  }
}

//IFlippable.cs

namespace LearnReferences
{
  interface IFlippable
  {
    int CurrentPage { get; set; }
    void Flip();
  }
}

/*
Arrays of References
We know that we can use inherited classes and implemented interfaces to reference an object:

Dissertation diss = new Dissertation(50);
IFlippable fdiss = diss;
This allows to work with many similar types at the same time. Imagine if we didn’t have this feature and we had to “flip” a group of Diary and Dissertation types:

Diary dy1 = new Diary(1);
Diary dy2 = new Diary(30);
Dissertation diss1 = new Dissertation(50);
Dissertation diss2 = new Dissertation(49);
dy1.Flip();
dy2.Flip();
diss1.Flip();
diss2.Flip();
Look at all that code! It would be faster and safer if we could store the references in an array and loop through it. But would it be an array of Diary[] or an array of Dissertation[] or something else? Since both dissertations and diaries are flippable (they both implement the IFlippable interface), we can create references to them as IFlippables:

IFlippable f1 = new Diary(1);
IFlippable f2 = new Diary(30);
IFlippable f3 = new Dissertation(50);
IFlippable f4 = new Dissertation(49);
Instead of dealing with individual variables, we can use an array of IFlippable references:

IFlippable[] classroom = new IFlippable[] { new Diary(1), new Diary(30), new Dissertation(50), new Dissertation(49) };
Then to “flip” each element, we can write a foreach loop:

foreach (IFlippable f in classroom) 
{
  f.Flip();
}
We can only access the functionality defined in the interface. For example, we couldn’t access f.Title because Title isn’t a property defined in IFlippable.

Create a variable books of type Book[] that contains diss1, diss2, dy1, and dy2.

Checkpoint 2 Passed
￼
Stuck? Get a hint
2.
Make an empty foreach loop that loops through each element in the array.

Checkpoint 3 Passed
￼
Stuck? Get a hint
3.
In the body of the loop
*/

//
using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      Dissertation diss1 = new Dissertation(32, "Anna Knowles-Smith", "Refugees and Theatre");
			Dissertation diss2 = new Dissertation(19, "Lajos Kossuth", "Shiny Happy People");
			Diary dy1 = new Diary(48, "Anne Frank", "The Diary of a Young Girl");
			Diary dy2 = new Diary(23, "Lili Elbe", "Man into Woman");
			Book[] books = new Book[] {diss1, diss2, dy1, dy2};
      
      foreach (Book book in books)
      {
        Console.WriteLine(book.Title);
      }
    }
  }
}

/*
Polymorphism
We just saw how useful it is to have the same interface for multiple data types. This is a common concept across many programming languages, and it’s called polymorphism.

The concept really includes two related ideas. A programming language supports polymorphism if:

Objects of different types have a common interface (interface in the general meaning, not just a C# interface), and
The objects can maintain functionality unique to their data type
Let’s prove to ourselves that this is true in C#. We’ll use the example of Stringify: Dissertation and Book have different Stringify() methods but can both be referenced as Books.

Here are snippets from each class:

class Dissertation : Book
{
  public override string Stringify()
  {
    return "This is a Dissertation object!";
  }
}


class Book
{
  public virtual string Stringify()
  {
    return "This is a Book object!";
  }
}
Given that information, what will the below program print?

Book bk = new Book();
Book bdiss = new Dissertation();
Console.WriteLine(bk.Stringify());
Console.WriteLine(bdiss.Stringify());
The answer is:

This is a Book object!
This is a Dissertation object!
Even though bk and bdiss are both Book type references, their behavior is different. Dissertation overrides the Stringify() method, so all Dissertation objects (regardless of reference type) will use that method.

Therefore, C# support polymorphism!

You’ll never have to write polymorphism in your code, but this vocabulary is essential to communicating with other developers!

So remember: polymorphism is the ability in programming to present the same interface for differing data types.
*/

//Program.cs

using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      Book b1 = new Book();
      Book b2 = new Diary();
      Console.WriteLine(b1.Stringify());
      Console.WriteLine(b2.Stringify());
    }
  }
}


//Books.cs

namespace LearnReferences
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
  }
}

//Diary.cs

namespace LearnReferences
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
  }
}

/*

Casting
So far we’ve referred to objects with a reference of their own type, an inherited type, or an implemented interface:

Dissertation diss = new Dissertation();
Book bdiss = diss;
IFlippable fdiss = diss;
The process is called upcasting. As we saw in the last exercise upcasting allows us to work with multiple types at once. It also lets us safely store an object without knowing its specific type. You can think of upcasting as using a reference “up” the inheritance hierarchy:

￼

What happens if you try to downcast, or reference an object by a subclass? You’ll need to do this when you want to access the specific functionality of a subclass.

For example what happens when we refer to a Book object as a Dissertation type?

Book bk = new Book();
Dissertation dbk = bk;
// Error!
The code produces this error:

error CS0266: Cannot implicitly convert type `Book` to `Dissertation`. An explicit conversion exists (are you missing a cast?)
Not every downcast is possible in C#. In this case, Dissertation has a Define() method that is incompatible with Book. This is the computer’s way of telling you: there’s a chance that this cast won’t work!

To get around this error, we must explicitly downcast, like below. The desired type is written in parentheses:

Book bk = new Book();
Dissertation bdk = (Book)bk;
This essentially tells the computer: “I know the risk I’m taking, and this might fail if I’m not careful.”

In many cases, the downcast will still fail. Here, Book can’t reference a Dissertation object, so when we run explicitly downcast we see that it fails with a new error message:

System.InvalidCastException: Specified cast is not valid.
There are multiple ways to deal with downcasting, including the as and is operators. We won’t get into those now, but you can learn about them in the Microsoft C# Programming Guide: Casting and type conversions if you’d like. For now, focus on these things:

Upcasting is creating a superclass or interface reference from a subclass reference
Downcasting is creating a subclass reference from a superclass or interface reference.
Upcasting can be done implicitly, while downcasting cannot

Upcasting is creating a superclass or interface reference from a subclass reference
Downcasting is creating a subclass reference from a superclass or interface reference.
Upcasting can be done implicitly, while downcasting cannot
*/

//downcast must be explicit

class Animal
{
  public virtual string Describe()
  { return "Here's an animal"; }
}

class Amphibian : Animal
{
  public override string Describe()
  { return "Here's an amphibian"; }
}

class Program {
  public static void Main (string[] args) {
    Amphibian amp = new Animal();
    Console.WriteLine(amp.Describe());
  }
}
//throws error as should be ...

Amphibian amp = (Amphibian) new Animal();

//
using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
			Dissertation diss = new Dissertation();
      Diary dy = new Diary();
      /*
      Book bdiss = (Book)diss;
      Book bdy = (Book)dy;
      */
      Book bdiss = diss;
      Book bdy = dy;
    }
  }
}

/*
REFERENCE FUNDAMENTALS
Null and Unassigned References
So far we’ve seen:

A reference to an object
Multiple references to an object
What about a reference that refers to no object? In C# a reference to no object is called either a null reference or unassigned. We’ll need to apply these concepts in C# whenever we want to show that a reference is “missing”, create a reference variable without defining it, or initialize an empty array.

In the first use case, we’d like to create a reference that is “missing” or empty. We set it equal to the keyword null:

Diary dy = null;
In the second case, if we create a reference variable without a value, it is unassigned:

Diary dy;
// dy is unassigned
In the third case, if we create an empty array of reference types, each element is an unassigned reference:

Diary[] diaries = new Diary[5];
// diaries[1] is unassigned, diaries[2] is unassigned, etc.
Be careful when checking for null and unassigned references. We can only compare a null reference if it is explicitly labeled null:

Diary dy = null;
Console.WriteLine(dy == null);
// Output: true
For the other two cases, comparing an unassigned variable we’ll get an error:

Object o;
Console.WriteLine (o == null);
// error CS0165: Use of unassigned local variable 'o'
This might seem annoying at first, but it’s actually a good thing: the C# compiler prevents future issues down the road by raising an error the first time an unassigned variable is used.
*/

//

using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      Book toAdd = null;
      Console.WriteLine(toAdd);
      Console.WriteLine(toAdd == null);
    }
  }
}

/*
Review
You made it! References aren’t always easy, but learning how to use them unlocks a whole new set of superpowers in C#.

In this lesson you learned that:

Classes and interfaces are reference types. A variable of this type holds a reference to the data, not the data itself. This is different from value types like int and bool
The equality operator (==) uses a referential comparison for reference types and a value comparison for value types
Multiple references can be created for a single object
A reference and its corresponding object do not have to be the same type. For example, we can refer to a subclass object by an inherited superclass or implemented interface reference
The functionality available to an object reference is determined by the reference’s type, not the object’s type
Polymorphism is the ability in programming to present the same interface for differing data types
Referencing an object by an inherited type or implemented interface is called upcasting. It can be done implicitly
Referencing an object by a derived class is called downcasting, which must be made explicit by adding the type name in parentheses. It may cause an InvalidCastException error when the code is run
To signify that a reference is “empty” or refers to no object, we set it equal to null
If a reference is not set to any value it is unassigned and cannot perform any operations
Instructions
In Program.cs, there are two lines that are commented out:

f.Define();
bdiss3.Define();
Before you move on, make sure you can explain why each of them cause an error.#
*/

