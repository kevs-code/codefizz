<?php
  
function cookSoup(){
	// Write your code here:
  global $location, $has_mushrooms, $has_soup;
  if ($location === "kitchen" and $has_mushrooms) {
    echo "You made some mushroom soup. Mushroom is the queen of all soups!\n";
    $has_soup = TRUE;
    $has_mushrooms = FALSE;
  } else {
    echo" You can't cook like this! You need something to cook AND to be in the kitchen.\n";
  }
}
