/*
In this lesson, we will go over several string methods:

length()
concat()
equals()
indexOf()
charAt()
substring()
toUpperCase() / toLowerCase()
*/

public class HelloWorld {
  
	public static void main(String[] args) {
    
    String str = "Hello, World!";
    
    // Examples:

    System.out.println(str.length());
    
    System.out.println(str.substring(4));
    
    System.out.println(str.toUpperCase());
    
  }
  
}
/*
13
o, World!
HELLO, WORLD!
*/

//length

public class TweetCounter {
  
	public static void main(String[] args) {
    
    String tweet = "Liz Lemon, ninjas are kind of cool... I just dont know any personally. Get on that.";  

    // What's the character count?
    System.out.println(tweet.length());
    
  }
  
}

//83

//concat

public class CombineNames {
  
	public static void main(String[] args) {
    
    // Add your first names:
    String firstName = "Monkey";  
    String lastName = "Types";

    // What's the full name?
    //String fullName = firstName.concat(lastName);//works
    System.out.println(firstName.concat(lastName));
    
  }
  
}
//MonkeyTypes

//equals

public class Password {
  
  public static void main(String[] args) {
    
    String password = "correcthorsebatterystaple";
    
    // Write the code:
    String ooof1 = "mepper";
    String ooof2 = "correcthorsebatterystaple";

    System.out.println(password.equals("mepper"));//exercise required
    System.out.println(password.equals(ooof1));//pffft1
    System.out.println(ooof2.equals(password));//pffft2
  }
  
}

/*

false
false
true
*/

//STRING METHODS
//indexOf()
//If we want to know the index of the first occurence of a character in a string, we can use the indexOf() method on a string.

//Remember that the indices in Java start with 0:

String letters = "ABCDEFGHIJKLMN";

System.out.println(letters.indexOf("C"));
//This would output 2.

String letters = "ABCDEFGHIJKLMN";

System.out.println(letters.indexOf("EFG"));
//This would output 4, because EFG starts at index 4.

//If the indexOf() doesn’t find what it’s looking for, it’ll return a -1.

//exercise
public class MorseCode {
  
  public static void main(String[] args) {
    
    String code = ".... .. / .. .----. -- / ... --- -. -. -.-- / .- -. -.. / .. / .-.. .. -.- . / - --- / . .- - / .-. .- -- . -.";

    // Write the code:
    //code is morse code ". .- -" means eat.
    System.out.println(code.indexOf(". .- -"));
    //87 index result
  }
  
}

//charAt()
//The charAt() method returns the character located at a String‘s specified index.

//For example:

String str = "qwer";

System.out.println(str.charAt(2));
//It would output e because that’s what’s at index 2. (Once again, indices start with 0.)

//Suppose we try return the character located at index 4, it would produce an error because index 4 is out of str‘s range.


//exercise

public class Initials {
  
	public static void main(String[] args) {
    
    // Add a first name and a last name:
    String firstName = "Monkey";  
    String lastName = "Types";
    
    // What are the initials?
    System.out.println(firstName.charAt(0));
    System.out.println(lastName.charAt(0));
  }
  
}
/*
M
T
*/

//substring


String line = "The Heav'ns and all the Constellations rung";

System.out.println(line.substring(23));
//It would output Constellations rung because that’s what begins at index 23 and ends at the end of line. The substring begins with the character at the specified index and extends to the end of the string.

//But suppose we want a substring at the middle of the string. We can include two arguments with this string method. For example:

String line = "The Heav'ns and all the Constellations rung";

System.out.println(line.substring(23, 38));
//It would output Constellations because that’s the substring that begins at index 23 and ends at index 38.

//exercise

public class Poetry {
  
	public static void main(String[] args) {
      
    String line = "The Heav'ns and all the Constellations rung";     
    // Change the arguments:
    System.out.println(line.substring(4, 11));
    //want to print Heav'ns now
  }
  
}
//Heav'ns

String address = "940 Lorimer";
address.substring(0, 3);
//940
//last index exclusive

//to upper/lowerCase()

String input = "Cricket!";

String upper = input.toUpperCase();
// stores "CRICKET!"

String lower = input.toLowerCase();
// stores "cricket!

//exercise
public class Hashtag {
  
  public static void main(String[] args) {
    
    String hashtag = "#100DaysOfCode";
    
    // Make the hashtag lowercase:

    System.out.println(hashtag.toLowerCase());
  }
  
}

//Review

/*
STRING METHODS
Review
Congratulations! 🙌

We have learned some of the string methods that come with the String class:

length()
concat()
indexOf()
charAt()
equals() / equalsIgnoreCase()
substring()
toUpperCase() / toLowerCase()

*/
//review code

public class Review {
  
  public static void main(String[] args) {
    
    
    
  }
  
}
//meh to play

//contains protein

public class DNA {

  public static void main(String[] args) {
    //return true if strand of DNA
    //  -. .-.   .-. .-.   .
    //    \   \ /   \   \ / 
    //   / \   \   / \   \  
    //  ~   `-~ `-`   `-~ `-


    String dna1 = "ATGCGATACGCTTGA";
    String dna2 = "ATGCGATACGTGA";
    String dna3 = "ATTAATATGTACTGA";
    String dna = dna1;
    System.out.println(dna.length());
    int atgIndex = dna.indexOf("ATG");
    int tgaIndex = dna.indexOf("TGA");
    String middle = dna.substring(atgIndex + 3, tgaIndex);
    System.out.println(atgIndex);
    System.out.println(tgaIndex);
    if (atgIndex != -1 && tgaIndex != -1 && middle.length() % 3 == 0) {
        System.out.println(dna + " Contains protein");
    } else {
        System.out.println(dna + " No protein");
    }

  }

}
/*
This works ...
You are all done!

Let’s test your code with each DNA strand. These should be the results:

dna1: Contains a protein.
dna2: Does not contain a protein.
dna3: Contains a protein.

*/
