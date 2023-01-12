//while


// Importing the Random library
import java.util.Random;

class LuckyFive {
  
  public static void main(String[] args) {
    
    // Creating a random number generator
    Random randomGenerator = new Random();
    
    // Generate a number between 1 and 6
    
    int dieRoll = randomGenerator.nextInt(6) + 1;

    // Repeat while roll isn't 5
    
    while (dieRoll != 5) {
      System.out.println(dieRoll);
      dieRoll = randomGenerator.nextInt(6) + 1;// prevents infinite loop
    } 
    
  }
  
}

//while counter

class Coffee {
  
  public static void main(String[] args) {
    
    // initialize cupsOfCoffee
    int cupsOfCoffee = 1;
    // add while loop with counter
    while (cupsOfCoffee <= 100) {
      System.out.println("Fry drinks cup of coffee #" + cupsOfCoffee);
      cupsOfCoffee++;
    }
    
  }
  
}

//for loop

class Coffee {
  
  public static void main(String[] args) {
    
    for (int i = 1; i <= 100; i++) {
      System.out.println("Fry drinks cup of coffee #" + i);
    }
    
  }
  
}


//for over array with ArraysList

//For example, if we wanted to add 1 to every int item in an array secretCode, we could do this:

for (int i = 0; i < secretCode.length; i++) {

  secretCode[i] += 1;

}
//Notice that our condition in this example is i < secretCode.length. Because array indices start at 0, the length of secretCode is 1 larger than its final index. Therefore, the loop should stop when it is less than BUT NOT equal to the length value.

//In the case of an ArrayList, this code would look like:

for (int i = 0; i < secretCode.size(); i++) {

  int num = secretCode.get(i);
  secretCode.set(i, num + 1);

}

//exercise

import java.util.ArrayList;

class CalculateTotal {
  
  public static void main(String[] args) {
    
    ArrayList<Double> expenses = new ArrayList<Double>();
    expenses.add(74.46);
    expenses.add(63.99);
    expenses.add(10.57);
    expenses.add(81.37);
    
    double total = 0;
    
    // Iterate over expenses
    for (int i = 0; i < expenses.size(); i++) {
      double num = expenses.get(i);
      total = total + num;   
    }
    
    System.out.println(total);
    
  }
  
}


//foreach

//For-each loops allow you to directly loop through each item in a list of items (like an array or ArrayList) and perform some action with each item. The syntax looks like this:

for (String inventoryItem : inventoryItems) {

  System.out.println(inventoryItem);

}


//exercise

import java.util.ArrayList;

class MostExpensive {
  
  public static void main(String[] args) {
    
    ArrayList<Double> expenses = new ArrayList<Double>();
    expenses.add(74.46);
    expenses.add(63.99);
    expenses.add(10.57);
    expenses.add(81.37);
    
    double mostExpensive = 0;
    
    // Iterate over expenses
    for (double expense : expenses) {
      if (expense > mostExpensive) {
        mostExpensive = expense;
      }
    }
    
    System.out.println(mostExpensive);
    
  }
  
}


//Review
//Nice work! Let’s iterate over what you’ve just learned about loops:

//while loops: These are useful to repeat a code block an unknown number of times until some condition is met. For example:
int wishes = 0;

while (wishes < 3) {

  // code that will run
  wishes++;

}
//for loops: These are ideal for when you are incrementing or decrementing with a counter variable. For example:
for (int i = 0; i < 5; i++) {

  // code that will run

}
//For-each loops: These make it simple to do something with each item in a list. For example:
for (String inventoryItem : inventoryItems) {

  // do something with each inventoryItem

}

//review code for play

import java.util.ArrayList;
import java.util.Arrays;

class Playground {

	public static void main(String[] args) {
  
    for (int i = 0; i < 28; i++) {
  		System.out.println("Congrats on finishing Java loops!");
	  }
  }

}

//fizzbuzz

class FizzBuzz {

  public static void main(String[] args) {

    for (int i = 1; i <= 100; i++) {
      if (i % 15 == 0) {
        System.out.println("FizzBuzz");
      } else if (i % 3 == 0) {
        System.out.println("Fizz");
      } else if (i % 5 == 0) {
        System.out.println("Buzz");
      } else {
        System.out.println(i);
      }    
    }
    
  }
}

