/**
 * @param {character[][]} grid
 * @return {number}
 */
var numIslands = function (grid) {
  const row = grid.length;
  const col = grid[0].length;
  let count = 0;
  const visited = new Set();
  for (let r = 0; r < row; r++) {
    for (let c = 0; c < col; c++) {
      if (explore(grid, r, c, visited)) {
        count++;
      }
    }
  }

  return count;
};

const explore = (grid, row, col, visited) => {
  const rowOutbound = row < 0 || row >= grid.length;
  const colOutbound = col < 0 || col >= grid[0].length;

  if (rowOutbound || colOutbound) return false;

  if (grid[row][col] === "0") return false;
  const key = row + "," + col;
  if (visited.has(key)) return false;
  visited.add(key);

  explore(grid, row - 1, col, visited);
  explore(grid, row + 1, col, visited);
  explore(grid, row, col - 1, visited);
  explore(grid, row, col + 1, visited);
  return true;
};

/*
Source: https://leetcode.com/problems/number-of-islands/

Input: grid = [
  ["1","1","1","1","0"],
  ["1","1","0","1","0"],
  ["1","1","0","0","0"],
  ["0","0","0","0","0"]
]
Output: 1

*/
