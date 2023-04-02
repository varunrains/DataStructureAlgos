// --- Directions
// Given an integer, return an integer that is the reverse
// ordering of numbers.
// --- Examples
//   reverseInt(15) === 51
//   reverseInt(981) === 189
//   reverseInt(500) === 5
//   reverseInt(-15) === -51
//   reverseInt(-90) === -9

function reverseInt(n) {
  let sign = Math.sign(n);
  let numberString = n.toString();
  let reversed = "";
  for (let charNumber of numberString) {
    if (charNumber !== "-") {
      reversed = charNumber + reversed;
    }
  }
  if (sign === -1) {
    reversed = "-" + reversed;
  }
  return parseInt(reversed);
}

// function reverseInt(n) {
//   const reversed = n.toString().split("").reverse().join("");
//   return parseInt(reversed) * Math.sign(n);
// }

module.exports = reverseInt;
