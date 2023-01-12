<?php
$play_count = 0;
$correct_guesses = 0;
$guess_high = 0;
$guess_low = 0;

echo "I'm going to think of numbers between 1 and 10 (inclusive). Do you think you can guess correctly?\n";

function guessNumber()
{
  global $play_count, $correct_guesses, $guess_high, $guess_low;
  $play_count++;
  $hid_num = rand(1, 10);
  echo "\nI've got a number, start make your guess please.\n";
  $guess = readline(">> ");
  $guess = intval($guess);
  echo "This is round $play_count, Your number is $guess.  My number was $hid_num.\n";
  if ($guess === $hid_num) {
    $correct_guesses++;
  } elseif ($guess > $hid_num) {
    $guess_high++;
  } else {
    $guess_low++;
  }
  $percent = ($correct_guesses / $play_count) * 100;
  echo "You have guesses right $percent% of the time, statistically you should guess right around 10% of the time.\n";
  if ($guess_high > $guess_low) {
    echo "When you guessed wrong, you tended to guess high.\n";
  } elseif ($guess_high < $guess_low) {
    echo "When you guessed wrong, you tended to guess low.\n";
  }
}


echo guessNumber() . "\n";
echo guessNumber() . "\n";
echo guessNumber() . "\n";
echo guessNumber() . "\n";
echo guessNumber() . "\n";
echo guessNumber() . "\n";
echo guessNumber() . "\n";
echo guessNumber() . "\n";
echo guessNumber() . "\n";
echo guessNumber() . "\n";
