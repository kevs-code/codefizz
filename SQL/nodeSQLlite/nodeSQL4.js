const { printQueryResults, calculateAverages, addClimateRowToObject } = require('./utils');
const sqlite = require('sqlite3');

const db = new sqlite.Database('./db.sqlite');

const temperaturesByYear = {};

db.run('DROP TABLE IF EXISTS Average', error => {
  if (error) {
    throw error;
  }
  db.each('SELECT * FROM TemperatureData',
    (error, row) => {
      if (error) {
        throw error;
      }
      addClimateRowToObject(row, temperaturesByYear);
    }, 
    error => {
      if (error) {
        throw error;
      }
      const averageTemperatureByYear = calculateAverages(temperaturesByYear);
      // your code here:
db.run('CREATE TABLE Average (id INTEGER PRIMARY KEY, year INTEGER NOT NULL, temperature REAL NOT NULL)');
averageTemperatureByYear.forEach(row => {
db.run('INSERT INTO Average (year, temperature) VALUES ($year, $temp)', {
  $year: row.year,
  $temp: row.temperature
}, err => {
          if (err) {
            console.log(err);
          }
})
})
    }
  );
});

