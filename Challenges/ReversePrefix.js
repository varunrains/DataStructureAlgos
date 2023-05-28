/**
 * @param {string} word
 * @param {character} ch
 * @return {string}
 */
var reversePrefix = function (word, ch) {
  //We can use indexOf or for loop for find index
  const index = word.indexOf(ch);
  if (index < 0) return word;
  let startIndex = 0;
  let endIndex = index;
  let result = new Array(index);
  while (startIndex <= endIndex) {
    result[startIndex] = word[endIndex];
    result[endIndex] = word[startIndex];
    startIndex++;
    endIndex--;
  }

  return result.join("").concat(word.substring(index + 1));
};


/*
Source: https://leetcode.com/problems/reverse-prefix-of-word/description/
Input: word = "abcdefd", ch = "d"
Output: "dcbaefd"
Explanation: The first occurrence of "d" is at index 3. 
Reverse the part of word from 0 to 3 (inclusive), the resulting string is "dcbaefd".
*/