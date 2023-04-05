// --- Directions
// Write a function that returns the number of vowels
// used in a string.  Vowels are the characters 'a', 'e'
// 'i', 'o', and 'u'.
// --- Examples
//   vowels('Hi There!') --> 3
//   vowels('Why do you ask?') --> 4
//   vowels('Why?') --> 0

function vowels(str) {
    //Instead of putting a if condition for a e i o u
    //Define a string of characters and then check against it
    //Like checker = [a, e ,i , o ,u]
    //checker.includes(char) --> Inside the for loop
    let vowelCount = 0;
    for(let char of str.toLowerCase()){
        if(char === 'a' || char === 'e' || char === 'i' || char === 'o' || char === 'u'){
            vowelCount++;
        }
    }
    return vowelCount;
}

module.exports = vowels;
