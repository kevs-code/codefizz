<html>
<body>
<h1>PHP and HTML</h1>
<p>This is HTML</p>
<?php echo "<p>This is PHP</p>";?>
</body>
</html>

<?php 
$about_me = [
  "name" => "Aisle Nevertell",
  "birth_year" => 1902,
  "favorite_food" => "pizza"
];

function calculateAge ($person_arr){
  $current_year = date("Y");
  $age = $current_year - $person_arr["birth_year"];
  return $age;
}
?>
<h1>Welcome!</h1>
<h2>About me:</h2>
<?php
#Add your code here
echo "<h3>$about_me[name]</h3>";
echo "<p>Age: " . calculateAge($about_me) . "</p>";
echo "<div>Favorite Food: $about_me[favorite_food]</div>";
?>

<h2>Now tell me a little about you.</h2>
<?php
/*
Review
In this lesson, you’ve begun to learn how to use PHP to generate HTML. This will become even more powerful as we learn how to get information from the client and use that to create dynamic websites.

Let’s review what we’ve learned so far:

The front-end of a website consists of JavaScript, CSS, HTML, images, and other static assets sent to the client.
When we navigate to a website the browser is the client, and it sends a request to the back-end for all the assets needed to view and interact with the website.
The back-end consists of a web server and all the logic and data needed to create and maintain a website or web application.
PHP is a back-end language.
PHP can be used to generate HTML files.
We embed PHP scripts within HTML by inserting PHP code between the opening (<?php) and closing (?>) tags.
*/

//form filling1

<h1>Learning PHP and HTML</h1>
<p>This first paragraph is standard HTML</p>
<?php echo "<p>Let's insert some text into our HTML using PHP!</p>";?>
<p>This last paragraph is also standard HTML</p>

<!-- This example uses the PHP opening (<?php) and closing (?>) tags to insert PHP code. It uses echo to add text to the HTML. This practice is so common that PHP provides a shorthand syntax. Instead of using -->
<?php # echo to begin the statement, you can simply use <?=.

#Our example becomes:

<p>This HTML will get delivered as is</p>
<?="<p>PHP interprets this and turns it into HTML</p>";?>
<p>This HTML will get delivered as is</p>

<!-- exercise -->

<h1>Learning PHP and HTML</h1>
<p>This first paragraph is standard HTML</p>
<?="<p>Let's insert some text into our HTML using PHP!</p>";?>
<p>This last paragraph is also standard HTML</p>
<!-- shorthand -->
<h1>Learning PHP and HTML</h1>
<p>This first paragraph is standard HTML</p>
<?="<p>Let's insert some text into our HTML using PHP!</p>";?>
<p>This last paragraph is also standard HTML</p>

<!--

Request Superglobals
Since PHP was built with web development as a primary use case, it has functionality to ease processing of HTML requests. When the front end client makes a request to a backend PHP server, several superglobals related to the request are available to the PHP script. Superglobals are automatic global variables which are available in all scopes throughout a script.

The list of superglobals in PHP includes the following:

$GLOBALS
$_SERVER
$_GET
$_POST
$_FILES
$_COOKIE
$_SESSION
$_REQUEST
$_ENV
For this lesson, we are focusing on three of these:

$_GET - this contains an associative array of variables passed to the current script using query parameters in the URL
$_POST - this contains an associative array of variables passed to the current script using a form submitted using the “POST” method
$_REQUEST - this contains the contents of $_GET, $_POST, and $_COOKIE
-->

<html>
<body>
$_REQUEST:
<?php print_r($_REQUEST);?>
<br>
$_GET:
<?php print_r($_GET);?>
<br>
$_POST:
<?php print_r($_POST);?>
<form method="get">
GET Form: <input type="text" name="get_name">
<input type="submit" value="Submit GET">
</form>
<form method="post">
POST Form: <input type="text" name="post_name">
<input type="submit" value="Submit POST">
</form>
<a href="index.php">Reset</a>
</body>
</html>
<!--
$_REQUEST: Array ( [get_name] => hello [post_name] => lom )
$_GET: Array ( [get_name] => hello )
$_POST: Array ( [post_name] => lom )

Reset
after typing lom in the post box and hello in the get box and clicking submit
if resubmit get resets all if resubmit post just resets post get and request remain
-->

<html>
<body>
<form method="get">
Country:
<input type="text" name="country">
<br>
Language:
<input type="text" name="language">
<br>
<input type="submit" value="Submit">
</form>
<br>
<p>Your language is: <?=$_GET['language'];?></p>
<p>Your country is: <?=$_GET['country'];?></p>
<a href="index.php">Reset</a>
</body>
</html>

<!-- note the shorthand above get below post-->

<html>
<body>
<form method="post">
Favorite Color:
<input type="text" name="color">
<br>
Favorite Food:
<input type="text" name="food">
<br>
<input type="submit" value="Submit">
</form>
<br>
<p>Best food is: <?=$_POST['food']?></p>
<p>Best color is: <?=$_POST['color']?></p>
<a href="index.php">Reset</a>
</body>
</html>

<!-- action redirect to new page here greet_user.php -->

<html>
<body>
<form method="get" action="greet_user.php">
First Name:
<input type="text" name="first">
<br>
Last Name:
<input type="text" name="last">
<br>
<input type="submit" value="Submit">
</form>

<a href="index.php">Reset</a>
</body>
</html>

<!-- greet_user.php -->
<html>
<body>
<p>Thanks!</p>
<p>Your name has been recorded as:</p>
<p><?=$_GET['first'] . " " . $_GET['last']?></p>
<a href="index.php">Reset</a>
</body>
</html>

<!-- review
Review
You’re ready to start handling forms in PHP!

To review:

<?= is shorthand for <?php echo.?>
PHP provides superglobals which can be accessed anywhere in the script.
$_GET is an associative array containing data from a GET request.
$_POST is an associative array containing data from a POST request.
$_REQUEST is an associative array containing data from both GET and POST requests. It should only be used if you don’t care which method was used.
The array keys in the PHP request superglobals are set by the name attributes in the HTML form, which need to be unique.
The action attribute is used to specify which file should handle data from the form request.
code
-->
<html>
<body>
<h1>index.php</h1>
<h2>Superglobals:</h2>
$_REQUEST:
<?php print_r($_REQUEST)?>
<br>
$_GET:
<?php print_r($_GET)?>
<br>
$_POST:
<?php print_r($_POST)?>
<h2>Forms:</h2>
<form method="get" action="handle_get.php">
GET Form: <input type="text" name="get_name">
<input type="submit" value="Submit GET">
</form>
<form method="post">
POST Form: <input type="text" name="post_name">
<input type="submit" value="Submit POST">
</form>
<a href="index.php">Reset</a>
</body>
</html>
