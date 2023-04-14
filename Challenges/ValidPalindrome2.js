var validPalindrome = function (s) {
  let startIndex = 0;
  let endIndex = s.length - 1;

  while (startIndex <= endIndex) {
    if (s[startIndex] !== s[endIndex]) {
      if (
        check(s, startIndex + 1, endIndex) ||
        check(s, startIndex, endIndex - 1)
      ) {
        return true;
      }
      return false;
    }
    startIndex++;
    endIndex--;
  }

  return true;
};

var check = function (s, sI, eI) {
  while (sI <= eI) {
    if (s[sI] !== s[eI]) {
      return false;
    }
    sI++;
    eI--;
  }
  return true;
};

/*
Source: https://leetcode.com/problems/valid-palindrome-ii/

Given a string s, return true if the s can be palindrome after deleting at most one character from it.
Input: s = "abca"
Output: true
Explanation: You could delete the character 'c'.
*/
