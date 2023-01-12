const _ = {
  clamp (num, min, max) {
    const lowerClamp = Math.max(num, min);
    const clamped = Math.min(lowerClamp, max);
    return clamped;
  },
  inRange (num, min, max) {
   if (!max) {
        const min1 = min;
        max = min1;
        min = 0;
    }
    console.log(arguments);
    if (max < min) {
        const max1 = max;
        max = min;
        min = max1;
    }
    console.log(arguments);
    console.log(num, min, max);
    if (num >= min && num < max) {
      return true;
    } else {
      return false;
    }
  },
  words (string) {
    const worded = string.split(' ');
    return worded;
  },
  pad (string, length) { 
    if (string.length < length) {
      const padLength = length - string.length;
        console.log(padLength);
      if (padLength % 2 === 0) {
        pads = padLength/2;
        return ' '.repeat(pads) + string + ' '.repeat(pads)
      } else {
        if (padLength !== 1) {
          pads = (padLength-1)/2;
        } else {
          pads = 0;
        }
        end = pads+1;
        return ' '.repeat(pads) + string + ' '.repeat(end);
      }
    } else {
      return string;
    }
  },
  has(object, key) {
    const hasValue = object[key];
    if (hasValue) {
        return true;
    } else {
        return false;
    }
  },
  invert(object) {
    const flipside = {};
    for (let [key, value] of Object.entries(object)) {
      flipside[value] = key;
    }
    return flipside;
  },
  findKey(object, predicate) {
    for (let [key, value] of Object.entries(object)) {
     console.log(key, value);
     //predicate is a function providing truthy test
     let predicateReturnValue = predicate(value);
     if  (predicateReturnValue) {
       console.log(key);
       return key;
     }
    }
    return undefined;
  },
  drop(array, number=1) {
    const newArray = array;
    newArray.splice(0, number);//slice maybe better
    return newArray;
  },
  dropWhile(array, predicate) {
     // material => material.length
     const dropNumber = array.findIndex((element, index) => {
       return !predicate(element, index, array);
     });//callback negate so falsy is truthy
     const droppedArray = this.drop(array, dropNumber);
     return droppedArray;
  },
  chunk(array, size = 1) {
    const chunkArray = [];
    for (let i = 0; i < array.length; i++) {
    if (i % size === 0) {	
    chunkArray.push(array.slice(i, i+size));
    }
    }
    return chunkArray;
  } 
}
const mepper = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
_.chunk(mepper, 5);
//console.log(_.drop(["hi", "okay", "yes", "bye"]));
//_.clamp(10, -5, 5);
/*
3 - Drops the specified number of elements from t                           
he beginning of an array - Failed: _.drop(["hi",                            
"okay", "yes", "bye"], 2) returned [ hi, okay ] i                           
nstead of [ bye, yes ].                                                     
4 - Drops one element if no number is specified -                           
 Failed: _.drop(["hi", "bye"]) returned [  ] inst                           
ead of [ bye ]. 
*/
// Do not write or modify code below this line.
module.exports = _;
