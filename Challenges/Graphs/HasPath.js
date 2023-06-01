/**
 * @param {number} n
 * @param {number[][]} edges
 * @param {number} source
 * @param {number} destination
 * @return {boolean}
 */
var validPath = function (n, edges, source, destination) {
  const graph = buildGraph(edges);

  return hasPathExists(graph, source, destination, new Set());
};

const hasPathExists = (graph, src, dest, visited) => {
  if (src === dest) return true;
  if (visited.has(src)) return false;

  visited.add(src);

  for (let neighbour of graph[src]) {
    const res = hasPathExists(graph, neighbour, dest, visited);
    if (res === true) return true;
  }

  return false;
};

const buildGraph = (edges) => {
  const graph = {};
  for (let edge of edges) {
    const [a, b] = edge;
    if (!(a in graph)) {
      graph[a] = [];
    }

    if (!(b in graph)) {
      graph[b] = [];
    }
    graph[a].push(b);
    graph[b].push(a);
  }

  return graph;
};


/*
Source: https://leetcode.com/problems/find-if-path-exists-in-graph/

Input: n = 3, edges = [[0,1],[1,2],[2,0]], source = 0, destination = 2
Output: true
Explanation: There are two paths from vertex 0 to vertex 2:
- 0 → 1 → 2
- 0 → 2

*/