class HashTable {
  constructor(size = 7) {
    this.dataMap = new Array(size);
  }

  //Underscore at the begining of the function tells other developers
  //that this function should not be called directly (kind of private)
  _hash(key) {
    let hash = 0;
    for (let i = 0; i < key.length; i++) {
      //23 because to make it look even more random (some constant value)
      hash = (hash + key.charCodeAt(i) * 23) % this.dataMap.length;
    }
    return hash;
  }

  set(key, value) {
    let index = this._hash(key);
    let array = [key, value];
    if (!this.dataMap[index]) {
      this.dataMap[index] = [];
    }

    this.dataMap[index].push(array);
  }

  get(key) {
    for (let i = 0; i < this.dataMap.length; i++) {
      if (this.dataMap[i]) {
        for (let j = 0; j < this.dataMap[i].length; j++) {
          if (this.dataMap[i][j][0] === key) {
            return this.dataMap[i][j][1];
          }
        }
      }
    }
    return undefined;
  }

  keys() {
    let allKeys = [];
    for (let i = 0; i < this.dataMap.length; i++) {
      if (this.dataMap[i]) {
        for (let j = 0; j < this.dataMap[i].length; j++) {
          allKeys.push(this.dataMap[i][j][0]);
        }
      }
    }
    return allKeys;
  }
}
