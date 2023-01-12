const assert = require('assert');

describe('Calculate', () =>{
  describe('.sum', () =>{
     it('returns the sum of an array of numbers', () =>{
     })
   }) 
})

const assert = require('assert');
const Calculate =  require('../index.js')

describe('Calculate', () => {
  describe('.sum',() => {
    it('returns the sum of an array of numbers', () => {
      assert.equal(Calculate.sum([1,2,3]), 6)
    });
  });
});
/*
const Calculate = {
  sum(arr) {
    let total = 0;
    arr.forEach(number => {
      total += number;
    });
    return total;
  }
};

module.exports = Calculate;
*/
const assert = require('assert');
const Calculate =  require('../index.js')

describe('Calculate', () => {
  describe('.sum',() => {
    it('returns the sum of an array of numbers', () => {
      //setup
      const expected = 6;
      const testArray = [1, 2, 3];
      //exercise
      const result = Calculate.sum(testArray);
      //verify
      assert.equal(result, expected);
    });
  });
});


/*
const Calculate = {
  sum(inputArray){
    return 6
  }
}

module.exports = Calculate;
*/
const Calculate = {
	sum(inputArray) {
    let total = 0;
    inputArray.forEach(number => {
      total += number;
    });
    return total;
	}
}

module.exports = Calculate;
//
var assert = require("assert");
var Calculate =  require('../index.js')
describe('Calculate', () => {
  describe('.sum',() => {
    it('returns the sum of an array of numbers', () => {
      const expectedResult = 6;
      const inputArray = [1,2,3]
      const result = Calculate.sum(inputArray)
      
      assert.equal(result, expectedResult);
    });

    it('returns the sum of a four item list', ()=> {
      const expectedResult = 22;
      const inputArray = [4, 5, 6, 7] ;
      const result = Calculate.sum(inputArray)
      assert.equal(result, expectedResult)
    })   
    
  });
});

/*
 const Calculate = {
	sum(inputArray) {
    let totalSum = 0;
    
    const inputArrayLength = inputArray.length;
		for (let i = 0; i < inputArrayLength; i++){
      totalSum += inputArray[i]
    }
    
    return totalSum;
	}
}

module.exports = Calculate;
*/

/*
 const Calculate = {
	sum(inputArray) {
    const reducer = (accumulator, currentValue) => accumulator + currentValue;
    let totalSum = inputArray.reduce(reducer);
    
    return totalSum;
	}
}

module.exports = Calculate;
*/

const Calculate = {
  sum(inputArray) {
    if(inputArray.length === 0) {
      return 0;
    }
    return inputArray.reduce((sum, value) => {
      return sum + value;
    })
  }
}

module.exports = Calculate;
