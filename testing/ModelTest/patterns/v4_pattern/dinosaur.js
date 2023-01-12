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
      max: [10, 'Cannot hold more than 10 dinosaurs.']
    },
    risk: {type: String}
  }
);

DinosaurSchema.statics.findByName = function(name, callback) {
  return this.findOne({ name: name }, callback);
};

// Define .breed here
DinosaurSchema.methods.breed = function(name, callback) {
  this.count = this.count + 1;
};
// instance method - call the method
dino.breed()

module.exports = mongoose.model('Dinosaur', DinosaurSchema);

