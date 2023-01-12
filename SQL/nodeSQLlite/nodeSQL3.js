const { printQueryResults } = require('./utils');
const sqlite = require('sqlite3');

const db = new sqlite.Database('./db.sqlite');

// Your code below:
db.all("SELECT * FROM TemperatureData WHERE year=1970", (error, rows) => {
  printQueryResults(rows);
});

// Your code below:
db.all("SELECT * FROM TemperatureData WHERE year = 1970", (error, rows) => {
  printQueryResults(rows);
})

db.get("SELECT * FROM TemperatureData WHERE year = 2020", (error, rows) => {
  printQueryResults(rows);
});

const { printQueryResults } = require('./utils');
const sqlite = require('sqlite3');

const db = new sqlite.Database('./db.sqlite');

// Your code below:
db.get("SELECT * FROM TemperatureData WHERE year = 2000", (error, rows) => {
  printQueryResults(rows);
});

const { printQueryResults } = require('./utils');
const sqlite = require('sqlite3');

const db = new sqlite.Database('./db.sqlite');

const ids = [1, 25, 45, 100, 360, 382];
// your code below:
for (i = 0; i < ids.length; i++) {
  db.get("SELECT * FROM TemperatureData WHERE id = $index", 
    {
      $index: ids[i]
    }, 
    (error, rows) => {
      printQueryResults(rows);
    });
};

/*
INSERT INTO celebs (id, name, age)
VALUES (1, 'Justin Bieber', 22);
*/

const sqlite = require('sqlite3');

const db = new sqlite.Database('./db.sqlite');

const newRow = {
  location: 'Istanbul, Turkey',
  year: 1976,
}
// Your code below!
db.run('INSERT INTO TemperatureData (location, year) VALUES ($newRow.location, $newRow.year)', function(error) {
  console.log(this.lastID);
});


*/
const { printQueryResults } = require('./utils');
const sqlite = require('sqlite3');

const db = new sqlite.Database('./db.sqlite');

const newRow = {
  location: 'Istanbul, Turkey',
  year: 1976,
  tempAvg: 13.35
}

db.run('INSERT INTO TemperatureData (location, year, temp_avg) VALUES ($location, $year, $tempAvg)', {
  $location: newRow.location,
  $year: newRow.year,
  $tempAvg: newRow.tempAvg
}, function(error) {
  // handle errors here!
  if(error){
    return console.log(error);
  }
  
  console.log(this.lastID);
});

db.get('SELECT * FROM TemperatureData WHERE id = $id', {
                $id: this.lastID
        },
  function(error, row){
    printQueryResults(row);
        });

/*

db.get("SELECT * FROM TemperatureData WHERE id = $id", {
  $id: this.lastID
}, (error, rows) => {
  printQueryResults(rows);
});

db.get("SELECT * FROM TemperatureData WHERE id = $this.lastID", (error, rows) => {
  printQueryResults(rows);
});

*/
const { printQueryResults } = require('./utils');
const sqlite = require('sqlite3');

const db = new sqlite.Database('./db.sqlite');

const newRow = {
  location: 'Istanbul, Turkey',
  year: 1976,
  tempAvg: 13.35
}

db.run('INSERT INTO TemperatureData (location, year, temp_avg) VALUES ($location, $year, $tempAvg)', {
  $location: newRow.location,
  $year: newRow.year,
  $tempAvg: newRow.tempAvg
}, function(error) {
  // handle errors here!
  if(error){
    return console.log(error);
  }
  
  console.log(this.lastID);

  db.get('SELECT * FROM TemperatureData WHERE id = $id', {
                $id: this.lastID
        },
  function(error, row){
    printQueryResults(row);
        });
});


