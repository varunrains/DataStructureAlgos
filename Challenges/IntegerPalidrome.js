/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function (x) {
  if (x < 0) return false;
  let temp = x;
  let reversed_int = 0;
  while (x > 0) {
    let lastDigit = x % 10;
    x = Math.floor(x / 10);

    reversed_int = reversed_int * 10 + lastDigit;
  }
  return temp === reversed_int;
};


/*
Source: https://leetcode.com/problems/palindrome-number/

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.

*/