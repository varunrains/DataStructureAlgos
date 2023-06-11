/**
 * @param {number} n
 * @return {boolean}
 */
var isHappy = function (n) {
  let squareValue = 0;
  let hashmap = {};
  while (true) {
    while (n > 0) {
      let lastDigit = n % 10;
      squareValue += lastDigit * lastDigit;
      let remaining = Math.floor(n / 10);
      n = remaining;
    }
    if (squareValue === 1) return true;
    n = squareValue;

    if (!hashmap[squareValue]) {
      hashmap[squareValue] = true;
    } else {
      return false;
    }
    squareValue = 0;
  }
};

/*
Source: https://leetcode.com/problems/happy-number/

Input: n = 19
Output: true
Explanation:
12 + 92 = 82
82 + 22 = 68
62 + 82 = 100
12 + 02 + 02 = 1

*/
