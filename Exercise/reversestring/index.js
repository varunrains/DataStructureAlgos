// --- Directions
// Given a string, return a new string with the reversed
// order of characters
// --- Examples
//   reverse('apple') === 'leppa'
//   reverse('hello') === 'olleh'
//   reverse('Greetings!') === '!sgniteerG'

function reverse(str) {
  return str.split("").reduce((reversed, character) => {
    return character+reversed;
  }, "");
}

// function reverse(str) {
//     let reversedString = '';
//     for(let i=str.length-1;i<=0;i--){
//         reversedString += str[i];
//     }
//     return reversedString;
// }

// function reverse(str){
//     let reverse = '';
//     for(let character of str){
//         reverse = character + reverse;
//     }
//     return reverse;
// }

// function reverse(str){
//     return str.split('').reverse().join('');
// }

module.exports = reverse;
