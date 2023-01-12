<?php
$is_clicked = TRUE;
if ($is_clicked) {
  $link_color = "purple";
  echo $link_color;
}

$is_clicked = FALSE;
if ($is_clicked) {
  $link_color = "purple";
  echo $link_color;
} else {
  $link_color = "blue";
  echo $link_color;
}

<?php
namespace Codecademy;

$learner_one = ["is_correct"=>FALSE, "box"=>["shape"=>"none", "color"=>"none"]];
   
$learner_two = ["is_correct"=>TRUE, "box"=>["shape"=>"none", "color"=>"none"]];
  
  
function markAnswer($bool, &$arr)
{
if ($bool) {
  $arr["shape"] = "checkmark";
  $arr["color"] = "green";
} else {
  $arr["shape"] = "x";
  $arr["color"] = "red"; 
}
}

markAnswer($learner_one["is_correct"], $learner_one["box"]);
markAnswer($learner_two["is_correct"], $learner_two["box"]);
print_r($learner_one);
print_r($learner_two);

/*
Array
(
    [is_correct] => 
    [box] => Array
        (
            [shape] => x
            [color] => red
        )

)
Array
(
    [is_correct] => 1
    [box] => Array
        (
            [shape] => checkmark
            [color] => green
        )

)
*/

<?php
namespace Codecademy;

function chooseCheckoutLane($num)
{
  if ($num <= 12) {
    return "express lane";
  } else {
    return "regular lane";
  }
}

function canIVote($age)
{
  if ($age >= 18) {
    return "yes";
  } else {
    return "no";
  }
}
echo chooseCheckoutLane(9) . "\n";
echo chooseCheckoutLane(14) . "\n";
echo canIVote(6) . "\n";
echo canIVote(26) . "\n";
/*
express lane
regular lane
no
yes
*/

<?php
namespace Codecademy;

function agreeOrDisagree($str1, $str2)
{
  if ($str1 === $str2) {
    return "You agree!";
  } else {
    return "You disagree!";
  }
}
echo agreeOrDisagree("yes", "yes") . "\n";
echo agreeOrDisagree("yes", "no") . "\n";

function checkRenewalMonth($month)
{
  $now = date("F");
  if ($now !== $month)
  {
    return "Welcome!";
  } else {
    return "Time to renew";
  }
}

echo checkRenewalMonth("January") ."\n";
echo checkRenewalMonth("August") ."\n";

/*
You agree!
You disagree!
Welcome!
Time to renew
*/

<?php
namespace Codecademy;

// need to consider order with elseif plus no and operator
function whatRelation($dna)
{
  if($dna < 1) {
      echo "not genetically related";
    } elseif ($dna < 3) {
      echo "third cousins";
    } elseif ($dna < 6) {
      echo "second cousins";
    } elseif ($dna < 14) {
      echo "first cousins";
    } elseif ($dna < 35) {
      echo "grandparent and grandchild, aunt/uncle and niece/nephew, or half siblings";
    } elseif ($dna < 100) {
      echo "parent and child or full siblings";
    } else {
      echo "identical twins";
    }
}
echo whatRelation(76) . "\n";
echo whatRelation(0) . "\n";
echo whatRelation(100) . "\n";

/*
parent and child or full siblings
not genetically related
identical twins
*/


<?php
namespace Codecademy;

function airQuality($color)
{
  switch ($color){
    case "green":
      echo "good";
      break;
    case "yellow":
      echo "moderate";
      break;
    case "orange":
      echo "unhealthy for sensitive groups";
      break;
    case "red":
      echo "unhealthy";
      break;
    case "purple":
      echo "very unhealthy";
      break;
    case "maroon":
      echo "hazardous";
      break;
    default:
      echo "invalid color"; 
  }
}

echo airQuality("green") . "\n";
echo airQuality("maroon") . "\n";
echo airQuality("red") . "\n";
echo airQuality("turnip") . "\n";

/*
good
hazardous
unhealthy
invalid color
*/
//fallthrough cases follow same code in switch

<?php
namespace Codecademy;
function returnSeason($month)
{
  switch ($month) {
    case "December":
    case "January":
    case "February":
      return "winter";
      break;
    case "March":
    case "April":
    case "May":
      return "spring";
      break;
    case "June":
    case "July":
    case "August":
      return "summer";
      break;
    case "September":
    case "October":
    case "November":
      return "fall";
      break;
  }
}

echo returnSeason("December") . "\n";
echo returnSeason("May") . "\n";
echo returnSeason("September") . "\n";
echo returnSeason("meh") . "\n";

/*
winter
spring
fall
*/

//ternary operator (again)

#standard
$isClicked = FALSE;
if ( $isClicked ) {
  $link_color = "purple";
} else {
  $link_color = "blue";
}

#ternary
$isClicked = FALSE;
$link_color = $isClicked ? "purple" : "blue";

// with vote and checkout

<?php
namespace Codecademy;

function ternaryCheckout($items)
{ 
  return $items <= 12 ? "express lane" : "regular lane";
}

function ternaryVote($age)
{ 
  return $age < 18 ? "no" : "yes";
}

echo ternaryCheckout(12) . "\n";
echo ternaryCheckout(15) . "\n";
echo ternaryVote(7) . "\n";
echo ternaryVote(107) . "\n";

/*
express lane
regular lane
no
yes
*/

//truthy or falsy
#falsy:

#Empty strings
#null
#an undefined or undeclared variable
#an empty array
#the number 0
#the string "0"
if ("") {
  echo "this will not print";
} elseif (null) {
  echo "this will not print";
} elseif ([]) {
  echo "this will not print";
} elseif (0) {
  echo "this will not print";
} elseif ("0") {
  echo "this will not print";
} else {
  echo "Finally!";
}
#will print Finally
#truthy most things

<?php
namespace Codecademy;

function truthyOrFalsy($str)
{
  if ($str) {
    return "True";
  } else {
    return "False";
  }
}
echo truthyOrFalsy("Hello") . "\n";
echo truthyOrFalsy(78) . "\n";
echo truthyOrFalsy([]) . "\n";
/*
True
True
False
*/

//name input commandline
// php src/index.php

<?php
namespace Codecademy;

echo "Hello, there. What's your first name?\n";
$name = readline(">> ");

if (strlen($name) > 8) {
  echo "Hi, $name. That's a long name.";
} elseif (strlen($name) < 4) {
  echo "Hi, $name. That's a short name.";
} else {
  echo "Hi, $name.";
}

/*

Review
Woah! We covered a lot in this lesson. Good work. Let’s review what we learned:

Conditionals make it possible for programs to decide how to react to a wide variety of situations.
if statements allow us to run a block of code if a condition is met.
The boolean data type is either the value TRUE or FALSE and is the foundation of programmatic decision making.
We use else to include a block of code to run when the condition is not met.
Comparison operators evaluate a relationship between two operands and return a boolean value.
The less than operator (<)
The less than or equal to operator (<=)
The greater than operator (>)
The greater than or equal to operator (>=)
The Identical operator (===)
The not identical operator (!==)
We can write conditionals with multiple if statements using the elseif construction.
Instead of using a series of if statements when we want to compare a value, expression, or variable against many different possible values and run different code depending on which it matches, we can use a switch statement.
The keyword break tells the computer to break out of the switch statement, without it, it will fall through the rest of the switch executing all the code until it reaches a break or the end of the statement.
A ternary operator (?:) is shorthand conditional operator. It takes three operands (a condition to check, an expression to return if the condition is TRUE, and an expression to return if the condition is FALSE).
Any value or expression inside a condition will be converted to TRUE or FALSE. We consider values that will convert to TRUE to be truthy and values that will convert to FALSE to be falsy.
We can get user input from the terminal with the readline() function.
That really is a lot… Take some time to practice and review! You’re doing great.
*/

<?php
$gryffindor = 0;
$hufflepuff = 0;
$ravenclaw = 0;
$slytherin = 0;

//$answer1, $answer2, $answer3;

echo  "================\nThe Sorting Hat!\n================\n\n";


  // ~~~~~~~~~~ Question 1 ~~~~~~~~~~

  echo "Q1) When I'm dead, I want people to remember me as:\n\n  1) The Good\n  2) The Great\n  3) The Wise\n  4) The Bold\n\nEnter your answer (1-4): ";
  
  

  $answer1 = readline(">>");

  if ($answer1 === "1")
    $hufflepuff++;
  elseif ($answer1 === "2")
    $slytherin++;
  elseif ($answer1 === "3")
    $ravenclaw++;
  elseif ($answer1 === "4")
    $gryffindor++;

  // ~~~~~~~~~~ Question 2 ~~~~~~~~~~

  echo "\nQ2) Dawn or Dusk?\n\n  1) Dawn\n  2) Dusk\n\nEnter your answer (1-2): ";

  $answer2 = readline(">>");

  if ($answer2 === "1") 
  {
    
    $gryffindor++;
    $ravenclaw++;
  
  } 
  elseif ($answer2 === "2") 
  {

    $hufflepuff++;
    $slytherin++;

  }
  else 
  {

    echo "Invalid input\n";

  }

  // ~~~~~~~~~~ Question 3 ~~~~~~~~~~

  echo "\nQ3) Which kind of instrument most pleases your ear?\n\n  1) The violin\n  2) The trumpet\n  3) The piano\n  4) The drum\n\nEnter your answer (1-4): ";

  $answer3 = readline(">>");

  if ($answer3 === "1")
    $slytherin++;
  elseif ($answer3 === "2")
    $hufflepuff++;
  elseif ($answer3 === "3")
    $ravenclaw++;
  elseif ($answer3 === "4")
    $gryffindor++;

  // ~~~~~~~~~~ Question 4 ~~~~~~~~~~

  echo "\nQ4) Which road tempts you the most?\n\n  1) The wide, sunny grassy lane\n  2) The narrow, dark, lantern-lit alley\n  3) The twisting, leaf-strewn path through woods\n  4) The cobbled street lined (ancient buildings)\n\nEnter your answer (1-4): ";

  $answer4 = readline(">>");

  if ($answer4 === "1")
    $hufflepuff++;
  elseif ($answer4 === "2")
    $slytherin++;
  elseif ($answer4 === "3")
    $gryffindor++;
  elseif ($answer4 === "4")
    $ravenclaw++;
  
  // ========== Sorting ==========

  echo "Congrats on being sorted into... ";

  $max = 0;
  $house = "";

  if ($gryffindor > $max) 
  {

    $max = $gryffindor;
    $house = "Gryffindor";
    
  }

  if ($hufflepuff > $max) 
  {

    $max = $hufflepuff;
    $house = "Hufflepuff";

  }
  
  if ($ravenclaw > $max) 
  {

    $max = $ravenclaw;
    $house = "Ravenclaw";

  }
  
  if ($slytherin > $max) 
  {

    $max = $slytherin;
    $house = "Slytherin";

  }
  
  echo $house . "!\n";



//8ball

<?php

function magic8ball()
{
  $question = readline("? ");
  echo $question . "\n";
  $res_ind = rand(0, 19);
  switch ($res_ind) {
    case 0:
      return "It is certain.";
      break;
    case 1:
      return "It is decidedly so.";
      break;
    case 2:
      return "Without a doubt.";
      break;
    case 3:
      return "Yes - definitely.";
      break;
    case 4:
      return "You may rely on it.";
      break;
    case 5:
      return "As I see it, yes.";
      break;
    case 6:
      return "Most likely.";
      break;
    case 7:
      return "Outlook good.";
      break;
    case 8:
      return "Yes.";
      break;
    case 9:
      return "Signs point to yes.";
      break;
    case 10:
      return "Reply hazy, try again.";
      break;
    case 11:
      return "Ask again later.";
      break;
    case 12:
      return "Better not tell you now.";
      break;
    case 13:
      return "Cannot predict now.";
      break;
    case 14:
      return "Concentrate and ask again.";
      break;
    case 15:
      return "Don't count on it.";
      break;
    case 16:
      return "My reply is no.";
      break;
    case 17:
      return "My sources say no.";
      break;
    case 18:
      return "Outlook not so good.";
      break;
    case 19:
      return "Very doubtful.";
      break;
  }
}

echo magic8ball() . "\n";
echo magic8ball() . "\n";
echo magic8ball() . "\n";
echo magic8ball() . "\n";
echo magic8ball() . "\n";
echo magic8ball() . "\n";


//basic guess number
<?php
$play_count = 0;
$correct_guesses = 0;
$guess_high = 0;
$guess_low = 0;

echo "I'm going to think of numbers between 1 and 10 (inclusive). Do you think you can guess correctly?\n";

function guessNumber()
{
  global $play_count, $correct_guesses, $guess_high, $guess_low;
  $play_count++;
  $hid_num = rand(1, 10);
  echo "\nI've got a number, start make your guess please.\n";
  $guess = readline(">> ");
  $guess = intval($guess);
  echo "This is round $play_count, Your number is $guess.  My number was $hid_num.\n";
  if ($guess === $hid_num) {
    $correct_guesses++;
  } elseif ($guess > $hid_num) {
    $guess_high++;
  } else {
    $guess_low++;
  }
  $percent = ($correct_guesses / $play_count) * 100;
  echo "You have guesses right $percent% of the time, statistically you should guess right around 10% of the time.\n";
  if ($guess_high > $guess_low) {
    echo "When you guessed wrong, you tended to guess high.\n";
  } elseif ($guess_high < $guess_low) {
    echo "When you guessed wrong, you tended to guess low.\n";
  }
}


echo guessNumber() . "\n";
echo guessNumber() . "\n";
echo guessNumber() . "\n";
echo guessNumber() . "\n";
echo guessNumber() . "\n";
echo guessNumber() . "\n";
echo guessNumber() . "\n";
echo guessNumber() . "\n";
echo guessNumber() . "\n";
echo guessNumber() . "\n";

//nested conditional

<?php
namespace Codecademy;

function both($bool1, $bool2)
{
  if ($bool1) {
    if ($bool2) {
      return "both";
    }
  }
  return "not both";
}

echo both("hi", TRUE) . "\n";
echo both("hi", FALSE) . "\n";
echo both([], "") . "\n";
/*
both
not both
not both
*/

// || or operator

TRUE || TRUE;   // Evaluates to: TRUE

FALSE || TRUE;  // Evaluates to: TRUE

TRUE || FALSE;  // Evaluates to: TRUE

FALSE || FALSE; // Evaluates to: FALSE

$is_admin = FALSE;
$is_user = TRUE;
if ($is_admin || $is_user){
  echo "You can change the password";
}

<?php
namespace Codecademy;
# if we're hungry or desert
function willWeEat($meal, $hungry)
{
  if ($meal === "dessert" || $hungry === TRUE) {
    return "Yum. Thanks!";
  }
  return "No thanks. We're not hungry.";
}

echo willWeEat("dessert", FALSE) . "\n";
echo willWeEat("elevensies", FALSE) . "\n";
echo willWeEat("second breakfast", TRUE) . "\n";
/*
Yum. Thanks!
No thanks. We're not hungry.
Yum. Thanks!
*/

// && operator

TRUE && TRUE;    // Evaluates to: TRUE
FALSE && TRUE;   // Evaluates to: FALSE
TRUE && FALSE;   // Evaluates to: FALSE
FALSE && FALSE;  // Evaluates to: FALSE

$correct_pin = TRUE;
$sufficient_funds = TRUE;
if ($correct_pin && $sufficient_funds){
  echo "You can make the withdrawal.";
}

<?php
namespace Codecademy;
function clapYourHands($happy, $know_it)
{
  if ($happy && $know_it) {
    return "CLAP!";
  }
  return ":(";
}

echo clapYourHands(TRUE, TRUE) . "\n";
echo clapYourHands(FALSE, TRUE) . "\n";

/*
CLAP!
:(
*/

// ! not operator

!10 < 11; // Evaluates to: TRUE
!(10 < 11);  // Evaluates to: FALSE
!TRUE || TRUE; // Evaluates to: TRUE
!(TRUE || TRUE); // Evaluates to: FALSE

$is_logged_in = FALSE; 
if (!$is_logged_in){
  echo "You must log in to continue.";
}


<?php
namespace Codecademy;

function duckDuckGoose($is_goose)
{
  if(!$is_goose) {
    return "duck";
  }
  return "goose!";
}

echo duckDuckGoose("") . "\n";
echo duckDuckGoose(0) . "\n";
echo duckDuckGoose("banana"). "\n";
/*
duck
duck
goose!
*/

// xor operator mutually exclusive or

TRUE xor TRUE;   // Evaluates to: FALSE

FALSE xor TRUE;  // Evaluates to: TRUE

TRUE xor FALSE;  // Evaluates to: TRUE

FALSE xor FALSE; // Evaluates to: FALSE

$is_wearing_glasses = TRUE;
$is_wearing_contacts = TRUE;

if ($is_wearing_glasses xor $is_wearing_contacts){
    echo "Your vision is corrected!";
} else {
    echo "Your vision is impaired.";
}

<?php
namespace Codecademy;
$banana_cream = ["whole milk", "sugar", "cornstarch", "salt", "egg yolks", "butter", "vanilla extract", "bananas", "heavy cream", "powdered sugar"];
$experimental_pie = ["whole milk", "sugar", "bananas", "chicken", "salmon", "garlic"];

// Write your code below:
function eatPie($arr)
{
  if (in_array("bananas", $arr) xor in_array("chicken", $arr)){
    return "Delicious pie!";
  }
  return "Disgusting!";
}

echo eatPie($banana_cream) . "\n"; // only bananas
echo eatPie($experimental_pie) . "\n"; // both bananas and chicken

/*
Delicious pie!
Disgusting!
*/


//alternative syntax || or && and 

// The or Operator:
TRUE or TRUE;   // Evaluates to: TRUE
FALSE or TRUE;  // Evaluates to: TRUE
TRUE or FALSE;  // Evaluates to: TRUE
FALSE or FALSE; // Evaluates to: FALSE

// The and Operator:
TRUE and TRUE;   // Evaluates to: TRUE
FALSE and TRUE;  // Evaluates to: FALSE
TRUE and FALSE;  // Evaluates to: FALSE
FALSE and FALSE; // Evaluates to: FALSE

TRUE || TRUE && FALSE // Evaluates to: TRUE
TRUE || TRUE and FALSE // Evaluates to: FALSE

(TRUE || TRUE) && FALSE // Evaluates to: FALSE
TRUE || (TRUE and FALSE) // Evaluates to: TRUE

<?php
namespace Codecademy;

$is_admin = FALSE;
$is_user = TRUE;
if ($is_admin or $is_user){
  echo "You can change the password.\n";
}


$correct_pin = TRUE;
$sufficient_funds = TRUE;
if ($correct_pin and $sufficient_funds){
  echo "You can make the withdrawal.";
}

/*
You can change the password.
You can make the withdrawal.
*/

//include

// one.php
echo "How are";
// two.php
echo " you?";
// index.php
echo "Hello! ";
include "one.php";
include "two.php";
// Prints: Hello! How are you?

<?php
include "top_bread.php";
include "mayo.php";
include "lettuce.php";
echo "Hmmm, what to put in a BLT aha, bacon\n";
include "bottom_bread.php";

/*
Toasty top bread
Homemade mayonnaise
Crisp, clean lettuce
Hmmm, what to put in a BLT aha, bacon
Toasty bottom bread
*/

/*
Review
Great job! You’ve learned the tools needed to craft programs with powerful decision making capabilities. Let’s review what we covered:

By nesting conditionals within one another, we can create branching decisions.
The logical operator || takes two different boolean values or expressions as its operands and returns a single boolean value. It returns TRUE if either its left operand or its right operand evaluate to TRUE.
The logical && operator returns TRUE only if both of its operands evaluate to TRUE. It returns FALSE if either or both of its operands evaluate to FALSE.
The logical not operator (!) takes only a right operand. It reverses the boolean value of its operand.
The logical exclusive or operator (xor) returns TRUE only if either its left operand or its right operand evaluate to TRUE, but not both or neither.
PHP includes alternate syntax for the || and && operators: we can use or in place of ||, and we can use and in place of &&. These operators work much the same way but have different operator precedence.
We can include code from one file inside another with include which allows us to write mode modular programs.
Awesome work!
*/


