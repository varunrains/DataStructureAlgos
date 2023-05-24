/**
 * @param {number} n
 * @return {number}
 */
var climbStairs = function(n, memo={}) {
    if(n in memo) return memo[n];
    if(n===1 || n===0){
        return 1;
    }
    let numberOfWays = climbStairs(n-1) + climbStairs(n-2);
    memo[n] = numberOfWays;
    return numberOfWays;
};

/*
Source: https://leetcode.com/problems/climbing-stairs/

Input: n = 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps
*/