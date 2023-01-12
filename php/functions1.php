<?php
// Write your code below:
  function praisePHP()
  {
    echo "Hail to the King, PHP!";
  }
 // windsor davies

<?php
// Write your code below:
function inflateEgo()
{
  echo "You lovely boy!\n";
}

inflateEgo(); 
inflateEgo();
//
<?php

// Write your code below:
function printStringReturnNumber()
{
  echo "Three\n";
  return 3;
}

$my_num = printStringReturnNumber();
echo $my_num;

// return also acts as function break

<?php

function notFound()
{
  echo "ERROR: Page not found!\n";
  return 404;
}

function greetLearner()
{
  echo "Hello, Learner!\n";
  echo "I hope you're (still) enjoying PHP!\n";
  echo "Love, Codecademy\n";
  return "<3";
}

// Don't change the code below:

$error = notFound(); 
$heart = greetLearner();

echo "I received a $error, but it's ok because I also received $heart.";

#function return string can concancenate with . or + with numbers


function second()
{
  return "You're amazing!\n";
}

function third()
{
  return "You're a coding hero!\n";
}

// Write your code below:

echo first() . second() . third();

// without a return statement return = null ('') or nothing if math operator on answer acts as 0


<?php

// Write your code below:
 function createVacuum() 
 {
   //echo "hmmm\n";
 }

echo createVaccum();
echo createVacuum() * 10;

//Harry met Sally!

<?php
// Write your code below:
function increaseEnthusiasm($string)
{
  $string .= "!";
  return $string;
}

echo increaseEnthusiasm("Yes");

function repeatThreeTimes($string)
{
  $string = $string . $string . $string;
  return $string;
}

echo repeatThreeTimes("Yes ");
# Harry met Sally, Meg Ryan says ...
echo increaseEnthusiasm(repeatThreeTimes("Yes "));

//meh

<?php
// Write your code below:
function calculateArea($height, $width)
{
  return $height * $width;
}

echo calculateArea(6, 7);

// Write your code below:
function calculateVolume($height, $width, $depth)
{
  return $height * $width * $depth;
}
echo "\n";
echo calculateVolume(2, 3, 7);
#42
#42

//bill time

<?php
// Write your code below:

function calculateTip($cost, $tip = 20)
{
  return $cost + ($cost * $tip/100);
}

echo "$" . calculateTip(100, 25) . "\n";
echo "$" . calculateTip(100) . "\n";
echo "$" . calculateTip(65, 15) . "\n";

// & reference operator to permanently change function $string parameter

<?php

$string_one = "you have teeth";
$string_two = "toads are nice";
$string_three = "brown is my favorite color";

// Write your code below:
function convertToQuestion(&$string)
{
  $string = "Do you think " . $string . "?\n";
  echo $string;
}

$string = 'hee';
echo convertToQuestion($string);
echo $string;
echo convertToQuestion($string_one);
echo convertToQuestion($string_two);
echo convertToQuestion($string_three);

#Do you think hee?
#Do you think hee?
#Do you think you have teeth?
#Do you think toads are nice?
#Do you think brown is my favorite color?

#scope, must declare globals in functions before use

<?php

$language = "PHP";
$topic = "scope";

function generateLessonName($concept)
{
  global $language;
  return $language . ": " . $concept;
}

echo generateLessonName($topic);

#PHP: scope

/*

Review
Great job! Let’s review what we covered in this lesson:

We can package a set of instructions within a named function to reuse whenever we’d like.

When we invoke a function, the computer will execute the function body, specified by the code block following the parameters list.

Functions can return a value by using the return keyword otherwise they return NULL which means no value.

We can store the return value of a function in a variable or use it any other way we’d use a value.

We can define functions with parameters which are variables we can refer to throughout our function’s body.

When invoking functions, the values that we give them are called arguments.

Functions can have multiple parameters.

The order in which the arguments are passed in decides which parameters they correspond to.

You can make an argument optional by providing its corresponding parameter with a default value.

If you prepend a parameter with the reference sign (&) that argument will be passed by reference.

Variables within functions have local scope and can not be accessed from outside the function.

Use the global keyword to use variables from the global scope within a function.

*/

// project

<?php
function generateStory($singularNoun, $verb, $color, $distance_unit)
{
  $story = "\n" .
  "The ${singularNoun}s are lovely, $color, and deep.\n" . 
  "But I have promises to keep,\n" .
  "And ${distance_unit}s to go before I $verb,\n" .
  "And ${distance_unit}s to go before I $verb.\n";
  
  return $story;
}

echo generateStory("Robot", "ran", "brown", "parsec");
echo generateStory("Dorothy", "found", "red", "meter");
echo generateStory("Verruca", "went", "purple", "cubit");
