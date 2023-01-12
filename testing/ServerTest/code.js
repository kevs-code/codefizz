const {assert} = require('chai');
describe('Array', () => {
  describe('.pop()', () => {
    it('should return a value and remove the element from the array', () => {
      // setup
      const foo = [4];
      const includedNumber = 4; 
      // check setup
      assert.include(foo, includedNumber);
      // exercise
      const fooPop = foo.pop();
      
      // asserts
      assert.equal(fooPop, includedNumber);
      assert.equal(foo.length, 0);
    });
  });
});

const {assert} = require('chai');
const {jsdom} = require('jsdom');

const parseTextFromHTML = (htmlAsString, selector) => {
  const selectedElement = jsdom(htmlAsString).querySelector(selector);
  if (selectedElement !== null) {
    return selectedElement.textContent;
  } else {
    throw new Error(`No element with selector ${selector} found in HTML string`);
  }
};

describe('HTML tests', () => {
  describe('#bar', () => {
    it('should include the string "Hello"', () => {
      // setup
      const foo = '<html><div id="bar">Hello</div><div id="buzz">Hello</div><html>';
      //asserts
      assert.include(parseTextFromHTML(foo, '#bar'), 'Hello'); 
    });
  });
});

// async await

const request = require('supertest');

const app = require('../../app');

describe('the homepage', () => {
  it('returns the correct content', async () => {
    const response = await request(app)
      .get('/')
      .send();
      console.log(response.text);
    });
});


//

const request = require('supertest');

const app = require('../../app');

describe('the homepage', () => {
    it('returns the correct content', async () => {
        const response = await request(app)
        .get('/')

        console.log(response.text);
    });
});


const express = require('express');
const router = express.Router();


router.get('/', async (req, res) => {
  res.send('<h1 id="page-title">My Page</h1>');
});

module.exports = router;

// part 2

const {assert} = require('chai');
const request = require('supertest');
const {jsdom} = require('jsdom');

const app = require('../../app');

const parseTextFromHTML = (htmlAsString, selector) => {
    const selectedElement = jsdom(htmlAsString).querySelector(selector);
    if (selectedElement !== null) {
      return selectedElement.textContent;
    } else {
      throw new Error(`No element with selector ${selector} found in HTML string`);
    }
};

describe('when the Message is valid', () => {
    it('creates a new message', async () => {
      const author = 'user name';
      const message ='feature testing with TDD makes me feel empowered to create a better workflow';
      
      //save message
      const response = await request(app)
        .post('/messages')
        .type('form')
        .send({author, message});
      
      //check response to verify message is saved
      assert.include(parseTextFromHTML(response, '#messages'), message);
    });
});

//

const {assert} = require('chai');
const request = require('supertest');

const app = require('../../app');

describe('root page', () => {
  describe('GET request', () => {
    it('returns a 200 status', async () => {
      const response = await request(app).
      get('/');
      assert.equal(response.status, 200);
    });
  });
});

/*


router.get('/', (req, res) => {
  res.send('');
});

module.exports = router;
*/

const {assert} = require('chai');
const request = require('supertest');
const {jsdom} = require('jsdom');

const app = require('../../app');

const parseTextFromHTML = (htmlAsString, selector) => {
  const selectedElement = jsdom(htmlAsString).querySelector(selector);
  if (selectedElement !== null) {
    return selectedElement.textContent;
  } else {
    throw new Error(`No element with selector ${selector} found in HTML string`);
  }
};

describe('root page', () => {
  describe('GET request', () => {
    it('returns a 200 status', async () => {
      const response = await request(app).
      get('/');
      assert.equal(response.status, 200);
    });
    
    it('contains the correct title', async () => {
      const response = await request(app).
      get('/');
      assert.equal(parseTextFromHTML(response.text, '#page-title'), "Messaging App");
    });
  });
});


/*
const express = require('express');
const router = express.Router();


router.get('/', (req, res) => {
    res.send('<h1 id="page-title">Messaging App</h1>');
});

module.exports = router;
*/

//

const {assert} = require('chai');
const request = require('supertest');
const {jsdom} = require('jsdom');

const app = require('../../app');

const parseTextFromHTML = (htmlAsString, selector) => {
  const selectedElement = jsdom(htmlAsString).querySelector(selector);
  if (selectedElement !== null) {
    return selectedElement.textContent;
  } else {
    throw new Error(`No element with selector ${selector} found in HTML string`);
  }
};

describe('profile page', () => {
  describe('GET request', () => {
    it('greets alice', async () => {
        
        const response = await request(app).
        get('/profile/alice');
        assert.equal(parseTextFromHTML(response.text, '#welcome-message'), 'Welcome alice!');
    });
    it('greets bob', async () => {
        const response = await request(app).
        get('/profile/bob');
        assert.equal(parseTextFromHTML(response.text, '#welcome-message'), 'Welcome bob!');
    });
  });
});


/*
const express = require('express');
const router = express.Router();


router.get('/:username', (req, res) => {
    res.send('<h1 id="welcome-message">Welcome ' + req.params.username +'!</h1>');
});

module.exports = router;
*/

// should delete alice or bob and make the other generic usename from ... req.params.username or maybe lastID
/*
const express = require('express');
const router = express.Router();


router.get('/:username', (req, res) => {
    const username = req.params.username;
    res.send('<h1 id="welcome-message">Welcome ' + username + '!</h1>');
});

module.exports = router;
*/

//profile-test.js
const {assert} = require('chai');
const request = require('supertest');
const {jsdom} = require('jsdom');

const app = require('../../app');

const parseTextFromHTML = (htmlAsString, selector) => {
  const selectedElement = jsdom(htmlAsString).querySelector(selector);
  if (selectedElement !== null) {
    return selectedElement.textContent;
  } else {
    throw new Error(`No element with selector ${selector} found in HTML string`);
  }
};

describe('profile page', () => {
  describe('GET request', () => {
    it('greets user with custom message', async () => {
        const username = 'alice';
        const response = await request(app).
        get('/profile/' + username);
        assert.equal(parseTextFromHTML(response.text, '#welcome-message'), 'Welcome ' + username + '!');
    });
  });
});


/* profile.handlebars

<h1 id="welcome-message">Welcome {{ username }}!</h1>

profile.js

const express = require('express');
const router = express.Router();


router.get('/:username', (req, res) => {
    const username = req.params.username;
    
    res.send(res.render('profile', {username}));
});

module.exports = router;

works fine

const {assert} = require('chai');
const request = require('supertest');
const {jsdom} = require('jsdom');

const app = require('../../app');

const parseTextFromHTML = (htmlAsString, selector) => {
  const selectedElement = jsdom(htmlAsString).querySelector(selector);
  if (selectedElement !== null) {
    return selectedElement.textContent;
  } else {
    throw new Error(`No element with selector ${selector} found in HTML string`);
  }
};

describe('/messages', () => {
  
  describe('POST', () => {
    describe('when the Message is valid', () => {
      it('redirects to the index', async () => {
        const author = 'Inquisitive User';
        const message = 'Why Test?';

        const response = await request(app)
          .post('/messages')
          .type('form')
          .send({author, message});

        assert.equal(response.status, 302);
        assert.equal(response.headers.location, '/');
      });
    });

    describe('when the author is blank', () => {
      it('renders an error message', async () => {
        const message = 'Every message requires an author';
        const receivedMessage = JSON.parse(response.text).message;
        const response = await request(app)
          .post('/messages')
          .send({message});
          assert.equal(response.status, 400);
          assert.equal(receivedMessage, message);
        });
    });

  });
});

but expects ... 
*/

const {assert} = require('chai');
const request = require('supertest');
const {jsdom} = require('jsdom');

const app = require('../../app');

const parseTextFromHTML = (htmlAsString, selector) => {
  const selectedElement = jsdom(htmlAsString).querySelector(selector);
  if (selectedElement !== null) {
    return selectedElement.textContent;
  } else {
    throw new Error(`No element with selector ${selector} found in HTML string`);
  }
};

describe('/messages', () => {
  
  describe('POST', () => {
    describe('when the Message is valid', () => {
      it('redirects to the index', async () => {
        const author = 'Inquisitive User';
        const message = 'Why Test?';

        const response = await request(app)
          .post('/messages')
          .type('form')
          .send({author, message});

        assert.equal(response.status, 302);
        assert.equal(response.headers.location, '/');
      });
    });

    describe('when the author is blank', () => {
      it('renders an error message', async () => {
        const message = 'Server Testing';

        const response = await request(app)
          .post('/messages')
          .send({message});
        
        assert.equal(response.status, 400);
        assert.equal(JSON.parse(response.text).message, 'Every message requires an author')
        });
    });

  });
});

