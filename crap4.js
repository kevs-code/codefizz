// Write your function here:
const howOld = (age, year) => {
  const nowYear = 2020;
  let modAge = age + (year - nowYear);
  // console.log(age + ' ' + modAge)
  if (modAge > age) {
    return `You will be ${modAge} in the year ${year}`;
  } else if (modAge < 0) {
    modAge = modAge * -1;
    return `The year ${year} was ${modAge} years before you were born`;
  } else {
    return `You were ${modAge} in the year ${year}`;
  }
  //'You were [calculated age] in the year [year passed in]'
} 

console.log(howOld(5, 2005));


// Once your function is written, write function calls to test your code!

