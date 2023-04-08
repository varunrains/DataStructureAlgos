// --- Directions
// 1) Implement the Node class to create
// a binary search tree.  The constructor
// should initialize values 'data', 'left',
// and 'right'.
// 2) Implement the 'insert' method for the
// Node class.  Insert should accept an argument
// 'data', then create an insert a new node
// at the appropriate location in the tree.
// 3) Implement the 'contains' method for the Node
// class.  Contains should accept a 'data' argument
// and return the Node in the tree with the same value.

class Node {
    constructor(data){
        this.data = data;
        this.left = null;
        this.right = null;
        //this.root = data;
    }

    insert(val){
        const newNode = new Node(val);
        if(val < this.data && !this.left){
this.left = newNode;
        }else if(val < this.data && this.left){
            this.left.insert(val);
        }else if(val > this.data && !this.right){
            this.right = newNode;
        }else if(val > this.data && this.right){
            this.right.insert(val);
        }

    }

    contains(val){
        // if(val === this.data){
        //     return true;
        // }else{
        //     return false;
        // }
if(val == this.data) return this;
 if(val < this.data && this.left){
  return  this.left.contains(val);
}
 else if(val > this.data && this.right){
  return  this.right.contains(val);
}

return null;
        // while(true){
        //     if(this.left === null && this.right === null)
        // }
    }
}

// const node = new Node(10);
//   node.insert(5);
//   node.insert(15);
//   node.insert(17);
// const node = new Node(10);
//   node.insert(5);
//   node.insert(15);
//   node.insert(20);
//   node.insert(0);
//   node.insert(-5);
//   node.insert(3);

//   node.contains(3);
//   console.log(node.left.data);

module.exports = Node;
