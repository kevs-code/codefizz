<?php

function magic8ball()
{
  $question = readline("? ");
  echo $question . "\n";
  $res_ind = rand(0, 19);
  switch ($res_ind) {
    case 0:
      return "It is certain.";
      break;
    case 1:
      return "It is decidedly so.";
      break;
    case 2:
      return "Without a doubt.";
      break;
    case 3:
      return "Yes - definitely.";
      break;
    case 4:
      return "You may rely on it.";
      break;
    case 5:
      return "As I see it, yes.";
      break;
    case 6:
      return "Most likely.";
      break;
    case 7:
      return "Outlook good.";
      break;
    case 8:
      return "Yes.";
      break;
    case 9:
      return "Signs point to yes.";
      break;
    case 10:
      return "Reply hazy, try again.";
      break;
    case 11:
      return "Ask again later.";
      break;
    case 12:
      return "Better not tell you now.";
      break;
    case 13:
      return "Cannot predict now.";
      break;
    case 14:
      return "Concentrate and ask again.";
      break;
    case 15:
      return "Don't count on it.";
      break;
    case 16:
      return "My reply is no.";
      break;
    case 17:
      return "My sources say no.";
      break;
    case 18:
      return "Outlook not so good.";
      break;
    case 19:
      return "Very doubtful.";
      break;
  }
}

echo magic8ball() . "\n";
echo magic8ball() . "\n";
echo magic8ball() . "\n";
echo magic8ball() . "\n";
echo magic8ball() . "\n";
echo magic8ball() . "\n";

