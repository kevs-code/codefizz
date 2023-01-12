const source = document.getElementById('eachHelper').innerHTML;
const template = Handlebars.compile(source);

const context = {
  newArray: ['a', 'b', 'c']
};

const compiledHtml = template(context);

const displayElements = document.getElementById('display');
displayElements.innerHTML = compiledHtml;

