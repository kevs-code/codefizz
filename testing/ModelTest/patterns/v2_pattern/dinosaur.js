const mongoose = require('mongoose');
const Schema = mongoose.Schema;

const validator = function(value) {
  return value <= 10; 
};

const DinosaurSchema = new Schema(
  {
    name: {type: String, required: true},
    count: {
      type: Number,
      validate: [validator, 'Cannot hold more than 10 dinosaurs.']
    },
    risk: {type: String}
  }
);

module.exports = mongoose.model('Dinosaur', DinosaurSchema);
// refactor validate with max: [10, 'Cannot hold more than 10 dinosaurs.']
// a mongoose built in method
