// --- Directions
// Check to see if two provided strings are anagrams of eachother.
// One string is an anagram of another if it uses the same characters
// in the same quantity. Only consider characters, not spaces
// or punctuation.  Consider capital letters to be the same as lower case
// --- Examples
//   anagrams('rail safety', 'fairy tales') --> True
//   anagrams('RAIL! SAFETY!', 'fairy tales') --> True
//   anagrams('Hi there', 'Bye there') --> False

function anagrams(stringA, stringB) {
    stringA = stringA.replace(/[^\w]/g,"").toLowerCase();
    stringB = stringB.replace(/[^\w]/g,"").toLowerCase();

    if(stringA.length !== stringB.length) return false;

    let objMapForStringA = {};
    let objMapForStringB = {};

    //You can remove the extra for loop and create
    //one common for loop which can be used for both the strings
    //DRY principle and KISS principle- KEEP in MIND!!!
    for(let chars of stringA){
        if(!objMapForStringA[chars]){
            objMapForStringA[chars] = 1;
        }else{
            objMapForStringA[chars]++;
        }
    }

    for(let chars of stringB){
        if(!objMapForStringB[chars]){
            objMapForStringB[chars] = 1;
        }else{
            objMapForStringB[chars]++;
        }
    }

    for(let val in objMapForStringA){
        if(objMapForStringA[val] !== objMapForStringB[val]){
            return false;
        }
    }
    return true;
}

module.exports = anagrams;
