var canJump = function (nums) {
  let endIndex = nums.length - 1;
  for (let i = endIndex - 1; i >= 0; i--) {
    if (nums[i] + i >= endIndex) {
      endIndex = i;
    }
  }
  if (endIndex === 0) {
    return true;
  }
  return false;
};

/*
Source: 
https://leetcode.com/problems/jump-game


Input: nums = [2,3,1,1,4]
Output: true
Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.

Input: nums = [3,2,1,0,4]
Output: false
Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.

*/
