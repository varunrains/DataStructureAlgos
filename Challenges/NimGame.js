/**
 * @param {number} n
 * @return {boolean}
 */
var canWinNim = function (n) {
  if (n % 4 === 0) return false;
  return true;
};


/*
https://leetcode.com/problems/nim-game/
Input: n = 4
Output: false
Explanation: These are the possible outcomes:
1. You remove 1 stone. Your friend removes 3 stones, including the last stone. Your friend wins.
2. You remove 2 stones. Your friend removes 2 stones, including the last stone. Your friend wins.
3. You remove 3 stones. Your friend removes the last stone. Your friend wins.
In all outcomes, your friend wins.


Sol ---> Come up with the pattern 
So for every round which is divisible by 4 you will loose in this case
N-> 1 2 3 4 5 6 7 8
    W W W L W W W L
*/