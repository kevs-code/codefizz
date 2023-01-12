/*
Introduction to Bugs
“First actual case of bug being found.”

The story goes that on September 9th, 1947, computer scientist Grace Hopper found a moth in the Harvard Mark II computer’s log book and reported the world’s first literal computer bug. However, the term “bug”, in the sense of technical error, dates back at least to 1878 and with Thomas Edison.

On your programming journey, you are destined to encounter innumerable red errors. Some even say that debugging is over 75% of the development time. But what makes a programmer successful isn’t avoiding errors; it’s knowing how to find the solution.

In Java, there are many different ways of classifying errors, but they can be boiled down to three categories:

Syntax errors: Errors found by the compiler.
Run-time errors: Errors that occur when the program is running.
Logic errors: Errors found by the programmer looking for the causes of erroneous results.
Generally speaking, the errors become more difficult to find and fix as you move down the above list.

In this lesson, we will be looking at different errors and different error messages, and we’ll teach you how to think about errors in your code a little differently.
*/
//common runtime error exceptions
/*
Some common exceptions that you will see in the wild:

ArithmeticException: Something went wrong during an arithmetic operation; for example, division by zero.
NullPointerException: You tried to access an instance variable or invoke a method on an object that is currently null.
ArrayIndexOutOfBoundsException: The index you are using is either negative or greater than the last index of the array (i.e., array.length-1).
FileNotFoundException: Java didn’t find the file it was looking for.

*/

//exercise

public class Debug {

  public static void main(String[] args) {
    
    int width = 0;//should be 20
    int length = 40;
    try {
      int ratio = length / width;
    } catch (ArithmeticException e) {
       System.err.println("ArithmeticException: " + e.getMessage());
    } 
  }
  
}

//ArithmeticException: / by zero

//exercise
//find logic error

import java.util.*;

public class AreaCalculator {
  
	public static void main(String[] args) {
    
	  Scanner keyboard = new Scanner(System.in);
    
	  System.out.println("Shape Area Calculator");
	
	  while(true) {
    
	    System.out.println();
	    System.out.println("-=-=-=-=-=-=-=-=-=-");
	    System.out.println();
	    System.out.println("1) Triangle");
	    System.out.println("2) Rectangle");
	    System.out.println("3) Circle");
	    System.out.println("4) Quit");
      System.out.println();
      
	    System.out.print("Which shape: ");
	
      int shape = keyboard.nextInt();
	    System.out.println();
	
	    if (shape == 1) {
		    area_triangle(5,6);
	    } else if (shape == 2) {
		    area_rectangle(4,5);
	    } else if (shape == 2) {
	    	area_circle(4);
	    } else if (shape == 4) {
		    quit();
		    break;
	    }
      
	  }
    
  }
	
  public static double area_triangle(int base, int height) {
    
		Scanner keyboard = new Scanner(System.in);
    
		System.out.print("Base: ");
		base = keyboard.nextInt();
    
		System.out.print("Height: ");
		height = keyboard.nextInt();
    
		System.out.println();
    
		int A = (base * height) / 2;//bug here gone
    
		System.out.println("The area is " + A + ".");
		
    return A;
    
	}
	
  public static int area_rectangle(int length, int width){
    
		Scanner keyboard = new Scanner(System.in);
    
		System.out.print("Length: ");
		length = keyboard.nextInt();
    
		System.out.print("Width: ");
		width = keyboard.nextInt();
    
		System.out.println();
    
		int A = length * width;
    
		System.out.println("The area is " + A + ".");
    
		return A;
	}
  
  public static double area_circle(int radius) {
    
		Scanner keyboard = new Scanner(System.in);
    
		System.out.print("Radius: ");
		radius = keyboard.nextInt();
    
		System.out.println();
    
		double A = Math.PI * radius * radius;
    
		System.out.println("The area is " + A + ".");
    
		return A;
    
	}
  
	public static String quit() {
    
		System.out.println("GoodBye");
		return null;
    
	}
  
}
//review
/*
Narrative
Learn
DEBUGGING
Review
Finding bugs is a huge part of a programmer’s life. Don’t be intimidated by them… embrace them. Errors in your code mean you’re trying to do something cool!

In this lesson, we have learned about the three types of Java errors:

Syntax errors: Errors found by the compiler.
Run-time errors: Errors found by checks in a running program.
Logic errors: Errors found by the programmer looking for the causes of erroneous results.
Remember, Google and Stack Overflow are a programmer’s best friends. For some more motivation, check out this blog post: Thinking About Errors in Your Code Differently.

Sometimes once you’ve tracked down a bug, you might still be confused on how to fix it! Whenever you want to know more about how Java works and what it can do, the best place to go is documentation. You can find the Java documentation at Oracle.

*/

//exercise code

import java.lang.Math;

class Fortune {

  public int generateRandom() {
    
    return (int)(Math.random() * 10);
    
  }

  public static void main(String[] args) {

    Fortune fortuneCookie = new Fortune();
    int fortune = fortuneCookie.generateRandom();
    
    if (fortune == 0) {

      System.out.println("Flattery will go far tonight.");
    
    } else if (fortune == 1) {
        
      System.out.println("Don't behave with cold manners.");
    
    } else if (fortune == 2) {
        
      System.out.println("May you someday be carbon neutral");
        
    } else if (fortune == 3) {
        
      System.out.println("You have rice in your teeth.");
        
    } else if (fortune == 4) {
        
      System.out.println("A conclusion is simply the place where you got tired of thinking.");
        
    } else if (fortune == 5) {
        
      System.out.println("No snowflake feels responsible in an avalanche.");
        
    } else if (fortune == 6) {
        
      System.out.println("He who laughs last is laughing at you.");
        
    } else if (fortune == 7) {
        
      System.out.println("If you look back, you'll soon be going that way.");
        
    } else if (fortune == 8) {
        
      System.out.println("You will die alone and poorly dressed.");
        
    } else if (fortune == 9) {
        
      System.out.println("The fortune you seek is in another cookie.");
        
    }
    
  }
  
}
