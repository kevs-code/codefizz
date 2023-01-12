// Write your function here:
const tipCalculator = (quality, total) => {
  if (typeof quality === 'string' && typeof total === 'number') {
    return quality === 'bad' ? total * 0.05 :
    quality === 'ok' ? total * 0.15 :
    quality === 'good' ? total * 0.2 :
    quality === 'excellent' ? total * 0.3 :
    total * 0.18;
  } else {
    console.log ('Error: parsed invalid data types');
  }
}

// Uncomment the line below when you're ready to try out your function
console.log(tipCalculator('good', 100)) //should return 20

// We encourage you to add more function calls of your own to test your code!

