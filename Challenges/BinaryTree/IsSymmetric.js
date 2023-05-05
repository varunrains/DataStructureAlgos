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
var isSymmetric = function(root) {
    return checkForSymetric(root.left, root.right)
};


var checkForSymetric = function(p, q){
    if(p === null && q === null) return true;
    if(p === null && q !== null) return false;
    if(p !== null && q === null) return false;

    return p.val === q.val && checkForSymetric(p.left, q.right) && checkForSymetric(p.right, q.left);
}


/*
Source: https://leetcode.com/problems/symmetric-tree/
Input: root = [1,2,2,3,4,4,3]
Output: true


*/