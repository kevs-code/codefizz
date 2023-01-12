const robot = {
  model: '1E78V2',
  energyLevel: 100,
  functionality: {
    beep() {
      console.log('Beep Boop');
    },
    fireLaser() {
      console.log('Pew Pew');
    },
  }
};

const { functionality } = robot;
functionality.beep();

/////////////////////check below///////
const myDog = {
  name: 'Tadpole',
  breed: 'mutt',
  color: 'tan',
  weight: 32
}

let { name } = myDog
