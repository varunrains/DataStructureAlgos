/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function (nums, target) {
  let hashMap = {};
  for (let i = 0; i < nums.length; i++) {
    let val = target - nums[i];
    if (hashMap[val] !== undefined) {
      return [hashMap[val], i];
    } else {
      hashMap[nums[i]] = i;
    }
  }

  return [];
};

/*
Source: https://leetcode.com/problems/two-sum/

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

*/
