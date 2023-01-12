<?php
  // Change player location
function changeLocation(){	
  // Write your code here:
  global $location;
  echo "Where do you want to go?\n";
  $travel = strtolower(readline(">> "));
  if ($location === "kitchen") {
    if ($travel === "bathroom") {
      echo "You go to: bathroom.\n";
      $location = "bathroom";
    } elseif ($travel === "woods") {
      echo "You follow the winding path, shivering as you make your way deep into the Terror Woods.\n";
      $location = "woods";
    } else {
      echo "That doesn't make sense. Are you confused? Try 'look around'.\n";
    }
  } elseif ($location === "woods") {
      if ($travel === "kitchen") {
        echo "You go to: kitchen.\n";
        $location = "kitchen";
      } elseif ($travel === "bathroom") {
        echo "You can't go directly to there from your current location. Try going somewhere else first.\n";
      } else {
        echo "That doesn't make sense. Are you confused? Try 'look around'.\n";
      }
  } else {
      // location === bathroom
    if ($travel === "kitchen") {
      echo "You go to: kitchen.\n";
      $location = "kitchen";
    } elseif ($travel === "woods") {
        echo "You can't go directly to there from your current location. Try going somewhere else first.\n";
    } else {
        echo "That doesn't make sense. Are you confused? Try 'look around'.\n";
    }   
  }
}
