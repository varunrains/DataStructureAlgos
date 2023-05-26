/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var searchInsert = function (nums, target, sI = 0, eI = nums.length - 1) {
  if (sI > eI) {
    return sI;
  }

  const midpoint = Math.floor((sI + eI) / 2);

  if (nums[midpoint] === target) {
    return midpoint;
  } else if (nums[midpoint] < target) {
    sI = midpoint + 1;
  } else {
    eI = midpoint - 1;
  }
  return searchInsert(nums, target, sI, eI);
};

/*
Source: https://leetcode.com/problems/search-insert-position/description/


Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

Input: nums = [1,3,5,6], target = 5
Output: 2
*/
