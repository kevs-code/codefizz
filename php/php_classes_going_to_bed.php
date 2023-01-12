<?php
class StringUtilities {
  public static function secondCase($string) {
    $string = strtolower($string);
    if (strlen($string) > 1) {
      $string[1] = strtoupper($string[1]);
    }
    return $string;
  }
}
echo StringUtilities::secondCase("BANANAS") . "\n";
echo StringUtilities::secondCase("Q") . "\n";
echo StringUtilities::secondCase("");

class Pajamas {
 private $owner, $fit, $color; 
 function __construct($owner = "cutie", $fit = "loose", $color = "pink") {
   $this->owner = StringUtilities::secondCase($owner);
   $this->fit = $fit;
   $this->color = $color;
 }
 public function setFit($fit) {
   $this->fit = $fit;
 }

 public function describe() {
   return "$this->owner has $this->fit $this->color pyjamas.";
 }
}

$chicken_PJs = new Pajamas("CHICKEN", "just right", "purple");
echo $chicken_PJs->describe() . "\n";
$chicken_PJs->setFit("tight");
echo $chicken_PJs->describe() . "\n";

class ButtonablePajamas extends Pajamas {
  private $button_state = "unbuttoned";
  function setButtonState($button_state) {
    $this->$button_state = $button_state;
  }
  public function toggleButtons() {
    if ($this->button_state === "unbuttoned") {
    $this->button_state = "buttoned";
    } else {
    $this->button_state = "unbuttoned";
    }
  }
  public function describe() {
    return parent::describe() . "  They are $this->button_state.\n";
  }
}
$moose_PJs = new ButtonablePajamas("moose", "just right", "purple");
$moose_PJs->toggleButtons();
echo $moose_PJs->describe();

