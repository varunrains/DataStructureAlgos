/**
 * @param {number} numCourses
 * @param {number[][]} prerequisites
 * @return {boolean}
 */
var canFinish = function (numCourses, prerequisites) {
  const graph = buildGraph(numCourses,prerequisites);
  const visited = new Array(numCourses - 1).fill(false);
  const recursionVisited = new Array(numCourses - 1).fill(false);

  for (let i = 0; i < numCourses; i++) {
    if (!visited[i] && checkCycle(graph, i, visited, recursionVisited)) {
      return false;
    }
  }

  return true;
};

const checkCycle = (graph, i, visited, recursionVisited) => {
  visited[i] = true;
  recursionVisited[i] = true;

  for (let neighbour of graph[i]) {
    if (
      !visited[neighbour] &&
      checkCycle(graph, neighbour, visited, recursionVisited)
    ) {
      return true;
    } else if (recursionVisited[neighbour]) {
      return true;
    }
  }

  recursionVisited[i] = false;
  return false;
};

const buildGraph = (numCourses, prerequisites) => {
    const graph = new Array(numCourses).fill(0).map(() => []);
    
    for (let [course, prerequisite] of prerequisites) {
      graph[course].push(prerequisite);
    }
  
    return graph;
  };

/*
Source: https://leetcode.com/problems/course-schedule/

Input: numCourses = 2, prerequisites = [[1,0]]
Output: true
Explanation: There are a total of 2 courses to take. 
To take course 1 you should have finished course 0. So it is possible.

This is same as detecting cycle in a Directed Graph
*/
