/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var moveZeroes = function (nums) {
  let counter = 0;
  for (let i = 0; i < nums.length; i++) {
    if (nums[i] !== 0) {
      nums[counter] = nums[i];
      counter++;
    }
  }

  for (let i = counter; i < nums.length; i++) {
    nums[i] = 0;
  }
};


/*
Source: https://leetcode.com/problems/move-zeroes/

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]

*/