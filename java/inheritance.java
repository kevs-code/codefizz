//inheriting constructor

//Can we do that?

//As it happens, Java has a trick up its sleeve for just this occasion: using the super() method which acts like the parent constructor inside the child class constructor:

class Triangle extends Shape {

  Triangle() {
    super(3);
  }

  // additional Triangle class members

}
//By passing 3 to super(), we are making it possible to instantiate a Triangle without passing in a value for numSides.

//Meanwhile, super() (behaving as Shape()) will shoulder the responsibility of setting numSides to 3 for our Triangle object.

//It is also possible to just completely override a parent class constructor by writing a new constructor for the child class:

class Triangle extends Shape {

  Triangle() {
    this.numSides = 3;
  }

  // additional Triangle class members

}
//In the above example, numSides is just set to 3 without leveraging the parent class constructor.

//Noodle.java
class Noodle {
  
  double lengthInCentimeters;
  double widthInCentimeters;
  String shape;
  String ingredients;
  String texture = "brittle";
  
  Noodle(double lenInCent, double wthInCent, String shp, String ingr) {
    
    this.lengthInCentimeters = lenInCent;
    this.widthInCentimeters = wthInCent;
    this.shape = shp;
    this.ingredients = ingr;
    
  }
  
  public void cook() {
    
    this.texture = "cooked";
    
  }
  
  public static void main(String[] args) {
    Pho phoChay = new Pho();
    System.out.println(phoChay.shape);
    
    
  }
  
}

//Pho.java

class Pho extends Noodle {
  Pho() {
    super(30.0, 0.64, "flat", "rice flour");
  }
  
}

//aspect modifiers - who can view what!

// modifier   class   package   child class   global
// public      yes     yes         yes         yes
// protected   yes     yes         yes          no
// no modifier yes     yes          no          no
// private     yes     no           no          no

//final

Here’s what protected looks like in use:

class Shape {

  protected double perimeter;

}

// any child class of Shape can access perimeter
//In addition to access modifiers, there’s another way to establish how child classes can interact with inherited parent class members: using the final keyword. If we add final before a parent class method’s access modifier, we disallow any child classes from changing that method. This is helpful in limiting bugs that might occur from modifying a particular method.


//Noodle.java

public class Noodle {
  
  private double lengthInCentimeters;
  private double widthInCentimeters;
  private String shape;
  protected String ingredients;
  private String texture = "brittle";
  
  Noodle(double lenInCent, double wthInCent, String shp, String ingr) {
    
    this.lengthInCentimeters = lenInCent;
    this.widthInCentimeters = wthInCent;
    this.shape = shp;
    this.ingredients = ingr;
    
  }
  
  final public boolean isTasty() {
    
    return true;
    
  }
  
  public static void main(String[] args) {
    
    Ramen yasaiRamen = new Ramen();
    //System.out.println(yasaiRamen.ingredients);
    System.out.println(yasaiRamen.isTasty());
    
  }
  
}

//Ramen.java

  }

}


//Introducing Polymorphism
//In Java, if Orange is a Fruit through inheritance, you can then use Orange in the same contexts as Fruit like this:
String makeJuice(Fruit fruit) {

  return "Apple juice and " + fruit.squeeze();

}

// inside main()
Orange orange = new Orange();
System.out.println(juicer.makeJuice(orange));
Wait, how does that work?
/*
This is because Java incorporates the object-oriented programming principle of polymorphism. Polymorphism, which derives from Greek meaning “many forms”, allows a child class to share the information and behavior of its parent class while also incorporating its own functionality.

The main advantages of polymorphic programming:

Simplifying syntax
Reducing cognitive overload for developers
These benefits are particularly helpful when we want to develop our own Java packages for other developers to import and use.

For example, the built-in operator + can be used for both doubles and ints. To the computer, the + means something like addDouble() for one and addInt() for the other, but the creators of Java (and of other languages) didn’t want to burden us as developers with recalling each individual method.

Note that the reverse situation is not true; you cannot use a generic parent class instance where a child class instance is required. So an Orange can be used as a Fruit, but a Fruit cannot be used as an Orange.*/

//overiding methods

//Let’s say we have a BankAccount class that allows us to print the current balance. We want to build a CheckingAccount class that inherits the functionality of a BankAccount but with a modified printBalance() method. We can do the following:

class BankAccount {

  protected double balance;

  public void printBalance() {
    System.out.println("Your account balance is $" + balance);
  }

}

class CheckingAccount extends BankAccount {

  @Override
  public void printBalance() {
    System.out.println("Your checking account balance is $" + balance);
  }

}
/*
Narrative
Learn
INHERITANCE AND POLYMORPHISM
Method Overriding
One common use of polymorphism with Java classes is something we mentioned earlier — overriding parent class methods in a child class. Like the + operator, we can give a single method slightly different meanings for different classes. This is useful when we want our child class method to have the same name as a parent class method but behave a bit differently in some way.

Let’s say we have a BankAccount class that allows us to print the current balance. We want to build a CheckingAccount class that inherits the functionality of a BankAccount but with a modified printBalance() method. We can do the following:

class BankAccount {

  protected double balance;

  public void printBalance() {
    System.out.println("Your account balance is $" + balance);
  }

}

class CheckingAccount extends BankAccount {

  @Override
  public void printBalance() {
    System.out.println("Your checking account balance is $" + balance);
  }

}
Notice that in order to properly override printBalance(), in CheckingAccount the method has the following in common with the corresponding method in BankAccount:

Method name
Return type
Number and type of parameters
You may have also noticed the @Override keyword above printBalance() in CheckingAccount. This annotation informs the compiler that we want to override a method in the parent class. If the method doesn’t exist in the parent class, we’ll get a helpful error when we compile the program.
*/

//noodle

class Noodle {
  
  protected double lengthInCentimeters;
  protected double widthInCentimeters;
  protected String shape;
  protected String ingredients;
  protected String texture = "brittle";
  
  Noodle(double lenInCent, double wthInCent, String shp, String ingr) {
    
    this.lengthInCentimeters = lenInCent;
    this.widthInCentimeters = wthInCent;
    this.shape = shp;
    this.ingredients = ingr;
    
  }
  
  public void cook() {
    
    System.out.println("Boiling.");
    
    this.texture = "cooked";
    
  }
  
  public static void main(String[] args) {
    
    Spaetzle kaesespaetzle = new Spaetzle();
    kaesespaetzle.cook();
    
  }
  
}

//spaetzle

class Spaetzle extends Noodle {
  
  Spaetzle() {
    
    super(3.0, 1.5, "irregular", "eggs, flour, salt");
    this.texture = "lumpy and liquid";
    
  }
  
  // Add the new cook() method below:
  @Override
  public void cook() {
    
    System.out.println("Grinding or scraping dough.");
    System.out.println("Boiling.");
    
    this.texture = "cooked";
    
  }
}

/*
Using a Child Class as its Parent Class
An important facet of polymorphism is the ability to use a child class object where an object of its parent class is expected.

One way to do this explicitly is to instantiate a child class object as a member of the parent class. We can instantiate a CheckingAcount object as a BankAccount like this:

BankAccount kaylasAccount = new CheckingAcount(600.00);
We can use kaylasAccount as if it were an instance of BankAccount, in any situation where a BankAccount object would be expected. (This would be true even if kaylasAccount were instantiated as a CheckingAccount, but using the explicit child as parent syntax is most helpful when we want to declare objects in bulk.)

It is important to note here that the compiler just considers kaylasAccount to be any old BankAccount. But because method overriding is handled at runtime, if we call printBalance(), we’ll see something CheckingAccount specific:

Your checking account balance is $600.00
This is because at runtime, kaylasAccount is recognized as the CheckingAccount it is. So, what if CheckingAccount has a method transferToSavings() that BankAccount does not have? Can kaylasAccount still use that method?

Well, no. The compiler believes that kaylasAccount is just a BankAccount that doesn’t have some fancy child class transferToSavings() method, so it would throw an error.
*/
//exercise
//dinner.java

class Dinner {
  
  private void makeNoodles(Noodle noodle, String sauce) {
    
    noodle.cook();
    
    System.out.println("Mixing " + noodle.texture + " noodles made from " + noodle.ingredients + " with " + sauce + ".");
    System.out.println("Dinner is served!");
    
  }
  
  public static void main(String[] args) {
    
    Dinner noodlesDinner = new Dinner();
    // Add your code here:
    
    Noodle biangBiang = new BiangBiang();
    noodlesDinner.makeNoodles(biangBiang, "soy sauce and chili oil");
  }
  
}
//Noodle.java

class Noodle {
  
  protected double lengthInCentimeters;
  protected double widthInCentimeters;
  protected String shape;
  protected String ingredients;
  protected String texture = "brittle";
  
  Noodle(double lenInCent, double wthInCent, String shp, String ingr) {
    
    this.lengthInCentimeters = lenInCent;
    this.widthInCentimeters = wthInCent;
    this.shape = shp;
    this.ingredients = ingr;
    
  }
  
  public void cook() {
    
    this.texture = "cooked";
    
  }
  
}

//BiangBiang.java

class BiangBiang extends Noodle {
  
  BiangBiang() {
    
    super(50.0, 5.0, "flat", "high-gluten flour, salt, water");
    
  }
  
}

//output

//Mixing cooked noodles made from high-gluten flour, salt, water with soy sauce and chili oil.
//Dinner is served!


//Child Classes in Arrays and ArrayLists
//Usually, when we create an array or an ArrayList, the list items all need to be the same type. But polymorphism puts a new spin on what is considered the same type…

//In fact, we can put instances of different classes that share a parent class together in an array or ArrayList! For example, let’s say we have a Monster parent class with a few child classes: Vampire, Werewolf, and Zombie. We can set up an array with instances of each:

Monster dracula, wolfman, zombie1;

dracula = new Vampire();
wolfman = new Werewolf();
zombie1 = new Zombie();

Monster[] monsters = {dracula, wolfman, zombie1};
//We can even iterate through the list of items — regardless of subclass — and perform the same action with each item:

for (Monster monster : monsters) {

  monster.attack();

}
//exercise

//noodle.java

class Noodle {
  
  protected double lengthInCentimeters;
  protected double widthInCentimeters;
  protected String shape;
  protected String ingredients;
  protected String texture = "brittle";
  
  Noodle(double lenInCent, double wthInCent, String shp, String ingr) {
    
    this.lengthInCentimeters = lenInCent;
    this.widthInCentimeters = wthInCent;
    this.shape = shp;
    this.ingredients = ingr;
    
  }
  
  public String getCookPrep() {
    
    return "Boil noodle for 7 minutes and add sauce.";
    
  }
  
  
  public static void main(String[] args) {
    
    Noodle spaghetti, ramen, pho;
    
    spaghetti = new Spaghetti();
    ramen = new Ramen();
    pho = new Pho();
    
    // Add your code below:
    Noodle[] allTheNoodles = {spaghetti, ramen, pho};
    for (Noodle noodle : allTheNoodles) {
      System.out.println(noodle.getCookPrep());
    }
  }
  
}
//spaghetti.java
class Spaghetti extends Noodle {
  
  Spaghetti() {
    
  	super(30.0, 0.2, "round", "semolina flour");
    
  }
  
  @Override
  public String getCookPrep() {
    
    return "Boil spaghetti for 8 - 12 minutes and add sauce, cheese, or oil and garlic.";
    
  }
  
}
//ramen.java

class Ramen extends Noodle {
  
  Ramen() {
    
    super(30.0, 0.3, "flat", "wheat flour");
    
  }
  
  @Override
  public String getCookPrep() {
    
    return "Boil ramen for 5 minutes in broth, then add meat, mushrooms, egg, and vegetables.";
    
  }
  
}

//pho.java

class Pho extends Noodle {
  
  Pho() {
    
    super(30.0, 0.64, "flat", "rice flour");
    
  }
  
  @Override
  public String getCookPrep() {
    
    return "Soak pho for 1 hour, then boil for 1 minute in broth. Then garnish with cilantro and jalapeno.";
    
  }
  
}

//prints

//Boil spaghetti for 8 - 12 minutes and add sauce, cheese, or oil and garlic.
//Boil ramen for 5 minutes in broth, then add meat, mushrooms, egg, and vegetables.
//Soak pho for 1 hour, then boil for 1 minute in broth. Then garnish with cilantro and jalapeno.

//review

/*
Review of Inheritance and Polymorphism
Excellent work! You’ve learned quite a bundle about inheritance and polymorphism in Java:

A Java class can inherit fields and methods from another class.
Each Java class requires its own file, but only one class in a Java package needs a main() method.
Child classes inherit the parent constructor by default, but it’s possible to modify the constructor using super() or override it completely.
You can use protected and final to control child class access to parent class members.
Java’s OOP principle of polymorphism means you can use a child class object like a member of its parent class, but also give it its own traits.
You can override parent class methods in the child class, ideally using the @Override keyword.
It’s possible to use objects of different classes that share a parent class together in an array or ArrayList.
*/

//language families

public class Language {
  protected String name;
  protected int numSpeakers;
  protected String regionsSpoken;
  protected String wordOrder;

  Language(String title, int numSpeak, String regSpoken, String wordOrd) {
    this.name = title;
    this.numSpeakers = numSpeak;
    this.regionsSpoken = regSpoken;
    this.wordOrder = wordOrd;
  }

  public void getInfo() {
  System.out.println(name + " is spoken by " + numSpeakers + " people mainly in " + regionsSpoken + ". The language follows the word order: " + wordOrder + ".");
  }

  public static void main(String[] args) {
      Language spanish = new Language("Spanish", 555000000, "Spain, Latin America, and Equatorial Guinea", "subject-verb-object");
      spanish.getInfo();
  }
}
