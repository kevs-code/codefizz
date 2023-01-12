document.body.innerHTML = '<h2>This is a heading</h2>';
document.querySelector('h1').innerHTML = 'Most popular TV show searches in 2016';
document.getElementById('fourth').innerHTML = 'Fourth element';

document.querySelector('.blue').style.fontFamily = 'Roboto';
document.querySelector('body').style.backgroundColor = '#201F2E';
let newDestination = document.createElement('li');
newDestination.id = 'oaxaca';
newDestination.innerHTML = 'Oaxaca, Mexico';

document.getElementById('more-destinations').appendChild(newDestination);

let oaxaca = document.getElementById('oaxaca');

document.getElementById('more-destinations').removeChild(oaxaca);

/*
let element = document.querySelector("button");
function turnButtonRed (){
element.style.backgroundColor = 'red';
element.style.color = 'white';
element.innerHTML = 'Red Button';
}
element.onclick = turnButtonRead //; was missing mfkers
*/

let element = document.querySelector("button");

function turnButtonRed (){
  element.style.backgroundColor = "red";
  element.style.color = "white";
  element.innerHTML = "Red Button"; 
}

element.onclick = turnButtonRed;


let first = document.body.firstChild;
first.innerHTML = 'I am the child!';
first.parentNode.innerHTML = 'I am the parent and my inner HTML has been replaced!';


let readMore = document.getElementById('read-more')
let moreInfo = document.getElementById('more-info')

// Write your code here:
readMore.onclick = () => {
  // this block of code will run
  moreInfo.style.display = 'block';
}
