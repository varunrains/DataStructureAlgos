/**
 * @param {number} n
 * @param {number} k - K number of steps to reach to the top
 * @return {number}
 */
var climbStairs = function (n, k) {
  const dp = new Array(n + 1);
  dp[0] = 1;
  //dp[1] = 1;

  for (let i = 1; i <= n; i++) {
    let ans = 0;
    for (let jump = 1; jump <= k; jump++) {
      if (i - jump >= 0) {
        ans += dp[i - jump];
      }
    }
    dp[i] = ans;
  }

  return dp[n];
};
