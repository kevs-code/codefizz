let story = 'Last weekend, I took literally the most beautiful bike ride of my life. The route is called "The 9W to Nyack" and it actually stretches all the way from Riverside Park in Manhattan to South Nyack, New Jersey. It\'s really an adventure from beginning to end! It is a 48 mile loop and it basically took me an entire day. I stopped at Riverbank State Park to take some extremely artsy photos. It was a short stop, though, because I had a really long way left to go. After a quick photo op at the very popular Little Red Lighthouse, I began my trek across the George Washington Bridge into New Jersey.  The GW is actually very long - 4,760 feet! I was already very tired by the time I got to the other side.  An hour later, I reached Greenbrook Nature Sanctuary, an extremely beautiful park along the coast of the Hudson.  Something that was very surprising to me was that near the end of the route you actually cross back into New York! At this point, you are very close to the end.';

let overusedWords = ['really', 'very', 'basically'];

let unnecessaryWords = ['extremely', 'literally', 'actually' ];

const storyWords = story.split(' ');
console.log(storyWords.length);

let betterWords = storyWords.filter(word => {
  return !unnecessaryWords.includes(word);
});
console.log(betterWords.length);
const newbArray = [];
overusedWords.forEach(word => {
  count = 0;
  for (let i = 0; i < storyWords.length; i++) {
    if (storyWords[i] ===  word) {
      count++;
    } 
  }
  console.log (`${word}: ${count}`);
});

const getSentenceCount = read => {
  count = 0;
  for (let i = 0; i < read.length; i++) {
    if (read[i].endsWith('!')  || read[i].endsWith('.')) {
      count++;
    } 
  }
  console.log (`Sentences: ${count}`);
};

getSentenceCount(storyWords);

console.log(betterWords.join(' '));


//let re = /[azAZ]/;
//return re.test(word);
//arr1.some(r=> arr2.includes(r)

/*

Congratulations! You’ve improved the original paragraph and given the user some important information about his or her work. Think about ways in which you can extend this project, potentially by using other JavaScript knowledge you have.

Here are some ideas:

For the overused words, remove it every other time it appears.

Write a function that finds the word that appears the greatest number of times.

Replaced overused words with something else.

*/
