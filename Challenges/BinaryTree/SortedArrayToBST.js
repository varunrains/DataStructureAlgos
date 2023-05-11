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
var sortedArrayToBST = function(nums) {
    if(nums.length === 0) return null;

    return sortedArrayToBSTHelper(nums,0,nums.length-1);
  
};

var sortedArrayToBSTHelper = function(nums, sI, eI){

    if(sI>eI) return null;

    let midIndex = Math.floor((sI + eI)/2);
    let root = new TreeNode(nums[midIndex]);

    root.left = sortedArrayToBSTHelper(nums,sI, midIndex - 1);
    root.right = sortedArrayToBSTHelper(nums, midIndex+1, eI);

    return root;

}

/*
Source: https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/

Input: nums = [-10,-3,0,5,9]
Output: [0,-3,9,-10,null,5]
Explanation: [0,-10,5,null,-3,null,9] is also accepted:
*/