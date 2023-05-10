//* Definition for a binary tree node.
class TreeNode {
    constructor(val, left, right) {
      this.val = val === undefined ? 0 : val;
      this.left = left === undefined ? null : left;
      this.right = right === undefined ? null : right;
    }
  }
/**
 * @param {number[]} nums
 * @return {TreeNode}
 */
var constructMaximumBinaryTree = function(nums) {
    //if(nums.length === 0) return null;
   return maxBinaryTreeHelper(nums,0,nums.length-1)
};


var maxBinaryTreeHelper = function(nums,sI, eI){
  if (nums.length === 0) return null;
  if (sI > eI) return null;
  let maxIndex = -1;
  let maximum = -1;
  for (let i = sI; i <= eI; i++) {
    if (nums[i] > maximum) {
      maximum = nums[i];
      maxIndex = i;
    }
  }

  let root = new TreeNode(maximum);

  root.left = maxBinaryTreeHelper(nums, sI, maxIndex - 1);
  root.right = maxBinaryTreeHelper(nums, maxIndex + 1, eI);

  return root;
}



/*
Source: https://leetcode.com/problems/maximum-binary-tree/description/

Input: nums = [3,2,1,6,0,5]
Output: [6,3,5,null,2,0,null,null,1]
Explanation: The recursive calls are as follow:
- The largest value in [3,2,1,6,0,5] is 6. Left prefix is [3,2,1] and right suffix is [0,5].
    - The largest value in [3,2,1] is 3. Left prefix is [] and right suffix is [2,1].
        - Empty array, so no child.
        - The largest value in [2,1] is 2. Left prefix is [] and right suffix is [1].
            - Empty array, so no child.
            - Only one element, so child is a node with value 1.
    - The largest value in [0,5] is 5. Left prefix is [0] and right suffix is [].
        - Only one element, so child is a node with value 0.
        - Empty array, so no child.

*/