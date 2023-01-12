<?php
// Write your code below:
  
$magrathea = 42;

echo $magrathea;
echo "\n";
$pi = 3.14;
echo $pi;

// Write your code below:
  
  echo 5 + 7;

// 
<?php
// Write your code below:
  $last_month = 1187.23;
  $this_month = 1089.98;
  echo $last_month - $this_month;

//
<?php
// Write your code below:
  
  $num_languages = 4;
  $months = 11;
  $days = $months * 16;
  $days_per_language = $days / $num_languages;
  echo $days_per_language;
//
<?php
// Write your code below:
  
  echo 8 ** 2;
//
<?php
// Write your code below:
  echo 82 % 6;


//order of operations applies  PEMDAS is BIDMAS Indices = Expoenents, Parentheses = brackets

// 
echo 94 - 4.25 + 7  + (20 / 4) - (23.5 * 1.2);
// assignment operators

#Add	  $x = $x + $y	$x += $y
#Subtract  $x = $x - $y	$x -= $y
#Multiply  $x = $x * $y	$x *= $y
#Divide	  $x = $x / $y	$x /= $y
#Mod	  $x = $x % $y	$x %= $y
// e.g., 
$savings = 800;
$bike_cost = 75;
$savings -= $bike_cost;
echo $savings; // Prints: 725
// ++ --
$age = 89; 
$age++;
echo $age; // Prints: 90

$days_til_vacation = 7; 
$days_til_vacation--;
echo $days_til_vacation; // Prints: 6

//also

<?php
// Write your code below:
$my_num = 2;
$answer = $my_num;
$answer += 2;
$answer *= 2;
$answer -= 2;
$answer /= 2;
$answer -= $my_num;
echo $answer; // Always 1
 /*
  
  $my_num = -19273645.862;

	$answer = $my_num;

	$answer += 2;

	$answer *= 2;

…  echo "\nCool?\nIt's a little cool, right?";

Look! It still works!
1
Cool?
It's a little cool, right?
*/ 

/*
<?php
  
$riel = 2103942;
$kyat = 19092;
$krones = 109;
$lek = 9094;

echo "riel: $riel\nkyat: $kyat\nkrones: $krones\nlek: $lek";

$riel *= 0.00025;
$kyat *= 0.00074;
$krones *= 0.11;
$lek *= 0.0096;
echo "\nriel to $: $$riel\nkyat to $: $$kyat\nkrones to $: $$krones\nlek to $: $$lek";
$usd = $riel + $kyat + $krones + $lek - 4;
echo "\nUSD left included(-\$4 fee): $usd";

riel: 2103942
kyat: 19092
krones: 109
lek: 9094
riel to $: $525.9855
kyat to $: $14.12808
krones to $: $11.99
lek to $: $87.3024
USD left included(-$4 fee): 635.40598

*/
