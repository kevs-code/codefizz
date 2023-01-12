public class Car {
// scope of Car class starts after curly brace

  public static void main(String[] args) {
    // scope of main() starts after curly brace

    // program tasks

  }
  // scope of main() ends after curly brace

}
// scope of Car class ends after curly brace

//
public class Store {
  public static void main(String[] args) {
    
  }
}

//constructors

public class Car {
  public Car() {
  //constructor method starts after curly brace

    //instructions for creating a Car instance

  }
  //constructor method ends after curly brace

  public static void main(String[] args) {

    // program tasks

  }
}

public class Car {

  public Car() {
  }

  public static void main(String[] args) {
    /*
    invoke a constructor using 
    'new', the name, and parentheses:
    new Car()
    */
    Car ferrari = new Car(); 
  }
}

//exercise

public class Store {
  
  // new method: constructor!
  public Store() {
    System.out.println("I am inside the constructor method.");
  }
  
  // main method is where we create instances!
  public static void main(String[] args) {
    System.out.println("Start of the main method.");
    
    // create the instance below
    Store lemonadeStand = new Store();
    // print the instance below
    System.out.println(lemonadeStand);
  }
}

/*
Start of the main method.
I am inside the constructor method.
Store@2aae9190
*/

//instance fields

We want Car instances of different colors, so we declare a String color instance field.

public class Car {
  /*
  declare fields inside the class
  by specifying the type and name
  */
  String color;

  public Car() {
    /* 
    instance fields available in
    scope of constructor method
    */
  }

  public static void main(String[] args) {
    // body of main method
  }
}

//exercise
public class Store {
  // declare instance fields here!
  String productType;
  
  // constructor method
  public Store() {
    System.out.println("I am inside the constructor method.");
  }
  
  // main method
  public static void main(String[] args) {
    System.out.println("This code is inside the main method.");
    
    Store lemonadeStand = new Store();
    
    System.out.println(lemonadeStand);
  }
}
//constructor again

public class Car {
  String color;

  // constructor method with a parameter
  public Car(String carColor) {
    // parameter value assigned to the field
    color = carColor;
  }
  public static void main(String[] args) {
    // program tasks
  }
}
//We need a value for the instance field color, so we’ve added String carColor as a parameter.


//The parameter carColor references the value passed in during a method call:

new Car("blue");
// carColor references "blue" inside constructor
new Car("yellow");
// carColor references "yellow" inside constructor

//exercise
public class Store {
  // instance fields
  String productType;
  
  // constructor method
  public Store(String product) {
    productType = product;
  }
  
  // main method
  public static void main(String[] args) {
    
    
  }
}

//assigning values to instance fields


Here we create an instance, ferrari, in the main() method with "red" as its color field:

public class Car {
  String color;

  public Car(String carColor) {
    // assign parameter value to instance field
    color = carColor;
  }

  public static void main(String[] args) {
    // parameter value supplied when calling constructor
    Car ferrari = new Car("red");
  }
}

/*
accessing a field:
objectName.fieldName
*/

ferrari.color;
// "red"

//exercise


public class Store {
  // instance fields
  String productType;
  
  // constructor method
  public Store(String product) {
    productType = product;
  }
  
  // main method
  public static void main(String[] args) {
    Store lemonadeStand = new Store("lemonade");
    System.out.println(lemonadeStand.productType);
  }
}

//lemonade

//multiple fields

public class Car {
  String color;
  // new fields!
  boolean isRunning;
  int velocity;

  // new parameters that correspond to the new fields
  public Car(String carColor, boolean carRunning, int milesPerHour) {
    color = carColor;
    // assign new parameters to the new fields
    isRunning = carRunning;
    velocity = milesPerHour;
  }

  public static void main(String[] args) {
    // new values passed into the method call
    Car ferrari = new Car("red", true, 27);
    Car renault = new Car("blue", false, 70);

    System.out.println(renault.isRunning);
    // false
    System.out.println(ferrari.velocity);
    // 27
  }
}
//Ordering matters! We must pass values into the constructor invocation in the same order that they’re listed in the parameters.

// values match types, no error
Car honda = new Car("green", false, 0);

// values do not match types, error!
Car junker = new Car(true, 42, "brown");

//exercise

public class Store {
  // instance fields
  String productType;
  int inventoryCount;
  double inventoryPrice;
  // constructor method
  public Store(String product, int count, double price) {
    productType = product;
    inventoryCount = count;
    inventoryPrice = price;
  }
  
  // main method
  public static void main(String[] args) {
    Store cookieShop = new Store("cookies", 12, 3.75);
  }
}

/*
REVIEW

Classes: Review
Java is an object-oriented programming language where every program has at least one class. Programs are often built from many classes and objects, which are the instances of a class.

Classes define the state and behavior of their instances. Behavior comes from methods defined in the class. State comes from instance fields declared inside the class.

Classes are modeled on the real-world things we want to represent in our program. Later we will explore how a program can be made from multiple classes. For now, our programs are a single class.
*/
public class Dog {
  // instance field
  String breed;
  // constructor method
  public Dog(String dogBreed) {
    /* 
    value of parameter dogBreed 
    assigned to instance field breed
    */
    breed = dogBreed;
  }
  public static void main(String[] args) {
    /* 
    create instance: 
    use 'new' operator and invoke constructor
    */
    Dog fido = new Dog("poodle");
    /* 
    fields are accessed using: 
    the instance name, `.` operator, and the field name.
    */
    fido.breed;
    // "poodle"
  }
}


//review code

public class Dog {
  String breed;
  boolean hasOwner;
  int age;
  
  public Dog(String dogBreed, boolean dogOwned, int dogYears) {
    System.out.println("Constructor invoked!");
    breed = dogBreed;
    hasOwner = dogOwned;
    age = dogYears;
  }
  
  public static void main(String[] args) {
    System.out.println("Main method started");
    Dog fido = new Dog("poodle", false, 4);
    Dog nunzio = new Dog("shiba inu", true, 12);
    boolean isFidoOlder = fido.age > nunzio.age;
    int totalDogYears = nunzio.age + fido.age;
    System.out.println("Two dogs created: a " + fido.breed + " and a " + nunzio.breed);
    System.out.println("The statement that fido is an older dog is: " + isFidoOlder);
    System.out.println("The total age of the dogs is: " + totalDogYears);
    System.out.println("Main method finished");
  }
}
//output

/*
Main method started
Constructor invoked!
Constructor invoked!
Two dogs created: a poodle and a shiba inu
The statement that fido is an older dog is: false
The total age of the dogs is: 16
Main method finished
*/
