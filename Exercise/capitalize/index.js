// --- Directions
// Write a function that accepts a string.  The function should
// capitalize the first letter of each word in the string then
// return the capitalized string.
// --- Examples
//   capitalize('a short sentence') --> 'A Short Sentence'
//   capitalize('a lazy fox') --> 'A Lazy Fox'
//   capitalize('look, it is working!') --> 'Look, It Is Working!'

function capitalize(str) {
    var splitArray = str.split(/[ ]+/g);
    let tempArray = [];
    for(let split of splitArray){
        let temp = split[0].toUpperCase(); 
        split = temp+split.slice(1);
        tempArray.push(split);
    }
    return tempArray.join(' ');
}

module.exports = capitalize;
