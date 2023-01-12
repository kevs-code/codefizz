const assert = require('assert');

// Naive approach
describe('.pop', () => {
  it('returns the last element in the array [naive]', () => {
    assert.ok(pop(['padawan', 'knight']) === 'knight'); 
  });
});
//pops correct in 3stage.js
// 3 phase approach
describe('.pop', () => {
  it('returns the last element in the array [3phase]', () => {
    // Setup
    const knightString = 'knight';
    const jediPath = ['padawan', knightString];

    // Exercise
    const popped = pop(jediPath);

    // Verify
    assert.ok(popped === knightString);
  });
});


