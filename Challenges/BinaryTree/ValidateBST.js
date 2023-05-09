/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {boolean}
 */

var helper = function(root, min = -Infinity, max = Infinity){
    if(root === null) return true;
    let left = helper(root.left, min, root.val);
    let right = helper(root.right,root.val, max);

    if(left && right && root.val > min && root.val < max)return true;
    else return false;
    
}

var isValidBST = function(root) {
return helper(root);
};

/*
Source: https://leetcode.com/problems/validate-binary-search-tree/
Input: root = [2,1,3]
Output: true

One more approach is to use the Inorder traversal and then use the array output
if the array is sorted then it is valid BST
To make it even efficient you can use the two pointer approach
to prev and curr to make it O(1) space complexity

*/