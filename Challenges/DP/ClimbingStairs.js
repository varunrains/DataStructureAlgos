/**
 * @param {number} n
 * @return {number}
 */
var climbStairs = function(n) {

    const dp = new Array(n+1);
    dp[0] = 1;
    dp[1] = 1;

    for(let i = 2;i<=n;i++){
        dp[i] = dp[i-1] + dp[i-2];
    }

    return dp[n]
};

/*
Refer recursive solution under Recursion folder
You can solve this with Recursion and memoization which will not give you time limit exceeded error

You are climbing a staircase. It takes n steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

If the question is changed to 3 or 4 steps you should keep adding (n-3) and (n-4) to the formula
or to the recursive solution.

Source: https://leetcode.com/problems/climbing-stairs/


Input: n = 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps
*/