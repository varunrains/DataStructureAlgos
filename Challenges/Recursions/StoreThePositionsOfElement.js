var storePosition = function (a, ele, i = 0, result = []) {
  if (i === a.length) {
    return result.join(",");
  }

  if (a[i] === ele) {
    result.push(i);
  }

  return storePosition(a, ele, i + 1, result);
};

storePosition([1, 2, 2, 2, 3, 4, 5, 5], 2);
