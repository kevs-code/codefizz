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
  
}

//_.clamp(10, -5, 5);


// Do not write or modify code below this line.
module.exports = _;
