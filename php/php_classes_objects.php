<?php
#To define a Pet class, we use the class keyword followed by the class name (typically title cased in PHP) and curly brackets:

class Pet {

}
#Within the curly brackets, we can add properties, which define the data each object of the class will contain. The syntax is similar to how we define variables:

class Pet {
  public $name, $color;
}
#Note: The public keyword has to do with something called visibility. We’ll discuss this in depth later in the lesson.

$very_good_dog = new Pet();
#We now have our first object, $very_good_dog. We interact with an object’s properties using the object operator (->) followed by the name of the property (without the dollar sign, $).

#We can use this syntax to assign values to object properties:

$very_good_dog->name = "Lassie";
#We can also use it to access the existing value of object properties:

echo $very_good_dog->name; # Prints "Lassie"


<?php
class Beverage {
  public $color, $opacity, $temperature;
}

$tea = new Beverage();
$tea->temperature = "hot";
echo $tea->temperature;

#methods

class Pet {
  public $first, $last;
  function getFullName() {
    return $this->first . " " . $this->last;
  }
}
#The $this variable refers to the current object; when we invoke this method, $this refers to the specific object that called the method.

#Methods are accessed in a similar fashion to properties, using the object operator (->), but in order to invoke them, use parentheses at the end:

$my_object->classMethod();
#So, to access the full name of our Pet, we can use the following:

$very_good_groundhog = new Pet();
$very_good_groundhog->first = "Punxsutawney";
$very_good_groundhog->last = "Phil";
echo $very_good_groundhog->getFullName(); # Prints "Punxsutawney Phil"


#exercise


<?php
class Beverage {
  public $temperature, $color, $opacity;
  function getInfo() {
    return "This beverage is $this->temperature and $this->color.";
  }
}

$soda = new Beverage();
$soda->color = "black";
$soda->temperature = "cold";
echo $soda->getInfo();

# constructors

class Pet {
  public $deserves_love;
  function __construct() {
    $this->deserves_love = TRUE;
  }
}
$my_dog = new Pet();
if ($my_dog->deserves_love){
  echo "I love you!";
}
// Prints: I love you!
#Constructors can also have parameters. These correspond to arguments passed in when using the new keyword. For example, maybe we want to allow for setting the name of the Pet on instantiation:

class Pet {
  public $name;
  function __construct($name) {
    $this->name = $name;
  }
} 
$dog = new Pet("Lassie");

#exercise constructor
<?php
class Beverage {
  public $temperature, $color, $opacity;
  function __construct($temperature, $color) {
    $this->temperature = $temperature;
    $this->color = $color;
  }
  function getInfo() {
    return "This beverage is $this->temperature and $this->color.";
  }
}

$soda = new Beverage("cold", "black");
echo $soda->getInfo();

#inheritance ... extends


#To define a class that inherits from another, we use the keyword extends:

class ChildClass extends ParentClass {

}
#Let’s define a Dog class that extends our Pet class. Each Dog instance will have an additional method called bark():

class Dog extends Pet {
  function bark() {
    return "woof";
  }
}

#exercise


<?php
class Beverage {
  public $temperature;
  
  function getInfo() {
    return "This beverage is $this->temperature.";
  }
}

class Milk extends Beverage {
  function __construct() {
    $this->temperature = "cold";
  }
}

//overload method = replace original method in parent class to do something else in child class

class Pet {
  function type() {
    return "pet";
  }
}
#But in our Dog class, we want to update this message:

class Dog extends Pet{
  function whatIsThis() {
    return "dog";
  }
}
#We can call the parent’s definition of the method within the subclass using parent:: followed by the method name:

class Dog extends Pet{
  function type() {
    return "dog";
  }
  function classify(){
    echo "This " . parent::type() . " is of type " . $this->type();
    // Prints: This pet is of type dog 
  }
}


#So ... exercise

<?php
class Beverage {
  public $temperature;
  
  function getInfo() {
    return "This beverage is $this->temperature.";
  }
}

class Milk extends Beverage {
  function __construct() {
    $this->temperature = "cold";
  }
  function getInfo() {
    return "This beverage is $this->temperature. I like my milk this way.";
  }
}

#visibility level
#Visibility - Private Members
#To understand visibility we need to think about how classes will be used in complex programs—in large applications, a class might be used in diverse situations (passed around inside functions and used in code written by numerous developers). When we think about our classes being used in many situations, we’ll want to consider restricting access to certain member data.

#Up to this point, we’ve been using public visibility for properties. This is also the default visibility for methods. A public visibility means members can be accessed from within the object or from outside it. But sometimes we’ll want a member to only be accessible from within the object. To do this, we can declare this member private.

#Let’s look at an example:

class Pet {
  private $healthScore = 0; 
  function exercise(){
    $this->healthScore++;
  }
  function feed(){
    $this->healthScore++;
  }
  function healthCheck(){
    if ($this->healthScore >= 2){
      echo "This is a healthy pet!";
    } else {
      echo "This is an unhealthy pet";
    }
  }
}
#In the code above, we have the property healthScore. This is a number we use to calculate the health of a pet. The healthScore property can be manipulated and accessed by member methods, but since we never want the property to be accessed directly outside of the class, we set the property as private. If an attempt is made to access the property directly, our code will raise a Fatal Error


#exercise

$milky = new Milk();
echo $milky->getInfo();

<?php
class Beverage {
  private $temperature, $color;
  public $opacity;
  function __construct($temperature, $color) {
    $this->temperature = $temperature;
    $this->color = $color;
  }
  function getInfo() {
    return "This beverage is $this->temperature and $this->color.";
  }
}
class Milk extends Beverage {
  function setOpacity($opacity) {
    $this->opacity = $opacity;
  }
}




CLASSES AND OBJECTS
Visibility - Protected Members
#A class’s private members can only be accessed using methods within that class itself. This isn’t usually the desired effect when we have subclasses. For example, the following code will throw a Fatal Error, since healthScore is private to the Pet class and can’t be accessed from the Horse class:

class Pet {
  private $healthScore = 0; 
}

class Horse extends Pet {
  function brushTeeth() {
    this->healthScore++; 
  }
}

$my_pet = new Horse();
$my_pet->brushTeeth(); // Error
#To allow members to be accessed from within child classes, we can set the visibility within the parent class to protected rather than private. This enables child classes to access these properties and methods internally while still preventing them from being accessed externally:

class Pet {
  protected $heathScore = 0; 
}

class Horse extends Pet {
  function brushTeeth() {
    this->heathScore++; 
  }
}

$my_pet = new Horse();
$my_pet->brushTeeth(); // Successfully increments healthScore
$my_pet->healthScore; // Error


<?php
class Beverage {
  private $temperature, $color;
  protected $opacity;
  function __construct($temperature, $color) {
    $this->temperature = $temperature;
    $this->color = $color;
  }
  function getInfo() {
    return "This beverage is $this->temperature and $this->color.";
  }
}
class Milk extends Beverage {
  function setOpacity($opacity) {
    $this->opacity = $opacity;
  }
}


#exercise

#The opacity property is accessed in a subclass, so setting it to private would be too restrictive. However, it is never accessed outside of the class so public is more permissive than we need.

<?php
class Beverage {
  private $temperature, $color;
  protected $opacity;
  function __construct($temperature, $color) {
    $this->temperature = $temperature;
    $this->color = $color;
  }
  function getInfo() {
    return "This beverage is $this->temperature and $this->color.";
  }
}
class Milk extends Beverage {
  function setOpacity($opacity) {
    $this->opacity = $opacity;
  }
}

#getters and setters

class Pet {
  private $name;
  function setName($name) {
    $this->name = $name;
  }
  function getName() {
    return $this->name;
  }
}
#This is the most basic way of using getters and setters in PHP. Initially, it may look like it adds little value over making properties public and accessing them directly. But what if we only want to accept a string when setting the name of a Pet?

#We can add logic to the setter to ensure that the value being passed in is formatted properly:

function setName($name) {
  if (gettype($name) === "string") {
    $this->name = $name;
    return true;
  } else {
    return false;
  }
}
#We added return values to the setter to provide some feedback as to whether the call to setName was successful.

#We can also use the getter to format values as they are passed out of the object. In this example, we are capitalizing the first letter of the Pet name:

function getName() {
  return ucfirst($this->name);
}

# exercise

<?php
class Beverage {
  private $color;
  function setColor($color) {
    $this->color = strtolower($color);
  }
  function getColor() {
  return $this->color;
  }
}

$soda = new Beverage();

#static members

#CLASSES AND OBJECTS
#Static Members
#Instantiating objects is the most common way to use classes and is also the most in-line with OOP principles. Sometimes though, it can be useful to group a set of utility functions and variables together into a single class. Since these don’t change for every instance, we don’t need to instantiate them. We can use them statically.

#When a member is intended to be used statically, we add the keyword static to its definition.

#Consider this class with a static property and a static method:

class StringUtils {
  public static $max_number_of_characters = 80;
  public static function uclast($string) {
    $string[strlen($string)-1] = strtoupper($string[strlen($string)-1]);
    return $string;
  }
}
#Accessing these static members is done a little differently than with objects. We need to use the Scope Resolution Operator (::). This can be thought of as switching briefly into the scope of the class itself. Since we are inside the scope, we access properties with the dollar sign. For example:

echo StringUtils::$max_number_of_characters; # Prints "80"
#Methods are accessed by using the method name:

echo StringUtils::uclast("hello world"); # Prints "hello worlD"

#hitchhiker exercise

<?php
class AdamsUtils {
  public static $the_answer = 42;
  public static function addTowel($string) {
    return $string . " and a towel.";
  }
}

$items = "I brought apples";

echo AdamsUtils::$the_answer;
echo AdamsUtils::addTowel($items);


/*
Review
Now you have the knowledge to create your own classes and objects in PHP using OOP! Take some time to review the concepts before moving on:

Classes are defined using the class keyword.
Functions defined within a class become methods and variables within the class are considered properties.
There are three levels of visibility for class members:
public (default) - accessible from outside of the class
protected - only accessible within the class or its descendants
private - only accessible within the defining class
Members can be defined to be static.
Static members are accessed using the Scope Resolution Operator (::).
Classes are instantiated into objects using the new keyword.
Members of an object are accessed using the Object Operator (->).
*/


<?php
class Beverage {
  public $temperature, $color, $opacity;
  function __construct($temperature, $color) {
    $this->temperature = $temperature;
    $this->color = $color;
  }
  function getInfo() {
    return "This beverage is $this->temperature and $this->color.";
  }
}

$soda = new Beverage("cold", "black");
echo $soda->getInfo();
#going to bed project

<?php
class StringUtilities {
  public static function secondCase($string) {
    $string = strtolower($string);
    if (strlen($string) > 1) {
      $string[1] = strtoupper($string[1]);
    }
    return $string;
  }
}
echo StringUtilities::secondCase("BANANAS") . "\n";
echo StringUtilities::secondCase("Q") . "\n";
echo StringUtilities::secondCase("");

class Pajamas {
 private $owner, $fit, $color; 
 function __construct($owner = "cutie", $fit = "loose", $color = "pink") {
   $this->owner = StringUtilities::secondCase($owner);
   $this->fit = $fit;
   $this->color = $color;
 }
 public function setFit($fit) {
   $this->fit = $fit;
 }

 public function describe() {
   return "$this->owner has $this->fit $this->color pyjamas.";
 }
}

$chicken_PJs = new Pajamas("CHICKEN", "just right", "purple");
echo $chicken_PJs->describe() . "\n";
$chicken_PJs->setFit("tight");
echo $chicken_PJs->describe() . "\n";

class ButtonablePajamas extends Pajamas {
  private $button_state = "unbuttoned";
  function setButtonState($button_state) {
    $this->$button_state = $button_state;
  }
  public function toggleButtons() {
    if ($this->button_state === "unbuttoned") {
    $this->button_state = "buttoned";
    } else {
    $this->button_state = "unbuttoned";
    }
  }
  public function describe() {
    return parent::describe() . "  They are $this->button_state.\n";
  }
}
$moose_PJs = new ButtonablePajamas("moose", "just right", "purple");
$moose_PJs->toggleButtons();
echo $moose_PJs->describe();

