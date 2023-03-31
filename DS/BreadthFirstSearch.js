function BFS() {
  let currentNode = this.root;

  let queue = [];
  let results = [];

  queue.push(currentNode);

  while (queue.length > 0) {
    let node = queue.shift();
    results.push(node.value);
    if (node.left) queue.push(node.left);
    if (node.right) queue.push(node.right);
  }
  return results;
}
