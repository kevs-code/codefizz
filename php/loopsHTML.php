
<ul>
<?php
for ($i = 0; $i < 2; $i++) {
?>
<li>Duck</li>
<?php
}
?>
<li>Goose</li>
</ul>
<!-- 

Why Use Shorthand?
Using the traditional loop syntax (above) in PHP with brackets ({}) to open and close code blocks can be used when embedding PHP code in HTML:

However, when adding nested loops, the readability of the code can suffer. To determine where loops end, we have to count and match brackets.

Luckily, PHP offers an alternate syntax which is especially useful when working with HTML. Instead of using an opening bracket ({), we use a colon (:) and instead of using a closing bracket (}), we use a closing keyword and semicolon (;). For the for loop, the closing keyword is endfor. Our duck, duck, goose example becomes:
-->
<ul>
<?php
for ($i = 0; $i < 2; $i++):
?>
<li>Duck</li>
<?php
endfor;
?>
<li>Goose</li>
</ul>

<h1>Only Shoes Shoe Shop</h1>
<?php
for ($i = 0; $i < 5; $i++) {
?>
<p>We sell shoes</p>
<?php
}
?>

<h1>Only Shoes Shoe Shop</h1>
<?php
for ($i = 0; $i < 5; $i++):
?>
<p>We sell shoes</p>
<?php
endfor;
?>
<!--
The only difference is the closing keywords. For a while loop, the closing keyword is endwhile, and for the foreach loop, the closing keyword is endforeach.

-->

<h1>Only Shoes Shoe Shop</h1>
<?php
$i = 0;
$repeats = [0, 1];
while ($i < 5) {
?>
<p>We sell shoes</p>
  <?php
  foreach ($repeats as $value) {
  ?>
  <p>(only shoes)</p>
  <?php
  }
  ?>
<?php
  $i++;
}
?>

<h1>Only Shoes Shoe Shop</h1>
<?php
$i = 0;
$repeats = [0, 1];
while ($i < 5):
?>
<p>We sell shoes</p>
  <?php
  foreach ($repeats as $value):
  ?>
  <p>(only shoes)</p>
  <?php
  endforeach;
  ?>
<?php
  $i++;
endwhile;
?>

<!-- php variables in php mode-->

<?php
$array = ["Alice", "Bob", "Charlie"];
foreach($array as $name): ?>
<p>$name</p>
<?php endforeach; ?>
<!--Since we are in HTML mode and not PHP mode when using $name here, it will simply print $name, instead of the corresponding item from the array.

Because of this behavior, it’s important to remember to re-enter PHP mode before using PHP variables. This can be done using the <?php opening and ?> closing tags. If you are going to simply be printing the variable using echo, you can also use the echo shorthand opening tag (<?=).

# With this, our example can be fixed like this:

<?php
$array = ["Alice", "Bob", "Charlie"];
foreach($array as $name): ?>
<p><?=$name?></p>
<?php endforeach; ?>

//

<h1>Shoe Shop</h1>
<?php
$footwear = [
  "sandals" => 4,
  "sneakers" => 7,
	"boots" => 3
];
?>
<p>Our footwear:</p>
<?php
foreach ($footwear as $type => $brands):
?>
<p>We sell <?=$brands?> brands of <?=$type?></p>
<?php
endforeach;
?>

/*
LOOPS IN HTML
Review
With the PHP shorthand you have just learned, you can now create more readable HTML files with embedded PHP loops.

Here are the key ideas from this lesson:

The PHP shorthand for loops uses a colon (:) instead of a bracket ({) to open the code block.
The shorthand uses keywords to close the code block instead of a bracket (}):
Use endfor to close a for loop
Use endforeach to close a foreach loop
Use endwhile to close a while loop
The closing keyword needs to be followed by a semicolon (;).
Make sure to re-enter PHP mode using */
#<?php or the echo shorthand <?= before using PHP variables in the loop
#

<h1>Shoe Shop</h1>
<?php
$footwear = [
  "sandals" => 4,
  "sneakers" => 7,
	"boots" => 3
];
?>
<p>Our footwear:</p>
<h3>foreach</h1>
<?php
foreach ($footwear as $type => $brands):
?>
<p>We sell <?=$brands?> brands of <?=$type?></p>
<?php
endforeach;
?>
<h3>for</h1>
<?php
$types = [
  "sandals",
  "sneakers",
	"boots"
];
$quantities = [
  4,
  7,
	3
];
for ($i=0; $i<count($types); $i++):
?>
<p>We sell <?=$quantities[$i]?> brands of <?=$types[$i]?></p>
<?php
endfor;
?>
<h3>while</h1>
<?php
$types = [
  "sandals",
  "sneakers",
	"boots"
];
$quantities = [
  4,
  7,
	3
];
$i = 0;
while ($i<count($types)):
?>
<p>We sell <?=$quantities[$i]?> brands of <?=$types[$i]?></p>
<?php
$i++;
endwhile;
?>

<!-- project cafe index.php-->

<h1>Welcome to the Repetitive Cafe</h1>
<?php
$drinks = ["cola" => 1.00, "gatorade" => 0.75, "alaskan medicine man water" => 18.00];
$pasties = ["cornish", "danish", "cheese"];
?>
<h3>Drinks!</h3>
<ul>
<?php
foreach ($drinks as $drink => $price):
?>
<li><?=$drink . " : $" . $price?></li>
<?php
endforeach;
?>
</ul>
<h3>Pastries! ($2 each)</h3>
<ul>
<?php
for ($i=0; $i<count($pasties); $i++):
?>
<li><?=$pasties[$i]?></li>
<?php
endfor;
?>
</ul>



