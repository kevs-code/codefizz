<?php
//part1 ordered arrays
// Write your code below:
$first_array = array("zero",1,"two",3,"four");
echo count($first_array);
#5 count is length array including mixed array declared in array() 
//short syntax

$number_array = [0, 1, 2];
//pffft to white space

$long_array = [
  1,
  2,
  3,
  4,
  5,
  6
];

# budda

<?php
namespace Codecademy;

// Write your code below:
$with_function = array("PHP", "popcorn", 555.55);
$with_short = ["PHP", "popcorn", 555.55];

#play with a spoon and fork
/*
$number_array = [0, 1, 2];
echo $number_array; // Prints: Array
print_r($number_array); // prints human readable
echo implode(", ", $number_array); // like join
*/

<?php
namespace Codecademy;

$message = ["Oh hey", " You're doing great", " Keep up the good work!\n"];

$favorite_nums = [7, 201, 33, 88, 91];
// Write your code below:
echo implode("!", $message);
echo print_r($favorite_nums);
/*
Oh hey! You're doing great! Keep up the good work!
Array
(
    [0] => 7
    [1] => 201
    [2] => 33
    [3] => 88
    [4] => 91
)
1
*/
/*
echo $message 
ArrayPHP Notice:  Array to string conversion in /home/ccuser/workspace/ordered-arrays-printing-arrays/src/index.php on line 10
*/

//reference an index


$round_one = ["X", "X", "first winner"];

$round_two = ["second winner", "X", "X", "X"];

$round_three = ["X", "X", "X", "X", "third winner"];

// Write your code below:
$winners = [$round_one[2], $round_two[0], $round_three[4]];

echo implode("\n", $winners);

#first winner
#second winner
#third winner
//reassign and append syntax (new)

<?php
namespace Codecademy;

$change_me = [3, 6, 9];
// Write your code below

$change_me[] = "twelve";
$change_me[] = 15;
$change_me[1] = "tadpole";
echo print_r($change_me);

Array
(
    [0] => 3
    [1] => tadpole
    [2] => 9
    [3] => twelve
    [4] => 15
)
1

// push and pop end of array

<?php
namespace Codecademy;

$stack = ["wild success", "failure", "struggle"];
// Write your code below:
array_push($stack, "blocker", "impediment");
// ["wild success", "failure", "struggle", "blocker", "impediment"];
array_pop($stack); 
array_pop($stack); 
array_pop($stack); 
array_pop($stack); 
print_r($stack);

Array
(
    [0] => wild success
)

// shift (front pop) and unshift (front push) beginning of array

$adjectives = ["bad", "good", "great", "fantastic"];
$removed = array_shift($adjectives); 
echo $removed; //Prints: bad
echo implode(", ", $adjectives); // Prints: good, great, fantastic 

$foods = ["pizza", "crackers", "apples", "carrots"];
$arr_len = array_unshift($foods, "pasta", "meatballs", "lettuce"); 
echo $arr_len; //Prints: 7
echo implode(", ", $foods); 
// Prints: pasta, meatballs, lettuce, pizza, crackers, apples, carrots


#olympics

<?php
namespace Codecademy;
$record_holders = [];
// Write your code below:

#$arr_len = array_unshift($record_holders, "Carl Lewis", "Leroy Burrell", "Donovan Bailey", "Maurice Greene", "Tim Montgomery");
$arr_len = array_unshift($record_holders, "Tim Montgomery", "Maurice Greene", "Donovan Bailey", "Leroy Burrell", "Carl Lewis");
echo "Ben Johnson was invalidated.\n";
echo $arr_len . "\n";
echo implode(", ", $record_holders) . "\n";
$invalidated = array_shift($record_holders);
echo "whoops, $invalidated was invalidated.\n";
echo  $arr_len = array_unshift($record_holders, "Justin Gatlin", "Asafa Powell") . "\n";
$invalidated .= " and " . array_shift($record_holders);
echo "whoops, $invalidated were invalidated.\n";
$arr_len = array_unshift($record_holders, "Usain Bolt");
echo implode(", ", $record_holders) . "\n";

/*
Ben Johnson was invalidated.
5
Tim Montgomery, Maurice Greene, Donovan Bailey, Leroy Burrell, Carl Lewis
whoops, Tim Montgomery was invalidated.
6
whoops, Tim Montgomery and Justin Gatlin were invalidated.
Usain Bolt, Asafa Powell, Maurice Greene, Donovan Bailey, Leroy Burrell, Carl Lewis
*/

//nested arrays

<?php
namespace Codecademy;


$treasure_hunt = ["garbage", "cat", 99, ["soda can", 8, ":)", "sludge", ["stuff", "lint", ["GOLD!"], "cave", "bat", "scorpion"], "rock"], "glitter", "moonlight", 2.11];
  
// Write your code below:
#find GOLD!
echo $treasure_hunt[3][4][2][0];  
#GOLD!

/*
Review
We covered a lot in this lesson! Great job. Take a second to review everything you learned:

Arrays are ordered collections of data that are a type of data structure fundamental to computer science.
In PHP, we refer to this data structure as ordered arrays.
The location of an element in an array is known as its index.
The elements in an ordered array are arranged in ascending numerical order starting with index zero.
We can construct ordered arrays with a built-in PHP function: array().
We can construct ordered arrays with short array syntax, e.g. [1,2,3].
We can print arrays using the built-in print_r() function or by converting them into strings using the implode() function.
We use square brackets ([]) to access elements in an array by their index.
We can add elements to the end of an array by appending square brackets ([]) to an array variable name and assigning the value with the assignment operator (=).
We can change elements in an array using array indexing and the assignment operator.
The array_pop() function removes the last element of an array.
The array_push() function adds elements to the end of an array.
The array_shift() function removes the first element of an array.
The array_unshift() function adds elements to the beginning of the array.
We can use chained square brackets ([]) to access and change elements within a nested array.
*/

// example code


<?php
// Using array() to construct an array:
$prime_numbers = array(2, 3, 5, 7, 11, 13, 17);  
  
// Using short array syntax:
$animals = ["dog", "cat", "turtle", "cow"];  

// Printing with print_r():
print_r($prime_numbers);

echo "\n\n";

// Printing with echo and implode()
echo implode(", ", $animals);

// Adding an element with square brackets:
$prime_numbers[] = 19;

// Accessing an array element:
$favorite_animal = $animals[0];
echo "\nMy favorite animal: " . $favorite_animal;

// Reassigning an element:
$animals[1] = "tiger";

// Using array_pop():
echo "\nBefore pop: " . implode(", ", $animals);
array_pop($animals);
echo "\nAfter pop: " . implode(", ", $animals);

// Using array_push():
echo "\nBefore push: " . implode(", ", $prime_numbers);
array_push($prime_numbers, 23, 29, 31, 37, 41);
echo "\nAfter push: " . implode(", ", $prime_numbers);

//Using array_shift():
echo "\nBefore shift: " . implode(", ", $animals);
array_shift($animals);
echo "\nAfter shift: " . implode(", ", $animals);

//Using array_unshift():
echo "\nBefore unshift: " . implode(", ", $animals);
array_unshift($animals, "horse", "zebra", "lizard");
echo "\nAfter unshift: " . implode(", ", $animals);

//Using chained operations with nested arrays:
$treasure_hunt = ["garbage", "cat", 99, ["soda can", 8, ":)", "sludge", ["stuff", "lint", ["GOLD!"], "cave", "bat", "scorpion"], "rock"], "glitter", "moonlight", 2.11];

echo "\nWe found " . $treasure_hunt[3][4][2][0];

// why do these = 2 both add 1 to 1 somehow?

php > $arr = [1]; 
php > echo array_unshift($arr, 0);
2

php > $arr = [1];
php > echo array_push($arr, 0);
2

