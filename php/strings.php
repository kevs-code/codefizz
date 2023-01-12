<!-- index.php -->
<h1>My First PHP Site</h1>
<p>This HTML will get delivered as is</p>
<?php echo "<p>But this code is interpreted by PHP and turned into HTML</p>";?>
<?php echo "<ul><li>You can use any HTML tags,</li><li>like this list.</li></ul>";?>
<footer>
  <p>And this code is back in plain HTML</p>
</footer>

//<?php
// Write your code below:
  echo "Hello, World!";

<?php
// Write your code below:
  echo "1. Learn PHP";
  echo "\n2. Absorb Learning";
  echo "\n3. Rinse and \"Repeat\"";

<?php
// Write your code below:   
echo "Code" . "cademy";

  echo "\nMy name is:" . " Monkey."; 
  echo "\n" . "tur" . "duck" . "en";

//strings
<?php
// Write your code below:
$name = "Monkey";
$biography = "\nI found a typewriter. I have had an infinity or two to play with it.  Look what I've done;?>";
$favorite_food = "\n" . "tur" . "duck" . "en";
  
//meh

<?php
// Write your code below:
$name = "Monkey";
$language = "PHP";

echo "I am " . $name . ", I am learning " . $language . ".";
echo "\nDidn't I already say I'm learning " . $language . ". It must be attention to detail or boredom."; 


<?php
// Fill in the blanks in the code below:
  $noun = "programmer";
  $adjective = "poor";
  $verb = "code";

  echo "The world's most beloved $noun was very $adjective and loved to $verb every single day.";


//Fix the code below and uncomment it:

  echo "\nI have always been obsessed with ${noun}s. I'm ${adjective}ish. I'm always ${verb}ing.";

//string reassign

<?php
  $movie = "Coco";
// Add your code here:
$old_favorite = $movie;


  echo "I'm a fickle person, my favorite movie used to be $movie.";
  
// Add a statement here:
  $movie = "Sonic";
  
  echo "\nBut now my favorite is $movie.";
  
// Add a statement below:

  echo "\n$old_favorite, seems so old now like me.";
  

// .= instead of .

<?php
  echo "I'm going on a picnic!";

  $sentence = "\nI'm going on a picnic, and I'm taking apples";

  echo $sentence;

// Write your code below:

  $sentence .= ", buttons";

  echo $sentence;

  $sentence .= ", clothes pegs";

  echo $sentence;


// reference operator =& to assign variable to variable (both update)

<?php
/* Imagine a lot of code here */  
  $very_bad_unclear_name = "15 chicken wings";

// Write your code here:
  // =& changes made to one effect the other variable 
  $order =& $very_bad_unclear_name;
  $order .= ", 2 number 9s, a large number 9 a number 6 with extra dip, a number 7, 2 number 45s one with cheese and a large soda";

    
  // Don't change the line below
  echo "\nYour order is: $very_bad_unclear_name.";


// Your order is: 15 chicken wings, 2 number 9s, a large number 9 a number 6 with extra dip, a number 7, 2 number 45s one with cheese and a large soda.

// variables declared with $ and start with _ or letter
$_order
