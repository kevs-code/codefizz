<html>
<body>
<!--Your code goes here-->
<h2>Addition</h2>
<form method="get" action="addition.php">
Number1:
<input type="number" name="num1">
<br>
Number2:
<input type="number" name="num2">
<br>
<input type="submit" value="Submit">
</form>

<h2>Division</h2>
<form method="get" action="division.php">
Number1:
<input type="number" name="dnum1">
<br>
Number2:
<input type="number" name="dnum2">
<br>
<input type="submit" value="Submit">
</form>

<a href="index.php">Reset</a>
</body>
</html>


<!-- addition.php -->
<html>
<body>
<!--Your code goes here-->
<?php
$sum = $_GET[num1] + $_GET[num2];
echo "$_GET[num1] + $_GET[num2] = $sum\n";?>
<a href="index.php">Reset</a>
</body>
</html>
<!-- division.php -->
<html>
<body>
<!--Your code goes here-->
<?php
$result = $_GET[dnum1] / $_GET[dnum2];
echo "$_GET[dnum1] / $_GET[dnum2] = $result\n";?>
<a href="index.php">Reset</a>
</body>
</html>
