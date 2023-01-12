/*
Build an Interface
For this lesson we will be designing a new set of transportation machines that satisfy the requirements of BOTH car designers and the highway patrol. First the highway patrol tells us: “Every automobile on the road must have these properties and methods accessible to us:”

speed
license plate number
number of wheels
ability to honk
The patrol needs this information to write speeding tickets and prevent bad behavior on the highway.

In other words, the patrol makes these requirements so that it can interact with automobiles in a certain way. In C#, this group of interactions is called an interface. The interface is a set of properties, methods, and other members. They are declared with a signature but their behaviors are not defined. A class implements an interface if it defines those properties, methods, and other members.

For example, if the patrol requires automobiles to have a license plate, then the IAutomobile interface contains a LicensePlate property. A class implements this interface if it defines a LicensePlate property.

The skeleton of an interface looks a bit like a class:

interface IAutomobile
{
}
Every interface should have a name starting with “I”. This is a useful reminder to other developers and our future selves that this is an interface, not a class. We can add members, like properties and methods, to the interface. Here’s an example of a fake property and method:

interface IAutomobile
{
  string Id { get; }
  void Vroom();
}
Notice that the property and method bodies are not defined. An interface is a set of actions and values, but it doesn’t specify how they work.

In our highway example, the highway patrol doesn’t care HOW the license plate property and honk method work, they just care whether every automobile has it.
*/

//promises that interface must meet
using System;

namespace LearnInterfaces
{
  interface IAutomobile
  {
    string LicensePlate { get; }
    double Speed { get; }
    int Wheels { get; }
    void Honk();
  }
}

//skeleton corresponding class minimum to not throw error
using System;

namespace LearnInterfaces
{
  class Sedan : IAutomobile
  {
    // interface promises must be met or error CS0535
    public string LicensePlate
    { get; }
    public double Speed
    { get; }
    public int Wheels
    { get; }
    public void Honk()
    {
      Console.WriteLine("Honk");
    }

}
}


/*
What Interfaces Cannot Do ... specify constructors and fields
The Sedan needs to satisfy more than the highway patrol’s rules (the IAutomobile interface). The car designers have asked that sedans are built and move in certain ways — it must have constructors and methods that aren’t required by the IAutomobile interface. This is okay in C#! The interface says what a class MUST have. It does not say what a class MUST NOT have.

In fact, interfaces cannot specify two types of members that are commonly found in classes:

Constructors
Fields
*/
//exercise so this is also a valid IAutomobile class

using System;

namespace LearnInterfaces
{
  class Sedan : IAutomobile
  {
    public Sedan (double speed)
    {
      this.Speed = speed;
      this.LicensePlate = Tools.GenerateLicensePlate();
      this.Wheels = 4;
    }

  	public string LicensePlate
    { get; }

    public double Speed
    { get; private set; }

    public int Wheels
    { get; }
    
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

    public void SpeedUp()
    {
      this.Speed += 5;
    }

    public void SlowDown()
    {
      this.Speed -= 5;
    }
    
  }
}


/*
Implementing an Interface Again
We’ve completed a Sedan class that satisfies both car designers and highway patrol: it can be constructed and change speed, and it implements the IAutomobile interface.

But sedans aren’t the only automobile on the road. There can be multiple classes that implement an interface.

For example, we can create a Truck class that also implements the interface.

This is where we start to see the power of interfaces. Even though Sedan and Truck are different types, we can assume that they behave similarly because they share an interface. Car designers can build different vehicle classes, but the highway patrol can treat them all the same.
*/
using System;

namespace LearnInterfaces
{
  class Truck : IAutomobile
  {
    // interface promises must be met or error CS0535
    public string LicensePlate
    { get; }
    public double Speed
    { get; }
    public int Wheels
    { get; }
    public void Honk()
    {
      Console.WriteLine("Honk");
    }
  }
}

//

using System;

namespace LearnInterfaces
{
  class Truck : IAutomobile
  {

    public Truck(double speed, double weight)
    {
      this.Speed = speed;
      this.Weight = weight;
      this.LicensePlate = Tools.GenerateLicensePlate();
      if (weight < 400) {
        this.Wheels = 8;
      } else {
        this.Wheels = 12;
      }
    }

  	public string LicensePlate
    { get; }

    public double Speed
    { get; private set; }

    public double Weight
    { get; }
    
    public int Wheels
    { get; }
    
    public void SpeedUp()
    {
      this.Speed += 5;
    }

    public void SlowDown()
    {
      this.Speed -= 5;
    }

    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

  }
}

/*
Testing Interfaces
Now we have a Sedan class and Truck class that implement the IAutomobile interface. Though they have some different behaviors, they both have the properties and method defined in the interface:

double Speed
string LicensePlate
int Wheels
void Honk()
At this point we can be confident that we won’t cause any errors if we try to access these members in either the Sedan or Truck class.
*/
//testing

using System;

namespace LearnInterfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      Sedan red = new Sedan(60);
      Sedan blue = new Sedan(70);
      Truck chugChug = new Truck(45, 500);
      Console.WriteLine($"Blue Sedan:\nSpeed: {blue.Speed}\nWheels: {blue.Wheels}\nLicensePlate: {blue.LicensePlate}\n");
      Console.WriteLine($"Red Sedan:\nSpeed: {red.Speed}\nWheels: {red.Wheels}\nLicensePlate: {red.LicensePlate}\n");
      Console.WriteLine($"ChugChug Truck:\nSpeed: {chugChug.Speed}\nWheels: {chugChug.Wheels}\nLicensePlate: {chugChug.LicensePlate}\n");
      red.SpeedUp();
      blue.SpeedUp();
      chugChug.SpeedUp();
      Console.WriteLine($"\n{red.Speed}\n{blue.Speed}\n{chugChug.Speed}\n");
    }
  }
}
/*
Review
Well done! In this lesson, you:

Learned that interfaces are useful to guarantee certain functionality across multiple classes
Built an interface using the interface keyword
Defined properties and methods (but not constructors or fields) in the interface
Built classes that implemented the interface
Added members to the classes that weren’t specified in the interface
As a last note: a class can implement multiple interfaces. For example, Sedan could implement IAutomobile and a new IReyclable interface. It would be useful to separate interfaces if they aren’t related, i.e. not all automobiles are recyclable.

With this lesson you completed, you might be asking yourself this question:

We have duplicated code, like SpeedUp() and SlowDown(), in two classes, and we know that duplicated code is hard to maintain. Is there a way to avoid duplication?

The answer has to do with inheritance. The concept won’t be covered in this lesson, but now you have one good reason to learn it.

Your C# skills are growing. Keep up the good work!

Instructions
The completed code is provided for you here. Make sure you are comfortable with interfaces before you move on from this lesson.

IAutomobile.cs defines the interface
Sedan.cs and Truck.cs define two classes that implement the interface
Program.cs demonstrates those classes in action
*/

//review code
//IAutomobile.cs

using System;

namespace LearnInterfaces
{
  interface IAutomobile
  {
    string LicensePlate { get; }
    double Speed { get; }
    int Wheels { get; }
    void Honk();
  }
}

//Sedan.cs

using System;

namespace LearnInterfaces
{
  class Sedan : IAutomobile
  {
  	public string LicensePlate
    { get; }

    public double Speed
    { get; private set; }

    public int Wheels
    { get; }
    
    public Sedan(double speed)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
      Wheels = 4;
    }
    
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }
    
    public void SpeedUp()
    {
      Speed += 5;
    }

    public void SlowDown()
    {
      Speed -= 5;
    }
    
  }
}

//Truck.cs

using System;

namespace LearnInterfaces
{
  class Truck : IAutomobile
  {
  	public string LicensePlate
    { get; }

    public double Speed
    { get; private set; }

    public int Wheels
    { get; }
    
    public double Weight
    { get; }

    public Truck(double speed, double weight)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
      Weight = weight;

      if (weight < 400)
      {
        Wheels = 8;
      }
      else
      {
        Wheels = 12;
      }
    }
    
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

    public void SpeedUp()
    {
      Speed += 5;
    }

    public void SlowDown()
    {
      Speed -= 5;
    }

  }
}

//Program.cs

using System;

namespace LearnInterfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      Sedan s = new Sedan(60);
      Console.WriteLine($"Sedan with license plate {s.LicensePlate} and {s.Wheels} wheels, driving at {s.Speed} km/h.");
      s.SpeedUp();
      Console.WriteLine($"Sedan's faster speed: {s.Speed}");

      Sedan s2 = new Sedan(70);
      Console.WriteLine($"Sedan with license plate {s2.LicensePlate} and {s2.Wheels} wheels, driving at {s2.Speed} km/h.");
      s2.SpeedUp();
      Console.WriteLine($"Sedan's faster speed: {s2.Speed}");
      
      Truck t = new Truck(45, 500);
      Console.WriteLine($"Truck with license plate {t.LicensePlate} and {t.Wheels} wheels, driving at {t.Speed} km/h.");
      t.SpeedUp();
      Console.WriteLine($"Truck's faster speed: {t.Speed}");


    }
  }
}

//inheritance helps prevent DRY
/*
INHERITANCE
Introduction to Inheritance
Duplicated code leads to errors. Say you have two classes Sedan and Truck. They’re different types, but they share a few properties and methods, like SpeedUp() and SlowDown(). If one of those members (say it’s SpeedUp()) has to change, then we would have to change the code in every location where SpeedUp() is defined.

In this case it’s two classes, but in other programs it may be many more! There are two reasons we don’t want to make the same change on code across multiple files:

It’s a waste of time
More importantly, it is a big risk for making mistakes
In this lesson you’ll learn about a solution to this problem: inheritance. With inheritance, you can define one superclass that contains the shared members (like SpeedUp() and SlowDown()). All classes that need those members can inherit them from the superclass.

Instructions
Check out Sedan.cs and Truck.cs. What code is duplicated across these types?

Shared in Vehicle a new Superclass or base class
Wheels
LicensePlate
Speed
Vechicle()//Parent or Superclass Constructor
Honk()
SpeedUp()
SlowDown()

Truck()//Child or Subclass Constructor
Weight

Sedan()//Child or Subclass Constructor

/*
Superclass and Subclass
In inheritance, one class inherits the members of another class. The class that inherits is called a subclass or derived class. The other class is called a superclass or base class.

In our car example, Sedan and Truck are subclasses (or derived classes). They will inherit members from a new class called Vehicle, which is the superclass (or base class).

Before using inheritance, both classes had:

Wheels, LicensePlate, and Speed properties
Honk(), SpeedUp(), and SlowDown() methods
Similar constructors
We can pull these out of both classes and put it in a Vehicle class. Sedan and Truck will still have access to those members, but we only need to write them in one place.

By the way, this inheritance hierarchy can extend either way: a new PickupTruck class could inherit from Truck, which inherits from Vehicle, which inherits from a new Machine class. The only rule is that a class can only inherit from one base class, e.g. Vehicle can’t inherit from Machine and Contraption.
*/

//Syntax
//INHERITANCE
//Create a Superclass
//A superclass is defined just like any other class:

class Vehicle
{
}
//And a subclass inherits, or “extends”, a superclass using colon syntax (:):

class Sedan : Vehicle
{
}
//A class can extend a superclass and implement an interface with the same syntax. Separate them with commas and make sure the superclass comes before any interfaces:

class Sedan : Vehicle, IAutomobile
{
}
//The above code means that Sedan will inherit all the functionality of the Vehicle class, and it “promises” to implement all the functionality in the IAutomobile interface.

/*
Access Inherited Members with Protected
While working on Vehicle and Sedan, you may have seen this error:

Sedan.cs(11,13): error CS0200: Property or indexer 'Vehicle.Wheels' cannot be assigned to -- it is read only
Remember public and private? A public member can be accessed by any code outside of the enclosing class. A private member can only be accessed by code within the same class.

The above error comes up because either:

There is no setter for Vehicle.Wheels, or
The setter is private
How do we fix this problem? Making the setter public is not secure. Making it private is too restrictive – we only want the subclass Sedan to access the property. C# has another access modifier to solved that: protected!

A protected member can be accessed by the current class and any class that inherits from it. In this case, if the setter for Vehicle.Wheels is protected, then any Vehicle, Truck, and Sedan instance can call it.


1.
In Vehicle, add a protected setter to each of these properties:

LicensePlate
Speed
Wheels
*/

//Vehicle.cs

using System;

namespace LearnInheritance
{
  class Vehicle
  {
    public string LicensePlate
    { get; protected set; }

    public double Speed
    { get; protected set; }

    public int Wheels
    { get; protected set; }

    public void SpeedUp()
    {
      Speed += 5;
    }

    public void SlowDown()
    {
      Speed -= 5;
    }
    
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

  }
}

//Sedan.cs

using System;

namespace LearnInheritance
{
  class Sedan : Vehicle, IAutomobile
  {
    public Sedan(double speed)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
      Wheels = 4;
    }
    
  }
}
/*
INHERITANCE
Remove Duplicate Code
At the start of this lesson we had duplicate code in Sedan and Truck. We know that duplicated code leads to errors, so we created a superclass Vehicle to contain that code.

But one version of the duplicated code lives on in Truck! Once we have Truck inherit from Vehicle we can remove that code as well. At that point, we’ll have three classes that have Speed, LicensePlate, SlowDown(), etc. but we’ll have it written in only one place.

*/

//Truck.cs

using System;

namespace LearnInheritance
{
  class Truck : Vehicle, IAutomobile
  {
    
    public double Weight
    { get; }

    public Truck(double speed, double weight)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
      Weight = weight;

      if (weight < 400)
      {
        Wheels = 8;
      }
      else
      {
        Wheels = 12;
      }
    }
    
  }
}
//Access Inherited Members with Base
//To construct a Sedan, we must first construct an instance of its superclass Vehicle.

//We can refer to a superclass inside a subclass with the base keyword.

//For example, in Sedan:

base.SpeedUp();
//refers to the SpeedUp() method in Vehicle.

//There’s special syntax for calling the superclass constructor:

class Sedan : Vehicle
{
  public Sedan (double speed) : base(speed)
  {
  }
}
//The above code shows a Sedan that inherits from Vehicle. The Sedan constructor calls the Vehicle constructor with one argument, speed. This works as long as Vehicle has a constructor with one argument of type double.

//Even if we don’t use base() in Sedan, it will call a Vehicle constructor. Without an explicit call to base(), any subclass constructor will implicitly call the default parameterless constructor for its superclass. For example, this code implicitly calls Vehicle():

class Sedan : Vehicle
{
  // Implicitly calls base(), aka Vehicle()
  public Sedan (double speed)
  {
  }
}
//The above code is equivalent to this:

{
  public Sedan (double speed) : base()
  {
  }
}
//This code will ONLY work if the constructor Vehicle() exists. If it doesn’t, then an error will be thrown.

//Vehicle.cs

using System;

namespace LearnInheritance
{
  class Vehicle
  {
    public Vehicle(double speed)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
    }

    public string LicensePlate
    { get; private set; }//private now

    public double Speed
    { get; private set; }//private now

    public int Wheels
    { get; protected set; }

    public void SpeedUp()
    {
      Speed += 5;
    }

    public void SlowDown()
    {
      Speed -= 5;
    }
    
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

  }
}



//Sedan.cs
using System;

namespace LearnInheritance
{
  class Sedan : Vehicle, IAutomobile
  {
    public Sedan(double speed) : base(speed)
    {
      Wheels = 4;
    }
    
  }
}


//Truck.cs

using System;

namespace LearnInheritance
{
  class Truck : Vehicle, IAutomobile
  { 
    public double Weight
    { get; }

    public Truck(double speed, double weight) : base(speed)
    {
      Weight = weight;

      if (weight < 400)
      {
        Wheels = 8;
      }
      else
      {
        Wheels = 12;
      }
    }

  }
}

/*

Override Inherited Members
Say that we wanted to make one more vehicle that operates a bit differently than a sedan or truck. We want to use most of the members in Vehicle, but we need to write new versions of SpeedUp() and SlowDown().

What we want is to override an inherited method. To do that, we use the override and virtual modifiers.

In the superclass, we mark the method in question as virtual, which tells the computer “this member might be overridden in subclasses”:
*/
public virtual void SpeedUp()
//In the subclass, we mark the method as override, which tells the computer “I know this member is defined in the superclass, but I’d like to override it with this method”:

public override void SpeedUp()
//As an aside: there’s another way to solve this problem. Instead of using virtual and override to override a member, we can define a new member with the same name. Essentially, the inherited member still exists, but it is “hidden” by the member in the subclass. If this sounds confusing, that’s okay! We also think it leads to unnecessary confusion, and that leads to errors. We’re going to stick with the virtual - override approach in this lesson.

//Bicycle.cs

using System;

namespace LearnInheritance
{
  class Bicycle : Vehicle
  {
    public Bicycle(double speed) : base(speed)
    {
      Wheels = 2;
    }
    public override void SpeedUp()
    {
      Speed += 5;
      if (Speed > 15) {
        Speed = 15;
      }
    }
    
    public override void SlowDown()
    {
      Speed -= 5;
      if (Speed < 0) {
        Speed = 0;
      }
    }

  }
}

//Vehicle.cs

using System;

namespace LearnInheritance
{
  class Vehicle
  {
    public string LicensePlate
    { get; private set; }

    public double Speed
    { get; protected set; }//protected again

    public int Wheels
    { get; protected set; }

    public Vehicle(double speed)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
    }

    public virtual void SpeedUp()
    {
      Speed += 5;
    }

    public virtual void SlowDown()
    {
      Speed -= 5;
    }
    
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

  }
}
/*
Make Inherited Members Abstract
Now we want to add one more method to Vehicle called Describe(). It will be different for every subclass, so there’s no point in defining a default one in Vehicle. Regardless, we want to make sure that it is implemented in each subclass.

This might sound similar to an interface. Why not add this method to the IAutomobile interface? We want Describe() to be available to all vehicles, not just automobiles.

To do this we need one more modifier: abstract. This line would go into the Vehicle class:
*/
public abstract string Describe();
//This is like the Vehicle class telling its subclasses: “If you inherit from me, you must define a Describe() method because I won’t be giving you any default functionality to inherit.” In other words, abstract member have no implementation in the superclass, but they must be implemented in all subclasses.

//If one member of a class is abstract, then the class itself can’t really exist as an instance. Imagine calling Vehicle.Describe(). It doesn’t make sense because it doesn’t exist! This means that the entire Vehicle class must be abstract. Label it with abstract as well:

abstract class Vehicle
//If you don’t do this, you’ll get an error message like this:

//error CS0513: 'Vehicle.Describe()' is abstract but it is contained in non-abstract class 'Vehicle'
//Once we write the abstract method and mark the class as abstract, we’ll need to actually implement it in each subclass. For example in Sedan:

public override string Describe()
{
  return $"This Sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
}
//To make it clear that this Describe() method in Sedan is overriding the Describe() method in Vehicle, we will need label it override.

//Program.cs
using System;

namespace LearnInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Sedan s = new Sedan(60);
      
      Truck t = new Truck(45, 500);
      
      Bicycle b = new Bicycle(10);
      
      Console.Write($"{s.Describe()}\n\n{t.Describe()}\n\n{b.Describe()}\n\n");
    }
  }
}
//abstract Vehicle.cs

using System;

namespace LearnInheritance
{
  abstract class Vehicle
  {
    public string LicensePlate
    { get; private set; }

    public double Speed
    { get; protected set; }

    public int Wheels
    { get; protected set; }

    public Vehicle(double speed)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
    }

    public virtual void SpeedUp()
    {
      Speed += 5;
    }

    public virtual void SlowDown()
    {
      Speed -= 5;
    }
    
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }
    public abstract string Describe();
  }
}

//Truck.cs

using System;

namespace LearnInheritance
{
  class Truck : Vehicle, IAutomobile
  { 
    public double Weight
    { get; }

    public Truck(double speed, double weight) : base(speed)
    {
      Weight = weight;

      if (weight < 400)
      {
        Wheels = 8;
      }
      else
      {
        Wheels = 12;
      }
    }
    public override string Describe()
    {
      return $"This Truck is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
    }
  }
}

//Sedan.cs

using System;

namespace LearnInheritance
{
  class Sedan : Vehicle, IAutomobile
  {
    public Sedan(double speed) : base(speed)
    {
      Wheels = 4;
    }
    public override string Describe()
    {
      return $"This Sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
    }
  }
}

//Bicycle.cs

using System;

namespace LearnInheritance
{
  class Bicycle : Vehicle
  {

    public Bicycle(double speed) : base(speed)
    {
      Wheels = 2;
    }

    public override void SpeedUp()
    {
      Speed += 5;
      
      if (Speed > 15)
      {
        Speed = 15;
      }
    }

    public override void SlowDown()
    {
      Speed -= 5;

      if (Speed < 0)
      {
        Speed = 0;
      }
    }
    public override string Describe()
    {
      return $"This Bicycle is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
    }
  }
}
/*
Review
Well done! You learned a lot very quickly, so let’s do a review:

Inheritance is a way to avoid duplication across multiple classes.
In inheritance, one class inherits the members of another class.
The class that inherits is called a subclass or derived class. The other class is called a superclass or base class.
We can access a superclass’ members using base. This is very useful when calling the superclass’ constructor.
We can restrict access to a superclass and its subclasses using protected.
We can override a superclass member using virtual and override.
We can make a member in a superclass without defining its implementation using abstract. This is useful if every subclass’ implementation will be different.
Instructions
The completed code is provided for you here.

Make sure you are comfortable with inheritance before you move on from this lesson. Here are a few questions to test yourself:

In Program.cs, Bicycle.Describe() is called. Find the definition for that method in the Bicycle class, then find the abstract definition of that method in Vehicle.
In Program.cs, a Sedan is instantiated. Find the constructor definition in the Sedan class. What happens when that constructor calls base()?
In Bicycle.cs, SpeedUp() is defined. How is it different from SpeedUp() in the Vehicle class?

*/
