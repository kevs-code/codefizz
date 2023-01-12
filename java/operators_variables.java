public class GuessingGame {
	public static void main(String[] args) {   
		int mystery1 = 8 + 6;
    int mystery2 = 8 - 6;
    System.out.println(mystery2);
	}
}
//prints 2


public class PlusAndMinus {
	public static void main(String[] args) {   
		int zebrasInZoo = 8;
    int giraffesInZoo = 4;
    int animalsInZoo = zebrasInZoo + giraffesInZoo;
    int numZebrasAfterTrade = zebrasInZoo - 2;
    System.out.println(animalsInZoo);
    System.out.println(numZebrasAfterTrade);
	}
}

//12
//6

public class MultAndDivide {
	public static void main(String[] args) {   
		double subtotal = 30;
    double tax = 0.0875;
    double total = subtotal + subtotal * tax;
    double perPerson = total / 4;
    System.out.println(total);
    System.out.println(perPerson);
	}
}

//32.625
//8.15625

public class Modulo {
	public static void main(String[] args) {   
		int students = 26;
    int leftOut = students % 3;
    System.out.println(leftOut);
	}
}

//2

public class GreaterLessThan {
	public static void main(String[] args) {   
		double creditsEarned = 176.5;
    double creditsOfSeminar = 8;
    double creditsToGraduate = 180;
    boolean canGraduate = creditsEarned > creditsToGraduate;
    System.out.println(canGraduate);
    double creditsAfterSeminar = creditsEarned + creditsOfSeminar;
    boolean canGraduateNow = creditsToGraduate < creditsAfterSeminar;
    System.out.println(canGraduateNow);
	}
}

//false
//true

public class EqualNotEqual {
	public static void main(String[] args) {   
		int songsA = 9;
    int songsB = 9;
    int albumLengthA = 41;
    int albumLengthB = 53;
    boolean sameNumberOfSongs = songsA == songsB;
    boolean differentLength = albumLengthA != albumLengthB;
	}
}
//both true

public class GreaterThanEqualTo {
  	public static void main(String[] args){
      double recommendedWaterIntake = 8;
      double daysInChallenge = 30;
      double yourWaterIntake = 235.5;
      double totalRecommendedAmount = recommendedWaterIntake * daysInChallenge;
      boolean isChallengeComplete = yourWaterIntake >= totalRecommendedAmount;
      System.out.println(isChallengeComplete);
    }
}

//false

//.equals

public class Song {
  	public static void main(String[] args){
      String line1 = "Nah nah nah nah nah nah nah nah nah yeah";
      String line2 = "Nah nah nah nah nah nah, nah nah nah, hey Jude";
      String line3 = "Nah nah nah nah nah nah, nah nah nah, hey Jude";
      System.out.println(line1.equals(line2));
      System.out.println(line2.equals(line3));
    }       
}

//false
//true

/*concatenation
String username = "PrinceNelson";
System.out.println("Your username is: " + username);
This code will print:

Your username is: PrinceNelson
We can even use a primitive datatype as the second variable to concatenate, and Java will intelligently make it a String first:

int balance = 10000;
String message = "Your balance is: " + balance;
System.out.println(message);
This code will print:

Your balance is: 10000
*/

public class Zoo {
  	public static void main(String[] args){
      int animals = 12;
      String species = "zebra";
      String zooDescription = "Our zoo has " + animals + " " + species + "s!";
      System.out.println(zooDescription);
    }       
}

//Our zoo has 12 zebras!
/*review

LEARN JAVA: MANIPULATING VARIABLES
Review
What’s the use of having variables if you can’t do anything with them? We’ve now seen some ways you can operate on variables and compare them. The possibilities are endless!

We covered:

Addition and subtraction, using + and -
Multiplication and division, using * and /
The modulo operator for finding remainders, %
Greater than, >, and less than, <
Equal to, ==, and not equal to, !=
Greater than or equal to, >=, and less than or equal to, <=
equals() for comparing Strings and other objects
Using + to concatenate Strings
Practice some of these concepts here, to make sure you have a solid foundation for learning more complicated and exciting Java concepts!
*/
public class BankAccount {
  	public static void main(String[] args){
      double balance = 1000.75;
      double amountToWithdraw = 250;
      double updatedBalance = balance - amountToWithdraw;
      double amountForEachFriend = updatedBalance / 3;
      boolean canPurchaseTicket = amountForEachFriend > 250;
      System.out.println(canPurchaseTicket);
      System.out.println("I gave each friend " + amountForEachFriend + "...");
    }       
}

//true
//I gave each friend 250.25...

//math_magic

public class Magic {
	public static void main(String[] args) {
    int myNumber = 3;
    // myNumber aka original in instructions
    int stepOne = myNumber * myNumber;//multiply by itself ^ ** not working as primitives;
		int stepTwo = stepOne + myNumber;
    int stepThree = stepTwo / myNumber;
    int stepFour = stepThree + 17;
    int stepFive = stepFour - myNumber;
    int stepSix = stepFive / 6;
    System.out.println(stepSix);
	}
}
