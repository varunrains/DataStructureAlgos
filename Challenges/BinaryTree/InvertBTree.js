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
 * @return {TreeNode}
 */
var invertTree = function(root) {
    if(root == null) return root;

    let temp = root.right;
    root.right = root.left;
    root.left = temp;

    root.left = invertTree(root.left);
    root.right = invertTree(root.right);

    return root;
};

/*
Source: https://leetcode.com/problems/invert-binary-tree
Input: root = [4,2,7,1,3,6,9]
Output: [4,7,2,9,6,3,1]
*/