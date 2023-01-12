const getUserChoice = userInput => {
  userInput = userInput.toLowerCase();
  if (userInput === 'rock' || userInput === 'paper' || userInput === 'scissors' || userInput === 'bomb') {
    return userInput;
  } else {
    return "Error: Input required is either rock, paper or scissors";
  }
}

const getComputerChoice = () => {
  let numb = Math.floor(Math.random() * 3);
  let answer = '';
  switch (numb) {
    case 0:
      answer = 'rock'
      break;
    case 1:
      answer = 'paper'
      break;
    case 2:
      answer = 'scissors'
      break;
    default:
      answer = 'code wrong!'
  }
  return answer;
}

const determineWinner = (userChoice, computerChoice) => {
  if (userChoice === 'bomb') {
    return "user wins!";
  }
  if (userChoice === computerChoice) {
    return "It's a tie!";
  }
  if (userChoice === 'rock') {
    if (computerChoice === 'paper') {
      return "computer wins!";
    } else {
      return "user wins!";
    }
  }
  if (userChoice === 'paper') {
    if (computerChoice === 'rock') {
      return "user wins!";
    } else {
      return "computer wins!";
    }
  }
  if (userChoice === 'scissors') {
    if (computerChoice === 'paper') {
      return "user wins!";
    } else {
      return "computer wins!";
    }
  }
  return "try again!";
}

const playGame = input => {
  let userChoice = getUserChoice(input);
  console.log(userChoice);
  let computerChoice = getComputerChoice();
  console.log(computerChoice);
  console.log(determineWinner(userChoice, computerChoice));
}

playGame('bomb')



