/**
 * @param {string} text1
 * @param {string} text2
 * @return {number}
 */
var longestCommonSubsequence = function (text1, text2) {
  let rows = text1.length;
  let cols = text2.length;
  const dp = new Array(rows + 1).fill().map((_) => new Array(cols + 1).fill(0));

  for (let row = 0; row <= rows; row++) {
    for (let col = 0; col <= cols; col++) {
      if (row === 0 || col === 0) {
        dp[row][col] = 0;
      } else if (text1[row - 1] === text2[col - 1]) {
        dp[row][col] = 1 + dp[row - 1][col - 1];
      } else {
        dp[row][col] = Math.max(dp[row][col - 1], dp[row - 1][col]);
      }
    }
  }

  return dp[rows][cols];
};


/*

If you use recursion here for some large inputs you will get timeout and also you cannot
memoize the solution hence DP approach is needed with the tabular thinking
like to construct a 2D array and then find the number of subsequences.
Solution: Udemy + YOutube https://www.youtube.com/watch?v=jHGgXV27qtk&ab_channel=Jenny%27sLecturesCSIT
*/