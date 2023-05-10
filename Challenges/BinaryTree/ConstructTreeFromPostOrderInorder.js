//* Definition for a binary tree node.
class TreeNode {
  constructor(val, left, right) {
    this.val = val === undefined ? 0 : val;
    this.left = left === undefined ? null : left;
    this.right = right === undefined ? null : right;
  }
}

/**
 * @param {number[]} inorder
 * @param {number[]} postorder
 * @return {TreeNode}
 */
var buildTree = function (inorder, postorder) {
  let len = inorder.length;
  return buildTreeHelper(inorder, postorder, 0, len - 1, 0, len - 1);
};

var buildTreeHelper = function (inorder, postorder, inS, inE, poS, poE) {
  if (inS > inE) return null;
  let rootIndex = -1;
  let root = postorder[poE];
  let rootNode = new TreeNode(root);

  for (let i = 0; i < inorder.length; i++) {
    if (inorder[i] === root) {
      rootIndex = i;
      break;
    }
  }

  let leftInorderStart = inS;
  let leftInorderEnd = rootIndex - 1;
  let leftPostOrderStart = poS;
  let leftPostOrderEnd = leftInorderEnd - leftInorderStart + leftPostOrderStart;

  let rightInorderStart = rootIndex + 1;
  let rightInOrderEnd = inE;
  let rightPostOrderStart = leftPostOrderEnd + 1;
  let rightPostOrderEnd = poE - 1;

  rootNode.left = buildTreeHelper(
    inorder,
    postorder,
    leftInorderStart,
    leftInorderEnd,
    leftPostOrderStart,
    leftPostOrderEnd
  );
  rootNode.right = buildTreeHelper(
    inorder,
    postorder,
    rightInorderStart,
    rightInOrderEnd,
    rightPostOrderStart,
    rightPostOrderEnd
  );
  return rootNode;
};

/*

Source: https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
Input: inorder = [9,3,15,20,7], postorder = [9,15,7,20,3]
Output: [3,9,20,null,null,15,7]
*/
