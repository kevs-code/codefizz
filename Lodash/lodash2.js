const weary = {
 talls: 'hairy',
 scary: 'not',
 longer: 'sub'
}
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
has (obj, key) {
    const hasValue = obj[key];
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
      //console.log(`${key}: ${value}`);
    } 
   for (let [key, value] of Object.entries(flipside)) {
      //console.log(`${key}: ${value}`);
    } 
    return flipside;
  }
}

console.log(_.invert(weary));




/*
console.log(Object.keys(object));
[ 'talls', 'scary', 'longer' ]
console.log(Object.values(object));
[ 'hairy', 'not', 'sub' ]

talls: hairy
scary: not
longer: sub
*/

/*  
    remember the importance of pass as reference for obj but property as string;  
    Pass By Value And Pass By Reference In JavaScript
    const hasValue = Object.keys(obj);
    const hasMore = Object.values(obj);
    const hadMore = Object.keys(obj).map(function(k){return obj[k]})
    console.log(obj + '\n' + hasValue + '\n' + hasMore + '\n' + hadMore);
*/

//_.has(_, 'wire');
// Do not write or modify code below this line.
module.exports = _;
