<?php
$count = 1;
while ($count < 11)
{
  echo "The count is: " . $count . "\n";
  $count += 1;
}

<?php
$count = 1;
while ($count < 101)
{
  if ($count % 33 == 0){
    echo $count . " is divisible by 33\n";
  }
$count += 1;
}
/*
33 is divisible by 33
66 is divisible by 33
99 is divisible by 33
*/

$count = 1;
do {
  echo "The count is: " . $count . "\n";
  $count += 1;
} while ($count < 11);

do {
  $guess = readline("\nGuess the number\n");
} while ($guess != "42");
echo "\nYou correctly guessed 42!";

<?php
  $plant_height = 28;

do {
  echo "The plant is $plant_height tall.\n";
  if ($plant_height >= 30) {
    echo "And can produce fruit.\n";
  }
  $plant_height += 1;
} while ($plant_height < 32);

/*
The plant is 28 tall.
The plant is 29 tall.
The plant is 30 tall.
And can produce fruit.
The plant is 31 tall.
And can produce fruit.
*/

//for

for ($count = 1; $count < 11; $count++)
{
  echo "The count is: " . $count . "\n";
}

<?php
for ($i = 10; $i >= 0; $i--)
{
  if ($i <= 10 && $i >= 3) {
    echo "$i\n";
  } elseif ($i === 2) {
    echo "Ready!\n";
  } elseif ($i === 1) {
    echo "Set!\n";
  } else {
    echo "Go!\n";
  }

}
/*
10 ... 3
Ready!
Set!
Go!
*/
//foreach
$counting_array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
foreach ($counting_array as $count) {
  echo "The count is: " . $count . "\n";
}

$details_array = ["color" => "blue", "shape" => "square"];
foreach ($details_array as $detail) {
  echo "The detail is: " . $detail . "\n";
}

$details_array = ["color" => "blue", "shape" => "square"];
foreach ($details_array as $attribute => $detail) {
  echo "The " . $attribute . " is: " . $detail . "\n";
}

<?php
$scores = [
  "Alice" => 99,
  "Bob" => 95,
  "Charlie" => 98,
  "Destiny" => 91,
  "Edward" => 88
];

foreach ($scores as $score) {
  echo "Someone received a score of $score.\n";
}

foreach ($scores as $student => $score) {
  echo "$student received a score of $score.\n";
}

/*
Someone received a score of 99.
Someone received a score of 95.
Someone received a score of 98.
Someone received a score of 91.
Someone received a score of 88.
Alice received a score of 99.
Bob received a score of 95.
Charlie received a score of 98.
Destiny received a score of 91.
Edward received a score of 88.
*/

//break
$count = 1;
while ($count < 11)
{
  echo "The count is: " . $count . "\n";
  if ($count === 5) {
    break;
  }
  $count += 1;
}

//continue

$count = 1;
while ($count < 11)
{
  if ($count === 5) {
    $count += 1;
    continue;
  }
  echo "The count is: " . $count . "\n";
  $count += 1;
}

//break and continue

<?php
  for ($i = 10; $i >= 0; $i--) {
    if ($i === 6) {
      continue;
    }
    if ($i === 2) {
      echo "Ready!\n";
    } elseif ($i === 1) {
      echo "Set!\n";
      break;
    } elseif ($i === 0) {
      echo "Go!\n";
    } else {
      echo $i . "\n";
    }
  }

/*

10
9
8
7
5
4
3
Ready!
Set!

*/

/*

Review
Now you have the ability to repeat execution of code blocks as necessary in your PHP programs.

Here is a summary of the topics covered in this lesson:

while loops execute only as long as their conditional evaluates to TRUE.
do…while loops always execute at least once and then continue executing while their conditional is TRUE.
for loops contain 3 expressions and are frequently used to execute a code block a specific number of times.
The first expression is executed prior to the first iteration.
The second expression is evaluated prior to each iteration. If TRUE, the code block executes. Otherwise, the loop terminates.
The third expression is evaluated after each iteration.
foreach loops are used for iterating over the elements of an array. The key and value of each element is available in the code block.
break is used to end execution of a loop early.
continue is used to end execution of a loop iteration early and continues to the next iteration.

*/

<?php
# while
$count = 5;
echo "Countdown!\n";
while ($count > -1) {
  echo $count . "\n";
  $count--;
}
echo "Blastoff!\n\n";

# do...while
$lights = "off";
do {
  echo "The lights are " . $lights . "\n";
  if ($lights === "off") {
    $lights = "on";
  } else {
    $lights = "off";
  }
} while ($lights === "on");
echo "\n";

# for
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=2){
  echo $names[$index] . "\n";
}
echo "\n";

# foreach
$properties = [
  "temperature" => "cold",
  "weather" => "rainy",
  "sky" => "gray"
              ];
foreach ($properties as $key=>$value) {
  echo "The $key is $value.\n";
}
echo "\n";

# break and continue
# this skips printing Ann and will
# stop execution after printing
# Dave
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=1){
  if ($names[$index] == "Ann") {
    continue;
  }
  echo $names[$index] . "\n";
  if ($names[$index] == "Dave") {
    break;
  }
}

/*

Review
Now you have the ability to repeat execution of code blocks as necessary in your PHP programs.

Here is a summary of the topics covered in this lesson:

while loops execute only as long as their conditional evaluates to TRUE.
do…while loops always execute at least once and then continue executing while their conditional is TRUE.
for loops contain 3 expressions and are frequently used to execute a code block a specific number of times.
The first expression is executed prior to the first iteration.
The second expression is evaluated prior to each iteration. If TRUE, the code block executes. Otherwise, the loop terminates.
The third expression is evaluated after each iteration.
foreach loops are used for iterating over the elements of an array. The key and value of each element is available in the code block.
break is used to end execution of a loop early.
continue is used to end execution of a loop iteration early and continues to the next iteration.

*/

<?php
# while
$count = 5;
echo "Countdown!\n";
while ($count > -1) {
  echo $count . "\n";
  $count--;
}
echo "Blastoff!\n\n";

# do...while
$lights = "off";
do {
  echo "The lights are " . $lights . "\n";
  if ($lights === "off") {
    $lights = "on";
  } else {
    $lights = "off";
  }
} while ($lights === "on");
echo "\n";

# for
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=2){
  echo $names[$index] . "\n";
}
echo "\n";

# foreach
$properties = [
  "temperature" => "cold",
  "weather" => "rainy",
  "sky" => "gray"
              ];
foreach ($properties as $key=>$value) {
  echo "The $key is $value.\n";
}
echo "\n";

# break and continue
# this skips printing Ann and will
# stop execution after printing
# Dave
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=1){
  if ($names[$index] == "Ann") {
    continue;
  }
  echo $names[$index] . "\n";
  if ($names[$index] == "Dave") {
    break;
  }
}

/*

Review
Now you have the ability to repeat execution of code blocks as necessary in your PHP programs.

Here is a summary of the topics covered in this lesson:

while loops execute only as long as their conditional evaluates to TRUE.
do…while loops always execute at least once and then continue executing while their conditional is TRUE.
for loops contain 3 expressions and are frequently used to execute a code block a specific number of times.
The first expression is executed prior to the first iteration.
The second expression is evaluated prior to each iteration. If TRUE, the code block executes. Otherwise, the loop terminates.
The third expression is evaluated after each iteration.
foreach loops are used for iterating over the elements of an array. The key and value of each element is available in the code block.
break is used to end execution of a loop early.
continue is used to end execution of a loop iteration early and continues to the next iteration.

*/

<?php
# while
$count = 5;
echo "Countdown!\n";
while ($count > -1) {
  echo $count . "\n";
  $count--;
}
echo "Blastoff!\n\n";

# do...while
$lights = "off";
do {
  echo "The lights are " . $lights . "\n";
  if ($lights === "off") {
    $lights = "on";
  } else {
    $lights = "off";
  }
} while ($lights === "on");
echo "\n";

# for
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=2){
  echo $names[$index] . "\n";
}
echo "\n";

# foreach
$properties = [
  "temperature" => "cold",
  "weather" => "rainy",
  "sky" => "gray"
              ];
foreach ($properties as $key=>$value) {
  echo "The $key is $value.\n";
}
echo "\n";

# break and continue
# this skips printing Ann and will
# stop execution after printing
# Dave
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=1){
  if ($names[$index] == "Ann") {
    continue;
  }
  echo $names[$index] . "\n";
  if ($names[$index] == "Dave") {
    break;
  }
}

/*

Review
Now you have the ability to repeat execution of code blocks as necessary in your PHP programs.

Here is a summary of the topics covered in this lesson:

while loops execute only as long as their conditional evaluates to TRUE.
do…while loops always execute at least once and then continue executing while their conditional is TRUE.
for loops contain 3 expressions and are frequently used to execute a code block a specific number of times.
The first expression is executed prior to the first iteration.
The second expression is evaluated prior to each iteration. If TRUE, the code block executes. Otherwise, the loop terminates.
The third expression is evaluated after each iteration.
foreach loops are used for iterating over the elements of an array. The key and value of each element is available in the code block.
break is used to end execution of a loop early.
continue is used to end execution of a loop iteration early and continues to the next iteration.

*/

<?php
# while
$count = 5;
echo "Countdown!\n";
while ($count > -1) {
  echo $count . "\n";
  $count--;
}
echo "Blastoff!\n\n";

# do...while
$lights = "off";
do {
  echo "The lights are " . $lights . "\n";
  if ($lights === "off") {
    $lights = "on";
  } else {
    $lights = "off";
  }
} while ($lights === "on");
echo "\n";

# for
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=2){
  echo $names[$index] . "\n";
}
echo "\n";

# foreach
$properties = [
  "temperature" => "cold",
  "weather" => "rainy",
  "sky" => "gray"
              ];
foreach ($properties as $key=>$value) {
  echo "The $key is $value.\n";
}
echo "\n";

# break and continue
# this skips printing Ann and will
# stop execution after printing
# Dave
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=1){
  if ($names[$index] == "Ann") {
    continue;
  }
  echo $names[$index] . "\n";
  if ($names[$index] == "Dave") {
    break;
  }
}

/*

Review
Now you have the ability to repeat execution of code blocks as necessary in your PHP programs.

Here is a summary of the topics covered in this lesson:

while loops execute only as long as their conditional evaluates to TRUE.
do…while loops always execute at least once and then continue executing while their conditional is TRUE.
for loops contain 3 expressions and are frequently used to execute a code block a specific number of times.
The first expression is executed prior to the first iteration.
The second expression is evaluated prior to each iteration. If TRUE, the code block executes. Otherwise, the loop terminates.
The third expression is evaluated after each iteration.
foreach loops are used for iterating over the elements of an array. The key and value of each element is available in the code block.
break is used to end execution of a loop early.
continue is used to end execution of a loop iteration early and continues to the next iteration.

*/

<?php
# while
$count = 5;
echo "Countdown!\n";
while ($count > -1) {
  echo $count . "\n";
  $count--;
}
echo "Blastoff!\n\n";

# do...while
$lights = "off";
do {
  echo "The lights are " . $lights . "\n";
  if ($lights === "off") {
    $lights = "on";
  } else {
    $lights = "off";
  }
} while ($lights === "on");
echo "\n";

# for
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=2){
  echo $names[$index] . "\n";
}
echo "\n";

# foreach
$properties = [
  "temperature" => "cold",
  "weather" => "rainy",
  "sky" => "gray"
              ];
foreach ($properties as $key=>$value) {
  echo "The $key is $value.\n";
}
echo "\n";

# break and continue
# this skips printing Ann and will
# stop execution after printing
# Dave
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=1){
  if ($names[$index] == "Ann") {
    continue;
  }
  echo $names[$index] . "\n";
  if ($names[$index] == "Dave") {
    break;
  }
}

/*

Review
Now you have the ability to repeat execution of code blocks as necessary in your PHP programs.

Here is a summary of the topics covered in this lesson:

while loops execute only as long as their conditional evaluates to TRUE.
do…while loops always execute at least once and then continue executing while their conditional is TRUE.
for loops contain 3 expressions and are frequently used to execute a code block a specific number of times.
The first expression is executed prior to the first iteration.
The second expression is evaluated prior to each iteration. If TRUE, the code block executes. Otherwise, the loop terminates.
The third expression is evaluated after each iteration.
foreach loops are used for iterating over the elements of an array. The key and value of each element is available in the code block.
break is used to end execution of a loop early.
continue is used to end execution of a loop iteration early and continues to the next iteration.

*/

<?php
# while
$count = 5;
echo "Countdown!\n";
while ($count > -1) {
  echo $count . "\n";
  $count--;
}
echo "Blastoff!\n\n";

# do...while
$lights = "off";
do {
  echo "The lights are " . $lights . "\n";
  if ($lights === "off") {
    $lights = "on";
  } else {
    $lights = "off";
  }
} while ($lights === "on");
echo "\n";

# for
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=2){
  echo $names[$index] . "\n";
}
echo "\n";

# foreach
$properties = [
  "temperature" => "cold",
  "weather" => "rainy",
  "sky" => "gray"
              ];
foreach ($properties as $key=>$value) {
  echo "The $key is $value.\n";
}
echo "\n";

# break and continue
# this skips printing Ann and will
# stop execution after printing
# Dave
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=1){
  if ($names[$index] == "Ann") {
    continue;
  }
  echo $names[$index] . "\n";
  if ($names[$index] == "Dave") {
    break;
  }
}

/*

Review
Now you have the ability to repeat execution of code blocks as necessary in your PHP programs.

Here is a summary of the topics covered in this lesson:

while loops execute only as long as their conditional evaluates to TRUE.
do…while loops always execute at least once and then continue executing while their conditional is TRUE.
for loops contain 3 expressions and are frequently used to execute a code block a specific number of times.
The first expression is executed prior to the first iteration.
The second expression is evaluated prior to each iteration. If TRUE, the code block executes. Otherwise, the loop terminates.
The third expression is evaluated after each iteration.
foreach loops are used for iterating over the elements of an array. The key and value of each element is available in the code block.
break is used to end execution of a loop early.
continue is used to end execution of a loop iteration early and continues to the next iteration.

*/

<?php
# while
$count = 5;
echo "Countdown!\n";
while ($count > -1) {
  echo $count . "\n";
  $count--;
}
echo "Blastoff!\n\n";

# do...while
$lights = "off";
do {
  echo "The lights are " . $lights . "\n";
  if ($lights === "off") {
    $lights = "on";
  } else {
    $lights = "off";
  }
} while ($lights === "on");
echo "\n";

# for
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=2){
  echo $names[$index] . "\n";
}
echo "\n";

# foreach
$properties = [
  "temperature" => "cold",
  "weather" => "rainy",
  "sky" => "gray"
              ];
foreach ($properties as $key=>$value) {
  echo "The $key is $value.\n";
}
echo "\n";

# break and continue
# this skips printing Ann and will
# stop execution after printing
# Dave
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=1){
  if ($names[$index] == "Ann") {
    continue;
  }
  echo $names[$index] . "\n";
  if ($names[$index] == "Dave") {
    break;
  }
}

/*

Review
Now you have the ability to repeat execution of code blocks as necessary in your PHP programs.

Here is a summary of the topics covered in this lesson:

while loops execute only as long as their conditional evaluates to TRUE.
do…while loops always execute at least once and then continue executing while their conditional is TRUE.
for loops contain 3 expressions and are frequently used to execute a code block a specific number of times.
The first expression is executed prior to the first iteration.
The second expression is evaluated prior to each iteration. If TRUE, the code block executes. Otherwise, the loop terminates.
The third expression is evaluated after each iteration.
foreach loops are used for iterating over the elements of an array. The key and value of each element is available in the code block.
break is used to end execution of a loop early.
continue is used to end execution of a loop iteration early and continues to the next iteration.

*/

<?php
# while
$count = 5;
echo "Countdown!\n";
while ($count > -1) {
  echo $count . "\n";
  $count--;
}
echo "Blastoff!\n\n";

# do...while
$lights = "off";
do {
  echo "The lights are " . $lights . "\n";
  if ($lights === "off") {
    $lights = "on";
  } else {
    $lights = "off";
  }
} while ($lights === "on");
echo "\n";

# for
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=2){
  echo $names[$index] . "\n";
}
echo "\n";

# foreach
$properties = [
  "temperature" => "cold",
  "weather" => "rainy",
  "sky" => "gray"
              ];
foreach ($properties as $key=>$value) {
  echo "The $key is $value.\n";
}
echo "\n";

# break and continue
# this skips printing Ann and will
# stop execution after printing
# Dave
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=1){
  if ($names[$index] == "Ann") {
    continue;
  }
  echo $names[$index] . "\n";
  if ($names[$index] == "Dave") {
    break;
  }
}

/*

Review
Now you have the ability to repeat execution of code blocks as necessary in your PHP programs.

Here is a summary of the topics covered in this lesson:

while loops execute only as long as their conditional evaluates to TRUE.
do…while loops always execute at least once and then continue executing while their conditional is TRUE.
for loops contain 3 expressions and are frequently used to execute a code block a specific number of times.
The first expression is executed prior to the first iteration.
The second expression is evaluated prior to each iteration. If TRUE, the code block executes. Otherwise, the loop terminates.
The third expression is evaluated after each iteration.
foreach loops are used for iterating over the elements of an array. The key and value of each element is available in the code block.
break is used to end execution of a loop early.
continue is used to end execution of a loop iteration early and continues to the next iteration.

*/

<?php
# while
$count = 5;
echo "Countdown!\n";
while ($count > -1) {
  echo $count . "\n";
  $count--;
}
echo "Blastoff!\n\n";

# do...while
$lights = "off";
do {
  echo "The lights are " . $lights . "\n";
  if ($lights === "off") {
    $lights = "on";
  } else {
    $lights = "off";
  }
} while ($lights === "on");
echo "\n";

# for
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=2){
  echo $names[$index] . "\n";
}
echo "\n";

# foreach
$properties = [
  "temperature" => "cold",
  "weather" => "rainy",
  "sky" => "gray"
              ];
foreach ($properties as $key=>$value) {
  echo "The $key is $value.\n";
}
echo "\n";

# break and continue
# this skips printing Ann and will
# stop execution after printing
# Dave
$names = ["Ann", "Bob", "Cassidy", "Dave", "Ed"];
for ($index = 0; $index < count($names); $index+=1){
  if ($names[$index] == "Ann") {
    continue;
  }
  echo $names[$index] . "\n";
  if ($names[$index] == "Dave") {
    break;
  }
}

//fizzbuzz version 1

<?php
$counter = 1;
while ($counter <= 100) {
  if ($counter % 3 == 0 && $counter % 5 == 0) {
    // could just use $counter % 15 == 0
    echo "$counter: FizzBuzz\n";
  } elseif ($counter % 3 == 0) {
    echo "$counter: Fizz\n";
  } elseif ($counter % 5 == 0) {
    echo "$counter: Buzz\n";
  } else {
    echo "$counter\n";
  }
  $counter += 1;
}

//version 2
echo "version2\n";
$output = [];
for ($i = 1; $i <= 100; $i++) {
  if ($i % 15 == 0) {
    array_push($output, "$i: FizzBuzz\n");
  } elseif ($i % 3 == 0) {
    array_push($output, "$i: Fizz\n");
  } elseif ($i % 5 == 0) {
    array_push($output, "$i: Buzz\n");
  } else {
    array_push($output, "$i\n");
  }
}

foreach ($output as $value) {
  echo $value;
}

//version 2b don't print % 3 or after first % 15
$j = 0;
foreach ($output as $value) { 
  if (strpos($value, "Fizz\n")){
    //oneway to stop fizz
    continue;
  } elseif (strpos($value, "FizzBuzz")){
    if ($j === 0) {
      $j ++;
    } else {
      continue;
    }
  }
  echo $value;
}



