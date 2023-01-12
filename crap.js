// Write your function here:
const lifePhase = age => {
  if (age >= 0 && age < 4) {
     return 'baby';
   } else if (age >= 4 && age < 13) {
     return 'child';
   } else if (age >= 13 && age < 20) {
     return 'teen';
   } else if (age >= 20 && age < 65) {
     return 'adult';
   } else if (age >= 65 && age < 141) {
     return 'senior citizen';
  } else {
    return 'This is not a valid age';
  }
}







// Uncomment the line below when you're ready to try out your function
console.log(lifePhase(5)) //should print 'child'

// We encourage you to add more function calls of your own to test your code!

function life_cycle(age) {
  if (age < 0 || age > 140) {
    return "This is not a valid age.";
  }
  return age < 3  ? 'baby' :
         age < 13 ? 'child' :
         age < 20 ? 'teen' :
         age < 65 ? 'adult' :
         age < 75 ? 'senior' : 'elderly';
}


switch (true) {
  case age < 0: age = 141;
  case age < 3: return 'baby';
  case age < 13: return 'child';
  case age < 20: return 'teen';
  case age < 65: return 'adult';
  case age < 75: return 'senior';
  case age < 141: return 'elderly';
  default: return "This is not a valid age."
}
