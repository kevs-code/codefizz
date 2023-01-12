/*To begin defining a class, C# uses this structure:

class Forest {
}
The code for a class is usually put into a file of its own, named with the name of the class. In this case it’s Forest.cs. This keeps our code organized and easy to debug.

In other parts of code, like Main() in Program.cs, we can use the class. We make instances, or objects, of the Forest class with the new keyword:

Forest f = new Forest();
We could say f is an instance of the Forest class, or f is of type Forest.

The process of creating an instance is called instantiation. Today we instantiate a class; yesterday they instantiated a class, and so on.
*/
//Forest.cs
using System;

namespace BasicClasses
{
  class Forest {
  }
}
//Program.cs
using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
    }
  }
}

//getters and setters
/*
Properties
As of now, a program can plant any value in a Forest field. For example, if we had an area field of type int, we could set it to 0, 40, or -1249. Can we have a forest of -1249 area? We need a way to define what values are valid and disallow those that are not. C# provides a tool for that: properties.

Properties are another type of class member. Each property is like a spokesperson for a field: it controls the access (getting and setting) to that field. We can use this to validate values before they are set to a field. A property is made up of two methods:

a get() method, or getter: called when the property is accessed
a set() method, or setter: called when the property is assigned a value
This shows a basic Area property without validation:

public int area;
public int Area
{
  get { return area; }
  set { area = value; }
}
The Area property is associated with the area field. It’s common to name a property with the title-cased version of its field’s name, e.g. age and Age, name and Name.

The set() method above uses the keyword value, which represents the value we assign to the property. Back in Program.cs, when we access the Age property, the get() and set() methods are called:

Forest f = new Forest();
f.Area = -1; // set() is called
Console.WriteLine(f.Area); // get() is called; prints -1
In the above example, when set() is called, the value variable is -1, so area is set to -1.

Here’s the same property with validation in the set() method. If we try to set Area to a negative value, it will be changed to 0.

public int Area
{
  get { return area; }
  set 
  { 
    if (value < 0) { area = 0; }
    else { area = value; }
  }
}
In Program.cs:

Forest f = new Forest();
// set() is called
f.Area = -1; 
// get() is called; prints 0
Console.WriteLine(f.Area);
*/
//get and set exercise

using System;

namespace BasicClasses
{
  class Forest
  {
    public string name;
    public string Name
    {
      get { return name; }
      set { name = value; }
    }
    public int trees;
    public int Trees
    {
      get { return trees; }
      set { trees = value; }
    }
    public int age;
    public string biome;
    public string Biome
    {
      get { return biome; }
      set {
        if (value == "Tropical" || value == "Temperate" || value == "Boreal") { 
        biome = value;
        } else {
          biome = "Unknown";
        } 
      }
    }
  }
}
//automatic properties

/*
Automatic Properties
It might have felt tedious to write the same getter and setter for the Name and Trees properties. C# has a solution for that! The basic getter and setter pattern is so common that there is a short-hand called an automatic property. As a reminder, here’s the basic pattern for an imaginary size property:
*/
public string size;
public string Size
{
  get { return size; }
  set { size = value; }
}
//This pattern can be written as an automatic property:

public string Size
{ get; set; }
//In this form, you don’t have to write out the get() and set() methods, and you don’t have to define a size field at all! A hidden field is defined in the background for us. All we have to worry about is the Size property.
//exercise refactor

using System;

namespace BasicClasses
{
  class Forest
  {
    //removed lowercase fields for automatic properties
    //lowercase call no longer available
    public int age;
    public string biome;
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
  }

}

//setting lowercase field to private brings us to ...
/*
Public vs. Private
At this point we have built fields to associate data with a class and properties to control the getting and setting of each field. As it is now, any code outside of the Forest class can “sneak past” our properties by directly accessing the field:

f.Age = 32; // using property
f.age = -1; // using field
The second line avoids the property’s validation by directly accessing the field. We can fix this by using the access modifiers public and private:

public — a public member can be accessed by any class
private — a private member can only be accessed by code in the same class
For simplicity, we’ve been adding public to every member so far. That allows code to access the members from the Main() method, which doesn’t belong to the Forest class. When we switch a field from public to private it will no longer be accessible from Main(), although code inside the Forest class — like properties — can still access it.

Access modifiers can be applied to all members of a class, including fields, properties, and the rest of the members covered in this lesson.

Remember encapsulation? public and private are necessary to encapsulate our classes. Think of it like “defensive coding”: you are protecting the inner mechanisms of a class with private so that other code can’t break your class. You only expose what you want to be public.

For example, since a class’ properties define how other programs get and set its fields, it’s good practice to make fields private and properties public.

C# encourages encapsulation by defaulting class members to private and classes to public.

.
Currently the biome field and Biome property are public. In Program.cs, the field is directly accessed and set to "Desert", an invalid value.

Run the code to see that “Desert” is the field’s value.

Checkpoint 2 Passed
2.
By directly accessing the public biome field the code skipped the validation. Let’s prevent that by setting the biome field to private in Forest.cs.

When you run the code, you should see the error:

error CS0122: 'Forest.biome' is inaccessible due to its protection level
That means C# has prevented us from accessing a private field (which is good).

Checkpoint 3 Passed
￼
Stuck? Get a hint
3.
Address the error by changing the code in Program.cs: use the property (Biome) instead of the field (biome). You’ll need to change code in two places in the file.

What is printed to the console now?

*/
//Program.cs
using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.Name = "Congo";
      f.Trees = 0;
      f.age = 0;
      f.Biome = "Desert";
      
      Console.WriteLine(f.Name);
      Console.WriteLine(f.Biome);
    }
  }
}
//Forest.cs
using System;

namespace BasicClasses
{
  class Forest
  {
    public int age;
    private string biome;
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
  }

}

/*
BASIC CLASSES AND OBJECTS
Get-Only Properties
Previously we used properties for field validation. By applying public and private, we can also use properties to control access to fields.

Recall our imaginary Area property. Say we want programs to get the value of the property, but we don’t want programs to set the value of the property. Then we either:

don’t include a set() method, or
make the set() method private.
This shows approach 1 — don’t include a set():

public string Area
{
  get { return area; }
}
We can still get Area, but if we try to set Area we get an error:

error CS0200: Property or indexer 'Forest.Area' cannot be assigned to (it is read-only)
This shows approach 2 — make set() private:

public int Area
{
  get { return area; }
  private set { area = value; }  
}
We can still get Area, but if we try to set Area in Main() we get an error:

error CS0272: The property or indexer 'Forest.Area' cannot be used in this context because the set accessor is inaccessible
Notice that in approach 1 we get an error for setting Area anywhere. In approach 2 we only get an error for setting Area outside of the Forest class. Generally we prefer approach 2 because it allows other Forest methods to set Area.
*/
//Program.cs

using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.Name = "Congo";
      f.Trees = 0;
      f.age = 0;
      f.Biome = "Desert";
      
      Console.WriteLine(f.Name);
      Console.WriteLine(f.Biome);
    }
  }
}

//Forest.cs

using System;

namespace BasicClasses
{
  class Forest
  {
    public int age;
    private string biome;
    
    public int Age
    {
      get { return age; }
      private set { age = value; }
    }

    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    
  }

}

//Methods

//This code defines a method IncreaseArea() that changes the value of the Area property:

class Forest {
  public int Area
  { /* property body omitted */  }
  public int IncreaseArea(int growth)
  {
    Area = Area + growth;
    return Area;
  }
}
//You would call the method like so:

Forest f = new Forest();
int result = f.IncreaseArea(2);
Console.WriteLine(result); // Prints 2

//exercise

//Forest.cs

using System;

namespace BasicClasses
{
  class Forest
  {
    public int age;
    private string biome;
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }

    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }

    public int Burn()
    {
      Trees -= 20;
      Age++;
      return Trees;
    }
    
  }
}

//Program.cs

using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.Name = "Congo";
      f.Trees = 0;
      f.Biome = "Desert";
      
      Console.WriteLine(f.Name);
      Console.WriteLine(f.Biome);
    }
  }
}

//Constructors

//In each of the examples so far, we created a new Forest object and set the property values one by one. It would be nice if we could write a method that’s run every time an object is created to set those values at once.

//C# has a special type of method, called a constructor, that does just that. It looks like a method, but there is no return type listed and the method name is the name of its enclosing class:

class Forest 
{
  public Forest()
  {
  }
}
//We can add code in the constructor to set values to fields:

class Forest
{
  public int Area;

  public Forest(int area)
  {
    Area = area;
  }
}
//This constructor method is used whenever we instantiate an object with the new keyword:

 // Constructor is called here
Forest f = new Forest(400);
//But we’ve been instantiating new objects all day! Why did it work before we defined a constructor?

//If no constructor is defined in a class, one is automatically created for us. It takes no parameters, so it’s called a parameterless constructor. That’s why we have been able to instantiate new objects without errors:

Forest f = new Forest();

/*

Define a constructor for the Forest class. It should have two parameters:

name, which sets the Name property
biome, which sets the Biome property
It should also set the value of Age to 0.

Checkpoint 2 Passed
￼
Stuck? Get a hint
2.
The code in Program.cs has been commented out. Un-comment it and run it.

You should see an error:

error CS7036: There is no argument given that corresponds to the required formal parameter 'name' of 'Forest.Forest(string, string)' 
This error occurs because you are using the parameterless constructor Forest() in Program.cs. This no longer works because a constructor Forest(string, string) has been defined.

Checkpoint 3 Passed
3.
Call the new constructor in Main() to create a Forest object with the name “Congo” and biome “Tropical”.

Delete the lines:

f.Name = "Congo";
and

f.Biome = "Desert";
They’re no longer useful because those properties are now set in the constructor!
*/

//Forest.cs
using System;

namespace BasicClasses
{
  class Forest
  {
    public int age;
    private string biome;
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }
    
    public Forest(string name, string biome)
    {
      Name = name;
      Biome = biome;
      Age = 0;
    }

    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
    
  }

}
//Program.cs
using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Congo", "Tropcal");

      f.Trees = 0;

      
      Console.WriteLine(f.Name);
      Console.WriteLine(f.Biome);
    }
  }
}

//this

this
//In the last exercise we assigned the area field in the constructor:

class Forest
{
  public int Area
  { /* property omitted */ }

  public Forest(int area)
  {
    Area = area;
  }
}
//The parameter for the constructor area looks a lot like the old field area and the new property Area. It’s good to be explicit when writing code so that there is no room for misinterpretation. We can refer to the current instance of a class with the this keyword.

class Forest
{
  public int Area
  { /* property omitted */ }

  public Forest(int area)
  {
    this.Area = area;
  }
}
//Forest.cs
using System;

namespace BasicClasses
{
  class Forest
  {
    public int age;
    private string biome;
    
    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
    }
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }
     
    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
    
  }

}

/*
Overloading Constructors
Just like other methods, constructors can be overloaded. For example, we may want to define an additional constructor that takes one argument:
*/
public Forest(int area, string country)
{ 
  this.Area = area;
  this.Country = country;
 }

public Forest(int area)
{ 
  this.Area = area;
  this.Country = "Unknown";
}
//The first constructor provides values for both fields, and the second gives a default value when the country is not provided. Now you can create a Forest instance in two ways:

Forest f = new Forest(800, "Africa");
Forest f2 = new Forest(400);
//Notice how we’ve written duplicate code for our second constructor: this.Area = area;. Later on, if we need to adjust the constructor, we’ll need to find every copy of the code and make the exact same change. That means more work and chances for errors.

//We have two options to resolve this. In either case we will remove the duplicated code:

//Use default arguments. This is useful if you are using C# 4.0 or later (which is fairly common) and the only difference between constructors is default values.
public Forest(int area, string country = "Unknown")
{
  this.Area = area;
  this.Country = country;
}
//2. Use : this(), which refers to another constructor in the same class. This is useful for old C# programs (before 4.0) and when your second constructor has additional functionality. This example has an additional functionality of announcing the default value.

public Forest(int area, string country)
{ 
  this.Area = area;
  this.Country = country;
}

public Forest(int area) : this(country, "Unknown")
{ 
  Console.WriteLine("Country property not specified. Value defaulted to 'Unknown'.");
}
//Remember that this.Area refers to the current instance of a class. When we use this() like a method, it refers to another constructor in the current class. In this example, the second constructor calls this() — which refers to the first Forest() constructor — AND it prints information to the console.

//Program.cs
using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      //Forest f = new Forest("Congo", "Tropical");
      //f.Trees = 0;
      Forest fe = new Forest("Rendlesham");
      Console.WriteLine(fe.Biome);
      //Console.WriteLine(f.Name);
      //Console.WriteLine(f.Biome);
    }
  }
}

//Forest.cs
using System;

namespace BasicClasses
{
  class Forest
  {
    public int age;
    private string biome;
    
    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
    }
    
    public Forest(string name) : this(name, "Unknown")
    {
      Console.WriteLine("Name property not specified. Value defaulted to 'Unknown'.");
    }

    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }
     
    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
    
  }

}

//review

/*
Review
Congrats! You’ve finished a lot of content and some of the most important concepts in C#. When someone asks you, “How do I make a custom data type in C#?” you can talk all about it! In this lesson, you learned how to:

Define a class
Instantiate an object using new
Define fields, the pieces of data for each class
Define properties, the spokespeople for each field
Define automatic properties, the shorthand for making properties
Define methods, the actions a class can take
Define constructors, the special methods called when a class is instantiated
Overload constructors and reuse code with this
Control access to class members using public and private
Instructions
1.
Try out your complete Forest class in Main()!

Instantiate a new object with the name "Amazon". Store the result in a variable.
Print the Trees property to the console.
Call the Grow() method.
Print the Trees property again to the console to confirm that the Grow() method works.
*/
//review code
//Program.cs

using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Amazon");
      Console.WriteLine(f.Trees);
      f.Grow();
      Console.WriteLine(f.Trees);
    }
  }
}

//
lass Program {
  public static void Main (string[] args) {
    Player p = new Player();
  }
}

class Player
{
  public Player(string name)
  {
    Console.WriteLine($"Player named: {name}");
  }

  public Player() : this("n/a")
  {}
}
//"Player named: n/a"

/*
Static Fields and Properties
You already know how to create a field and property, like:

class Forest
{
  private string definition;
  public string Definition
  {
     get { return definition; }
     set { definition = value; }
   }
}
The definition of what a forest is applies to all Forest objects, not just one — there should only be one value for the whole class. This is a good use case for a static field/property.

To make a static field and property, just add static after the access modifier (public or private).

class Forest
{
  private static string definition;
  public static string Definition
  { 
    get { return definition; }
    set { definition = value; }
  }
}
Remember that static means “associated with the class, not an instance”. Thus any static member is accessed from the class, not an instance:

static void Main(string[] args)
{
  Console.WriteLine(Forest.Definition);
}
If you tried to access a static member from an instance (like f.Definition) you would get an error like:

error CS0176: Static member 'Forest.Definition' cannot be accessed with an instance reference, qualify it with a type name instead
Instructions
1.
In the previous exercise we mentioned storing the count of all Forest objects. We’ll use a static field and property to store that. Define a private static field named forestsCreated.
*/

//Forests.cs == handy_class_template.cs

using System;

namespace StaticMembers
{
  class Forest
  {
    // FIELDS
    private static int forestsCreated;
    public int age;
    private string biome;
    
    // CONSTRUCTORS
    
    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
      ForestsCreated++;
    }
    
    public Forest(string name) : this(name, "Unknown")
    { }
    
    // PROPERTIES
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }
    
    public static int ForestsCreated
    {
      get { return forestsCreated; }
      private set { forestsCreated = value; }
    }

    // METHODS
     
    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
    
  }

}

//Program.cs

using System;

namespace StaticMembers
{
  class Program
  {
    static void Main(string[] args)
    {
      
    }
  }
}

//static methods cannot access instance members only other static members ...

//Static Methods
//You already know how to create an instance method, like:

class Forest
{
  private string definition;
  public void Define()    
  {
    Console.WriteLine(definition);
  }
}
//This behavior (printing a general definition) isn’t specific to any one instance — it applies to the class itself, so it should be made static.

//To make a static method, just add static after the access modifier (public or private).

class Forest
{
  private static string definition;
  public static void Define()
  { 
    Console.WriteLine(definition); 
  }
}
//Notice that we made added static to both the field definition and method Define().

//This is because a static method can only access other static members. It cannot access instance members:

class Forest
{
  private string definition;
  public static void Define()
  { 
    // Throws error because definition is not static
    Console.WriteLine(definition); 
  }
}
//Otherwise, static methods work like any other method.

//exercise

using System;

namespace StaticMembers
{
  class Forest
  {
    // FIELDS
    
    public int age;
    private string biome;
    private static int forestsCreated;
    private static string treeFacts;

    // CONSTRUCTORS
    
    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
      ForestsCreated++;
    }
    
    public Forest(string name) : this(name, "Unknown")
    { }
    
    // PROPERTIES
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }
    
    public static int ForestsCreated
    {
      get { return forestsCreated; }
      private set { forestsCreated = value; }
    }
    
    public static string TreeFacts
    {
      get { return treeFacts; }
    }
    // METHODS
     
    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
    
    public static void PrintTreeFacts()
    {
      Console.WriteLine(TreeFacts);
    }
  }

}

//now assign a value to TreeFacts with a static constructor

//Static Constructors
//An instance constructor is run before an instance is used, and a static constructor is run once before a class is used:

class Forest 
{
  static Forest()
  { /* ... */ }
}
//This constructor is run when either one of these events occurs:

//Before an object is made from the type.
//Before a static member is accessed.
//In other words, if this was the first line in Main(), a static constructor for Forest would be run:

Forest f  = new Forest();
//It would also be run if this was the first line in Main():

Forest.Define();
//Typically we use static constructors to set values to static fields and properties.

//A static constructor does not accept an access modifier.

using System;

namespace StaticMembers
{
  class Forest
  {
    // FIELDS
    
    public int age;
    private string biome;
    private static int forestsCreated;
    private static string treeFacts;
    
    // CONSTRUCTORS
    
    static Forest()
    {
      treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
      ForestsCreated = 0;
    }

    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
      ForestsCreated++;
    }
    
    public Forest(string name) : this(name, "Unknown")
    { }
    
    
    // PROPERTIES
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }
    
    public static int ForestsCreated
    {
      get { return forestsCreated; }
      private set { forestsCreated = value; }
    }
    
    public static string TreeFacts
    {
      get { return treeFacts; }
    }
    
    // METHODS
     
    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
    
    public static void PrintTreeFacts()
    {
      Console.WriteLine(TreeFacts);
    }
    
  }

}
//Program.cs
using System;

namespace StaticMembers
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest.PrintTreeFacts();
    }
  }
}

/*
Static Classes
We covered a few static members: field, property, method, and constructor. What if we made the whole class static?

static class Forest {}
A static class cannot be instantiated, so you only want to do this if you are making a utility or library, like Math or Console.

These two common classes are static because they are just tools — they don’t need specific instances and they don’t store new information.

Now when you see something like:

Math.Min(34, 54);
Console.WriteLine("yeehaw!");
You know that these are two static classes calling two static methods.

We rarely create static classes of our own, so let’s practice using other static classes. First print the value of pi — a commonly-used value in geometry —, which is stored in Math.PI.

Checkpoint 2 Passed

Stuck? Get a hint
2.
Find the absolute value of -32 using the method Math.Abs(). This method returns the absolute value, or “positive version”, of the argument.

Print the result to the console.
*/
//
using System;

namespace StaticMembers
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Math.PI);
      Console.WriteLine(Math.Abs(-32));
    }
  }
}
/*
Common Static Errors
With great power comes great responsibility. If you plan on using static, you must be familiar with the errors you might cause! Here a few common ones:

This error usually means you labeled a static constructor as public or private, which is not allowed:

error CS0515: 'Forest.Forest()': static constructor cannot have an access modifier
This usually means you tried to reference a non-static member from a class, instead of from an instance:

error CS0120: An object reference is required to access non-static field, method, or property 'Forest.Grow()'
This usually means that you tried to reference a static member from an instance, instead of from the class:

error CS0176: Member 'Forest.TreeFacts' cannot be accessed with an instance reference; qualify it with a type name instead
*/
//1.
//Fix error CS0515.
public static Forest()
//to ...
static Forest()
//2.
//Fix error CS0120.
Forest.Grow();
//to ...
f.Grow();
//3.
//Fix error CS0176.
Console.WriteLine(f.TreeFacts);
//to ...
Console.WriteLine(Forest.TreeFacts);
//Program.cs

using System;

namespace StaticMembers
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Congo", "Tropical");
      
      f.Grow();
      
      Console.WriteLine(Forest.TreeFacts);
    }
  }
}


//Forest.cs

using System;

namespace StaticMembers
{
  class Forest
  {
    // FIELDS
    
    public int age;
    private string biome;
    private static int forestsCreated;
    private static string treeFacts;
    
    // CONSTRUCTORS
    
    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
      ForestsCreated++;
    }
    
    public Forest(string name) : this(name, "Unknown")
    { }
    
    static Forest()
    {
      treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
      ForestsCreated = 0;
      
    }
    
    // PROPERTIES
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }
    
    public static int ForestsCreated
    {
      get { return forestsCreated; }
      private set { forestsCreated = value; }
    }
    
    public static string TreeFacts
    {
      get { return treeFacts; }
    }
    
    // METHODS
     
    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
    
    public static void PrintTreeFacts()
    {
      Console.WriteLine(TreeFacts);
    }
    
  }

}
/*
Main()
Now that you’re familiar with classes, you’re ready to tackle the Main() method, the entry point for any program. You’ve seen it many times, but now you can explain every part!

class Program
{
  public static void Main (string[] args) 
  {
  }
}
Main() is a method of the Program class.
public — The method can be called outside the Program class.
static — The method is called from the class name: Program.Main().
void — The method means returns nothing.
string[] args — The method has one parameter named args, which is an array of strings.
Main() is like any other method you’ve encountered. It has a special use for C#, but that doesn’t mean you can’t treat it like a plain old method!

Instructions
1.
Each time we run dotnet run, the Main() method is called. We can include arguments on the command line, like dotnet run arg1 arg2 arg3 that will be converted into an array as the args parameter. In the console, enter:

dotnet run mango pineapple lychee
Based on this new information, how is your text printed to the console?
*/
//
using System;

namespace ApplyingClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.Length > 0)
      {
        string mainPhrase = String.Join(" and ", args);
        Console.WriteLine($"My favorite fruits are {mainPhrase}!");
      }

      
    }
  }
}
//commandline
//$ dotnet run mango pineapple lychee
//My favorite fruits are mango and pineapple and lychee!
 
/*
Review
Congrats! You are now ready to use static throughout your classes:

In general, static means “associated with the class, not an instance”.
A static member is always accessed by the class name, rather than the instance name, like Forest.Area.
A static method cannot access non-static members.
A static constructor is run once per type, not per instance. It is invoked before the type is instantiated or a static member is accessed.
Either of these would trigger the static constructor of Forest:
public static void Main() {
  Forest f  = new Forest(); 
}
or

public static void Main() {
  Forest.Define(); 
}
A static class cannot be instantiated. Its members are accessed by the class name, like Math.PI.

*/
//review code
//Program.cs

using System;

namespace StaticMembers
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Forest.ForestsCreated);
      Forest f1 = new Forest("New");
      Forest f2 = new Forest("Old");
      Console.WriteLine(Forest.ForestsCreated);
    }
  }
}

//Forest.cs

using System;

namespace StaticMembers
{
  class Forest
  {
    // FIELDS
    
    public int age;
    private string biome;
    private static int forestsCreated;
    private static string treeFacts;
    
    // CONSTRUCTORS
    
    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
      ForestsCreated++;
    }
    
    public Forest(string name) : this(name, "Unknown")
    { }
    
    static Forest()
    {
      treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
      ForestsCreated = 0;
      
    }
    
    // PROPERTIES
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }
    
    public static int ForestsCreated
    {
      get { return forestsCreated; }
      private set { forestsCreated = value; }
    }
    
    public static string TreeFacts
    {
      get { return treeFacts; }
    }
    
    // METHODS
     
    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
    
    public static void PrintTreeFacts()
    {
      Console.WriteLine(TreeFacts);
    }
    
  }

}
