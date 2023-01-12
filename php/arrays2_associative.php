<?php
namespace Codecademy;

// Write your code below:

$php_array = array(
  "language" => "PHP",
  "creator" => "Rasmus Lerdorf",
  "year_created" => 1995,
  "filename_extensions" => [".php", ".phtml", ".php3", ".php4", ".php5", ".php7", ".phps", ".php-s", ".pht", ".phar"]
);

$php_short = ["language" => "PHP",
  "creator" => "Rasmus Lerdorf",
  "year_created" => 1995,
  "filename_extensions" => [".php", ".phtml", ".php3", ".php4", ".php5", ".php7", ".phps", ".php-s", ".pht", ".phar"]];


//printing ...

$grades = [
    "Jane" => 98,
    "Lily" => 74,
    "Dan" => 88,
];

echo $grades; // Prints: Array

echo implode(", ", $grades); // Prints: 98, 74, 88 
print_r($grades);
/*
Array
(
    [Jane] => 98
    [Lily] => 74
    [Dan] => 88
)
*/

<?php
namespace Codecademy;

// Write your code below:
$september_hits = ["The Sixth Sense" => 22896967, "Stigmata" => 18309666,
"Blue Streak" => 19208806, "Double Jeopardy" => 23162542];

echo implode("\n", $september_hits) . "\n\n";
print_r($september_hits);

/*
22896967
18309666
19208806
23162542

Array
(
    [The Sixth Sense] => 22896967
    [Stigmata] => 18309666
    [Blue Streak] => 19208806
    [Double Jeopardy] => 23162542
)

*/
//adding to or accessing dictionary, whoops associative array
//access
$my_array = ["panda"=>"very cute", "lizard"=>"cute", "cockroach"=>"not very cute"];
echo $my_array["panda"]; // Prints: very cute
//add
$my_array["capybara"] = "cutest";
echo $my_array["capybara"]; // Prints: cutest

//messing with key access

$favorites = ["favorite_food"=>"pizza", "favorite_place"=>"my dreams", "FAVORITE_CASE"=>"CAPS","favorite_person"=>"myself"];

echo  $favorites["favorite" . "_" . "food"]; 
// Prints: pizza

$key =  "favorite_place";
echo  $favorites[$key];  
// Prints: my dreams

echo $favorites[strtoupper("favorite_case")];
// Prints: CAPS

//exercise

<?php
namespace Codecademy;
$assignment_one = ["Alex"=> 87, "Kenny"=> 91, "Natalia"=> 91, "Lily"=> 67, "Dan"=> 81, "Kat"=> 77, "Sara" => 65];

$assignment_two = ["Alex"=> 91, "Kenny"=> 99, "Natalia"=> 100, "Lily"=> 61, "Dan"=> 88, "Kat"=> 90];

$assignment_three = ["Alex"=> 78, "Kenny"=> 92, "Natalia"=> 94, "Lily"=> 79, "Dan"=> 73, "Sara" => 61];

$student_name = "Alex";
// Write your code below:
$assignment_two["Sara"] = 65;
$assignment_three["Kat"] = 97;

$dans_grades =[$assignment_one["Dan"], $assignment_two["Dan"], $assignment_three["Dan"]];
#81,88,73
echo $assignment_two[$student_name];
#91

//changing

$new_arr = ["first" => "I am first!", "second" => "I am second!"]; 

$new_arr["third"] = "I am third!";

echo $new_arr["third"]; // Prints: I am third!

$new_arr["third"] = "I am the *NEW* third!";

echo $new_arr["third"]; // Prints: I am the *NEW* third!

//removing (unset)

$nums = ["one" => 1,"two"=> 2];

echo implode(", ", $nums); // Prints: 1, 2

unset($nums["one"]);

echo implode(", ", $nums); // Prints: 2

//exercise

<?php
namespace Codecademy;

$my_car = [
  "oil" => "black and clumpy",
  "brakes" => "new",
  "tires" => "old with worn treads",
  "filth" => "bird droppings", 
  "wiper fluid" => "full", 
  "headlights" => "bright"
];
print_r($my_car);

// Write your code below:

$my_car["oil"] = "new and premium";
$my_car["tires"] = "new with deep treads";
unset($my_car["filth"]);
print_r($my_car);

/*

Array
(
    [oil] => black and clumpy
    [brakes] => new
    [tires] => old with worn treads
    [filth] => bird droppings
    [wiper fluid] => full
    [headlights] => bright
)
Array
(
    [oil] => new and premium
    [brakes] => new
    [tires] => new with deep treads
    [wiper fluid] => full
    [headlights] => bright
)
*/

//numerical keys and mix and match ordered and associative arrays is bad practice,  but possible

$num_array = [1000 => "one thousand", 100 => "one hundred", 600 => "six hundred"];
echo $num_array[1000]; // Prints: one thousand

$ordered = [99, 1, 7, 8];
$ordered["special"] = "Cool!";
echo $ordered[3]; // Prints: 8
echo $ordered["special"]; // Prints: Cool!
/*
When we add an element to an array without specifying a key (e.g. using array_push()), PHP will associate it with the “next” integer key. If no integer keys have been used, it will associate it with the key 0, otherwise it will associate it one more than the largest integer used thus far. This behavior is the same whether the array is being used as an ordered array or an associative array. Let’s look at an example:
*/
$num_array = [1000 => "one thousand", 100 => "one hundred", 600 => "six hundred"];
$num_array[] = "New Element in \$num_array";
echo $num_array[1001]; // Prints: New Element in $num_array

$animals_array = ["panda"=>"very cute", "lizard"=>"cute", "cockroach"=>"not very cute"];
array_push($animals_array, "New Element in \$animals_array");
echo $animals_array[0]; // Prints: New Element in $animals_array
/*
Even though associative arrays and ordered arrays are technically the same, we recommend treating them as separate data types. Only use the empty square brackets syntax (or functions like array_push()) with ordered arrays.

But, for now, let’s break this rule a little to get used to the ins and outs of PHP arrays!
*/

//exercise

<?php
namespace Codecademy;

// Write your code below:
$hybrid_array = [1, 2, 3, 4];
$hybrid_array[8] = "five more";
print_r($hybrid_array);
array_push($hybrid_array, rand());
echo $hybrid_array[9];

/*
Array
(
    [0] => 1
    [1] => 2
    [2] => 3
    [3] => 4
    [8] => five more
)
1143114067 

*/

//joining arrays union (+) operator doesn't replace index in ordered array ...

$my_array = ["panda" => "very cute", "lizard" => "cute", "cockroach" => "not very cute"];
$more_rankings = ["capybara" => "cutest", "lizard" => "not cute", "dog" => "max cuteness"];
$animal_rankings = $my_array + $more_rankings;

/*
The $animal_rankings we created above will have each of the key=>value pairs from $my_array. In addition, it will contain the key=>value pairs from $more_rankings: "capybara"=>"cutest" and "dog"=>"max cuteness". However, since "lizard" is not a unique key, $animal_rankings["lizard"] will retain the value of $my_array["lizard"] (which is "cute").

The union operator can be a little tricky… consider the following union:
*/
$number_array = [8, 3, 7];

$string_array = ["first element", "second element", "third element"];
/*
$union_array = $number_array + $string_array;
What values does $union_array hold? It has the elements 8, 3, and 7. Since the two arrays being joined have identical keys (0, 1, and 2), no values from the second array, $string_array, are included in $union_array.
*/

//exercise

<?php
namespace Codecademy;

$giraffe_foods = ["dip"=>"guacamole", "chips"=>"corn", "entree"=>"grilled chicken"];

$impala_foods = ["dessert"=>"cookies", "vegetable"=>"asparagus", "side"=>"mashed potatoes"];

$rat_foods = ["dip"=>"mashed earth worms", "entree"=>"trash pizza", "dessert"=>"sugar cubes", "drink"=>"lemon water"];

// Write your code below:

$potluck = $giraffe_foods + $impala_foods;
print_r($potluck);

$potluck = $giraffe_foods + $impala_foods + $rat_foods;
print_r($potluck);

/*
Array
(
    [dip] => guacamole
    [chips] => corn
    [entree] => grilled chicken
    [dessert] => cookies
    [vegetable] => asparagus
    [side] => mashed potatoes
)
Array
(
    [dip] => guacamole
    [chips] => corn
    [entree] => grilled chicken
    [dessert] => cookies
    [vegetable] => asparagus
    [side] => mashed potatoes
    [drink] => lemon water
)
*/


//assign by reference or value

$favorites = ["food"=>"pizza", "person"=>"myself", "dog"=>"Tadpole"];
$copy = $favorites;
$alias =& $favorites;
$favorites["food"] = "NEW!";

echo $favorites["food"]; // Prints: NEW!
echo $copy["food"]; // Prints: pizza
echo $alias["food"]; // Prints: NEW!

//need to be aware in functions of passing value or reference
//below object unchanged
function changeColor ($arr) 
{
  $arr["color"] = "red";    
}
$object = ["shape"=>"square", "size"=>"small", "color"=>"green"];
changeColor ($object);
echo $object["color"]; // Prints: green

//with reference works this time

function reallyChangeColor (&$arr) 
{
  $arr["color"] = "red";    
}
$object = ["shape"=>"square", "size"=>"small", "color"=>"green"];
reallyChangeColor ($object);
echo $object["color"]; // Prints: red

//exercise

<?php
namespace Codecademy;
$doge_meme = ["top_text" => "Such Python", "bottom_text" => "Very language. Wow.", "img" => "very-cute-dog.jpg", "description" => "An adorable doge looks confused."];

$bad_meme = ["top_text" => "i don't know", "bottom_text" => "i can't think of anything", "img" => "very-fat-cat.jpg", "description" => "A very fat cat looks happy."];

// Write your code below:

function createMeme($meme)
{
  $meme["top_text"] = "Much PHP";
  $meme["bottom_text"] = "Very programming. Wow.";
  return $meme;
}

$php_doge = createMeme($doge_meme);
print_r($php_doge);

function fixMeme(&$meme)
{
  $meme["top_text"] = "Much more PHP";
  $meme["bottom_text"] = "Very tired. Wow.";
  return $meme;
}

$php_bad = fixMeme($bad_meme);
print_r($php_bad);

/*
Array
(
    [top_text] => Much PHP
    [bottom_text] => Very programming. Wow.
    [img] => very-cute-dog.jpg
    [description] => An adorable doge looks confused.
)
Array
(
    [top_text] => Much more PHP
    [bottom_text] => Very tired. Wow.
    [img] => very-fat-cat.jpg
    [description] => A very fat cat looks happy.
)
*/


/*
ASSOCIATIVE ARRAYS
Review
You learned so much in this lesson! Let’s review:

Associative arrays are data structures in which string or integer keys are associated with values.
We use the => operator to associate a key with its value. $my_array = ["panda"=>"very cute"]
To print an array’s keys and their values, we can use the print_r() function.
We access the value associated with a given key by using square brackets ([ ]). For example: $my_array["panda"] will return "very cute".
We can assign values to keys using this same indexing syntax and the assignment operator (=): $my_array["dog"] = "good cuteness";
This same syntax can be used to change existing elements. $my_array["dog"] = "max cuteness";
We can remove a key=>value pair entirely using the PHP unset() function.
Keys can be integers. In fact, ordered arrays are just arrays in which integer keys have been assigned to the values automatically.
In PHP, associative arrays and ordered arrays are different uses of the same data type.
The union (+) operator takes two array operands and returns a new array with any unique keys from the second array appended to the first array.
When writing function with array parameters, we can pass the array by value or by reference depending on our intent.
Awesome work!
*/

// sample code

<?php
$doge_meme = ["top_text" => "Such Python", "bottom_text" => "Very language. Wow.", "img" => "very-cute-dog.jpg", "description" => "An adorable doge looks confused."];

$doge_meme["new value"] = "Woah I'm new";

echo "\n" . $doge_meme["new value"];

array_push($doge_meme, "just an example");

echo "\n" . $doge_meme[0] . "\n";

unset($doge_meme[0]);
unset($doge_meme["new value"]);

$doge_meme["description"] = "A wonderful dog picture with a brand new description.";

function createMeme ($meme) 
{
  $meme["top_text"] = "Much PHP";
  $meme["bottom_text"] = "Very programming. Wow.";
  return $meme;
}  

$php_doge = createMeme($doge_meme);

print_r($doge_meme);

print_r($php_doge);

function fixMeme (&$meme) 
{
  $meme["top_text"] = "I can haz";
  $meme["bottom_text"] = "PHP, plz?";
} 

$lame_meme = ["top_text" => "i don't know", "bottom_text" => "i can't think of anything", "img" => "very-fat-cat.jpg", "description" => "An very fat cat looks happy."];

print_r($lame_meme);

fixMeme ($lame_meme);

print_r($lame_meme);

//bobs savings

<?php
  
$annualExpenses = [
    "vacations" => 1000,
    "carRepairs" => 1000,    
];

$monthlyExpenses = [
    "rent" => 1500,
    "utilities" => 200,
    "healthInsurance" => 200
];

$grossSalary = 48150;
$socialSecurity = $grossSalary * .062;

$incomeSegments = [[9700, .88], [29775, .78], [8675, .76]];

// Write your code below:

function net($seg)
{
  $income = $seg[0][0] * $seg[0][1]
  + $seg[1][0] * $seg[1][1]
  + $seg[2][0] * $seg[2][1];
  return $income;
}

$annualExp = $annualExpenses["vacations"] + $annualExpenses["carRepairs"]; 

$netIncome = net($incomeSegments);
$annualIncome = $netIncome - $socialSecurity - $annualExp;
echo $annualIncome . "\n";
$monthlyIncome = $annualIncome / 12;
$monthlyExp = $monthlyExpenses["rent"] + $monthlyExpenses["utilities"] + 
$monthlyExpenses["healthInsurance"];
$monthlyIncome -= $monthlyExp;
echo $monthlyIncome . "\n";
$weeklyIncome = $monthlyIncome / 4.33;

$weeklyExpenses = [
    "gas" => 25,
    "food" => 90,
    "entertainment" => 47
];

$weeklyExp = $weeklyExpenses["gas"] + $weeklyExpenses["food"]  
+ $weeklyExpenses["entertainment"];

$weeklyIncome -= $weeklyExp;
echo $weeklyIncome . "\n";

$bobSavings = 52 * $weeklyIncome;
echo "$" . round($bobSavings, 2);

/*
33368.2
880.68333333333
41.391070053888
$2152.34
*/
