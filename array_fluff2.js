let secretMessage = ['Learning', 'is', 'not', 'about', 'what', 'you', 'get', 'easily', 'the', 'first', 'time,', 'it', 'is', 'about', 'what', 'you', 'can', 'figure', 'out.', '-2015,', 'Chris', 'Pine,', 'Learn', 'JavaScript'];
secretMessage.pop();
console.log(secretMessage.length);
secretMessage.push('to', 'Program');
secretMessage[7] = 'right';
secretMessage.shift();
secretMessage.unshift('Programming');
console.log(secretMessage);
console.log(secretMessage.splice(6, 4));
secretMessage[6] = 'know,';
// secretMessage.splice(6, 5);
console.log(secretMessage);
console.log(secretMessage.join(' '));

