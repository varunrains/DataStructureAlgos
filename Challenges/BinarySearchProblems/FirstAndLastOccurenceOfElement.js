/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var searchRange = function (nums, target) {
  let firstOccurence = getFirst(nums, target);
  let lastOccurence = getLast(nums, target);

  return [firstOccurence, lastOccurence];
};

//BInary search , search the left side
var getFirst = function (nums, target) {
  let s = 0;
  let e = nums.length - 1;
  let ans = -1;
  while (s <= e) {
    let mid = Math.floor((s + e) / 2);

    if (target === nums[mid]) {
      ans = mid;
      e = mid - 1;
    } else if (target < nums[mid]) {
      e = mid - 1;
    } else {
      s = mid + 1;
    }
  }

  return ans;
};


//Binary search, search the right side
var getLast = function (nums, target) {
  let s = 0;
  let e = nums.length - 1;
  let ans = -1;
  while (s <= e) {
    let mid = Math.floor((s + e) / 2);

    if (target === nums[mid]) {
      ans = mid;
      s = mid + 1;
    } else if (target < nums[mid]) {
      e = mid - 1;
    } else {
      s = mid + 1;
    }
  }

  return ans;
};

/*
Source: https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/

Input: nums = [5,7,7,8,8,10], target = 8
Output: [3,4]

Input: nums = [5,7,7,8,8,10], target = 6
Output: [-1,-1]
*/
