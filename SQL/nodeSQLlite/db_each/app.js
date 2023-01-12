const { addClimateRowToObject, calculateAverages, printQueryResults } = require('./utils');
const sqlite = require('sqlite3');

const db = new sqlite.Database('./db.sqlite');

// your code below:
const temperaturesByYear = {};
db.each("SELECT * FROM TemperatureData", 
  (error, row) => {
    addClimateRowToObject(row, temperaturesByYear);
  },
  (error, numberOfRows) => {
    // This gets called after each of our rows have been processed
    let averageTemperatureByYear = calculateAverages(temperaturesByYear);
  printQueryResults(averageTemperatureByYear);
  }
);
