const express = require('express');
const app = express();
const morgan = require('morgan');
const bodyParser = require('body-parser');
const sqlite = require('sqlite3');
const db = new sqlite.Database('./db.sqlite');

app.use(express.static('public'));

const PORT = process.env.PORT || 4001;

app.use(morgan('dev'));
app.use(bodyParser.json());

app.get('/strips', (req, res, next) => {
  let stripsFromDatabase = [];
  db.all("SELECT * FROM Strip", (error, rows) => {
  stripsFromDatabase.push(rows);
});
  res.send({ strips: stripsFromDatabase });
});


/*
app.get('/strips', (req, res, next) => {
  db.all('SELECT * FROM Strip', (err, rows) => {
    if (err) {
      res.sendStatus(500);
    } else {
      res.send({strips: rows});
    }
  });
});

const validateStrip = (req, res, next) => {
  const stripToCreate = req.body.strip;
  if (!stripToCreate.head || !stripToCreate.body || !stripToCreate.bubbleType ||
      !stripToCreate.background) {
    return res.sendStatus(400);
  }
  next();
}
*/


app.post('/strips', (req, res, next) => {
  const receivedStrip = createElement('strips', req.query);
  if (receivedStrip) {
    strips.push(receivedStrip);
    res.status(201).send(receivedStrip);
  } else {
    res.status(400).send();
  }
});

/*
app.post('/strips', validateStrip, (req, res, next) => {
  const stripToCreate = req.body.strip;
  db.run(`INSERT INTO Strip (head, body, bubble_type, background, bubble_text,
    caption) VALUES ($head, $body, $bubbleType, $background, $bubbleText,
    $caption)`,
  {
    $head: stripToCreate.head,
    $body: stripToCreate.body,
    $bubbleType: stripToCreate.bubbleType,
    $background: stripToCreate.background,
    $bubbleText: stripToCreate.bubbleText,
    $caption: stripToCreate.caption,
  }, function(err) {
    if (err) {
      return res.sendStatus(500);
    }
    db.get(`SELECT * FROM Strip WHERE id = ${this.lastID}`, (err, row) => {
      if (!row) {
        return res.sendStatus(500);
      }
      res.status(201).send({strip: row});
    });
  });
});
*/

app.listen(PORT, () => {
  console.log(`Server is listening on ${PORT}`);
});

module.exports = app;
