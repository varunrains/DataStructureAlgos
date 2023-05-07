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
 * @return {number[][]}
 */

class Element {
  constructor(node, distance) {
    this.node = node;
    this.distance = distance;
  }
}

var verticalTraversal = function (root) {
  let queue = [];
  queue.push(new Element(root, 0), null);
  let map = {};
  let res = [];
  let level = {};

  while (queue.length > 0) {
    let current = queue.shift();

    let currentDistance = current?.distance;
    let currentNode = current?.node;

    if (currentNode) {
      if (!map[currentDistance]) {
        map[currentDistance] = [currentNode.val];
      } else {
        map[currentDistance].push(currentNode.val);
      }

      if (!level[currentDistance]) {
        level[currentDistance] = [currentNode.val];
      } else {
        level[currentDistance].push(currentNode.val);
      }
    }

    if (currentNode?.left)
      queue.push(new Element(currentNode.left, currentDistance - 1));
    if (currentNode?.right)
      queue.push(new Element(currentNode.right, currentDistance + 1));

    if (!currentNode && Object.entries(level).length !== 0) {
      let levelKeys = Object.keys(level);
      for (let m of levelKeys) {
        if (level[m].length > 1) {
          map[m] = map[m].slice(0, map[m].length - level[m].length);
          level[m] = level[m].sort(function (a, b) {
            return a - b;
          });
          map[m].push(...level[m]);
        }
      }
      level = {};
      queue.push(null);
    }
  }

  let keyArray = Object.keys(map)
    .map((x) => parseInt(x))
    .sort(function (a, b) {
      return a - b;
    });
  for (let m of keyArray) {
    res.push(map[m]);
  }

  return res;
};

/*
Source: https://leetcode.com/problems/vertical-order-traversal-of-a-binary-tree/


Input: root = [3,9,20,null,null,15,7]
Output: [[9],[3,15],[20],[7]]
Explanation:
Column -1: Only node 9 is in this column.
Column 0: Nodes 3 and 15 are in this column in that order from top to bottom.
Column 1: Only node 20 is in this column.
Column 2: Only node 7 is in this column.
*/
