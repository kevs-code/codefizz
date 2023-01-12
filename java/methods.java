//dry - don't repeat yourself this code mess needs methods
//methods withdraw, deposit
//fields(state) balance

public class SavingsAccount {
  
  int balance;
  
  public SavingsAccount(int initialBalance){
    balance = initialBalance;
  }
  
  public static void main(String[] args){
    SavingsAccount savings = new SavingsAccount(2000);
    
    //Check balance:
    System.out.println("Hello!");
    System.out.println("Your balance is "+savings.balance);
    
    //Withdrawing:
    int afterWithdraw = savings.balance - 300;
    savings.balance = afterWithdraw;
    System.out.println("You just withdrew "+300);
    
    //Check balance:
    System.out.println("Hello!");
    System.out.println("Your balance is "+savings.balance);
    
    //Deposit:
    int afterDeposit = savings.balance + 600;
    savings.balance = afterDeposit;
    System.out.println("You just deposited "+600);
    
    //Check balance:
    System.out.println("Hello!");
    System.out.println("Your balance is "+savings.balance);
    
    //Deposit:
    int afterDeposit2 = savings.balance + 600;
    savings.balance = afterDeposit2;
    System.out.println("You just deposited "+600);
    
    //Check balance:
    System.out.println("Hello!");
    System.out.println("Your balance is "+savings.balance);
    
  }       
}
//methods

Starting the car!
Vroom!
//This method looks like:

public void startEngine() {
  System.out.println("Starting the car!");
  System.out.println("Vroom!");
}
/*The first line, public void startEngine(), is the method signature. It gives the program some information about the method:

public means that other classes can access this method. We will learn more about that later in the course.
The void keyword means that there is no specific output from the method. We will see methods that are not void later in this lesson, but for now all of our methods will be void.
startEngine() is the name of the method.
A checkBalance() method for the Savings Account we talked about earlier looks something like:
*/
public void checkBalance(){
  System.out.println("Hello!");
  System.out.println("Your balance is " + balance);
}

//exercise

public class Store {
  // instance fields
  String productType;
  
  // constructor method
  public Store(String product) {
    productType = product;
  }
  
  // advertise method
  public void advertise() {
    System.out.println("Come spend some money!");
    System.out.println("Selling " + productType + "!");
  }
  // main method
  public static void main(String[] args) {
    
  }
}

//calling methods

//Here is an example of calling a method on an object using the Car class:

class Car {

  String color;

  public Car(String carColor) {
    color = carColor;
  }

  public void startEngine() {
    System.out.println("Starting the car!");
    System.out.println("Vroom!");
  }

  public static void main(String[] args){
    Car myFastCar = new Car("red");
    myFastCar.startEngine();
  }
}


// 

public class Store {
  // instance fields
  String productType;
  
  // constructor method
  public Store(String product) {
    productType = product;
  }
  
  // advertise method
  public void advertise() {
		System.out.println("Selling " + productType + "!");
    System.out.println("Come spend some money!");
  }
  
  // main method
  public static void main(String[] args) {
    Store lemonadeStand = new Store("Lemonade");
    lemonadeStand.advertise();
    lemonadeStand.advertise();
    lemonadeStand.advertise();
  }
}

/*

Selling Lemonade!
Come spend some money!
Selling Lemonade!
Come spend some money!
Selling Lemonade!
Come spend some money!

*/

//scope

public class Store {
  // instance fields
  String productType;
  
  // constructor method
  public Store(String product) {
    productType = product;
  }
  
  // advertise method
  public void advertise() {
    //cant access cookie here wrong scope
    String message = "Selling " + productType + "!";
		System.out.println(message);
  }
  
  // main method
  public static void main(String[] args) {
    String cookie = "Cookies";
    Store cookieShop = new Store(cookie);
    //cant access message here wrong scope	
    cookieShop.advertise();
  }
}

// so to access in different scopes pass parameters (or declare globals)
class Car {

  String color;

  public Car(String carColor) {
    color = carColor;         
  }

  public void startRadio(String station) {
    System.out.println("Turning on the radio to " + station + "!");
    System.out.println("Enjoy!");
  }

  public static void main(String[] args){
    Car myCar = new Car("red");
    myCar.startRadio("Meditation Station");
  }
}
/*
In this code, we create a startRadio() method that accepts an String parameter called station. In the main() method, we call the startRadio() method on the myCar object and provide an String argument of "Meditation Station".

A call to the startRadio() method on myCar results in printing:

Turning on the radio to Meditation Station!
Enjoy!
*/

//exercise

public class Store {
  // instance fields
  String productType;
  
  // constructor method
  public Store(String product) {
    productType = product;
  }
  
  // advertise method
  public void advertise() {
    String message = "Selling " + productType + "!";
		System.out.println(message);
  }

  // greetCustomer method
  public void greetCustomer(String customer) {
    String greeting = "Welcome to the store, " + customer + "!";  
		System.out.println(greeting);
  }
  
  // main method
  public static void main(String[] args) {
    Store lemonadeStand = new Store("Lemonade");
    lemonadeStand.greetCustomer("Marlon");
  }
}

//reassigning variables

public SavingsAccount{
  double balance;
  public SavingsAccount(double startingBalance){
    balance = startingBalance;
  }

  public void deposit(double amountToDeposit){
     //Add amountToDeposit to the balance
  }

  public void withdraw(double amountToWithdraw){
     //Subtract amountToWithdraw from the balance
  }

  public static void main(String[] args){

  }
}
//These methods would change the value of the variable balance. We can reassign balance to be a new value by using our assignment operator, =, again.

public void deposit(double amountToDeposit){
  double updatedBalance = balance + amountToDeposit;
  balance = updatedBalance;
}
//Now, when we call deposit(), it should change the value of the instance field balance:

public static void main(String[] args){
  SavingsAccount myAccount = new SavingsAccount(2000);
  System.out.println(myAccount.balance);
  myAccount.deposit(100);
  System.out.println(myAccount.balance);
}

//exercise

public class Store {
  // instance fields
  String productType;
  double price;
  
  // constructor method
  public Store(String product, double initialPrice) {
    productType = product;
    price = initialPrice;
  }
  
  // increase price method
  public void increasePrice(double priceToAdd){
    double newPrice = price + priceToAdd;
    price = newPrice;
  }
  
  // main method
  public static void main(String[] args) {
    Store lemonadeStand = new Store("Lemonade", 3.75);
    lemonadeStand.increasePrice(1.5);
    System.out.println(lemonadeStand.price);
  }
}
//5.25

//returns
//now we return we can replace void with datatype e.g., int

//We return a value by using the keyword return:

public int numberOfTires() {
   int tires = 4;
   return tires;
}
//This method, called numberOfTires, returns 4. In past exercises, when creating new methods, we used the keyword void. Here, we are replacing void with int, to signify that the return type is an int.

//The void keyword (which means “completely empty”) indicates to the method that no value is returned after calling that method.

//Alternatively, we can use datatype keywords (such as int, char, etc.) to specify that a method should return a value of that type.

public static void main(String[] args){
  Car myCar = new Car("red");
  int numTires = myCar.numberOfTires();
}

// exercise

public class Store {
  // instance fields
  String productType;
  double price;
  
  // constructor method
  public Store(String product, double initialPrice) {
    productType = product;
    price = initialPrice;
  }
  
  // increase price method
  public void increasePrice(double priceToAdd){
    double newPrice = price + priceToAdd;
    price = newPrice;
  }
  
  // get price with tax method
  public double getPriceWithTax() {
    double totalPrice = price + price * 0.08;
    return totalPrice;
  }

  // main method
  public static void main(String[] args) {
    Store lemonadeStand = new Store("Lemonade", 3.75);
    double lemonadePrice = lemonadeStand.getPriceWithTax();
    System.out.println(lemonadePrice);
  }
}

//The toString() Method
//When we print out Objects, we often see a String that is not very helpful in determining what the Object represents. In the last lesson, we saw that when we printed our Store objects, we would see output like:

//Store@6bc7c054
//where Store is the name of the object and 6bc7c054 is its position in memory.

//This doesn’t tell us anything about what the Store sells, the price, or the other instance fields we’ve defined. We can add a method to our classes that makes this printout more descriptive.

//When we define a toString() method for a class, we can return a String that will print when we print the object:

class Car {

    String color;

    public Car(String carColor) {
        color = carColor;
    }

    public static void main(String[] args){
        Car myCar = new Car("red");
        System.out.println(myCar);
    }

   public String toString(){
       return "This is a " + color + " car!";
   }
}
//When this runs, the command System.out.println(myCar) will print This is a red car!, which tells us about the Object myCar.

//exercise

public class Store {
  // instance fields
  String productType;
  double price;
  
  // constructor method
  public Store(String product, double initialPrice) {
    productType = product;
    price = initialPrice;
  }
  
  // increase price method
  public void increasePrice(double priceToAdd){
    double newPrice = price + priceToAdd;
    price = newPrice;
  }
  
  // get price with tax method
  public double getPriceWithTax(){
    double tax = 0.08;
    double totalPrice = price + price*tax;
    return totalPrice;
  }

  // toString method
  public String toString(){
    return "This store sells " + productType + " at a price of " + price + ".";
  }
  
  // main method
  public static void main(String[] args) {
    Store lemonadeStand = new Store("Lemonade", 3.75);
    Store cookieShop = new Store("Cookies", 5);
    System.out.println(lemonadeStand);
    System.out.println(cookieShop);
  }
}
//instead of className@memorylocation we get

//This store sells Lemonade at a price of 3.75.
//This store sells Cookies at a price of 5.0.

//by defining our toString method e.g., __repr__
//review fix initial mess
/*
LEARN JAVA: METHODS
Review
Great work! Methods are a powerful way to abstract tasks away and make them repeatable. They allow us to define behavior for classes, so that the Objects we create can do the things we expect them to. Let’s review everything we have learned about methods so far.

Defining a method : Methods have a method signature that declares their return type, name, and parameters
Calling a method : Methods are invoked with a . and ()
Parameters : Inputs to the method and their types are declared in parentheses in the method signature
Changing Instance Fields : Methods can be used to change the value of an instance field
Scope : Variables only exist within the domain that they are created in
Return : The type of the variables that are output are declared in the method signature
As you move through more Java material, it will be helpful to frame the tasks you create in terms of methods. This will help you think about what inputs you might need and what output you expect.
*/

//exercise


public class SavingsAccount {
  
  int balance;
  
  public SavingsAccount(int initialBalance){
    balance = initialBalance;
  }
  
  public void checkBalance() {
    System.out.println("Hello!\nYour balance is " + balance);
  }
  
  public void deposit(int amountToDeposit) {
    int updatedBalance = balance + amountToDeposit;
    balance = updatedBalance;
    System.out.println("Your just deposited " + amountToDeposit);
  } 

  public int withdraw(int amountToWithdraw) {
    int updatedBalance = balance - amountToWithdraw;
    balance = updatedBalance;
    System.out.println("Your just withdrew " + amountToWithdraw);
    return amountToWithdraw;
  }
  
  public static void main(String[] args){
    SavingsAccount savings = new SavingsAccount(2000);
    
    //Check balance:
    savings.checkBalance();
    
    //Withdrawing:
    
    savings.withdraw(300);
    
    //Check balance:

    savings.checkBalance();
    //Deposit:
    savings.deposit(600);
    
    
    //Check balance:
    savings.checkBalance();
    
    //Deposit:
    savings.deposit(600);
    
    //Check balance:
    savings.checkBalance();
    
  }       
}
/*
Hello!
Your balance is 2000
Your just withdrew 300
Hello!
Your balance is 1700
Your just deposited 600
Hello!
Your balance is 2300
Your just deposited 600
Hello!
Your balance is 2900
*/

//calculator

public class Calculator{
  //its a bad calculator
  public Calculator() {

  }

  public int add(int a, int b) {
    return a + b;
  }

  public int subtract(int a, int b) {
    return a - b;
  }

  public int multiply(int a, int b) {
    return a * b;
  }

  public double divide(double a, double b) {
    return a / b;
  }

  public int modulo(int a, int b) {
    return a % b;
  }
  
  public static void main(String[] args){
    Calculator myCalculator = new Calculator();
    System.out.println(myCalculator.add(5, 7));
    System.out.println(myCalculator.subtract(45, 11));
    System.out.println(myCalculator.multiply(5, 7));
    System.out.println(myCalculator.divide(45, 11));
    System.out.println(myCalculator.modulo(5, 7));
  }


}


//codey

public class Droid {
  int batteryLevel;
  String name;
  
  public Droid(String droidName) {
    name = droidName;
    batteryLevel = 100;
  }

  public String toString () {
    return "Hello, I’m the droid: " + name;
  }

  public void performTask(String task) {
    System.out.println(name + " is performing task: "+ task);
    batteryLevel = batteryLevel - 10;
    System.out.println("battery level: " + batteryLevel);
  }


  public static void main(String[] args){
    Droid codey = new Droid("Codey");
    System.out.println(codey);
    codey.performTask("singing");
    codey.performTask("dancing");
    codey.performTask("walk on water");
  }
}

/*
Hello, I’m the droid: Codey
Codey is performing task: singing
battery level: 90
Codey is performing task: dancing
battery level: 80
Codey is performing task: walk on water
battery level: 70
*/
