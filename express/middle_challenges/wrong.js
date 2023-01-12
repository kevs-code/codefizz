const express = require('express');
const app = express();

const database = {
  snacks: ['chips', 'apple', 'cookies'],
  sides: ['beans and rice', 'cole slaw', 'broccoli'],
  appetizers: ['oysters', 'dumplings', 'smoked almonds'],
};

// Add your code here:
const timeMiddleware = () => {
  const currentTime = Date.now();
  req.date = currentTime;
 //next(); would suffice
};

app.use(timeMiddleware);

app.get('/snacks', (req, res, next) => {
  res.send(`Snacks as of ${req.date}: ${database.snacks}`);
});

app.get('/sides', (req, res, next) => {
  res.send(`Sides as of ${req.date}: ${database.sides}`);
});

app.get('/appetizers', (req, res, next) => {
  res.send(`Appetizers as of ${req.date}: ${database.appetizers}`);
});
