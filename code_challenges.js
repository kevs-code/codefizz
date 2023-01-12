// Write your code here: instead of .reverse()
const reverseArray = (array) => {
	// return.array.reverse() not allowed
  const reverseArray = [];
  for (let i = array.length; i > 0; i--) {
    reverseArray.push(array[i-1]);
  }
  return reverseArray;
}

// When you're ready to test your code, uncomment the below and run:

const sentence = ['sense.','make', 'all', 'will', 'This'];

console.log(reverseArray(sentence)) 
// Should print ['This', 'will', 'all', 'make', 'sense.'];



///////////////////////////2

// Write your code here: instead of .forEach()

const greetAliens = (array) => {
  for (let i = 0; i < array.length; i++) {
    console.log(`Oh powerful ${array[i]}, we humans offer our unconditional surrender!`)
  }
};

// When you're ready to test your code, uncomment the below and run:

const aliens = ["Blorgous", "Glamyx", "Wegord", "SpaceKing"];

greetAliens(aliens);


///////////////////////3 instead of .map()

t convertToBaby = (animals) => {
  const babyAnimals = [];
  for (let i = 0; i < animals.length; i++) {
    babyAnimals.push('baby ' + animals[i]);
  }
  return babyAnimals;
};

// When you're ready to test your code, uncomment the below and run:

const animals = ['panda', 'turtle', 'giraffe', 'hippo', 'sloth', 'human'];

console.log(convertToBaby(animals)) 

/////////////////////4 fix smallest power of two (i assigned twice)

const numbers = [5, 3, 9, 30];

const smallestPowerOfTwo = arr => {
      let results = [];
      // The 'outer' for loop - loops through each element in the array
      for (let i = 0; i < arr.length; i++) {
            number = arr[i];

            // The 'inner' while loop - searches for smallest power of 2 greater than the given number
            j = 1;// broken all j assigned to i
            while (j < number) {
                  j = j * 2;
            }
            results.push(j);
      }
      return results
}

console.log(smallestPowerOfTwo(numbers)) 
// Should print the returned array [ 8, 4, 16, 32 ] instead prints the returned array [8] 
const veggies = ['broccoli', 'spinach', 'cauliflower', 'broccoflower'];

const politelyDecline = (veg) => {
      console.log('No ' + veg + ' please. I will have pizza with extra cheese.');
}

// Write your code here:
const declineEverything = veggies => {
  veggies.forEach(e => politelyDecline(e))
}
declineEverything(veggies);

// Wrong should use this format
const declineEverything = arr => {
  arr.forEach(politelyDecline)
}
declineEverything(veggies);

/////////////////////////solution

const veggies = ['broccoli', 'spinach', 'cauliflower', 'broccoflower'];

const politelyDecline = (veg) => {
      console.log('No ' + veg + ' please. I will have pizza with extra cheese.');
}

// Checkpoint 1 solutions:
const declineEverything = arr => {
  arr.forEach(politelyDecline)
}


// As a function declaration:
/*function declineEverything(arr) {
      arr.forEach(politelyDecline)
}

*/

// Checkpoint 2 solutions:
// Using an anonymous function and string interpolation:
const acceptEverything = arr => {
  arr.forEach(e => {
    console.log(`Ok, I guess I will eat some ${e}.`)
  })
}

// Using a named function and string concatenation:
const grudginglyAccept = veg => {
      console.log('Ok, I guess I will eat some ' + veg + '.');
}
/*
const acceptEverything = arr => {
      arr.forEach(grudginglyAccept)
}

// Using a loop:
const acceptEverything = arr => {
 for(let i = 0; i<arr.length; i++){
    console.log(`Ok, I guess I will eat some ${arr[i]}.`)
 }
}
*/

//////////////////////////6 pfffffft
const numbers = [2, 7, 9, 171, 52, 33, 14]

const toSquare = num => num * num;

// Write your code here:
const squareNums = numbers => {
 const big = numbers.map(num => {
  return toSquare(num);
})
  return big;
};

console.log(squareNums(numbers));



/////////////////////////7

// Write your code here:
const shoutGreetings = array => {
  const buston = [];
  array.forEach(word => {
    buston.push(word.toUpperCase() + '!');
  })
  return buston;
};

// Feel free to uncomment out the code below to test your function!

const greetings = ['hello', 'hi', 'heya', 'oi', 'hey', 'yo'];

console.log(shoutGreetings(greetings))
// Should print [ 'HELLO!', 'HI!', 'HEYA!', 'OI!', 'HEY!', 'YO!' ]

////////////////////8

// Write your code here:
const sortYears = years => {
  return years.sort((a, b) => b - a);
}

// Feel free to uncomment the below code to test your function:

const years = [1970, 1999, 1951, 1982, 1963, 2011, 2018, 1922]

console.log(sortYears(years))
// Should print [ 2018, 2011, 1999, 1982, 1970, 1963, 1951, 1922 ]

////////////////9

// Write your code here:
const justCoolStuff = (arr1, arr2) => {
  const cool = arr1.filter(stuff => {
    for (let i = 0; i < arr2.length; i++) {
      if (stuff === arr2[i]) {
        return stuff;
      }
    }
  });
  return cool;
}
// Feel free to uncomment the code below to test your function

const coolStuff = ['gameboys', 'skateboards', 'backwards hats', 'fruit-by-the-foot', 'pogs', 'my room', 'temporary tattoos'];

const myStuff = [ 'rules', 'fruit-by-the-foot', 'wedgies', 'sweaters', 'skateboards', 'family-night', 'my room', 'braces', 'the information superhighway']; 

console.log(justCoolStuff(myStuff, coolStuff))
// Should print [ 'fruit-by-the-foot', 'skateboards', 'my room' ]


/////////////10

// Write your code here:
const isTheDinnerVegan = array => {
  const vegan = array.every(obj => {  
    return obj.source === 'plant';
  })
  return vegan;
}

// Feel free to comment out the code below to test your function

const dinner = [{name: 'hamburger', source: 'meat'}, {name: 'cheese', source: 'dairy'}, {name: 'ketchup', source:'plant'}, {name: 'bun', source: 'plant'}, {name: 'dessert twinkies', source:'unknown'}];
/*console.log(dinner.every(obj => {  
    return obj.source === 'plant';
  }));//also works
*/
console.log(isTheDinnerVegan(dinner))
// Should print false

////////////////11

const speciesArray = [ {speciesName:'shark', numTeeth:50}, {speciesName:'dog', numTeeth:42}, {speciesName:'alligator', numTeeth:80}, {speciesName:'human', numTeeth:32}];

// Write your code here:
const sortTeeth = teeth => {
  return teeth.sort((a, b) => a - b);
}

const sortSpeciesByTeeth = speciesArray => {
  const teethValue = [];
  const indexer = [];
  speciesArray.forEach (species => {
    teethValue.push(species.numTeeth);
  });
  const ordered = sortTeeth(teethValue);
  console.log(ordered);
  ordered.forEach (tooth => {
  for (let i = 0; i < speciesArray.length; i++) {
    if (tooth === speciesArray[i].numTeeth) {
      indexer.push(speciesArray[i]);
    }
  }
  })
  //const big = speciesArray.indexOf()
  return indexer;
}


// Feel free to either write a named comparison function, or use an anonymous function for your argument to .sort().


// Feel free to comment out the code below when you're ready to test your function!

console.log(sortSpeciesByTeeth(speciesArray))

/* Should print [ { speciesName: 'human', numTeeth: 32 },
  { speciesName: 'dog', numTeeth: 42 },
  { speciesName: 'shark', numTeeth: 50 },
  { speciesName: 'alligator', numTeeth: 80 } ]
*/


//////////12

// Write your code here:
const findMyKeys = array => {
  return array.findIndex(array => array === 'keys');
}
// Feel free to comment out the code below to test your function

const randomStuff = ['credit card', 'screwdriver', 'receipt', 'gum', 'keys', 'used gum', 'plastic spoon'];

console.log(findMyKeys(randomStuff))
// Should print 4


///////13a

// Write your code here:

const dogFactory = (name, breed, weight) => {
  if (typeof name === 'string' && typeof breed === 'string' && typeof weight === 'number') {
    return {
      name,
      breed,
      weight
    }
  } else {
    return -1;
  }
}
dogFactory('Joe', 'Pug', 27)
// Should return { name: 'Joe', breed: 'Pug', weight: 27 }

///////13b refactor with getters setters and methods

// Write your code here:

const dogFactory = (name, breed, weight) => {
    return {
      _name: name,
      _breed: breed,
      _weight: weight,
      get name(){
        if (typeof this._name === 'string'){
          return this._name;
        } else {
          return -1;
        }
      },
      set name(nam){
        if (typeof this._name === 'string'){
          this._name = nam;
        } else {
          return -1;
        }
      },
      get breed(){
        if (typeof this._breed === 'string'){
          return this._breed;
        } else {
          return -1;
        }
      },
      set breed(namb){
        if (typeof this._breed === 'string'){
          this._breed = namb;
        } else {
          return -1;
        }
      },
       get weight(){
        if (typeof this._weight === 'number' && this._weight > 0) {
          return this._weight;
        } else {
          return -1;
        }
      },
      set weight(mass){
        if (typeof this._weight === 'number' && this._weight > 0) {
          this._weight = mass;
        } else {
          return -1;
        }
      },
      bark() {
        return 'ruff! ruff!';
      },
      eatTooManyTreats() {
        this._weight += 1;
      }
    }
}
dogFactory('Joe', 'Pug', 27)
// Should return { name: 'Joe', breed: 'Pug', weight: 27 }


