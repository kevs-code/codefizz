const _ = {
  clamp (num, min, max) {
    const lowerClamp = Math.max(num, min);
    const clamped = Math.min(lowerClamp, max);
    return clamped;
  },
  inRange (num, min, max) {
   if (arguments.length === 2) {
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
    if (num >= min && num <= max) {
      return true;
    } else {
      return false;
    }
  }
}

// Do not write or modify code below this line.
module.exports = _;
