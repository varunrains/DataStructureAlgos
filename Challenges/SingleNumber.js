var singleNumber = function (nums) {
  let ans = 0;
  for (let i = 0; i < nums.length; i++) {
    ans = ans ^ nums[i];
  }
  return ans;
};
/*
XOR is very powerful if you remember its usage you can solve many problems
Remember these three properties of a XOR
A ^ A = 0
A ^ B ^ A = B
A ^ 0 = A
*/

/*
Source: https://leetcode.com/problems/single-number/description/

Note: Use XOR to get the space complexity of O(1) and time complexity of O(N) (linear time complexity)

Input: nums = [2,2,1]
Output: 1

Input: nums = [4,1,2,1,2]
Output: 4

Input: nums = [1]
Output: 1

*/