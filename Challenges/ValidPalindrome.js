var isPalindrome = function (s) {

  if (s === null || s.length === 0) return false;
  let pattern = /[a-zA-Z0-9]/gi;
  //If the string contains space and if not matches the pattern
  //Then it will return null
  s = s.toLowerCase().match(pattern);

  if (s === null || s.length === 0) return true;
  s = s.join("");
  let startIndex = 0;
  let endIndex = s.length - 1;

  while (startIndex <= endIndex) {
    if (s[startIndex] !== s[endIndex]) {
      return false;
    }
    startIndex++;
    endIndex--;
  }

  return true;
};

/*
https://leetcode.com/problems/valid-palindrome/
Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
*/
