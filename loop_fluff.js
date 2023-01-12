// Write your code below
const cupsOfSugarNeeded = 2;
let cupsAdded = 0;


do {
 cupsAdded++;
 console.log(cupsAdded);
} while (cupsAdded < cupsOfSugarNeeded);


const rapperArray = ["Lil' Kim", "Jay-Z", "Notorious B.I.G.", "Tupac"];

// Write your code below

for (let i = 0; i < rapperArray.length; i++) {
  console.log(rapperArray[i]);
  if (rapperArray[i] === 'Notorious B.I.G.' ) {
     break;
  }
  console.log("And if you don't know, now you know.");
}

// var input = "whale talk";
var input = "turpentine and turtles";
const vowels = ['a', 'e', 'i', 'o', 'u'];
var resultArray = [];
for (let i = 0; i < input.length; i++) {
  // console.log(i);
  for (let j = 0; j < vowels.length; j++) {
    // console.log(j);
    if (input[i] === vowels[j]) {
       resultArray.push(input[i]);
    }
  };
  if (input[i] === 'e') {
    resultArray.push(input[i]);
  }
  if (input[i] === 'u') {
    resultArray.push(input[i]);
  }
}
console.log(resultArray.join('').toUpperCase());
