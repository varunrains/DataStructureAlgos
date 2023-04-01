//Note all these codes should be run with the
//Binary search tree
function DFSPreOrder() {
  let results = [];

  function traverse(currentNode) {
    results.push(currentNode.value);
    if (currentNode.left) traverse(currentNode.left);
    if (currentNode.right) traverse(currentNode.right);
  }
  traverse(this.root);
  return results;
}

function DFSPostOrder() {
  let results = [];

  function traverse(currentNode) {
    if (currentNode.left) traverse(currentNode.left);
    if (currentNode.right) traverse(currentNode.right);
    results.push(currentNode.value);
  }
  traverse(this.root);
  return results;
}

function DFSInOrder() {
  let results = [];

  function traverse(currentNode) {
    if (currentNode.left) traverse(currentNode.left);
    results.push(currentNode.value);
    if (currentNode.right) traverse(currentNode.right);
  }
  traverse(this.root);
  return results;
}
