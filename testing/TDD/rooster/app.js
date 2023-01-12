const assert = require('assert');
const Rooster = require('../index');

describe('Rooster', () => {
  describe('.announceDawn', () => {
    it('returns a rooster call', () => {
      // Define expected output
      const expected = 'cock-a-doodle-doo!';
      // Call Rooster.announceDawn and store result in variable
      const morningCall = Rooster.announceDawn();
      // Use an assert method to compare actual and expected result
      assert.ok(expected === morningCall);
    })
  });
  describe('.timeAtDawn', () => {
    it('returns its argument as a string', () => {
      const dawnTime = Rooster.announceDawn(8);
      const numbered = dawnTime.toString();
      assert.strictEqual(numbered, dawnTime);
    })   
  });
   
});


