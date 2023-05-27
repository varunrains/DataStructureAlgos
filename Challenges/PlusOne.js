/**
 * @param {number[]} digits
 * @return {number[]}
 */
var plusOne = function (digits) {
  let len = digits.length;

  for (let i = len - 1; i >= 0; i--) {
    if (digits[i] < 9) {
      digits[i]++;
      break;
    } else {
      digits[i] = 0;
    }
  }

  if (digits[0] === 0) {
    let res = new Array(len + 1).fill(0);
    res[0] = 1;
    return res;
  }

  return digits;
};
/*
Source: https://leetcode.com/problems/plus-one/
Input: digits = [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
Incrementing by one gives 123 + 1 = 124.
Thus, the result should be [1,2,4].

*/
