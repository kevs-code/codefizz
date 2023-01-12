const express = require('express');
const { seedElements } = require('./utils');

const expressions = [];
seedElements(expressions, 'expressions');

const expressionsRouter = express.Router();

// Get all expressions
expressionsRouter.get('/', (req, res, next) => {
  res.send(expressions);
});

module.exports = expressionsRouter;
