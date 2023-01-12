
try {
  throw Error('This error will get caught');
} catch (e) {
  console.log(e);
}

console.log('The thrown error that was caught in the try...catch statement!');

