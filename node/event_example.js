// Here we require in the 'events' module and save a reference to it in an events variable
let events = require('events');

let listenerCallback = (data) => {
    console.log('Celebrate ' + data);
}
let myEmitter = new events.EventEmitter();
myEmitter.on('celebration', listenerCallback);

myEmitter.emit('celebration', 'good times come on');

//$ node app.js
//Celebrate good times come on
