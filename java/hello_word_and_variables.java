public class HelloWorld {
  public static void main(String[] args) {
    System.out.println("Hello World!");
  }
}

// hello monkey

public class HelloYou {
  public static void main(String[] args) {
    System.out.println("Hello Monkey");
    
  }
}
// commments
public class Timeline {
  public static void main(String[] args) {
    System.out.println("Hello Java!");
    
    System.out.println("You were born in 1995");

    //Sun Microsystems announced the release of Java in 1995
    
    System.out.println("You were created by James Gosling");
    /*
		James Gosling is a Canadian engineer who 
		created Java while working at Sun Microsystems. 
		His favorite number is the square root of 2!
    */
    System.out.println("You are a fun language!");
  }
} 

//whitespace when coding use line returns  instead of just ; for readability

public class LanguageFacts {
  public static void main(String[] args) {
    // Press enter or return on your keyboard after each semicolon!
    
    System.out.println("Java is a class-based language.");
    System.out.println("Java classes have a 'main' method.");
    System.out.println("Java statements end with a semicolon.");
    System.out.println("Programming is… my only hope.");
  }
}

// javac filename for compiling before run
// javac Compiling.java

// Compiling.java

public class Compiling {
  public static void main(String[] args) {
    
    System.out.println("Java is a class-based language.");
    System.out.println("Java classes have a 'main' method.");
    System.out.println("Java statements end with a semicolon.");

    System.out.println("Programming is... fun!");
    
  }
}
// produces Compiling.class binary
// now we can type java Compiling to run no suffix

//javac Compiling.java
//to run new binary Compiling.class type:
//java Compiling

/*
Java Review: Putting It All Together
In this lesson, we’ve started writing our first programs in Java.

We’ve also learned rules and guidelines for how to write Java programs:

Java programs have at least one class and one main() method.
Each class represents one real-world idea.
The main() method runs the tasks of the program.
Java comments add helpful context to human readers.
Java has whitespace, curly braces, and semicolons.
Whitespace is for humans to read code easily.
Curly braces mark the scope of a class and method.
Semicolons mark the end of a statement.
Java is a compiled language.
Compiling catches mistakes in our code.
Compilers transform code into an executable class.
*/

public class Review {
  public static void main(String[] args) {
    //The main method executes the tasks of the class
    System.out.println("My first Java program from scratch!");
  }
}

//print a tree

// Define your tree class in this file!
public class Tree {
  public static void main(String[] args) {
    // introduce ourselves and print a tree to the screen
    System.out.println("Hey there, I’m Monkey and I’m learning to code in Java!");
    System.out.println("I’m going to plant a tree today!");
    System.out.println("   *  ");
    System.out.println("  *** ");
    System.out.println(" ***** ");
    System.out.println("   *  ");
    System.out.println("   *  "); 
  }
}
//another

public class Creator {
	public static void main(String[] args) {
    String name = "James Gosling";
    int yearCreated = 1995;
    System.out.println(name);
    System.out.println(yearCreated);
	}
}

//declare type int numbers +/- between +/- 2,147,483,648 and including 0


//This is the class declaration
public class CountComment {
  //This is the main method that runs when you compile
	public static void main(String[] args) {
    //This is where you will define your variable
    int numComments = 6;
    //This is where you will print your variable
    System.out.println(numComments);
	}
  
  //This is the end of the class
}

//This is outside the class

/*
The double primitive data type can help. double can hold decimals as well as very large and very small numbers. The maximum value is 1.797,693,134,862,315,7 E+308, which is approximately 17 followed by 307 zeros. The minimum value is 4.9 E-324, which is 324 decimal places!

To declare a variable of type double, we use the double keyword in the declaration:
*/
// doubles can have decimal places:
double price = 8.99;
// doubles can have values bigger than what an int could hold:
double gdp = 12237700000;
//

public class MarketShare {
	public static void main(String[] args) {
    double androidShare = 81.7;
    System.out.println(androidShare);
	}
}
/*

Is the oven on? Is the light green? Did I eat breakfast?

These questions are answered with a boolean, a type that references one of two values: true or false.

We declare boolean variables by using the keyword boolean before the variable name.
*/
boolean javaIsACompiledLanguage = true;
boolean javaIsACupOfCoffee = false;
//

public class Booleans {
	public static void main(String[] args) {    
    boolean intsCanHoldDecimals = false;
    System.out.println(intsCanHoldDecimals);
	}
}

/*

The char data type can hold any character, like a letter, space, or punctuation mark.

It must be surrounded by single quotes, '.

For example:
*/
char grade = 'A';
char firstLetter = 'p';
char punctuation = '!';

//

public class Char {
	public static void main(String[] args) {   
    char expectedGrade = 'C';
    System.out.println(expectedGrade);
	}
}
/*
Strings hold sequences of characters. We’ve already seen instances of a String, for example when you printed out "Hello World".

Just like with a primitive, we declare the variable by specifying the type first:
*/
String greeting = "Hello World";

public class Song {
	public static void main(String[] args) {   
    String openingLyrics = "Yesterday, all my troubles seemed so far away";
    System.out.println(openingLyrics);
	}
}
/*

Narrative
Learn
LEARN JAVA: VARIABLES
Static Checking
The Java programming language has static typing. Java programs will not compile if a variable is assigned a value of an incorrect type. This is a bug, specifically a type declaration bug.

Bugs are dangerous! They cause our code to crash, or produce incorrect results. Static typing helps because bugs are caught during programming rather than during execution of the code.

The program will not compile if the declared type of the variable does not match the type of the assigned value:

int greeting = "Hello World";
The String "Hello World" cannot be held in a variable of type int.

For the example above, we see an error in the console at compilation:

error: incompatible types: String cannot be converted to int
    int greeting = "Hello World";
When bugs are not caught at compilation, they interrupt execution of the code by causing runtime errors. The program will crash.

Java’s static typing helps programmers avoid runtime errors, and thus have much safer code that is free from bugs.
*/

// corrected types

public class Mess {
	public static void main(String[] args) {   
		int year = 2001;
    String title = "Shrek";
    char genre = 'C';
    double runtime = 1.58;
    boolean isPG = true;
	}
}


/*

LEARN JAVA: VARIABLES
Naming
Let’s imagine we’re storing a user’s name for their profile. Which code example do you think is better?

String data = "Delilah";
or

String nameOfUser = "Delilah";
While both of these will compile, the second example is way more easy to understand. Readers of the code will know the purpose of the value: "Delilah".

Naming variables according to convention leads to clear, readable, and maintainable code. When someone else, or our future self, reads the code, there is no confusion about the purpose of a variable.

In Java, variable names are case-sensitive. myHeight is a different variable from myheight. The length of a variable name is unlimited, but we should keep it concise while keeping the meaning clear.

A variable starts with a valid letter, or a $, or a _. No other symbols or numbers can begin a variable name. 1stPlace and *Gazer are not valid variable names.

Variable names of only one word are spelled in all lowercase letters. Variable names of more than one word have the first letter lowercase while the beginning letter of each subsequent word is capitalized. This style of capitalization is called camelCase.

// good style
boolean isHuman;

// bad styles
// no capitalization for new word
boolean ishuman;
// first word should be lowercase
boolean IsHuman;
// underscores don't separate words
boolean is_human;


//BadNames

public class BadNames {
	public static void main(String[] args) {   
		String 1stName = "Samira";
    String blah = "Smith";
    String .com = "samira@google.com";
    int salaryexpectation = 100000;
    int year_of_birth = 1955;
    
    System.out.println("The program runs!");
	}
}



//fixed

public class BadNames {
	public static void main(String[] args) {   
		String firstName = "Samira";
    String lastName = "Smith";
    String email = "samira@google.com";
    int salaryExpectation = 100000;
    int yearOfBirth = 1955;
    
    System.out.println("The program runs!");
	}
}


*/
//

/*
LEARN JAVA: VARIABLES
Review
Creating and filling variables is a powerful concept that allows us to keep track of all kinds of data in our program.

In this lesson, we learned how to create and print several different data types in Java, which you’ll use as you create bigger and more complex programs.

We covered:

int, which stores whole numbers.
double, which stores bigger whole numbers and decimal numbers.
boolean, which stores true and false.
char, which stores single characters using single quotes.
String, which stores multiple characters using double quotes.
Static typing, which is one of the safety features of Java.
Variable naming conventions.
Practice declaring variables and assigning values to make sure you have a solid foundation for learning more complicated and exciting Java concepts!
*/

public class MyProfile {
	public static void main(String[] args) {   
    String name = "Dazzling Monkey.";
    int age = 42;
    double desiredSalary = 80000.00;
    char gender = 'm';
    boolean lookingForJob = true;
	}
}

//print strings well

public class MadLibs {
  /*
  This program generates a mad libbed story.
  Author: Monkey
  Date: 2/19/1949
  */
public class MadLibs {
  /*
  This program generates a mad libbed story.
  Author: Monkey
  Date: 2/19/1949
  */
  	public static void main(String[] args){
      String name1 = "Laura";
      String adjective1 = "jaded";
      String adjective2 = "pfffft";
      String adjective3 = "agitated";
      String verb1 = "gyrate";
      String noun1 = "matrix2 extra";
      String noun2 = "white rabbits";
      String noun3 = "cyberpunk music";
      String noun4 = "onlooker";
      String name2 = "five-o";
      String place1 = "crygogenically freeze the rabble";
      String noun5 = "time";
      int number = 2525;
      String noun6 = "human battery powered machine";    
      //The template for the story
      String story = "This morning "+name1+" woke up feeling "+adjective1+". 'It is going to be a "+adjective2+" day!' Outside, a bunch of "+noun1+"s were protesting to keep "+noun2+" in stores. They began to "+verb1+" to the rhythm of the "+noun3+", which made all the "+noun4+"s very "+adjective3+". Concerned, "+name1+" texted "+name2+", who flew "+name1+" to "+place1+" and dropped "+name1+" in a puddle of frozen "+noun5+". "+name1+" woke up in the year "+number+", in a world where "+noun6+"s ruled the world.";
      System.out.println(story);
    }       
}

