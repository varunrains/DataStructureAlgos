/**
 * @param {number} m
 * @param {number} n
 * @return {number}
 */
var uniquePaths = function (m, n) {
  const d = [...Array(m)].map(() => [...Array(n)].fill(0));

  for (let i = 0; i < m; i++) {
    d[i][0] = 1;
  }

  for (let i = 0; i < n; i++) {
    d[0][i] = 1;
  }

  for (let row = 1; row < m; row++) {
    for (let col = 1; col < n; col++) {
      d[row][col] = d[row - 1][col] + d[row][col - 1];
    }
  }

  return d[m - 1][n - 1];
};


/*
Source: https://leetcode.com/problems/unique-paths/

Input: m = 3, n = 7
Output: 28
*/