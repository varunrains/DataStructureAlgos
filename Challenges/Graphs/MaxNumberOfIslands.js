/**
 * @param {number[][]} grid
 * @return {number}
 */
var maxAreaOfIsland = function (grid) {
  const row = grid.length;
  const col = grid[0].length;
  const visited = new Set();
  let maxArea = 0;
  for (let r = 0; r < row; r++) {
    for (let c = 0; c < col; c++) {
      let area = explore(grid, r, c, visited);
      if (area > maxArea) {
        maxArea = area;
      }
    }
  }

  return maxArea;
};

const explore = (grid, row, col, visited) => {
  const rowOutOfBound = row < 0 || row >= grid.length;
  const colOutOfBound = col < 0 || col >= grid[0].length;

  if (rowOutOfBound || colOutOfBound) return 0;

  if (grid[row][col] === 0) return 0;

  const key = row + "," + col;
  if (visited.has(String(key))) return 0;
  visited.add(String(key));

  let size = 1;
  size += explore(grid, row, col + 1, visited);
  size += explore(grid, row, col - 1, visited);
  size += explore(grid, row + 1, col, visited);
  size += explore(grid, row - 1, col, visited);

  return size;
};

/*
Source: https://leetcode.com/problems/max-area-of-island/description/
Input: grid = [[0,0,1,0,0,0,0,1,0,0,0,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,1,1,0,1,0,0,0,0,0,0,0,0],[0,1,0,0,1,1,0,0,1,0,1,0,0],[0,1,0,0,1,1,0,0,1,1,1,0,0],[0,0,0,0,0,0,0,0,0,0,1,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,0,0,0,0,0,0,1,1,0,0,0,0]]
Output: 6
Explanation: The answer is not 11, because the island must be connected 4-directionally.

Maxium area
*/
