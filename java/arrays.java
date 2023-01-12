//sample code with arrays
public class Newsfeed {
  
  String[] trendingArticles;
  int[] views;
  double[] ratings;
  
  public Newsfeed(String[] initialArticles, int[] initialViews, double[] initialRatings){
    trendingArticles = initialArticles;
    views = initialViews;
    ratings = initialRatings;
  }
  
  public String getTopArticle(){
    return trendingArticles[0];
  }
  
  public void viewArticle(int articleNumber){
    views[articleNumber] = views[articleNumber] + 1;
    System.out.println("The article '" + trendingArticles[articleNumber] + "' has now been viewed " + views[articleNumber] + " times!");
  }
  
  public void changeRating(int articleNumber, double newRating){
    if (newRating > 5 || newRating < 0) {
      System.out.println("The rating must be between 0 and 5 stars!");
    } else {
      ratings[articleNumber] = newRating;
      System.out.println("The article '" + trendingArticles[articleNumber] + "' is now rated " + ratings[articleNumber] + " stars!");
    }
  }
  
  public static void main(String[] args){
    String[] robotArticles = {"Oil News", "Innovative Motors", "Humans: Exterminate Or Not?", "Organic Eye Implants", "Path Finding in an Unknown World"};
    int[] robotViewers = {87, 32, 13, 11, 7};
    double[] robotRatings = {2.5, 3.2, 5.0, 1.7, 4.3};
    Newsfeed robotTimes = new Newsfeed(robotArticles, robotViewers, robotRatings);
    
    robotTimes.viewArticle(2);
    robotTimes.viewArticle(2);
    System.out.println("The top article is " + robotTimes.getTopArticle());
    robotTimes.changeRating(3, 5);
  }
}

/*
Creating an Array Explicitly
Imagine that we’re using a program to keep track of the prices of different clothing items we want to buy. We would want a list of the prices and a list of the items they correspond to. To create an array, we first declare the type of data it holds:

double[] prices;
Then, we can explicitly initialize the array to contain the data we want to store:

 prices = {13.15, 15.87, 14.22, 16.66};
Just like with simple variables, we can declare and initialize in the same line:

double[] prices = {13.15, 15.87, 14.22, 16.66};
We can use arrays to hold Strings and other objects as well as primitives:

String[] clothingItems = {"Tank Top", "Beanie", "Funny Socks", "Corduroys"};
*/



//exercise

public class Newsfeed {
  
  
  public Newsfeed(){
    
  }
  
  // Create getTopics() below:
  public String[] getTopics() {
    String[] topics = {"Opinion", "Tech", "Science", "Health"};
    return topics;
  }

  public static void main(String[] args){
    Newsfeed sampleFeed = new Newsfeed();
    
    String[] topics = sampleFeed.getTopics();
    System.out.println(topics);
    
  }
}
//[Ljava.lang.String;@2aae9190

//to print arrays use Arrays.toString from java.utils.Arrays

// import the Arrays package here:
import java.util.Arrays;// contains toString methods for printing arrays
public class Newsfeed {
  
  
  public Newsfeed(){
    
  }
    
  public String[] getTopics(){
    String[] topics = {"Opinion", "Tech", "Science", "Health"};
    return topics;
  }
  

  public static void main(String[] args){
    Newsfeed sampleFeed = new Newsfeed();
    String[] topics = sampleFeed.getTopics();
    System.out.println(Arrays.toString(topics));//here Arrays.toString()
  }
}
//[Opinion, Tech, Science, Health]

//index

//We use square brackets, [ and ], to access data at a certain index:

double[] prices = {13.1, 15.87, 14.22, 16.66};

System.out.println(prices[1]);
//This command would print:

15.87
//Because 15.87 is the item at the 1 index of the array. Remember that arrays start at index 0!

//exercise
//viewtopicindex increment an index in arrat and also return an array indexawith gettoptopics

import java.util.Arrays;

public class Newsfeed {
  
  String[] topics = {"Opinion", "Tech", "Science", "Health"};
  int[] views = {0, 0, 0, 0};
  
  public Newsfeed(){

  }
    
  public String[] getTopics(){
    return topics;
  }
  
  public String getTopTopic(){
    return topics[0];
  }
  
  public void viewTopic(int topicIndex){
    views[topicIndex] = views[topicIndex] + 1;
  }

  public static void main(String[] args){
    Newsfeed sampleFeed = new Newsfeed();
    
    System.out.println("The top topic is "+ sampleFeed.getTopTopic());
    
    sampleFeed.viewTopic(1);
    sampleFeed.viewTopic(1);
    sampleFeed.viewTopic(3);
    sampleFeed.viewTopic(2);
    sampleFeed.viewTopic(2);
    sampleFeed.viewTopic(1);
    
    System.out.println("The " + sampleFeed.topics[1] + " topic has been viewed " + sampleFeed.views[1] + " times!"); 
  }
}


//create empty array

//We can also create empty arrays and then fill the items one by one. Empty arrays have to be initialized with a fixed size:

String[] menuItems = new String[5];
//Once you declare this size, it cannot be changed! This array will always be of size 5.

//After declaring and initializing, we can set each index of the array to be a different item:

menuItems[0] = "Veggie hot dog";
menuItems[1] = "Potato salad";
menuItems[2] = "Cornbread";
menuItems[3] = "Roasted broccoli";
menuItems[4] = "Coffee ice cream";
//This group of commands has the same effect as assigning the entire array at once:

//String[] menuItems = {"Veggie hot dog", "Potato salad", "Cornbread", "Roasted broccoli", "Coffee ice cream"};
//We can also change an item after it has been assigned! Let’s say this restaurant is changing its broccoli dish to a cauliflower one:

menuItems[3] = "Baked cauliflower";
//Now, the array looks like:

["Veggie hot dog", "Potato salad", "Cornbread", "Baked cauliflower", "Coffee ice cream"]


//exercise

import java.util.Arrays;

public class Newsfeed {
  
  String[] topics = {"Opinion", "Tech", "Science", "Health"};
  int[] views = {0, 0, 0, 0};
  String[] favoriteArticles;
  
  public Newsfeed(){
    // Initialize favoriteArticles here:
    favoriteArticles = new String[10];
  }
  
  public void setFavoriteArticle(int favoriteIndex, String newArticle){
    // Add newArticle to favoriteArticles:
    favoriteArticles[favoriteIndex] = newArticle;
    
  }
    
  public static void main(String[] args){
    Newsfeed sampleFeed = new Newsfeed();
    
    sampleFeed.setFavoriteArticle(2, "Humans: Exterminate Or Not?");
    sampleFeed.setFavoriteArticle(3, "Organic Eye Implants");
    sampleFeed.setFavoriteArticle(0, "Oil News");
    
    System.out.println(Arrays.toString(sampleFeed.favoriteArticles));
  }
}
/*

[Oil News, null, Humans: Exterminate Or Not?, Organic Eye Implants, null, null, null, null, null, null]

*/

//Length
//What if we have an array storing all the usernames for our program, and we want to quickly see how many users we have? To get the length of an array, we can access the length field of the array object:

String[] menuItems = new String[5];
System.out.println(menuItems.length);
//This command would print 5, since the menuItems array has 5 slots, even though they are all empty.

//If we print out the length of the prices array:

double[] prices = {13.1, 15.87, 14.22, 16.66};

System.out.println(prices.length);
//We would see 4, since there are four items in the prices array!
//exercise

import java.util.Arrays;

public class Newsfeed {
  
  String[] topics = {"Opinion", "Tech", "Science", "Health"};
  int[] views = {0, 0, 0, 0};
  
  public Newsfeed(){

  }
    
  public String[] getTopics(){
    return topics;
  }
  
  public int getNumTopics(){
    return topics.length;
  }
  
  public static void main(String[] args){
    Newsfeed sampleFeed = new Newsfeed();
    
    System.out.println("The number of topics is "+ sampleFeed.getNumTopics());
   
  }
}

//The number of topics is 4

//string args


String[] args
//When we write main() methods for our programs, we use the parameter String[] args. Now that we know about array syntax, we can start to parse what this means.

//A String[] is an array made up of Strings. Examples of String arrays:

String[] humans = {"Talesha", "Gareth", "Cassie", "Alex"};
String[] robots = {"R2D2", "Marvin", "Bender", "Ava"};
//The args parameter is another example of a String array. In this case, the array args contains the arguments that we pass in from the terminal when we run the class file. (So far, args has been empty.)

//So how can you pass arguments to main()? Let’s say we have this class HelloYou:

public class HelloYou {
  public static void main(String[] args) {
    System.out.println("Hello " + args[0]);  
  }
}
//When we run the file HelloYou in the terminal with an argument of "Laura":

java HelloYou Laura
//We get the output:

Hello Laura
//The String[] args would be interpreted as an array with one element, "Laura".

//When we use args[0] in the main method, we can access that element like we did in HelloYou.


//exercise

import java.util.Arrays;

public class Newsfeed {
  
  String[] topics;
  
  public Newsfeed(String[] initialTopics) {
		topics = initialTopics;
  }
  
  public static void main(String[] args) {
		Newsfeed feed;
    if (args[0].equals("Human")) {//here
      
      //topics for a Human feed:
      String[] humanTopics = {"Politics", "Science", "Sports", "Love"};
			feed = new Newsfeed(humanTopics);
      
    } else if(args[0].equals("Robot")) {//here
      
      //topics for a Robot feed:
      String[] robotTopics = {"Oil", "Parts", "Algorithms", "Love"};
      feed = new Newsfeed(robotTopics);
      
    } else {
      String[] genericTopics = {"Opinion", "Tech", "Science", "Health"};
      feed = new Newsfeed(genericTopics);
    }
        
    System.out.println("The topics in this feed are:");
    System.out.println(Arrays.toString(feed.topics));
  }
}

/*
command line i/o
$ java Newsfeed Robot
The topics in this feed are:
[Oil, Parts, Algorithms, Love]
$ java Newsfeed Human
The topics in this feed are:
[Politics, Science, Sports, Love]
*/

/*

Review
We have now seen how to store a list of values in arrays. We can use this knowledge to make organized programs with more complex variables.

Throughout the lesson, we have learned about:

Creating arrays explicitly, using { and }.
Accessing an index of an array using [ and ].
Creating empty arrays of a certain size, and filling the indices one by one.
Getting the length of an array using length.
Using the argument array args that is passed into the main() method of a class.
*/
//exercise

import java.util.Arrays;

public class Classroom {
  
  public static void main(String[] args){
    String[] students = {"Sade", "Alexus", "Sam", "Koma"};
    double[] mathScores = new double[4];
    mathScores[0] = 94.5;
    mathScores[2] = 76.8;
    System.out.println("The number of students in the class is " + students.length + ".");
  }
}

//part2 arrayLists

/*
Introduction
When we work with arrays in Java, we’ve been limited by the fact that once an array is created, it has a fixed size. We can’t add or remove elements.

But what if we needed to add to the book lists, newsfeeds, and other structures we were using arrays to represent?

To represent dynamic lists, we can use Java’s ArrayLists. ArrayLists allow us to:

Store elements of the same type (just like arrays)
Access elements by index (just like arrays)
Add elements
Remove elements
Remember how we had to import java.util.Arrays in order to use additional array methods? To use an ArrayList at all, we need to import them from Java’s util package as well:

import java.util.ArrayList;
Let’s learn how to make use of this powerful object…

remember can't assign on ends of fixed length array using index assignments out of range so java.util.ArrayList required
*/

ArrayList<String> babyNames;
//We use angle brackets < and > to declare the type of the ArrayList. These symbols are used for generics. Generics are a Java construct that allows us to define classes and objects as parameters of an ArrayList. For this reason, we can’t use primitive types in an ArrayList:

// This code won't compile:
ArrayList<int> ages;

// This code will compile:
ArrayList<Integer> ages;
//The <Integer> generic has to be used in an ArrayList instead. You can also use <Double> and <Char> for types you would normally declare as doubles or chars.

//We can initialize to an empty ArrayList using the new keyword:

// Declaring:
ArrayList<Integer> ages;
// Initializing:
ages = new ArrayList<Integer>();

// Declaring and initializing in one line:
ArrayList<String> babyNames = new ArrayList<String>();



//exercise declare and initialize in one line ArrayList

// import the ArrayList package here:
import java.util.ArrayList;

class ToDos {
  
  public static void main(String[] args) {
    
    // Create toDoList below:
    ArrayList<String> toDoList = new ArrayList<String>();
    
  }
  
}

//add


import java.util.ArrayList;

class ToDos {
    
  public static void main(String[] args) {
    
    ArrayList<String> toDoList = new ArrayList<String>();
    String toDo1 = "Water plants";
    // Add more to-dos here:
    String toDo2 = "Watch planets";
    String toDo3 = "Study ants";   
    // Add to-dos to toDoList
    toDoList.add(toDo1);
    toDoList.add(toDo2);
    toDoList.add(toDo3);

    System.out.println(toDoList);
      
    
  }
  
}

//size (like length then)

import java.util.ArrayList;

class ToDos {
    
  public static void main(String[] args) {
    
    // Sherlock
    ArrayList<String> sherlocksToDos = new ArrayList<String>();
    
    sherlocksToDos.add("visit the crime scene");
    sherlocksToDos.add("play violin");
    sherlocksToDos.add("interview suspects");
    sherlocksToDos.add("solve the case");
    sherlocksToDos.add("apprehend the criminal");
    
    // Poirot
    ArrayList<String> poirotsToDos = new ArrayList<String>();
    
    poirotsToDos.add("visit the crime scene");
    poirotsToDos.add("interview suspects");
    poirotsToDos.add("let the little grey cells do their work");
    poirotsToDos.add("trim mustache");
    poirotsToDos.add("call all suspects together");
    poirotsToDos.add("reveal the truth of the crime");
    
    // Print the size of each ArrayList below:
    System.out.println(sherlocksToDos.size());
    System.out.println(poirotsToDos.size());
    // Print the name of the detective with the larger to-do list:
    System.out.println("Poirot");
  }
  
}

//get instead of bracket notation to access index
//System.out.println(sherlocksToDos[2]);//won't work on ArrayList
//System.out.println(sherlocksToDos.get(2));//instead

import java.util.ArrayList;

class ToDos {
    
  public static void main(String[] args) {
    
    // Sherlock
    ArrayList<String> sherlocksToDos = new ArrayList<String>();
    
    sherlocksToDos.add("visit the crime scene");
    sherlocksToDos.add("play violin");
    sherlocksToDos.add("interview suspects");
    sherlocksToDos.add("solve the case");
    sherlocksToDos.add("apprehend the criminal");
    
    // Poirot
    ArrayList<String> poirotsToDos = new ArrayList<String>();
    
    poirotsToDos.add("visit the crime scene");
    poirotsToDos.add("interview suspects");
    poirotsToDos.add("let the little grey cells do their work");
    poirotsToDos.add("trim mustache");
    poirotsToDos.add("call all suspects together");
    poirotsToDos.add("reveal the truth of the crime");
    
    System.out.println("Sherlock's third to-do:");
    // Print Sherlock's third to-do:
    //System.out.println(sherlocksToDos[2]);//won't work on ArrayList
    System.out.println(sherlocksToDos.get(2));
    System.out.println("\nPoirot's second to-do:");
    // Print Poirot's second to-do:
    System.out.println(poirotsToDos.get(1));
    
  }
  
}
//set 
//NOT shoppingCart[0] = "Tweed Cape"; USE shoppingCart.set(0, "Tweed Cape");
/*
String[] shoppingCart = {"Trench Coat", "Tweed Houndstooth Hat", "Magnifying Glass"};

shoppingCart[0] = "Tweed Cape";

// shoppingCart now holds ["Tweed Cape", "Tweed Houndstooth Hat", "Magnifying Glass"]
ArrayList has a slightly different way of doing this, using the set() method:

ArrayList<String> shoppingCart = new ArrayList<shoppingCart>();

shoppingCart.add("Trench Coat");
shoppingCart.add("Tweed Houndstooth Hat");
shoppingCart.add("Magnifying Glass");

shoppingCart.set(0, "Tweed Cape");
*/

//exercise

import java.util.ArrayList;

class ToDos {
    
  public static void main(String[] args) {
    
    // Sherlock
    ArrayList<String> sherlocksToDos = new ArrayList<String>();
    
    sherlocksToDos.add("visit the crime scene");
    sherlocksToDos.add("play violin");
    sherlocksToDos.add("interview suspects");
    sherlocksToDos.add("solve the case");
    sherlocksToDos.add("apprehend the criminal");
    
    // Poirot
    ArrayList<String> poirotsToDos = new ArrayList<String>();
    
    poirotsToDos.add("visit the crime scene");
    poirotsToDos.add("interview suspects");
    poirotsToDos.add("let the little grey cells do their work");
    poirotsToDos.add("trim mustache");
    poirotsToDos.add("call all suspects together");
    poirotsToDos.add("reveal the truth of the crime");
    
    // Set each to-do below:
    sherlocksToDos.set(1, "listen to Dr. Watson for amusement");
    poirotsToDos.set(3, "listen to Captain Hastings for amusement");
    System.out.println("Sherlock's to-do list:");
    System.out.println(sherlocksToDos.toString() + "\n");
    System.out.println("Poirot's to-do list:");
    System.out.println(poirotsToDos.toString());
  }
  
}

//remove

//Removing an Item
//What if we wanted to get rid of an entry altogether? For arrays, we would have to make a completely new array without the value.

//Luckily, ArrayLists allow us to remove an item by specifying the index to remove:

ArrayList<String> shoppingCart = new ArrayList<String>();

shoppingCart.add("Trench Coat");
shoppingCart.add("Tweed Houndstooth Hat");
shoppingCart.add("Magnifying Glass");

shoppingCart.remove(1);
// shoppingCart now holds ["Trench Coat", "Magnifying Glass"]
//We can also remove an item by specifying the value to remove:

ArrayList<String> shoppingCart = new ArrayList<String>();

shoppingCart.add("Trench Coat");
shoppingCart.add("Tweed Houndstooth Hat");
shoppingCart.add("Magnifying Glass");

shoppingCart.remove("Trench Coat");
// shoppingCart now holds ["Tweed Houndstooth Hat", "Magnifying Glass"]


//exercise

import java.util.ArrayList;

class ToDos {
    
  public static void main(String[] args) {
    
    // Sherlock
    ArrayList<String> sherlocksToDos = new ArrayList<String>();
    
    sherlocksToDos.add("visit the crime scene");
    sherlocksToDos.add("play violin");
    sherlocksToDos.add("interview suspects");
    sherlocksToDos.add("solve the case");
    sherlocksToDos.add("apprehend the criminal");
    
    // Poirot
    ArrayList<String> poirotsToDos = new ArrayList<String>();
    
    poirotsToDos.add("visit the crime scene");
    poirotsToDos.add("interview suspects");
    poirotsToDos.add("let the little grey cells do their work");
    poirotsToDos.add("trim mustache");
    poirotsToDos.add("call all suspects together");
    poirotsToDos.add("reveal the truth of the crime");
    
    // Remove each to-do below:
    poirotsToDos.remove("visit the crime scene");// by value
    sherlocksToDos.remove(0);//same job sit the crime scene as above by index
    //sherlocksToDos.remove("play violin"); below using index again
    sherlocksToDos.remove(0);//index shifted so would be value or 0 again as old 0 shifted
      
    System.out.println(sherlocksToDos.toString() + "\n");
    System.out.println(poirotsToDos.toString());
  }
  
}

//get indexOf()

//For instance, what if we had an ArrayList detectives with the names of fictional detectives in chronological order, and we wanted to know what position "Fletcher" was.

// detectives holds ["Holmes", "Poirot", "Marple", "Spade", "Fletcher", "Conan", "Ramotswe"];
System.out.println(detectives.indexOf("Fletcher"));
//This code would print 4, since "Fletcher" is at index 4 of the detectives ArrayList.


//exercise

import java.util.ArrayList;

class ToDos {
    
  public static void main(String[] args) {
    
    // Sherlock
    ArrayList<String> sherlocksToDos = new ArrayList<String>();
    
    sherlocksToDos.add("visit the crime scene");
    sherlocksToDos.add("play violin");//3 from here == 0 index to 3 index
    sherlocksToDos.add("interview suspects");
    sherlocksToDos.add("listen to Dr. Watson for amusement");
    sherlocksToDos.add("solve the case");
    sherlocksToDos.add("apprehend the criminal");
    
    sherlocksToDos.remove("visit the crime scene");
    
    // Calculate to-dos until case is solved:
    int remainingToDos = sherlocksToDos.indexOf("solve the case");
      
    // Change the value printed:
    System.out.println(remainingToDos);

  }
  
}

/*
LEARN JAVA: ARRAYLISTS
Review
Nice work! You now know the basics of ArrayLists including:

Creating an ArrayList.
Adding a new ArrayList item using add().
Accessing the size of an ArrayList using size().
Finding an item by index using get().
Changing the value of an ArrayList item using set().
Removing an item with a specific value using remove().
Retrieving the index of an item with a specific value using indexOf().
Now if only there were some way to move through an array or ArrayList, item by item…
*/

//dessert island discs swap indices example here

import java.util.ArrayList;

class Playlist {
  
  public static void main(String[] args) {
   ArrayList<String> desertIslandPlaylist = new ArrayList<String>();
   desertIslandPlaylist.add("Thank you");
   desertIslandPlaylist.add("War pigs");
   desertIslandPlaylist.add("One");
   desertIslandPlaylist.add("Elenor Rigby");
   desertIslandPlaylist.add("Israel Kamakawiwi'ole SOTR");
   desertIslandPlaylist.add("Can't help falling in love with you.");
   System.out.println(desertIslandPlaylist);
   System.out.println(desertIslandPlaylist.size());
   desertIslandPlaylist.remove(3);//or reference directly
   String tempA = desertIslandPlaylist.get(desertIslandPlaylist.indexOf("Thank you"));
   desertIslandPlaylist.set(0, desertIslandPlaylist.get(desertIslandPlaylist.indexOf("One")));
   desertIslandPlaylist.set(2, hold);
   System.out.println(desertIslandPlaylist);
  }
  
}
