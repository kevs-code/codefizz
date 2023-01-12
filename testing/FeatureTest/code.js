const {assert} = require('chai');

describe('User visits root', () => {
  describe('without existing messages', () => {
    it('starts blank', () => {
      browser.url('/');
    }); 
  });
});

const {assert} = require('chai');

describe('User visits root', () => {

  describe('without existing messages', () => {
    it('starts blank', () => {
      browser.url('/');

      assert.equal(browser.getText('#messages'), '');
    });
  });
});

// <section id="messages"></section>

const {assert} = require('chai');

describe('User visits root', () => {

  describe('without existing messages', () => {
    it('starts blank', () => {
      browser.url('/');

      assert.equal(browser.getText('#messages'),'');
    });
  });

  describe('posting a message', () => {
    it('saves the message with the author information', () => {
      const message = 'feature tests often hit every level of the TDD Testing Pyramid';
      const author = 'username';
 
    });
  });
});

//

const {assert} = require('chai');

describe('User visits root', () => {

  describe('without existing messages', () => {
    it('starts blank', () => {
      browser.url('/');

      assert.equal(browser.getText('#messages'),'');
    });
  });

  describe('posting a message', () => {
    it('saves the message with the author information', () => {
      // Setup
      const message ='feature tests often hit every level of the TDD Testing Pyramid';
      const author = 'username';
      // Exercise
      browser.url('/');
      browser.setValue('input[id=author]', author);
      browser.setValue('textarea[id=message]', message);
      browser.click('input[type=submit]');
    });
  });
});

//

const {assert} = require('chai');

describe('User visits root', () => {

  describe('without existing messages', () => {
    it('starts blank', () => {
      browser.url('/');

      assert.equal(browser.getText('#messages'),'');
    });
  });

  describe('posting a message', () => {
    it('saves the message with the author information', () => {
      
      const message ='feature tests often hit every level of the TDD Testing Pyramid';
      const author = 'username';

      browser.url('/');
      browser.setValue('input[id=author]', author);
      browser.setValue('textarea[id=message]', message);
      browser.click('input[type=submit]');
 
      assert.include(browser.getText('#messages'), author);
      assert.include(browser.getText('#messages'), message);
    });
  });
});
/*
<section id = "messages">
</section>
<input id = 'author'>
</input>
<textarea id='message'>
</textarea>
<input type='submit'>
</input>
*/
