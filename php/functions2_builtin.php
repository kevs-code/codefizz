<?php

namespace Codecademy;

$first = "Welcome to the magical world of built-in functions.";
  
$second = 82137012983; 

//Write your code below:
echo gettype($first);
echo "\n";
echo gettype($second);
echo "\n";
echo var_dump($first);
echo var_dump($second);
/*
string
integer
string(51) "Welcome to the magical world of built-in functions."
int(82137012983)
*/

//

<?php
namespace Codecademy;

// Write your code below:
echo strrev(".pu ti peeK .taerg gniod er'uoY");
echo "\n";
echo strtolower("SOON, tHiS WILL Look NoRmAL.");
echo "\n";
echo str_repeat("\nThere's no place like home.\n", 3);

/*
You're doing great. Keep it up.
soon, this will look normal.

There's no place like home.

There's no place like home.

There's no place like home.
*/

//
<?php
namespace Codecademy;

$essay_one = "I really enjoyed the book. I thought the characters were really interesting. The plot of the novel was really engaging. I really felt the characters' emotions. They were really well-written. I really wish the ending had been different though.";
  
$essay_two = "Obviously this is a really good book. You obviously would not have made us read it if it wasn't. I felt like the ending was too obvious though. It was so obvious who did it right away. I think the thing with the light was obviously a metaphor for life. It would have been better if the characters were less obvious about their secrets.";  

// Write your code below:
echo substr_count($essay_one, "really"); // counts pattern occurence in string
echo "\n";
echo substr_count($essay_two, "obvious"); // so counts count obviously and obvious
//number functions
<?php
namespace Codecademy;
 
// Write your code below:
//abs = absolute number regardless of sign +/-
function calculateDistance($num1, $num2)
{
  return abs($num1 - $num2);
}


echo calculateDistance(-1, 4) . "\n"; //should return 5
echo calculateDistance(4, -1) . "\n"; //should return 5
echo calculateDistance(3, 7) . "\n"; //should return 4
echo calculateDistance(7, 3) . "\n"; //should return 4

//round .50 = round down gives integer
function calculateTip($num)
{
  return round($num * 1.18);
}

echo "$" . calculateTip(100) . "\n"; //should return 118
echo "$" . calculateTip(35) . "\n"; //should return 41
echo "$" . calculateTip(88.77) . "\n";//should return 105
/*
5
5
4
4
$118
$41
$105
*/


<?php
namespace Codecademy;

// Write your code below:
$max = getrandmax(); 

echo $max;
#2147483647 
echo "\n";
echo rand();
// number between 0 and environments max number result ...
#1096615833
echo "\n";
echo rand(1, 52);
// number between 1 and 52
#36

/*

Documentation
In order to understand built-in functions we’ve never used before, we’ll want to get comfortable understanding how they are represented in the documentation. Documentation typically includes:

The name of the function.
The versions of the PHP language the function is available in.
An overview of how the function works.
Additional details on the parameters and return value.
Examples of the function in use.
User comments further explaining features of the function.
The description section can be confusing, so we’ll break that down.

Here’s the description for the abs() function:

abs ( mixed $number ) : number

Here we see the function name followed by parentheses. The parentheses contain information about the function’s parameter(s)—first the parameter’s type followed by its name. The parameter for abs() has the type mixed because there are multiple data types the function will accept (an integer or a float). The parameter for abs() is named $number. After the parentheses is a colon (:) followed by number; this is the data type the function will return.

A function that prints something but doesn’t return a value will have :void instead of a return type. Similarly, a function that doesn’t accept parameters will have void within its parentheses.

Let’s look at a more complicated example. Here’s the description for the substr_count() function:

substr_count ( string $haystack , string $needle [, int $offset = 0 [, int $length ]] ) : int

Earlier in this lesson, we invoked substr_count() with only the two string parameters ($haystack and $needle). But functions can have optional parameters. This means they’ll work with or without them. These parameters are wrapped in square brackets ([ ]) in the function’s description. An optional parameter may have a default value, this is the value that will be used if no argument is passed into the function. The default value is indicated with an equal sign (=).

The substr_count() function accepts two additional integer arguments—$offset and $length. $offset has a default value of 0. Take a look at the documentation and see if you can figure out what they do.

Let’s practice reading some function descriptions!
*/
#Instructions
#1.
#Here’s the description for the str_pad() built-in function:

// figure this ... 
#str_pad ( string $input , int $pad_length [, string $pad_string = " " [, int $pad_type = STR_PAD_RIGHT ]] ) : string

<?php
namespace Codecademy;

$a = 29;
$b = "You did it!";
$c = STR_PAD_BOTH;
$d = "*~*";

// Write your code below:
echo str_pad($b, $a, $d, $c);

#*~**~**~*You did it!*~**~**~*

<?php
namespace Codecademy;

// Write your code below:
function convertToShout($string)
{
  return strtoupper($string) . "!";
}

echo convertToShout("woah there, buddy");
echo "\n";
echo convertToShout("i just don't know");
echo "\n";
echo convertToShout("oh, ok, that's fine");
echo "\n";
echo convertToShout("it's nice to meet you");
echo "\n";
/*
WOAH THERE, BUDDY!
I JUST DON'T KNOW!
OH, OK, THAT'S FINE!
IT'S NICE TO MEET YOU!
*/

function tipGenerously($num)
{
  return ceil($num * 1.2);
}

echo tipGenerously(100.00) . "\n"; // should return 120
echo tipGenerously(982.27) . "\n"; // should return 1179
echo tipGenerously(15.67) . "\n"; // should return 19
echo tipGenerously(66.18) . "\n"; // should return 80
echo tipGenerously(21.65) . "\n"; // should return 26o

function calculateCircleArea($diameter)
{
  // 1/4pi *d^2
  echo (1/4 * pi()) * $diameter ** 2 . "\n";
  // or below pi/r^2
  return (($diameter/2) ** 2) * pi();
}

echo calculateCircleArea(25) . "\n"; //should return 490.87385212341
echo calculateCircleArea(30) . "\n"; // should return 706.8583470577
echo calculateCircleArea(872) . "\n"; // should return 597204.19707681
echo calculateCircleArea(6) . "\n"; // should return 28.274333882308
echo calculateCircleArea(29) . "\n"; // should return 660.51985541725

/*
120
1179
19
80
26
490.87385212341
490.87385212341
706.8583470577
706.8583470577
597204.19707681
597204.19707681
28.274333882308
28.274333882308
660.51985541725
660.51985541725
*/

//more examples

<?php
$string_var = "Check it out";
echo strtoupper($string_var) . "!\n";

echo ceil(8.873);
echo "\n";
  
echo pi();
echo "\n";

echo str_pad("PHP", 30, "*^*-", STR_PAD_BOTH);
echo "\n";

echo getrandmax();
echo "\n";

echo rand();
echo "\n";

echo rand(1, 52);
echo "\n";

echo abs(-1287);
echo "\n";

echo round(8723.999);
echo "\n";

echo substr_count($string_var, " ");
echo "\n";

echo strrev("\n.pu ti peeK .taerg gniod er'uoY");

echo strtolower("SOON, tHiS WILL Look NoRmAL.\n");

echo str_repeat("There's no place like home.\n", 3);

echo gettype($string_var);
echo "\n";
echo var_dump($string_var);

/*
In PHP, intdiv() returns the integer quotient of the division of dividend by divisor.

For example, if the dividend was 8 and the divisor was 3, it would return 2. (8 divided by 3 is 2.667, the integer portion of this is 2)
*/

/*
PHP has a function hebrev() which converts logical Hebrew text to visual text:

hebrev ( string $hebrew_text [, int $max_chars_per_line = 0 ] ) : string
Given the function definition, which of the following does not set $max_chars_per_line to 0?
hebrev($string, 10);
*/

// math function project

<?php
$initial = '555';
$a = octdec($initial); // octal to decimal number
echo $a . "\n";
$b = deg2rad($a); // degrees to radians
echo $b . "\n";
$c = cos($b); // get cosine from radians
echo $c . "\n";
$d = round ($c, 3); // round cosine to 3 dp
echo $d . "\n";
$e = log($d); // returns natural log of float
echo $e . "\n";
$f = abs($e); // absolute value
echo $f . "\n";
$g = acos($f); // arc or inv cosine
echo $g . "\n";
$h = rad2deg($g); // radians to degrees
echo $h . "\n";
$i = floor($h); // maths floor
echo $i . "\n";
$j = $i -47; // 42 here we are!
echo "The answer to the meaning of life the universe and everything is " . $j . ".\n";
#42
