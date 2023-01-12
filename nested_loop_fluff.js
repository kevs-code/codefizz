// Write your code below

const bobsFollowers = ['rita', 'sue', 'and', 'bob2'];
const tinasFollowers = ['rita', 'sue', 'ike'];
const mutualFollowers = [];

for (let i = 0; i < bobsFollowers.length; i++) {
  for (let j = 0; j < tinasFollowers.length; j++) {
    if (bobsFollowers[i] === tinasFollowers[j]) {
      mutualFollowers.push(tinasFollowers[j]);
    }
  }
};

