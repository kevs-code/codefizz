<form method="post" action="">
Your Favorite Programming Language: <input type="text" name="language">
<input type="submit" value="Submit Language">
</form>
<?php
// $_POST = ["language" => "PHP"];
echo $_POST["language"]; // Prints: PHP
#form handling
<html>
	<body>
		<form method="post" action="">
			Your name:
			<br>
  		<input type="text" name="name">
 			<br><br>
  		What is the best thing about learning to code:
  		<br>
  		<input type="text" name="best">
  		<br><br> 
  		<input type="submit" value="Submit Answers">
		</form>
    <div id="form-output">
    <p id="name"><?=$_POST["name"]?></p>
    <p id="best"><?=$_POST["best"]?></p>
    </div>
		<a href="index.php">Reset</a>
	</body>
</html>
    

#starts with letter

<?php
// Define checkWord() here:
  function checkWord($word, $letter)
  {
    if ($_SERVER["REQUEST_METHOD"] === "POST") {
      if (strtolower($word[0]) !== strtolower($letter)) {
        return "* This word must start with the letter $letter!";
      } else {
        return ""; // questionable codeblock else
      }
    }
    return "";
  }
  
  
  
  
?>
  
<h1>Time to Practice our ABCs</h1>
<form method="post" action="">
    Enter a word that starts with the letter "a":
    <br>
    <input type="text" name="a-word" id="a-word" value="<?=$_POST['a-word']?>">
    <br>      
    <p id="a-error"><?=checkWord($_POST["a-word"], "a")?></p>
    <br>     
    Enter a word that starts with the letter "b":
    <br>
    <input type="text" id="b-word" name="b-word" value="<?=$_POST['b-word']?>">
    <br>      
    <p id="b-error"><?=checkWord($_POST["b-word"], "b")?></p> 
    <br>
    Enter a word that starts with the letter "c":
    <br>
    <input type="text" id="c-word" name="c-word" value="<?=$_POST['c-word']?>">
    <br>      
    <p id="c-error"><?=checkWord($_POST["c-word"], "c")?></p>
    <br>
    <input type="submit" value="Submit Words">
</form>
<div>
    <h3>"a" is for: <?= $_POST["a-word"];?><h3>
    <h3>"b" is for: <?= $_POST["b-word"];?><h3>
    <h3>"c" is for: <?= $_POST["c-word"];?><h3>    
<div>  
<?php
//sanitise
#trim() remove leading/ trailing whitespace

$email = "     aisle.nevertell@yahoo.com   ";
echo trim($email); // Prints: aisle.nevertell@yahoo.com

#htmlspecialchars() converts HTML elements to HTML entities (represent HTML but don't display properly e.g., <h1>ho</h1> instead of big ho)

 = "<a href=\"https://www.evil-spam.biz/html/\">Your account has been compromised! Click here to get technical support!!</a>";

echo htmlspecialchars($data);

//Prints: &lt;a href=&quot;https://www.evil-spam.biz/html/&quot;&gt;Your account has been compromised! Click here to get technical support!&lt;/a&gt;

<form method="post" action="">
Enter some HTML:
<br>
<input type="text" name="html">
<br>  
<input type="submit" value="Submit">
</form>
<div>
  You entered:
	<?= htmlspecialchars($_POST["html"]) ?> 
</div>  
<?php
# filter var

<?php
$validation_error = "";
$user_answer = "";
$submission_response = "";

// Write your code here:

if ($_SERVER["REQUEST_METHOD"] === "POST") {
  $user_answer = filter_var($_POST["answer"], FILTER_SANITIZE_NUMBER_INT);
  if ($user_answer === "-5") { //note -5 without "" doesn't work
    $submission_response = "Correct!";
  } else {
    $validation_error = "* Wrong answer. Try again.";
  }

?>
<h2>Time for a math quiz!</h2>
<form method="post" action="">
<h4>Question 1:</h4>  
<p>What is 6 - 11?</p> 
<input type="text" name="answer" id="answer" value="<?= $user_answer;?>">
<br>
<span class="error" id="error"><?= $validation_error;?></span> 
<br> 
<input type="submit" value="Submit Your Answer">
</form>
<div>
  <p id="answer-display">Your answer was: <?= $user_answer;?></p>
  <p id="submission-response"><?= $submission_response;?></p>
</div>

#validate url with filter_var

<?php
$validation_error = "";
$user_url = "";
$form_message = "";

// Write your code here:

if ($_SERVER["REQUEST_METHOD"] === "POST") {
  $user_url = $_POST["url"];
  if (filter_var($user_url, FILTER_VALIDATE_URL)) {
    $form_message = "Thank you for your submission.";
  } else {
    $validation_error = "* This is an invalid URL.";
    $form_message = "Please retry and submit your form again.";
  }
}





?>

<form method="post" action="">
Your Favorite Website: 
<br>
<input type="text" name="url" value="<?php echo $user_url;?>">
<span class="error"><?= $validation_error;?></span>
<br>
<input type="submit" value="Submit">
</form>
<p> <?= $form_message;?> </p> 

<?php
#using options valid int

function validateAdult ($age){
  $options = ["options" => ["min_range" => 18, "max_range" => 124]];  
  if (filter_var($age, FILTER_VALIDATE_INT, $options)) {
    echo("You are ${age} years old.");
  } else {
    echo("That is not a valid age.");
  }
}

validateAdult(18); // Prints: You are 18 years old.
validateAdult(124); // Prints: You are 124 years old.
validateAdult(8); // Prints: That is not a valid age.
validateAdult(200); // Prints: That is not a valid age.    

//validate integer exercise

<?php
$message = "";
$month_error = "";
$day_error = "";
$year_error = "";
  
// Create your variables here:


$month_options = ["options" => ["min_range" => 1, "max_range" => 12]];
$day_options = ["options" => ["min_range" => 1, "max_range" => 31]];
$year_options = ["options" => ["min_range" => 1903, "max_range" => 2020]];



// Define your function here:
function validateInput($type, &$error, $options_arr)
{
  if (filter_var($_POST["$type"], FILTER_VALIDATE_INT, $options_arr)) {
    return TRUE;
  } else {
    $error = "* Invalid ${type}";
    return FALSE;
  }
}






  if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Uncomment the code below:
    $test_month = validateInput("month", $month_error, $month_options);
    $test_day = validateInput("day", $day_error, $day_options);
    $test_year = validateInput("year", $year_error, $year_options);    
    if ($test_month && $test_day && $test_year){
      $message = "Your birthday is: {$_POST["month"]}/{$_POST["day"]}/{$_POST["year"]}";
    }  
  }

?>

<form method="post" action="">
	Enter your birthday:
	<br>
	Month: <input type="number" name="month" value="<?= $_POST["month"];?>">
	<span class="error"><?= $month_error;?>		</span>
  <br>
	Day: <input type="number" name="day" value="<?= $_POST["day"];?>">
  <span class="error"><?= $day_error;?>		</span>
	<br>  
	Year: <input type="number" name="year" value="<?= $_POST["year"];?>">  
	<span class="error"><?= $year_error;?>		</span>
	<br>
	<input type="submit" value="Submit">
</form>
    <p><?= $message;?></p>

<?php
#regex custom validations using preg_match returns 1 true 0 false
#strlen for custom length

#regex
$pattern = '/^[(]*([0-9]{3})[- .)]*[0-9]{3}[- .]*[0-9]{4}$/';

preg_match($pattern, "(999)-555-2222"); // Returns: 1

preg_match($pattern, "555-2222"); // Returns: 0
#strlen
$name = "Aisle Nevertell";
$length = strlen($name);
if ($length > 2 && $length < 100){
  echo "That seems like a reasonable name to me...";
} 


//exercise


<?php
$feedback = "";
$success_message = "Thank you for your donation!";
$error_message = "* There was an error with your card. Please try again.";

$card_type = "";
$card_num = "";
$donation_amount = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $card_type = $_POST["credit"];
    $card_num = $_POST["card-num"];
    $donation_amount = $_POST["amount"];

// Write your code here:
  if (strlen($card_num) < 100) {
    if ($card_type === "visa") {
      $pattern = "/4[0-9]{12}([0-9]{3})?([0-9]{3})?/";
      if (preg_match($pattern, $card_num) === 1) {
        $feedback = $success_message;
      } else {
        $feedback = $error_message;
      }
    } else {
      $pattern = "/5[1-5][0-9]{14}/";
      if (preg_match($pattern, $card_num) === 1){
        $feedback = $success_message;
      } else {
        $feedback = $error_message;
      }
    }
  } else {
    $feedback = $error_message;
  }  
}
?>
<form action="" method="POST">
  <h1>Make a donation</h1>
    <label for="amount">Donation amount?</label>
      <input type="number" name="amount" value="<?= $donation_amount;?>">
      <br><br>
    <label for="credit">Credit card type?</label>
      <select name="credit" value="<?= $card_type;?>">
        <option value="mastercard">Mastercard</option>
        <option value="visa">Visa</option>
      </select>
      <br><br>
      <label for="card-num">Card number?</label>
      <input type="number" name="card-num" value="<?= $card_num;?>">
      <br><br>   
      <input type="submit" value="Submit">
</form>
<span class="feedback"><?= $feedback;?></span>

<?php

# validating against backend

<?php
$users = ["coolBro123" => "password123!", "coderKid" => "pa55w0rd*", "dogWalker" => "ais1eofdog$"];  
  
  
$feedback = "";
$message = "You're logged in!";
$validation_error = "* Incorrect username or password.";
$username = "";

// Write your code here:


if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $username = $_POST["username"];
  $password = $_POST["password"];
  foreach ($users as $user => $pword) {
    if ($user === $username) {
      if ($password === $pword) {
        $feedback = $message;
      }
    }
  }
  if (!$feedback) {
    $feedback = $validation_error;
  }
} 





?>
  
<h3>Welcome back!</h3>
<form method="post" action="">
Username:<input type="text" name="username" value="<?php echo $username;?>">
<br>
Password:<input type="text" name="password" value="">
<br>
<input type="submit" value="Log in">
</form>
<span class="feedback"><?= $feedback;?></span>

<?php
//sanitizing backend

$one = "codeacademy";
$two = "CodeAcademy";
$three = "code academy";
$four = "Code Academy";

$pattern = "/[cC]ode\s*[aA]cademy/";
$codecademy = "Codecademy";

echo preg_replace($pattern, $codecademy, $one);
// Prints: Codecademy

echo preg_replace($pattern, $codecademy, $two);
// Prints: Codecademy

echo preg_replace($pattern, $codecademy, $three);
// Prints: Codecademy

echo preg_replace($pattern, $codecademy, $four);
// Prints: Codecademy

//sanitize backend just numbers for phone number

<?php
$contacts = ["Susan" => "5551236666", "Alex" => "7779991717", "Lily" => "8181117777"];  
$message = "";
$validation_error = "* Please enter a 10-digit North American phone number.";
$name = "";
$number = "";

 if ($_SERVER["REQUEST_METHOD"] == "POST") {
   $name = $_POST["name"];
   $number  = $_POST["number"];
   // Write your code here:
   if (strlen($number) < 30 ) {
     $pattern = "/[^0-9]/";
     $fnumber = preg_replace($pattern, "", $number);
     if (strlen($fnumber) === 10) {
       $contacts[$name] = $fnumber;
       $message = "Thanks ${name}, we'll be in touch.";
     } else {
       $message = $validation_error;
     }
   } else {
     $message = $validation_error;
   }
   
  
   
   

};
?>
<html>
	<body>
  <h3>Contact Form:</h3>
		<form method="post" action="">
			Name:
			<br>
  		<input type="text" name="name" value="<?= $name;?>">
 			<br><br>
  		Phone Number:
  		<br>
  		<input type="text" name="number" value="<?= $number;?>">
  		<br><br> 
  		<input type="submit" value="Submit">
		</form>
		<div id="form-output">
			<p id="response"><?= $message?></p>
    </div>
	</body>
</html>
    
<?php
// php header function for rerouting correct form submission sounds like html action

We can use the PHP header() function to perform redirects. We call the header() function on a string that begins with "Location: ", followed by the URL we want to redirect the user to. For example: "Location: https://www.best-puppy-pix.com/". After invoking the header() function we’ll want to use the language construct exit to terminate the current script.

To work properly, the header() function needs to be run before anything is output by the script—this includes HTML. So we’ll include it in our PHP script before our file outputs any HTML:

if (/* Is the submission data validated? */) {
  header("Location: https://www.best-puppy-pix.com/");
  exit;
}
//exercise 
<?php
$validation_error = "";
$username = "";
$users = ["coolBro123" => "password123!", "coderKid" => "pa55w0rd*", "dogWalker" => "ais1eofdog$"];

 if ($_SERVER["REQUEST_METHOD"] === "POST") {
   $username = $_POST["username"];
   $password  = $_POST["password"];
   if (isset($users[$username]) && $users[$username] === $password){
     // Add your code here:
      header("Location: success.html");
      exit;
   } else {
     $validation_error = "* Incorrect username or password.";
   }
 }

?>
  
<h3>Welcome back!</h3>
<form method="post" action="">
Username:<input type="text" name="username" value="<?php echo $username;?>">
<br>
Password:<input type="text" name="password" value="">
<br>
<span class="error"><?= $validation_error;?></span>
<br>
<input type="submit" value="Log in">
</form>
  
<?php
/*

INTRODUCTION TO PHP FORM VALIDATION
Review
Great work! We covered a lot in this lesson. Let’s review:

Performing back-end form validations on the data submitted is an essential step to protect our website and its users.
Using the POST method attribute in an HTML form gives our PHP script access to data submitted within the superglobal associative array: $_POST.
We modify our HTML and PHP so that when input is deemed invalid, meaningful feedback is shown to the user.
If we plan on displaying user input, we need to first sanitize it. We can use methods like trim() and htmlspecialchars() for basic sanitization.
We can use filter_var() with a filter to sanitize common input types.
We can also use filter_var() with a filter to perform validations on common input types.
We’ll often want to perform custom validations.
The preg_match() function compares checks if a given string matches a regular expression.
Since regular expression comparisons can consume a lot of computing power, we’ll want to check the length of inputs before performing regular expression checks.
It’s common to perform validations by comparing user input to back-end data
Before storing user input in our back-end, we’ll sanitize it for both safety and consistent formatting
If a user’s form submission has been accepted, we can reroute them to a different page.
Data validation and sanitization is an extremely important part of web development. In this lesson, we’ve covered some of the basic theory and techniques. When developing for production, you’ll need to further research and understands the needs of the specific sites or applications as well as the tools available with the specific databases or frameworks in use.

As your validations get more and more complex, you should also practice modularity and separate your validation logic from your display logic.
*/

<?php
$validation_error = "";
$user_language = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
$user_language = $_POST["language"];
  if ($user_language != "PHP") {
    $validation_error = "* Your favorite language must be PHP!";
  } 
}
?>

<form method="post" action="">
Your Favorite Programming Language: <input type="text" name="language" value="<?php echo $user_language;?>">
<span class="error"><?= $validation_error;?></span>
<input type="submit" value="Submit Language">
</form>
<?php
/*first prints "kitties@codecademy.com" second prints nothing as not valid in orginal form $email
$email = "k<i>tt</i>es@codecademy.com";
echo filter_var($email, FILTER_SANITIZE_EMAIL);
echo filter_var($email, FILTER_VALIDATE_EMAIL);


#exercise project bobby tables
*/
<?php
$name = "";
$character = "";
$email = "";
$birth_year = 1969;
$validation_error = "";
$existing_users = ["admin", "guest"];

if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $raw_name = trim(htmlspecialchars($_POST["name"]));
  $raw_character = trim(htmlspecialchars($_POST["character"]));
  $raw_email = $_POST["email"];
  $raw_birth_year = $_POST["birth_year"];
  if (in_array($raw_name, $existing_users)) {
    $validation_error = "This name is taken. <br>";
  } else {
    $name = $raw_name;
  }
  $pcs = ["wizard", "mage", "orc"];
  if (in_array($raw_character, $pcs)) {
    $character = $raw_character;
  } else {
    $validation_error = "You must pick a wizard, mage, or orc. <br>";
  }
  if(filter_var($raw_email, FILTER_VALIDATE_EMAIL)) {
    $email = $raw_email;
  } else {
    $validation_error = "Invalid email. <br>";
  }
  $options = ["options" => ["min_range" => 1900, "max_range" => 2018]];
  if (filter_var($raw_birth_year, FILTER_VALIDATE_INT, $options)) {
    $birth_year = $raw_birth_year;
  } else {
    $validation_error = "That can't be your birth year. <br>";
  }
}
?>
<h1>Create your profile</h1>
<form method="post" action="">
<p>
Select a name: <input type="text" name="name" value="<?php echo $name;?>" >
</p>
<p>
Select a character:
  <input type="radio" name="character" value="wizard" <?php echo ($character=='wizard')?'checked':'' ?>> Wizard
  <input type="radio" name="character" value="mage" <?php echo ($character=='mage')?'checked':'' ?>> Mage
  <input type="radio" name="character" value="orc" <?php echo ($character=='orc')?'checked':'' ?>> Orc
</p>
<p>
Enter an email:
<input type="text" name="email" value="<?php echo $email;?>" >
</p>
<p>
Enter your birth year:
<input type="text" name="birth_year" value="<?php echo $birth_year;?>">
</p>
<p>
  <span style="color:red;"><?= $validation_error;?></span>
</p>
<input type="submit" value="Submit">
</form>
  
<h2>Preview:</h2>
<p>
  Name: <?=$name;?>
</p>
<p>
  Character Type: <?=$character;?>
</p>
<p>
  Email: <?=$email;?>
</p>
<p>
  Age: <?=date("Y")-$birth_year;?>
</p>
