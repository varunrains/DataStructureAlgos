var lastIndex = function (a, ele, i = a.length - 1) {
    if (i === -1) {
      return -1;
    }
  
    if (a[i] === ele) {
      return i;
    }
  
    return lastIndex(a, ele, i-1);
  };
  
  lastIndex([1, 2, 2, 2, 3], 2);