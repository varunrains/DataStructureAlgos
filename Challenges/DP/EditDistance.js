/**
 * @param {string} word1
 * @param {string} word2
 * @return {number}
 */
var minDistance = function (word1, word2) {
  const first = word1.length;
  const second = word2.length;
  const dp = new Array(first + 1)
    .fill()
    .map((_) => new Array(second + 1).fill());

  for (let row = 0; row <= first; row++) {
    for (let col = 0; col <= second; col++) {
      if (row === 0) {
        dp[row][col] = col;
      } else if (col === 0) {
        dp[row][col] = row;
      } else if (word1[row - 1] === word2[col - 1]) {
        dp[row][col] = dp[row - 1][col - 1];
      } else {
        const insert = dp[row][col - 1];
        const del = dp[row - 1][col];
        const replace = dp[row - 1][col - 1];
        dp[row][col] = 1 + Math.min(insert, del, replace);
      }
    }
  }

  return dp[first][second];
};

/*
Source: https://leetcode.com/problems/edit-distance/

Input: word1 = "horse", word2 = "ros"
Output: 3
Explanation: 
horse -> rorse (replace 'h' with 'r')
rorse -> rose (remove 'r')
rose -> ros (remove 'e')

Referred Udemy to solve this
*/
