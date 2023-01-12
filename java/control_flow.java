if (flip == 1) {

  System.out.println("Heads!");

}
/*The if keyword marks the beginning of the conditional statement, followed by parentheses ().
The parentheses hold a boolean datatype.
For the condition in parentheses we can also use variables that reference a boolean, or comparisons that evaluate to a boolean.

The boolean condition is followed by opening and closing curly braces that mark a block of code. This block runs if, and only if, the boolean is true.
*/

boolean isValidPassword = true;

if (isValidPassword) {

  System.out.println("Password accepted!");

}

// Prints "Password accepted!"

int numberOfItemsInCart = 9;

if (numberOfItemsInCart > 12) {

  System.out.println("Express checkout not available");

}

// Nothing is printed.
//If a conditional is brief we can omit the curly braces entirely:

//if (true) System.out.println("Brevity is the soul of wit");

public class Order {
  
  public static void main(String[] args) {
    
    double itemCost = 30.99;
    
    // Write an if-then statement:
    
    if (itemCost > 24.00) {
      System.out.println("High value item!");
    }

  }
  
}
//usual if else called if-then-else here


public class Order {
  
  public static void main(String[] args) {
    
    boolean isFilled = false;
    
    // Write an if-then-else statement:
    if (isFilled) {
      System.out.println("Shipping");
    } else {
      System.out.println("Order not ready");
    }
    
  }
  
}

//if-then-else-elseif

//The conditional statement now has multiple conditions that are evaluated from the top down:

String course = "Theatre";

if (course.equals("Biology")) {

  // Enroll in Biology course

} else if (course.equals("Algebra")) {

  // Enroll in Algebra course

} else if (course.equals("Theatre")) {

  // Enroll in Theatre course

} else {

  System.out.println("Course not found!");

}
//The first condition to evaluate to true will have that code block run. Here’s an example demonstrating the order:

int testScore = 72;

if (testScore >= 90) {

  System.out.println("A");

} else if (testScore >= 80) {

  System.out.println("B");

} else if (testScore >= 70) {

  System.out.println("C");

} else if (testScore >= 60) {

  System.out.println("D");

} else {

  System.out.println("F");

}
// prints: C

//exercise


public class Order {
  boolean isFilled;
  double billAmount;
  String shipping;
  
  public Order(boolean filled, double cost, String shippingMethod) {
		if (cost > 24.00) {
      System.out.println("High value item!");
    }
    isFilled = filled;
    billAmount = cost;
    shipping = shippingMethod;
  }
  
  public void ship() {
    if (isFilled) {
      System.out.println("Shipping");
      System.out.println("Shipping cost: " + calculateShipping());
    } else {
      System.out.println("Order not ready");
    }
  }
  
  public double calculateShipping() {
	 	// declare conditional statement here
    if (shipping == "Regular") {
      return 0;
    } else if (shipping == "Express") {
      return 1.75;
    } else {
      return .50;
    }
 	}
  
  public static void main(String[] args) {
    // do not alter the main method!
    Order book = new Order(true, 9.99, "Express");
    Order chemistrySet = new Order(false, 72.50, "Regular");
    
    book.ship();
    chemistrySet.ship();
  }
}

//switch


//Here’s an example of our course selection conditional as a switch statement instead:

String course = "History";

switch (course) {
  case "Algebra": 
    // Enroll in Algebra
    break; 
  case "Biology": 
    // Enroll in Biology
    break;
  case "History": 
    // Enroll in History
    break;
  case "Theatre":
    // Enroll in Theatre
    break;
  default:
    System.out.println("Course not found");
}

//passthrough

//Without break, code below the matching case label is run, including code under other case labels, which is rarely the desired behavior.

String course = "Biology";

switch (course) {
  case "Algebra": 
    // Enroll in Algebra
  case "Biology": 
    // Enroll in Biology
  case "History": 
    // Enroll in History
  case "Theatre":
    // Enroll in Theatre
  default:
    System.out.println("Course not found");
}

// enrolls student in Biology... AND History and Theatre!

//exercise last exercise with switch instead

public class Order {
  boolean isFilled;
  double billAmount;
  String shipping;
  
  public Order(boolean filled, double cost, String shippingMethod) {
		if (cost > 24.00) {
      System.out.println("High value item!");
    }
    isFilled = filled;
    billAmount = cost;
    shipping = shippingMethod;
  }
  
  public void ship() {
    if (isFilled) {
      System.out.println("Shipping");
      System.out.println("Shipping cost: " + calculateShipping());
    } else {
      System.out.println("Order not ready");
    }
  }
  
  public double calculateShipping() {
    double shippingCost;
	 	// declare switch statement here
    switch (shipping) {
      case "Regular":
        shippingCost = 0;
        break;
      case "Express":
        shippingCost = 1.75;
        break;
      default:
        shippingCost = .50;
    }
    
    return shippingCost;
 	}
  
  public static void main(String[] args) {
    // do not alter the main method!
    Order book = new Order(true, 9.99, "Express");
    Order chemistrySet = new Order(false, 72.50, "Regular");
    
    book.ship();
    chemistrySet.ship();
  }
}


/*
Review
Before this lesson, our code executed from top to bottom, line by line.

Conditional statements add branching paths to our programs. We use conditionals to make decisions in the program so that different inputs will produce different results.

Conditionals have the general structure:

if (condition) {
    // consequent path
} else {
    // alternative path
}
Specific conditional statements have the following behavior:

if-then:
code block runs if condition is true
if-then-else:
one block runs if conditions is true
another block runs if condition is false
if-then-else chained:
same as if-then but an arbitrary number of conditions
switch:
switch block runs if condition value matches case value
*/

//review code add instances to main


public class Order {
  boolean isFilled;
  double billAmount;
  String shipping;
  
  public Order(boolean filled, double cost, String shippingMethod) {
		if (cost > 24.00) {
      System.out.println("High value item!");
    } else {
      System.out.println("Low value item!");
    }
    isFilled = filled;
    billAmount = cost;
    shipping = shippingMethod;
  }
  
  public void ship() {
    if (isFilled) {
      System.out.println("Shipping");
    } else {
      System.out.println("Order not ready");
    }
    
    double shippingCost = calculateShipping();
    
    System.out.println("Shipping cost: ");
    System.out.println(shippingCost);
  }
  
  public double calculateShipping() {
    double shippingCost;
    switch (shipping) {
      case "Regular":
        shippingCost = 0;
        break;
      case "Express":    
        shippingCost = 1.75;
        break;
      default:
        shippingCost = .50; 
    }
    return shippingCost;
 	}
  
  public static void main(String[] args) {
    // create instances and call methods here!

  }
}

//&& operator

true && true
// true
false && true
// false
true && false
// false
false && false
// false


//exercise

public class Reservation {
  int guestCount;
  int restaurantCapacity;
  boolean isRestaurantOpen;
  boolean isConfirmed;
  
  public Reservation(int count, int capacity, boolean open) {
    guestCount = count;
		restaurantCapacity = capacity;
		isRestaurantOpen = open;
  }  
  
  public void confirmReservation() {
    /* 
       Write conditional
       ~~~~~~~~~~~~~~~~~
       if restaurantCapacity is greater
       or equal to guestCount
       AND
       the restaurant is open:
         print "Reservation confirmed"
         set isConfirmed to true
       else:
         print "Reservation denied"
         set isConfirmed to false
    */
    if (restaurantCapacity >= guestCount && isRestaurantOpen) {
      System.out.println("Reservation confirmed");
      isConfirmed = true;
    } else {
      System.out.println("Reservation denied");
      isConfirmed = false;
    }
  }
  
  public void informUser() {
    System.out.println("Please enjoy your meal!");
  }
  
  public static void main(String[] args) {
    Reservation partyOfThree = new Reservation(3, 12, true);
    Reservation partyOfFour = new Reservation(4, 3, true);
    partyOfThree.confirmReservation();
    partyOfThree.informUser();
    partyOfFour.confirmReservation();
    partyOfFour.informUser();
  }
}

/*

Reservation confirmed
Please enjoy your meal!
Reservation denied
Please enjoy your meal!
*/

/*
or ||

true || true
// true
false || true
// true
true || false
// true
false || false
// false
*/
//exercise

public class Reservation {
  int guestCount;
  int restaurantCapacity;
  boolean isRestaurantOpen;
  boolean isConfirmed;
  
  public Reservation(int count, int capacity, boolean open) {
    // Write conditional statement below
    if (count < 1 || count > 8) {
      System.out.println("Invalid reservation!");
    }
    
    guestCount = count;
		restaurantCapacity = capacity;
		isRestaurantOpen = open;
  }  
  
  public void confirmReservation() {
    if (restaurantCapacity >= guestCount && isRestaurantOpen) {
      System.out.println("Reservation confirmed");
      isConfirmed = true;
    } else {
      System.out.println("Reservation denied");
			isConfirmed = false;
    }
  }
  
  public void informUser() {
    System.out.println("Please enjoy your meal!");
  }
  
  public static void main(String[] args) {
    Reservation partyOfThree = new Reservation(3, 12, true);
    Reservation partyOfFour = new Reservation(4, 3, true);
    partyOfThree.confirmReservation();
    partyOfThree.informUser();
    partyOfFour.confirmReservation();
    partyOfFour.informUser();
  }
}
//logical not !

!false
// true
!true
// false

// exercise
public class Reservation {
  int guestCount;
  int restaurantCapacity;
  boolean isRestaurantOpen;
  boolean isConfirmed;
  
  public Reservation(int count, int capacity, boolean open) {
    if (count < 1 || count > 8) {
      System.out.println("Invalid reservation!");
    }
    guestCount = count;
		restaurantCapacity = capacity;
		isRestaurantOpen = open;
  }  
  
  public void confirmReservation() {
    if (restaurantCapacity >= guestCount && isRestaurantOpen) {
      System.out.println("Reservation confirmed");
      isConfirmed = true;
    } else {
      System.out.println("Reservation denied");
			isConfirmed = false;
    }
  }
  
  public void informUser() {
    // Write conditional here
    if (!isConfirmed) {
      System.out.println("Unable to confirm reservation, please contact restaurant.");
    } else {
      System.out.println("Please enjoy your meal!");
    }
  }
  
  public static void main(String[] args) {
    Reservation partyOfThree = new Reservation(3, 12, true);
    Reservation partyOfFour = new Reservation(4, 3, true);
    partyOfThree.confirmReservation();
    partyOfThree.informUser();
    partyOfFour.confirmReservation();
    partyOfFour.informUser();
  }
}
//review
/*
Review
Conditional operators work on boolean values to simplify our code. They’re often combined with conditional statements to consolidate the branching logic.

Conditional-AND, &&, evaluates to true if the booleans on both sides are true.

if (true && false) {
  System.out.println("You won't see me print!");
} else if (true && true) {
  System.out.println("You will see me print!");
}
Conditional-OR, ||, evaluates to true if one or both of the booleans on either side is true.

if (false || false) {
  System.out.println("You won't see me print!");
} else if (false || true) {
  System.out.println("You will see me print!");
}
Logical-NOT, !, evaluates to the opposite boolean value to which it is applied.

if (!false) {
  System.out.println("You will see me print!");
}

*/
//review code (more add instances in main)

public class Reservation {
  int guestCount;
  int restaurantCapacity;
  boolean isRestaurantOpen;
  boolean isConfirmed;
  
  public Reservation(int count, int capacity, boolean open) {
    if (count < 1 || count > 8) {
      System.out.println("Invalid reservation!");
    }
    guestCount = count;
		restaurantCapacity = capacity;
		isRestaurantOpen = open;
  }  
  
  public void confirmReservation() {
    if (restaurantCapacity >= guestCount && isRestaurantOpen) {
      System.out.println("Reservation confirmed");
      isConfirmed = true;
    } else {
      System.out.println("Reservation denied");
			isConfirmed = false;
    }
  }
  
  public void informUser() {
    if (!isConfirmed) {
      System.out.println("Unable to confirm reservation, please contact restaurant.");
    } else {
      System.out.println("Please enjoy your meal!");
    }
  }
  
  public static void main(String[] args) {
    // Create instances here
    
  }
}

//carLoan

public class CarLoan {
    // calculates a CarLoan monthly payment
  public static void main(String[] args) {
    int carLoan = 10000;
    int loanLength = 3;
    int interestRate = 5;
    int downPayment = 2000;
    if (loanLength <= 0 || interestRate <= 0) {
      System.out.println("Error! You must take out a valid car loan.");
    } else if (downPayment > carLoan) {
      System.out.println("The car can be paid in full.");
    } else {
      int remainingBalance = carLoan - downPayment;
      int months = loanLength * 12;
      int monthlyBalance = remainingBalance / months;
      int interest = monthlyBalance * interestRate / 100;
      int monthlyPayment = monthlyBalance + interest;
      System.out.println(monthlyPayment);
    }
	}
}

//continents


public class Continents {
	public static void main(String[] args) {
    //prints largest city on continent (identified by integer value)
    int continent = 4;

    switch (continent) {
      case 1:
        System.out.println("North America: Mexico City, Mexico");
        break;
      case 2:
        System.out.println("South America: Sao Paulo, Brazil");
        break;
      case 3:
        System.out.println("Europe: Moscow, Russia");
        break;
      case 4:
        //default case
        System.out.println("Africa: Lagos, Nigeria");
        break;
      case 5:
        System.out.println("Asia: Shanghai, China");
        break;
      case 6:
        System.out.println("Australia: Sydney, Australia");
        break;
      case 7:
        System.out.println("Antarctica: McMurdo Station, US");
        break;
      default:
        System.out.println("Undefined continent!");
    }
		

	}
}
