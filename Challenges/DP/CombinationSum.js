/**
 * @param {number[]} candidates
 * @param {number} target
 * @return {number[][]}
 */
var combinationSum = function (candidates, target, memo = {}) {
  if (memo[target]) return memo[target];
  if (target === 0) {
    return [[]]; // Return an array containing an empty combination as a valid solution
  }
  if (target < 0) {
    return null;
  }

  let res = [];
  let combinationSet = new Set(); // Set to store unique combinations
  for (let num of candidates) {
    let remainder = target - num;
    let remainderSum = combinationSum(candidates, remainder, memo);

    if (remainderSum !== null) {
      for (let combination of remainderSum) {
        let currentCombination = [...combination, num];
        let currentCombinationString = currentCombination.sort().join("-");

        if (!combinationSet.has(currentCombinationString)) {
          combinationSet.add(currentCombinationString);
          res.push(currentCombination);
        }
      }
    }
  }

  memo[target] = res;
  return res;
};

/*
The above solution can be improved a lot. Please check

Source: https://leetcode.com/problems/combination-sum/description/

Input: candidates = [2,3,6,7], target = 7
Output: [[2,2,3],[7]]
Explanation:
2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times.
7 is a candidate, and 7 = 7.
These are the only two combinations.

*/
