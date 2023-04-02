// --- Directions
// Given a string, return the character that is most
// commonly used in the string.
// --- Examples
// maxChar("abcccccccd") === "c"
// maxChar("apple 1231111") === "1"

function maxChar(str) {
  const hashMap = {};
  let max = 0;
  let maxChar = "";
  for (let character of str) {
    if (!hashMap[character]) {
      hashMap[character] = 1;
    } else {
      hashMap[character]++;
    }
  }

  for (let char in hashMap) {
    if (hashMap[char] > max) {
      max = hashMap[char];
      maxChar = char;
    }
  }

  return maxChar;
}

module.exports = maxChar;
