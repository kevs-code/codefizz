const db = require('./db');

db.each('SELECT * FROM Flower', (error, row) => {
  if (row.petal_color === 'blue') {
    console.log(row);
  }
});

const db = require('./db');

  db.run('CREATE TABLE City');

const db = require('./db');

db.get('SELECT superpower FROM Superhero WHERE id = 12', (err, row) => {
  console.log(row.superpower);
});


const db = require('./db');

db.all('SELECT * from NonexistentTable', (err, rows) => {
  if (err) {
    console.log(err);
  } else {
    console.log(rows);
  }
});

const db = require('./db');

let totalPrice = 0;
db.each(
  "SELECT price FROM Clothing WHERE item = 'shirt'",
  (err, row) => {
    totalPrice += row.price;
  },
  (err, numRows) =>{
    console.log(totalPrice);
  }
);

const db = require('./db');

db.serialize(() => {
db.run('CREATE TABLE Popcorn (id INTEGER PRIMARY KEY, type TEXT)');
db.run('INSERT INTO POPCORN (type) VALUES ("cheddar")');
db.run('INSERT INTO POPCORN (type) VALUES ("kettle corn")');
});

const db = require('./db');

db.get("SELECT quantity FROM SpiceRack WHERE name = 'paprika'", (err, row) => {
  console.log(row.quantity);
})

const db = require('./db');

const selectByGenre = genre => {
  // Add your code in here
  db.all('SELECT title FROM Song WHERE genre = $genre', {
    $genre: genre
  }, (err, row) => {
    console.log(row.title);
  });
};

const db = require('./db');

db.all("SELECT * FROM Scientist WHERE field = 'biology'", (err, row) => {
  console.log(row);
});

const db = require('./db');

db.each("SELECT height FROM CartoonCharacter WHERE species = 'mouse'", (error, row) => {
    console.log(row.height);
});


const db = require('./db');

db.serialize(() => {
  db.run('DROP TABLE IF EXISTS Furniture', error => {
    if (error) {
      throw error;
    }
  });
  db.run('CREATE TABLE Furniture');
});

const db = require('./db');

const logCaffeineLevel = name => {
  db.get("SELECT * FROM Tea WHERE name=$name;", { $name: name }, (err, row) => {
    console.log(row.caffeine_level);
  })
}

const db = require('./db');


db.run("INSERT INTO Bridge (name, established_year) VALUES ('Brooklyn Bridge', 1883)");

const db = require('./db');

db.get("SELECT traffic FROM TrainStation WHERE station_id = 38 AND month = 'Aug'", (err, row) => {
  console.log(row.traffic);
});

const db = require('./db');

const logFloorsForAddress = address => {
  // Your code here:
  db.get("SELECT number_of_floors FROM Building WHERE address = $address", {
    $address: address
  }, (err, row) => {
    console.log(row.number_of_floors);
  });
}

const db = require('./db');

db.run("INSERT INTO BirdOfParadise (scientific_name, common_name) VALUES ('Cicinnurus regius', 'king bird-of-paradise')");

const db = require('./db');

const addMovie = (title, publicationYear, director) => {
  db.run("INSERT INTO Movie (title, publication_year, director) VALUES ($title, $publicationYear, $director)", {
    $title: title, 
    $publicationYear: publicationYear, 
    $director: director
  });
};


const db = require('./db');

db.each("SELECT name FROM Minifridge WHERE type = 'soda'", (error, row) => {
    console.log(row.name);
});

const db = require('./db');

db.run("INSERT INTO Holiday (name, work) VALUES ('Barry', false)");
